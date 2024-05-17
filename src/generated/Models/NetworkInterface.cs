// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class NetworkInterface : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Description of the NIC (for example, Ethernet adapter, Wireless LAN adapter Local Area Connection, and so on).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Last IPv4 address associated with this NIC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpV4Address { get; set; }
#nullable restore
#else
        public string IpV4Address { get; set; }
#endif
        /// <summary>Last Public (also known as global) IPv6 address associated with this NIC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpV6Address { get; set; }
#nullable restore
#else
        public string IpV6Address { get; set; }
#endif
        /// <summary>Last local (link-local or site-local) IPv6 address associated with this NIC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalIpV6Address { get; set; }
#nullable restore
#else
        public string LocalIpV6Address { get; set; }
#endif
        /// <summary>MAC address of the NIC on this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacAddress { get; set; }
#nullable restore
#else
        public string MacAddress { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="NetworkInterface"/> and sets the default values.
        /// </summary>
        public NetworkInterface()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="NetworkInterface"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NetworkInterface CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkInterface();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"description", n => { Description = n.GetStringValue(); } },
                {"ipV4Address", n => { IpV4Address = n.GetStringValue(); } },
                {"ipV6Address", n => { IpV6Address = n.GetStringValue(); } },
                {"localIpV6Address", n => { LocalIpV6Address = n.GetStringValue(); } },
                {"macAddress", n => { MacAddress = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("ipV4Address", IpV4Address);
            writer.WriteStringValue("ipV6Address", IpV6Address);
            writer.WriteStringValue("localIpV6Address", LocalIpV6Address);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
