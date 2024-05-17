// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess {
    #pragma warning disable CS1591
    public class M365ForwardingRule : ForwardingRule, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The category property</summary>
        public ForwardingCategory? Category { get; set; }
        /// <summary>The port(s) used by a forwarding rule for Microsoft 365 traffic are specified to determine the specific network port(s) through which the Microsoft 365 traffic is directed and forwarded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ports { get; set; }
#nullable restore
#else
        public List<string> Ports { get; set; }
#endif
        /// <summary>The protocol property</summary>
        public NetworkingProtocol? Protocol { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="M365ForwardingRule"/> and sets the default values.
        /// </summary>
        public M365ForwardingRule() : base()
        {
            OdataType = "#microsoft.graph.networkaccess.m365ForwardingRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="M365ForwardingRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new M365ForwardingRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new M365ForwardingRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"category", n => { Category = n.GetEnumValue<ForwardingCategory>(); } },
                {"ports", n => { Ports = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"protocol", n => { Protocol = n.GetEnumValue<NetworkingProtocol>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ForwardingCategory>("category", Category);
            writer.WriteCollectionOfPrimitiveValues<string>("ports", Ports);
            writer.WriteEnumValue<NetworkingProtocol>("protocol", Protocol);
        }
    }
}
