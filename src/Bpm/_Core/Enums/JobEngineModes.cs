using System;

namespace BindOpen.Bpm
{
    /// <summary>
    /// This enumeration lists all the possible modes of job engine.
    /// </summary>
    [Flags]
    public enum JobEngineModes
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Any.
        /// </summary>
        Any = Service | Batch,

        /// <summary>
        /// The service mode with check of new jobs to execute.
        /// </summary>
        /// <remarks>The service mode is the default one.</remarks>
        Service = 0x01 << 0,

        /// <summary>
        /// The bacth mode
        /// </summary>
        Batch = 0x01 << 1
    }
}
