using BindOpen.Bpm.Jobs;
using BindOpen.Bpm.Services;
using BindOpen.Data;
using BindOpen.Data.Meta;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public interface IBdoActivityRunner : IBdoRunner, ITChild<IBdoJobRunner>
    {
        // ------------------------------------------
        // PROPERTIES
        // ------------------------------------------

        #region Properties

        /// <summary>
        /// The description of this instance.
        /// </summary>
        IBdoActivity Activity { get; set; }

        /// <summary>
        /// Inputs of this instance.
        /// </summary>
        IBdoMetaSet InputDetail { get; set; }

        RuntimeModes RuntimeMode { get; set; }

        #endregion
    }
}
