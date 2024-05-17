// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class PositionDetail : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Detail about the company or employer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CompanyDetail? Company { get; set; }
#nullable restore
#else
        public CompanyDetail Company { get; set; }
#endif
        /// <summary>Description of the position in question.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>When the position ended.</summary>
        public Date? EndMonthYear { get; set; }
        /// <summary>The title held when in that position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle { get; set; }
#nullable restore
#else
        public string JobTitle { get; set; }
#endif
        /// <summary>The place where the employee is within the organizational hierarchy.</summary>
        public int? Layer { get; set; }
        /// <summary>The employee’s experience or management level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Level { get; set; }
#nullable restore
#else
        public string Level { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The role the position entailed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role { get; set; }
#nullable restore
#else
        public string Role { get; set; }
#endif
        /// <summary>The start month and year of the position.</summary>
        public Date? StartMonthYear { get; set; }
        /// <summary>summary of the position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PositionDetail"/> and sets the default values.
        /// </summary>
        public PositionDetail()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PositionDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PositionDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PositionDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"company", n => { Company = n.GetObjectValue<CompanyDetail>(CompanyDetail.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"endMonthYear", n => { EndMonthYear = n.GetDateValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"layer", n => { Layer = n.GetIntValue(); } },
                {"level", n => { Level = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"startMonthYear", n => { StartMonthYear = n.GetDateValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CompanyDetail>("company", Company);
            writer.WriteStringValue("description", Description);
            writer.WriteDateValue("endMonthYear", EndMonthYear);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteIntValue("layer", Layer);
            writer.WriteStringValue("level", Level);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("role", Role);
            writer.WriteDateValue("startMonthYear", StartMonthYear);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
