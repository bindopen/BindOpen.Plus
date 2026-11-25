using System.Xml.Serialization;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a DTO workflow definition.
    /// </summary>
    [XmlType("Workflow", Namespace = "https://storage.bindopen.org/xsd/bindopen")]
    [XmlRoot(ElementName = "workflow", Namespace = "https://storage.bindopen.org/xsd/bindopen", IsNullable = false)]
    public class WorkflowDto : SequenceDto
    {
        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the WorkflowDto class.
        /// </summary>
        public WorkflowDto() : base()
        {
        }

        #endregion
    }
}

