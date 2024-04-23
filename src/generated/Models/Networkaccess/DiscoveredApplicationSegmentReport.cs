// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess {
    public class DiscoveredApplicationSegmentReport : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The accessType property</summary>
        public ApiSdk.Models.Networkaccess.AccessType? AccessType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deviceCount property</summary>
        public int? DeviceCount { get; set; }
        /// <summary>The discoveredApplicationSegmentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DiscoveredApplicationSegmentId { get; set; }
#nullable restore
#else
        public string DiscoveredApplicationSegmentId { get; set; }
#endif
        /// <summary>The firstAccessDateTime property</summary>
        public DateTimeOffset? FirstAccessDateTime { get; set; }
        /// <summary>The fqdn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fqdn { get; set; }
#nullable restore
#else
        public string Fqdn { get; set; }
#endif
        /// <summary>The ip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ip { get; set; }
#nullable restore
#else
        public string Ip { get; set; }
#endif
        /// <summary>The lastAccessDateTime property</summary>
        public DateTimeOffset? LastAccessDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The port property</summary>
        public int? Port { get; set; }
        /// <summary>The totalBytesReceived property</summary>
        public long? TotalBytesReceived { get; set; }
        /// <summary>The totalBytesSent property</summary>
        public long? TotalBytesSent { get; set; }
        /// <summary>The transactionCount property</summary>
        public int? TransactionCount { get; set; }
        /// <summary>The transportProtocol property</summary>
        public NetworkingProtocol? TransportProtocol { get; set; }
        /// <summary>The userCount property</summary>
        public int? UserCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DiscoveredApplicationSegmentReport"/> and sets the default values.
        /// </summary>
        public DiscoveredApplicationSegmentReport()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DiscoveredApplicationSegmentReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DiscoveredApplicationSegmentReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DiscoveredApplicationSegmentReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"accessType", n => { AccessType = n.GetEnumValue<AccessType>(); } },
                {"deviceCount", n => { DeviceCount = n.GetIntValue(); } },
                {"discoveredApplicationSegmentId", n => { DiscoveredApplicationSegmentId = n.GetStringValue(); } },
                {"firstAccessDateTime", n => { FirstAccessDateTime = n.GetDateTimeOffsetValue(); } },
                {"fqdn", n => { Fqdn = n.GetStringValue(); } },
                {"ip", n => { Ip = n.GetStringValue(); } },
                {"lastAccessDateTime", n => { LastAccessDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
                {"totalBytesReceived", n => { TotalBytesReceived = n.GetLongValue(); } },
                {"totalBytesSent", n => { TotalBytesSent = n.GetLongValue(); } },
                {"transactionCount", n => { TransactionCount = n.GetIntValue(); } },
                {"transportProtocol", n => { TransportProtocol = n.GetEnumValue<NetworkingProtocol>(); } },
                {"userCount", n => { UserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessType>("accessType", AccessType);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteStringValue("discoveredApplicationSegmentId", DiscoveredApplicationSegmentId);
            writer.WriteDateTimeOffsetValue("firstAccessDateTime", FirstAccessDateTime);
            writer.WriteStringValue("fqdn", Fqdn);
            writer.WriteStringValue("ip", Ip);
            writer.WriteDateTimeOffsetValue("lastAccessDateTime", LastAccessDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("port", Port);
            writer.WriteLongValue("totalBytesReceived", TotalBytesReceived);
            writer.WriteLongValue("totalBytesSent", TotalBytesSent);
            writer.WriteIntValue("transactionCount", TransactionCount);
            writer.WriteEnumValue<NetworkingProtocol>("transportProtocol", TransportProtocol);
            writer.WriteIntValue("userCount", UserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
