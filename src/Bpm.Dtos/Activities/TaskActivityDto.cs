using System.Xml.Serialization;

namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a task activity design.
    /// </summary>
    [XmlType("TaskActivity", Namespace = "https://storage.bindopen.org/xsd/bindopen")]
    [XmlRoot(ElementName = "activity", Namespace = "https://storage.bindopen.org/xsd/bindopen", IsNullable = false)]
    public class TaskActivityDto : ActivityDto
    {
        // --------------------------------------------------
        // CONSTRUCTORS
        // --------------------------------------------------

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the TaskActivityDto class.
        /// </summary>
        public TaskActivityDto() : base()
        {
        }

        #endregion
    }
}
