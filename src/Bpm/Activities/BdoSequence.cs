using BindOpen.Data;
using BindOpen.Data.Objects;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a DTO sequence activity design.
    /// </summary>
    public class BdoSequence : BdoActivity, IBdoSequence
    {
        public SequenceKinds SequenceKind { get; set; }

        public ITBdoSet<IBdoActivity> Activities { get; set; }

        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the SequenceDto class.
        /// </summary>
        public BdoSequence() : this(SequenceKinds.Standard)
        {
        }

        /// <summary>
        /// Instantiates a new instance of the ActivityDto class.
        /// </summary>
        /// <param name="name">The name to consider.</param>
        /// <param name="taskKind">The activity kind to consider.</param>
        /// <param name="title">The title to consider.</param>
        /// <param name="id">The ID to consider.</param>
        protected BdoSequence(SequenceKinds kind) : base(ActivityKinds.Sequence)
        {
            SequenceKind = kind;

            if (this is IBdoWorkflow)
            {
                Kind = ActivityKinds.Workflow;
            }
        }

        #endregion

        // --------------------------------------------------
        // ACCESSORS
        // --------------------------------------------------

        #region Accessors

        // Cloning ------------------------------------------

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>Returns the cloned object.</returns>
        public override object Clone()
        {
            BdoSequence sequenceActivity = base.Clone() as BdoSequence;
            //sequenceActivity.Activities = Activities.Select(p => p.Clone() as BdoActivity).ToList();

            return sequenceActivity;
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <param name="isRecursive">Indicates whether the clone operation is recursive.</param>
        /// <returns>Returns the cloned object.</returns>
        public virtual object Clone(bool isRecursive = false)
        {
            BdoSequence sequenceActivity = Clone() as BdoSequence;
            return sequenceActivity;
        }

        #endregion
    }
}
