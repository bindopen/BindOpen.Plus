using System.Text.Json.Serialization;

namespace BindOpen.Databases.Tests.Fakes
{
    /// <summary>
    /// This class represents a regional direction DTO.
    /// </summary>
    public class RegionalDirectionDtoFake
    {
        #region Properties

        /// <summary>
        /// The code of this instance.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The address of this instance.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// The phone of this instance.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The email of this instance.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The fax of this instance.
        /// </summary>
        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        /// <summary>
        /// The label of this instance.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the RegionalDirectorateDto class.
        /// </summary>
        public RegionalDirectionDtoFake()
        {
        }

        #endregion
    }
}