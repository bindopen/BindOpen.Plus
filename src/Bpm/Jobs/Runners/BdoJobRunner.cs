using BindOpen.Bpm.Activities;
using BindOpen.Data.Helpers;
using BindOpen.Data.Meta;
using BindOpen.Logging;
using BindOpen.Logging.Loggers;
using BindOpen.Scoping;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BindOpen.Bpm.Jobs
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public class BdoJobRunner : BackgroundService, IBdoJobRunner
    {
        private CancellationTokenSource _cancelTokenSource;

        // ------------------------------------------
        // PROPERTIES
        // ------------------------------------------

        #region Properties

        public string Identifier { get; set; }

        private ProcessExecutionState _state = ProcessExecutionState.None;

        public ProcessExecutionState State { get => _state; protected set { _state = value; } }

        /// <summary>
        /// The scope of this instance.
        /// </summary>
        public IBdoScope Scope { get; set; }

        /// <summary>
        /// The loggers of this instance.
        /// </summary>
        public List<IBdoLogger> Loggers { get; set; }

        /// <summary>
        /// The logger of this instance.
        /// </summary>
        public IBdoLogger Logger { get; set; }

        /// <summary>
        /// The description of this instance.
        /// </summary>
        public IBdoJob Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IBdoMetaSet VariableSet { get; set; }

        #endregion

        // ------------------------------------------
        // CONSTRUCTORS
        // ------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the BdoJobRunner class.
        /// </summary>
        public BdoJobRunner()
        {
        }

        #endregion


        public string Key() => Identifier;

        // ------------------------------------------
        // METHODS
        // ------------------------------------------

        #region Properties

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            //Logger ??= BdoLogging.NewLog();

            // we retrieve the activity

            var log = Logger.NewRootLog();

            var activity = Job?.Activity;
            activity ??= Scope.Interpreter?.Evaluate<BdoActivity>(Job.ActivityReference, VariableSet, log);

            // the activity must exist

            if (activity == null)
            {
                //Logger?.AddError("Activity missing");
                return;
            }

            // we set the execution as started

            //Logger?.Execution?.SetAsStarted();

            // we run the activity

            var runner = this.NewRunner(activity);
            await runner.StartAsync(cancellationToken);

            // we wait for the runner to stop

            while (_activityRunners.All(q => q.State == ProcessExecutionState.Ended)) { }

            ClearSubscriptions();

            // we update log

            //Logger?.AddEvent(EventKinds.Checkpoint, "Task started");
        }

        public async Task RestartAsync(CancellationToken cancellationToken)
        {
            // we set the execution as re-started

            //Logger?.Execution?.SetAsRestarted();

            // we stop the runner

            await StopAsync(cancellationToken);

            // we wait for the runner to stop

            while (_activityRunners.All(q => q.State == ProcessExecutionState.Ended))
            {
            }

            ClearSubscriptions();

            // we start again

            await ExecuteAsync(cancellationToken);

            // we update log

            //Logger?.AddEvent(EventKinds.Checkpoint, "Task re-started");
        }

        public async Task ResumeAsync()
        {
            // we set the execution as resumed

            //Logger?.Execution?.SetAsResumed();

            // we resume all the runners

            _activityRunners.ForEach(async q => await q.StartAsync(_cancelTokenSource.Token));

            // we update log

            //Logger?.AddEvent(EventKinds.Checkpoint, "Task resumed");
        }

        public async Task PauseAsync()
        {
            // we set the execution as paused

            //Logger?.Execution?.SetAsPaused();

            // we pause all the runners

            _activityRunners.ForEach(async q => await q.StopAsync(_cancelTokenSource.Token));

            // we update log

            //Logger?.AddEvent(EventKinds.Checkpoint, "Task paused");
        }

        public async Task StopAsync(CancellationToken cancellationToken, ProcessExecutionStatus status = ProcessExecutionStatus.Completed)
        {
            if (!ProcessExecutionState.Ended.ToStatuses().Contains(status)) return;

            // we set the execution as ended

            //Logger?.Execution?.SetAsEnded(status);

            // we stop the task

            await base.StopAsync(cancellationToken);

            // we update log

            switch (status)
            {
                case ProcessExecutionStatus.Completed:
                    //Logger?.Execution?.WithProgressIndex(Logger?.Execution?.ProgressMax ?? 100);
                    //Logger?.AddEvent(EventKinds.Checkpoint, "Task completed");
                    break;
                case ProcessExecutionStatus.NothingDone:
                    //Logger?.Execution?.WithProgressIndex(Logger?.Execution?.ProgressMax ?? 100);
                    //Logger?.AddEvent(EventKinds.Checkpoint, "Task completed with nothing done");
                    break;
                case ProcessExecutionStatus.Stopped_Exception:
                    //Logger?.AddEvent(EventKinds.Checkpoint, "Task stopped by exception");
                    break;
                case ProcessExecutionStatus.Stopped_User:
                    //Logger?.AddEvent(EventKinds.Checkpoint, "Task stopped by user");
                    break;
                default:
                    //Logger?.AddEvent(EventKinds.Checkpoint, "Task stopped");
                    break;
            }
        }

        #endregion

        private List<IBdoActivityRunner> _activityRunners = new();

        public void ClearSubscriptions()
        {
            _activityRunners = new List<IBdoActivityRunner>();
        }

        public void Subscribe(IBdoActivityRunner runner)
        {
            if (_activityRunners?.Any(q => q.BdoKeyEquals(runner)) == true)
            {
                _activityRunners.Add(runner);
            }
        }

        public void Unsubscribe(IBdoActivityRunner runner)
        {
            _activityRunners.RemoveAll(q => q.BdoKeyEquals(runner));
        }
    }
}
