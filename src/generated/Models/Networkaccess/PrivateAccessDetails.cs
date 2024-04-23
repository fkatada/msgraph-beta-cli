// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess {
    public class PrivateAccessDetails : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The accessType property</summary>
        public ApiSdk.Models.Networkaccess.AccessType? AccessType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The connectionStatus property</summary>
        public ApiSdk.Models.Networkaccess.ConnectionStatus? ConnectionStatus { get; set; }
        /// <summary>The connectorId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorId { get; set; }
#nullable restore
#else
        public string ConnectorId { get; set; }
#endif
        /// <summary>The connectorIp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorIp { get; set; }
#nullable restore
#else
        public string ConnectorIp { get; set; }
#endif
        /// <summary>The connectorName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorName { get; set; }
#nullable restore
#else
        public string ConnectorName { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The processingRegion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcessingRegion { get; set; }
#nullable restore
#else
        public string ProcessingRegion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PrivateAccessDetails"/> and sets the default values.
        /// </summary>
        public PrivateAccessDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivateAccessDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrivateAccessDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivateAccessDetails();
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
                {"connectionStatus", n => { ConnectionStatus = n.GetEnumValue<ConnectionStatus>(); } },
                {"connectorId", n => { ConnectorId = n.GetStringValue(); } },
                {"connectorIp", n => { ConnectorIp = n.GetStringValue(); } },
                {"connectorName", n => { ConnectorName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"processingRegion", n => { ProcessingRegion = n.GetStringValue(); } },
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
            writer.WriteEnumValue<ConnectionStatus>("connectionStatus", ConnectionStatus);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("connectorIp", ConnectorIp);
            writer.WriteStringValue("connectorName", ConnectorName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("processingRegion", ProcessingRegion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
