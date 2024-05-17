// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess {
    #pragma warning disable CS1591
    public class ForwardingRule : PolicyRule, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public ForwardingRuleAction? Action { get; set; }
        /// <summary>Destinations maintain a list of potential destinations and destination types that the user may access within the context of a network filtering policy. This includes IP addresses and fully qualified domain names (FQDNs)/URLs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RuleDestination>? Destinations { get; set; }
#nullable restore
#else
        public List<RuleDestination> Destinations { get; set; }
#endif
        /// <summary>The ruleType property</summary>
        public NetworkDestinationType? RuleType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ForwardingRule"/> and sets the default values.
        /// </summary>
        public ForwardingRule() : base()
        {
            OdataType = "#microsoft.graph.networkaccess.forwardingRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ForwardingRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ForwardingRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.networkaccess.internetAccessForwardingRule" => new InternetAccessForwardingRule(),
                "#microsoft.graph.networkaccess.m365ForwardingRule" => new M365ForwardingRule(),
                "#microsoft.graph.networkaccess.privateAccessForwardingRule" => new PrivateAccessForwardingRule(),
                _ => new ForwardingRule(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"action", n => { Action = n.GetEnumValue<ForwardingRuleAction>(); } },
                {"destinations", n => { Destinations = n.GetCollectionOfObjectValues<RuleDestination>(RuleDestination.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ruleType", n => { RuleType = n.GetEnumValue<NetworkDestinationType>(); } },
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
            writer.WriteEnumValue<ForwardingRuleAction>("action", Action);
            writer.WriteCollectionOfObjectValues<RuleDestination>("destinations", Destinations);
            writer.WriteEnumValue<NetworkDestinationType>("ruleType", RuleType);
        }
    }
}
