// <auto-generated/>
using ApiSdk.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityExportReport {
    #pragma warning disable CS1591
    public class ExportReportPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The additionalOptions property</summary>
        public ApiSdk.Models.Security.AdditionalOptions? AdditionalOptions { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The exportCriteria property</summary>
        public ApiSdk.Models.Security.ExportCriteria? ExportCriteria { get; set; }
        /// <summary>The exportLocation property</summary>
        public ApiSdk.Models.Security.ExportLocation? ExportLocation { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ExportReportPostRequestBody"/> and sets the default values.
        /// </summary>
        public ExportReportPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExportReportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExportReportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExportReportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"additionalOptions", n => { AdditionalOptions = n.GetEnumValue<AdditionalOptions>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"exportCriteria", n => { ExportCriteria = n.GetEnumValue<ExportCriteria>(); } },
                {"exportLocation", n => { ExportLocation = n.GetEnumValue<ExportLocation>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AdditionalOptions>("additionalOptions", AdditionalOptions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<ExportCriteria>("exportCriteria", ExportCriteria);
            writer.WriteEnumValue<ExportLocation>("exportLocation", ExportLocation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
