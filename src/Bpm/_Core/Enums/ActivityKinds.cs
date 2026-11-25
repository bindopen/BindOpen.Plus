using System;
using System.Xml.Serialization;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This enumeration lists all the activity kinds.
    /// </summary>
    [Flags]
    [XmlType("ActivityKind", Namespace = "https://bindopen.org/xsd")]
    [XmlRoot(ElementName = "activityKind", Namespace = "https://bindopen.org/xsd", IsNullable = false)]
    public enum ActivityKinds
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Any.
        /// </summary>
        Any = Task | Sequence | Workflow,

        /// <summary>
        /// Task.
        /// </summary>
        Task = 0x01 << 0,

        /// <summary>
        /// Sequence.
        /// </summary>
        Sequence = 0x01 << 1,

        /// <summary>
        /// Workflow.
        /// </summary>
        Workflow = 0x01 << 2
    }
}