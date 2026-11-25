using BindOpen.Bpm.Jobs;
using BindOpen.Data;

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
        public static IBdoJob NewJob(string name = null)
        {
            var job = BdoData.New<BdoJob>()
                .WithName(name);

            return job;
        }
    }
}
