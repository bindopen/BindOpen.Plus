using System;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This enumeration lists all the dependency condition kinds.
    /// </summary>
    [Flags]
    public enum DependencyConditionKinds
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Any.
        /// </summary>
        Any = Started | Processsed,

        /// <summary>
        /// Started.
        /// </summary>
        Started = 0x01 << 0,

        /// <summary>
        /// Processsed.
        /// </summary>
        Processsed = 0x01 << 1
    }
}