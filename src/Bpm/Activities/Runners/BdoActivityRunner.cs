using BindOpen.Bpm.Jobs;
using BindOpen.Data;
using BindOpen.Data.Meta;
using BindOpen.Logging;
using BindOpen.Logging.Loggers;
using BindOpen.Scoping;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public abstract class BdoActivityRunner : BackgroundService, IBdoActivityRunner
    {
        private CancellationTokenSource _cancelTokenSource;

        // ------------------------------------------
        // PROPERTIES
        // ------------------------------------------

        #region Properties

        public string Identifier { get; set; }

        protected ProcessExecutionState _state = ProcessExecutionState.None;

        public ProcessExecutionState State { get => _state; protected set { _state = value; } }

        /// <summary>
        /// The scope of this instance.
        /// </summary>
        public IBdoScope Scope { get; set; }

        /// <summary>
        /// The logger of this instance.
        /// </summary>
        public IBdoLogger Logger { get; set; }

        /// <summary>
        /// The loggers of this instance.
        /// </summary>
        public List<IBdoLogger> Loggers { get; set; }

        /// <summary>
        /// The description of this instance.
        /// </summary>
        public IBdoActivity Activity { get; set; }

        public RuntimeModes RuntimeMode { get; set; }

        public IBdoMetaSet InputDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IBdoMetaSet VariableSet { get; set; }

        public IBdoJobRunner Parent { get; set; }

        #endregion

        // ------------------------------------------
        // CONSTRUCTORS
        // ------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the BdoActivityRunner class.
        /// </summary>
        public BdoActivityRunner()
        {
        }

        #endregion

        public string Key() => Identifier;

        // ------------------------------------------
        // METHODS
        // ------------------------------------------

        #region Methods

        public virtual async Task StopAsync(
            CancellationToken cancellationToken,
            ProcessExecutionStatus status = ProcessExecutionStatus.Completed)
        {
            if (!ProcessExecutionState.Ended.ToStatuses().Contains(status)) return;

            // we set the execution as ended

            _state = ProcessExecutionState.Ended;

            //var transaction = Logger?.NewTransaction();

            //transaction
            //    .PatchExecution(q => q.State, _state)
            //    .PatchExecution(q => q.Status, status);
            //await transaction.Commit();

            // we stop the task

            await base.StopAsync(cancellationToken);

            // we update log

            int? progressMax = 100;

            switch (status)
            {
                case ProcessExecutionStatus.Completed:
                    //transaction
                    //    .PatchExecution(q => q.Index, progressMax ?? 100)
                    //    .CreateEvent(EventKinds.Checkpoint, "Task completed");
                    break;
                case ProcessExecutionStatus.NothingDone:
                    //transaction
                    //    .PatchExecution(q => q.Index, progressMax ?? 100)
                    //    .CreateEvent(EventKinds.Checkpoint, "Task completed with nothing done");
                    break;
                case ProcessExecutionStatus.Stopped_Exception:
                    //transaction.CreateEvent(EventKinds.Checkpoint, "Task stopped by exception");
                    break;
                case ProcessExecutionStatus.Stopped_User:
                    //transaction.CreateEvent(EventKinds.Checkpoint, "Task stopped by user");
                    break;
                default:
                    //transaction.CreateEvent(EventKinds.Checkpoint, "Task stopped");
                    break;
            }

            //await transaction.Commit();
        }

        #endregion
    }
}
