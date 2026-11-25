using BindOpen.Data;
using BindOpen.Data.Helpers;
using BindOpen.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public class BdoSequenceRunner : BdoActivityRunner, IBdoSequenceRunner
    {
        // ------------------------------------------
        // CONSTRUCTORS
        // ------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the BdoSequenceRunner class.
        /// </summary>
        public BdoSequenceRunner()
        {
        }

        #endregion

        // ------------------------------------------
        // METHODS
        // ------------------------------------------

        #region Metthods

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var log = Logger?.NewRootLog();
            //var transaction = Logger?.NewTransaction(Activity?.Id, QueryResultModes.Full);

            // we set the execution as started

            _state = ProcessExecutionState.Pending;

            //transaction
            //    .PatchExecution(q => q.State, _state)
            //    .PatchExecution(q => q.Status, ProcessExecutionStatus.Processing)
            //    .Commit();

            // we set the execution as started

            if (Activity is BdoSequence sequence)
            {

                // we get the last events

                var lastLogs = log?.Children(q => q.Execution?.State == ProcessExecutionState.Pending, true);

                if (lastLogs?.Any() != true)
                {
                    lastLogs = log?._Children.Any() == true ? new[] { log?._Children?.FirstOrDefault() } : null;
                }

                // we retrieve the last activities

                var runActivities = new List<IBdoActivity>();

                if (lastLogs?.Any() == true)
                {
                    foreach (var ev in lastLogs)
                    {
                        var id = ev?.TaskConfig?.Identifier;

                        IBdoActivity runActivity = Activity?.Child(id, true).As<IBdoActivity>();

                        if (runActivity != null)
                        {
                            runActivities.Add(runActivity);
                        }
                    }
                }
                else
                {
                    runActivities.Add(Activity);
                }

                // we run the current activities

                foreach (var runActivity in runActivities)
                {
                    var runner = Parent?.NewRunner(runActivity)
                        .WithInputs(InputDetail);

                    await runner.StartAsync(stoppingToken);
                }


                if (sequence.Activities?.Any() == true)
                {
                    switch (sequence.SequenceKind)
                    {
                        case SequenceKinds.ForEach:
                            var list = InputDetail?.FirstOrDefault()?.GetDataList(Scope, VariableSet, log);
                            foreach (var item in list)
                            {
                                foreach (var activity in sequence.Activities)
                                {
                                    var runner = Parent?.NewRunner(activity);
                                    await runner.StartAsync(stoppingToken);
                                }
                            }
                            break;
                        case SequenceKinds.Loop:
                            foreach (var activity in sequence.Activities)
                            {
                                var runner = Parent?.NewRunner(activity);
                                await runner.StartAsync(stoppingToken);
                            }
                            break;
                        case SequenceKinds.Parallel:
                            Parallel.ForEach(sequence.Activities, async q =>
                            {
                                var runner = Parent?.NewRunner(q);
                                await runner.StartAsync(stoppingToken);
                            });
                            break;
                        case SequenceKinds.Standard:
                            foreach (var activity in sequence.Activities)
                            {
                                var runner = Parent?.NewRunner(activity);
                                await runner.StartAsync(stoppingToken);
                            }
                            break;
                    }
                }
            }

            // We unscribe

            Parent?.Unsubscribe(this);

            // we update log

            //await Logger.CreateEvent(EventKinds.Checkpoint, "Task started").Commit();
        }

        public override async Task StopAsync(CancellationToken cancellationToken, ProcessExecutionStatus status = ProcessExecutionStatus.Completed)
        {
            Parent?.Subscribe(this);

            await base.StopAsync(cancellationToken, status);
        }

        #endregion
    }
}
