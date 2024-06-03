// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CloudPcLaunchInfo : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudPcId { get; set; }
#nullable restore
#else
        public string CloudPcId { get; set; }
#endif
        /// <summary>The connect URL of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudPcLaunchUrl { get; set; }
#nullable restore
#else
        public string CloudPcLaunchUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates whether the Cloud PC supports switch functionality. If the value is true, it supports switch functionality; otherwise,  false.</summary>
        public bool? Windows365SwitchCompatible { get; set; }
        /// <summary>Indicates the reason the Cloud PC doesn&apos;t support switch. CPCOsVersionNotMeetRequirement indicates that the user needs to update their Cloud PC operation system version. CPCHardwareNotMeetRequirement indicates that the Cloud PC needs more CPU or RAM to support the functionality.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Windows365SwitchNotCompatibleReason { get; set; }
#nullable restore
#else
        public string Windows365SwitchNotCompatibleReason { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CloudPcLaunchInfo"/> and sets the default values.
        /// </summary>
        public CloudPcLaunchInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcLaunchInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudPcLaunchInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcLaunchInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cloudPcId", n => { CloudPcId = n.GetStringValue(); } },
                { "cloudPcLaunchUrl", n => { CloudPcLaunchUrl = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "windows365SwitchCompatible", n => { Windows365SwitchCompatible = n.GetBoolValue(); } },
                { "windows365SwitchNotCompatibleReason", n => { Windows365SwitchNotCompatibleReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cloudPcId", CloudPcId);
            writer.WriteStringValue("cloudPcLaunchUrl", CloudPcLaunchUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("windows365SwitchCompatible", Windows365SwitchCompatible);
            writer.WriteStringValue("windows365SwitchNotCompatibleReason", Windows365SwitchNotCompatibleReason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
