using BindOpen.Bpm.Activities;
using BindOpen.Data;
using BindOpen.Data.Meta;
using BindOpen.Data.Objects;
using BindOpen.Logging;

namespace BindOpen.Bpm.Jobs
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public interface IBdoJob : IBdoObject, IIdentified, INamed, IBdoTitled, IBdoDescribed, IActivable
    {
        // ------------------------------------------
        // PROPERTIES
        // ------------------------------------------

        #region Properties

        /// <summary>
        /// Priority of this instance.
        /// </summary>
        ActionPriorities Priority { get; set; }

        /// <summary>
        /// Agent ID of this instance.
        /// </summary>
        string AgentId { get; set; }

        /// <summary>
        /// Log reference of this instance.
        /// </summary>
        IBdoReference ActivityReference { get; set; }

        /// <summary>
        /// Log reference of this instance.
        /// </summary>
        IBdoActivity Activity { get; set; }

        /// <summary>
        /// Log reference of this instance.
        /// </summary>
        IBdoReference LogReference { get; set; }

        /// <summary>
        /// Log reference of this instance.
        /// </summary>
        IBdoLog Log { get; set; }

        /// <summary>
        /// Inputs of this instance.
        /// </summary>
        IBdoMetaSet InputDetail { get; set; }

        #endregion
    }
}
