using System;
using System.Text.Json.Serialization;

namespace BindOpen.Databases.Tests.Fakes
{
    /// <summary>
    /// This class represents a dated DTO.
    /// </summary>
    public class DatedDtoFake : IDatedDtoFake
    {
        #region Properties

        /// <summary>
        /// The creation date of this instance.
        /// </summary>
        [JsonPropertyName("creationDate")]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// The last modification date of this instance.
        /// </summary>
        [JsonPropertyName("lastModificationDate")]
        public DateTime? LastModificationDate { get; set; }

        #endregion
    }
}