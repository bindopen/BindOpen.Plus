using System;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This enumeration lists all the periodicity end kinds.
    /// </summary>
    [Flags]
    public enum PeriodicityEndKinds
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Any.
        /// </summary>
        Any = Date | OccurenceNumber,

        /// <summary>
        /// Date.
        /// </summary>
        Date = 0x01 << 0,

        /// <summary>
        /// Number of occurences.
        /// </summary>
        OccurenceNumber = 0x01 << 1
    }

}
