using BindOpen.Bpm.Activities;
using BindOpen.Data;
using BindOpen.Data.Meta;
using BindOpen.Logging;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BindOpen.Bpm.Jobs
{
    /// <summary>
    /// This class represents a job.
    /// </summary>
    public class JobDto : IBdoDto
    {
        // ------------------------------------------
        // PROPERTIES
        // ------------------------------------------

        #region Properties

        /// <summary>
        /// The display name of this instance.
        /// </summary>
        [JsonPropertyName("id")]
        [XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>
        /// The display name of this instance.
        /// </summary>
        [JsonPropertyName("name")]
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// The description of this instance.
        /// </summary>
        [JsonPropertyName("title")]
        [XmlElement("title")]
        public StringDictionaryDto Title { get; set; }

        /// <summary>
        /// The description of this instance.
        /// </summary>
        [JsonPropertyName("description")]
        [XmlElement("description")]
        public StringDictionaryDto Description { get; set; }

        /// <summary>
        /// Priority of this instance.
        /// </summary>
        [JsonPropertyName("priority")]
        [XmlElement("priority")]
        public ActionPriorities Priority { get; set; } = ActionPriorities.Medium;

        /// <summary>
        /// Indicates whether this instance is active.
        /// </summary>
        [JsonPropertyName("isActive")]
        [XmlElement("isActive")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Owner of this instance.
        /// </summary>
        [JsonPropertyName("agentId")]
        [XmlElement("agentId")]
        public string AgentId { get; set; }

        /// <summary>
        /// Agent ID of this instance.
        /// </summary>
        [JsonPropertyName("activity.reference")]
        [XmlElement("activity.reference")]
        public ReferenceDto ActivityReference { get; set; }

        /// <summary>
        /// Agent ID of this instance.
        /// </summary>
        [JsonPropertyName("activity")]
        [XmlElement("activity")]
        public ActivityDto Activity { get; set; }

        /// <summary>
        /// Owner of this instance.
        /// </summary>
        [JsonPropertyName("log.reference")]
        [XmlElement("log.reference")]
        public ReferenceDto LogReference { get; set; }

        /// <summary>
        /// Owner of this instance.
        /// </summary>
        [JsonPropertyName("activity")]
        [XmlElement("activity")]
        public LogDto Log { get; set; }

        /// <summary>
        /// Inputs of this instance.
        /// </summary>
        [JsonPropertyName("input.detail")]
        [XmlElement("input.detail")]
        public MetaSetDto InputDetail { get; set; }

        #endregion

        // ------------------------------------------
        // CONSTRUCTORS
        // ------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the JobDto class.
        /// </summary>
        public JobDto()
        {
        }

        #endregion
    }
}
