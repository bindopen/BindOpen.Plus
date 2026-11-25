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
    public class BdoJob : BdoObject, IBdoJob
    {
        // ------------------------------------------
        // PROPERTIES
        // ------------------------------------------

        #region Properties

        /// <summary>
        /// The display name of this instance.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// The display name of this instance.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this instance.
        /// </summary>
        public ITBdoDictionary<string> Title { get; set; }

        /// <summary>
        /// The description of this instance.
        /// </summary>
        public ITBdoDictionary<string> Description { get; set; }

        /// <summary>
        /// Priority of this instance.
        /// </summary>
        public ActionPriorities Priority { get; set; } = ActionPriorities.Medium;

        /// <summary>
        /// Indicates whether this instance is active.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Owner of this instance.
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// Agent ID of this instance.
        /// </summary>
        public IBdoReference ActivityReference { get; set; }

        /// <summary>
        /// Agent ID of this instance.
        /// </summary>
        public IBdoActivity Activity { get; set; }

        /// <summary>
        /// Owner of this instance.
        /// </summary>
        public IBdoReference LogReference { get; set; }

        /// <summary>
        /// Owner of this instance.
        /// </summary>
        public IBdoLog Log { get; set; }

        /// <summary>
        /// Inputs of this instance.
        /// </summary>
        public IBdoMetaSet InputDetail { get; set; }

        #endregion

        // ------------------------------------------
        // CONSTRUCTORS
        // ------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the BdoJob class.
        /// </summary>
        public BdoJob()
        {
        }

        #endregion
    }
}
