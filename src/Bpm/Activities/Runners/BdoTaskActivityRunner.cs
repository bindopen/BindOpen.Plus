using BindOpen.Data;
using BindOpen.Data.Meta;
using BindOpen.Logging;
using BindOpen.Scoping;
using BindOpen.Scoping.Tasks;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public class BdoTaskActivityRunner : BdoActivityRunner
    {
        // ------------------------------------------
        // CONSTRUCTORS
        // ------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the BdoTaskActivityRunner class.
        /// </summary>
        public BdoTaskActivityRunner()
        {
        }

        #endregion

        // ------------------------------------------
        // METHODS
        // ------------------------------------------

        #region Methods

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var log = Logger?.NewRootLog();

            // we set the execution as started

            _state = ProcessExecutionState.Pending;

            //log.Execution.Set
            //    .PatchExecution(q => q.State, _state)
            //    .PatchExecution(q => q.Status, ProcessExecutionStatus.Processing);
            //transaction.Commit();

            // we retrieve the task definition

            var inputs = BdoData.NewSet(Activity.Detail.Where(q => q.IsInput())?.ToArray());

            IBdoTask task = Scope?.CreateTask(Activity.DataType, inputs, VariableSet, log);

            if (task != null)
            {
                await task.ExecuteAsync(stoppingToken, Scope, VariableSet, RuntimeMode, log);

                while (_state == ProcessExecutionState.Pending) { }
            }

            // we update log

            //Logger?.CreateEvent(EventKinds.Checkpoint, "Task started").Commit();
        }

        #endregion
    }
}
