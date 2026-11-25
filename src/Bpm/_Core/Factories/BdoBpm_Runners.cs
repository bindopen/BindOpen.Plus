using BindOpen.Bpm.Activities;
using BindOpen.Bpm.Jobs;
using BindOpen.Scoping;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This class represents an activity factory.
    /// </summary>
    public static partial class BdoBpm
    {
        /// <summary>
        /// Creates a new job.
        /// </summary>
        public static IBdoJobRunner NewRunner(
            this IBdoScope scope,
            IBdoJob job)
        {
            var runner = scope.CreateScoped<BdoJobRunner>()
                .WithJob(job);

            return runner;
        }

        /// <summary>
        /// Creates a new job.
        /// </summary>
        public static T NewRunner<T>(
            this IBdoScope scope,
            IBdoJob job)
            where T : class, IBdoJobRunner, new()
        {
            var runner = scope.CreateScoped<T>()
                .WithJob(job);

            return runner;
        }

        /// <summary>
        /// News a new job.
        /// </summary>
        public static IBdoActivityRunner NewRunner(
            this IBdoJobRunner jobRunner,
            IBdoActivity activity)
        {
            IBdoActivityRunner runner = null;

            if (activity is IBdoSequence)
            {
                runner = jobRunner?.Scope?.CreateScoped<BdoSequenceRunner>();
            }
            else if (activity is IBdoTaskActivity)
            {
                runner = jobRunner?.Scope?.CreateScoped<BdoTaskActivityRunner>();
            }

            runner?
                .WithActivity(activity)
                .WithParent(jobRunner);

            return runner;
        }
    }
}
