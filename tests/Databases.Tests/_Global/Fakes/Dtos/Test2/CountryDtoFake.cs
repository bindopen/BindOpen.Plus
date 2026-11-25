
using System.Text.Json.Serialization;

namespace BindOpen.Databases.Tests.Fakes
{
    /// <summary>
    /// This class represents a country DTO.
    /// </summary>
    public class CountryDtoFake : DatedDtoFake
    {
        #region Properties

        /// <summary>
        /// The code of this instance.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The label of this instance.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// The information about this instance.
        /// </summary>
        [JsonPropertyName("info")]
        public CountryInformationDtoFake Information { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the CountryDto class.
        /// </summary>
        public CountryDtoFake()
        {
        }

        #endregion
    }
}