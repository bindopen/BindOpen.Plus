using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a DTO sequence activity design.
    /// </summary>
    [XmlType("Sequence", Namespace = "https://storage.bindopen.org/xsd/bindopen")]
    [XmlRoot(ElementName = "sequence", Namespace = "https://storage.bindopen.org/xsd/bindopen", IsNullable = false)]
    public class SequenceDto : ActivityDto
    {
        [JsonPropertyName("kind")]
        [XmlAttribute("kind")]
        [DefaultValue(SequenceKinds.Standard)]
        public SequenceKinds SequenceKind { get; set; }

        /// <summary>
        /// THe children of this instance.
        /// </summary>
        [JsonPropertyName("activities")]
        [XmlElement("activity", Type = typeof(TaskActivityDto))]
        [XmlElement("sequence", Type = typeof(SequenceDto))]
        [XmlElement("workflow", Type = typeof(WorkflowDto))]
        public List<ActivityDto> Activities { get; set; }


        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the SequenceActivityDto class.
        /// </summary>
        public SequenceDto() : base()
        {
        }

        #endregion
    }
}
