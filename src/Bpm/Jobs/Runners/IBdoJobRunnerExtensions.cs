namespace BindOpen.Bpm.Jobs
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class IBdoJobRunnerExtensions
    {
        public static T WithJob<T>(
            this T obj,
            IBdoJob job)
            where T : IBdoJobRunner
        {
            if (obj != null)
            {
                obj.Job = job;
            }
            return obj;
        }
    }
}