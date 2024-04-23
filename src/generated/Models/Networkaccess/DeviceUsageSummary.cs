// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess {
    public class DeviceUsageSummary : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The number of distinct device IDs between the discovery pivot time and the end of the reporting period.</summary>
        public int? ActiveDeviceCount { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The discovery pivot time and the end of the reporting period, but were seen between the start of the reporting period and the discovery pivot time.</summary>
        public int? InactiveDeviceCount { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The total number of distinct device IDs that were seen during the reporting period.</summary>
        public int? TotalDeviceCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DeviceUsageSummary"/> and sets the default values.
        /// </summary>
        public DeviceUsageSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceUsageSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceUsageSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceUsageSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                {"inactiveDeviceCount", n => { InactiveDeviceCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"totalDeviceCount", n => { TotalDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("activeDeviceCount", ActiveDeviceCount);
            writer.WriteIntValue("inactiveDeviceCount", InactiveDeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("totalDeviceCount", TotalDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
