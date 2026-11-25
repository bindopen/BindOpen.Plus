using System;

namespace BindOpen.Bpm
{
    /// <summary>
    /// Enumeration of possible kinds of workflow item layouts.
    /// </summary>
    [Flags]
    public enum ItemLayoutKind
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Any.
        /// </summary>
        Any = 1,

        /// <summary>
        /// Loop activity.
        /// </summary>
        LoopActivity = 2,

        /// <summary>
        /// Parallel activity.
        /// </summary>
        ParallelActivity = 3,

        /// <summary>
        /// Sequence activity.
        /// </summary>
        SequenceActivity = 4,

        /// <summary>
        /// Task activity.
        /// </summary>
        TaskActivity = 5,

        /// <summary>
        /// Workflow.
        /// </summary>
        Workflow = 6,

        /// <summary>
        /// Workflow state.
        /// </summary>
        WorkflowState = 7,

        /// <summary>
        /// Variable.
        /// </summary>
        Variable = 8,

        /// <summary>
        /// Workflow activity input.
        /// </summary>
        ActivityInput = 9,

        /// <summary>
        /// Workflow activity output.
        /// </summary>
        ActivityOutput = 10,

        /// <summary>
        /// Sequence link.
        /// </summary>
        SequenceLink = 11
    }
}