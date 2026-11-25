namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a task activity design.
    /// </summary>
    public class BdoTaskActivity : BdoActivity, IBdoTaskActivity
    {
        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the TaskActivityDto class.
        /// </summary>
        public BdoTaskActivity() : base(ActivityKinds.Task)
        {
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
            BdoTaskActivity taskActivity = base.Clone() as BdoTaskActivity;
            return taskActivity;
        }

        #endregion
    }
}
