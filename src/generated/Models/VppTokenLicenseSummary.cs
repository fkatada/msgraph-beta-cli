// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// License summary of a given app in a token.
    /// </summary>
    public class VppTokenLicenseSummary : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Apple Id associated with the given Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppleId { get; set; }
#nullable restore
#else
        public string AppleId { get; set; }
#endif
        /// <summary>The number of VPP licenses available.</summary>
        public int? AvailableLicenseCount { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The organization associated with the Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName { get; set; }
#nullable restore
#else
        public string OrganizationName { get; set; }
#endif
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount { get; set; }
        /// <summary>Identifier of the VPP token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppTokenId { get; set; }
#nullable restore
#else
        public string VppTokenId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="VppTokenLicenseSummary"/> and sets the default values.
        /// </summary>
        public VppTokenLicenseSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VppTokenLicenseSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VppTokenLicenseSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppTokenLicenseSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appleId", n => { AppleId = n.GetStringValue(); } },
                { "availableLicenseCount", n => { AvailableLicenseCount = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "organizationName", n => { OrganizationName = n.GetStringValue(); } },
                { "usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                { "vppTokenId", n => { VppTokenId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteIntValue("availableLicenseCount", AvailableLicenseCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteStringValue("vppTokenId", VppTokenId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
