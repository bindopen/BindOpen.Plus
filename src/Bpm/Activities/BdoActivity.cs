using BindOpen.Data;
using BindOpen.Data.Schema;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a DTO activity.
    /// </summary>
    public abstract class BdoActivity : BdoSchema, IBdoActivity
    {
        // --------------------------------------------------
        // PROPERTIES
        // --------------------------------------------------

        #region Properties

        /// <summary>
        /// The kind of this instance.
        /// </summary>
        public ActivityKinds Kind { get; set; } = ActivityKinds.None;

        /// <summary>
        /// 
        /// </summary>
        public float MaximumIndex { get; set; } = 100;

        #endregion


        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the ActivityDto class.
        /// </summary>
        protected BdoActivity() : this(ActivityKinds.Any)
        {
        }

        /// <summary>
        /// Instantiates a new instance of the ActivityDto class.
        /// </summary>
        /// <param name="name">The name to consider.</param>
        /// <param name="taskKind">The activity kind to consider.</param>
        /// <param name="title">The title to consider.</param>
        /// <param name="id">The ID to consider.</param>
        protected BdoActivity(ActivityKinds kind) : base()
        {
            DataType = BdoData.NewDataType(DataValueTypes.Any);
            Kind = kind;
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
            return null;
        }

        #endregion
    }
}
