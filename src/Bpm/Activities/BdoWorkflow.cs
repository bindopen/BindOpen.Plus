namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a DTO workflow definition.
    /// </summary>
    public class BdoWorkflow : BdoSequence, IBdoWorkflow
    {
        // Reference to context

        // Reference to packages

        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the BdoWorkflow class.
        /// </summary>
        public BdoWorkflow() : base(SequenceKinds.Standard)
        {
        }

        #endregion
    }
}

