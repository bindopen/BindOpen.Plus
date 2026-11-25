using BindOpen.Data.Schema;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a DTO activity.
    /// </summary>
    [XmlType("Activity", Namespace = "https://storage.bindopen.org/xsd/bindopen")]
    [XmlInclude(typeof(TaskActivityDto))]
    [XmlInclude(typeof(SequenceDto))]
    [XmlInclude(typeof(WorkflowDto))]
    [JsonDerivedType(typeof(TaskActivityDto), "activity")]
    [JsonDerivedType(typeof(SequenceDto), "sequence")]
    [JsonDerivedType(typeof(WorkflowDto), "workflow")]
    public abstract class ActivityDto : SchemaDto
    {
        // --------------------------------------------------
        // PROPERTIES
        // --------------------------------------------------

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("maximumIndex")]
        [XmlAttribute("maximumIndex")]
        [DefaultValue(100)]
        public float MaximumIndex { get; set; } = 100;

        #endregion

        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the ActivityDto class.
        /// </summary>
        protected ActivityDto()
        {
        }

        #endregion
    }
}
