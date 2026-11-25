using System;
using System.Text.Json.Serialization;

namespace BindOpen.Databases.Tests.Fakes
{
    /// <summary>
    /// This class represents a  employee DTO.
    /// </summary>
    public class EmployeeDtoFake
    {
        #region Properties

        /// <summary>
        /// The code of this instance.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The double field of this instance.
        /// </summary>
        [JsonPropertyName("double")]
        public double DoubleField { get; set; }

        /// <summary>
        /// The date time field of this instance.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime? DateTimeField { get; set; }

        /// <summary>
        /// The integration date of this instance.
        /// </summary>
        [JsonPropertyName("long")]
        public long LongField { get; set; }

        /// <summary>
        /// The byte array of this instance.
        /// </summary>
        [JsonPropertyName("bytes")]
        public Byte[] ByteArrayField { get; set; }

        /// <summary>
        /// The reigonal diretorate code of this instance.
        /// </summary>
        [JsonPropertyName("regionalDirectorateCode")]
        public string RegionalDirectorateCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiates a new instance of the EmployeeDto class.
        /// </summary>
        public EmployeeDtoFake()
        {
        }

        #endregion
    }
}