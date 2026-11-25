using System;
using System.Xml.Serialization;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This enumeration lists all the sequence kinds.
    /// </summary>
    [Flags]
    [XmlType("SequenceKind", Namespace = "https://bindopen.org/xsd")]
    [XmlRoot(ElementName = "sequenceKind", Namespace = "https://bindopen.org/xsd", IsNullable = false)]
    public enum SequenceKinds
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Any.
        /// </summary>
        Any = Standard | Loop | Parallel | ForEach,

        /// <summary>
        /// Task.
        /// </summary>
        Standard = 0x01 << 0,

        /// <summary>
        /// Sequence.
        /// </summary>
        Loop = 0x01 << 1,

        /// <summary>
        /// Workflow.
        /// </summary>
        Parallel = 0x01 << 2,

        /// <summary>
        /// ForEach.
        /// </summary>
        ForEach = 0x01 << 3
    }
}