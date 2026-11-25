using System.Text.Json.Serialization;

namespace BindOpen.Databases.Tests.Fakes
{
    /// <summary>
    /// This class represents a country information DTO.
    /// </summary>
    public class CountryInformationDtoFake : DatedDtoFake
    {
        #region Properties

        /// <summary>
        /// The country code of this instance.
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The adjustment 1 of this instance.
        /// </summary>
        [JsonPropertyName("adjustment1")]
        public int Adjustment1 { get; set; }

        /// <summary>
        /// The delay 1 of this instance.
        /// </summary>
        [JsonPropertyName("delay1")]
        public int Delay1 { get; set; }

        /// <summary>
        /// The adjustment 2 of this instance.
        /// </summary>
        [JsonPropertyName("adjustment2")]
        public int Adjustment2 { get; set; }

        /// <summary>
        /// The delay 2 of this instance.
        /// </summary>
        [JsonPropertyName("delay2")]
        public int Delay2 { get; set; }

        /// <summary>
        /// The registry of this instance.
        /// </summary>
        [JsonPropertyName("registry")]
        public string Registry { get; set; }

        /// <summary>
        /// The international registry of this instance.
        /// </summary>
        [JsonPropertyName("internationalRegistry")]
        public string InternationalRegistry { get; set; }

        /// <summary>
        /// The start date of this instance.
        /// </summary>
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the CountryInformationDto class.
        /// </summary>
        public CountryInformationDtoFake()
        {
        }

        #endregion
    }
}