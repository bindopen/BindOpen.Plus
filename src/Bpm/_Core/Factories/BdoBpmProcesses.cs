using BindOpen.Logging;

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
        public static IBdoProcessExecution CreateExecution()
        {
            var ex = new BdoProcessExecution();

            return ex;
        }
    }
}
