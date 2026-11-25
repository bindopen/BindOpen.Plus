using BindOpen.Data.Schema;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents an activity.
    /// </summary>
    public interface IBdoActivity : IBdoSchema
    {
        // --------------------------------------------------
        // PROPERTIES
        // --------------------------------------------------

        #region Properties

        /// <summary>
        /// The kind of this instance.
        /// </summary>
        ActivityKinds Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        float MaximumIndex { get; set; }

        #endregion
    }
}
