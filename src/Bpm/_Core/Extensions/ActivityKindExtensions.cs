using BindOpen.Bpm.Activities;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This class represents a activity kind extension.
    /// </summary>
    public static class ActivityKindExtensions
    {
        /// <summary>
        /// Gets the activity kind of the specified task.
        /// </summary>
        /// <param name="activity">The activity to consider.</param>
        /// <returns>Returns the activity kind of the specified task.</returns>
        public static ActivityKinds GetActivityKind(this IBdoActivity activity)
        {
            if (activity is IBdoSequence)
                return ActivityKinds.Sequence;
            else if (activity is IBdoTaskActivity)
                return ActivityKinds.Task;
            else if (activity is IBdoWorkflow)
                return ActivityKinds.Workflow;
            else
                return ActivityKinds.None;
        }
    }
}