// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class MultiTenantOrganizationPartnerConfigurationTemplate : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines the partner-specific configuration for automatic user consent settings. Unless configured, the inboundAllowed and outboundAllowed properties are null and inherit from the default settings, which is always false.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InboundOutboundPolicyConfiguration? AutomaticUserConsentSettings { get; set; }
#nullable restore
#else
        public InboundOutboundPolicyConfiguration AutomaticUserConsentSettings { get; set; }
#endif
        /// <summary>Defines your partner-specific configuration for users from other organizations accessing your resources via Microsoft Entra B2B collaboration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bCollaborationInbound { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationInbound { get; set; }
#endif
        /// <summary>Defines your partner-specific configuration for users in your organization going outbound to access resources in another organization via Microsoft Entra B2B collaboration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bCollaborationOutbound { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationOutbound { get; set; }
#endif
        /// <summary>Defines your partner-specific configuration for users from other organizations accessing your resources via Azure B2B direct connect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bDirectConnectInbound { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectInbound { get; set; }
#endif
        /// <summary>Defines your partner-specific configuration for users in your organization going outbound to access resources in another organization via Microsoft Entra B2B direct connect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bDirectConnectOutbound { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectOutbound { get; set; }
#endif
        /// <summary>Determines the partner-specific configuration for trusting other Conditional Access claims from external Microsoft Entra organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyInboundTrust? InboundTrust { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyInboundTrust InboundTrust { get; set; }
#endif
        /// <summary>The templateApplicationLevel property</summary>
        public ApiSdk.Models.TemplateApplicationLevel? TemplateApplicationLevel { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MultiTenantOrganizationPartnerConfigurationTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MultiTenantOrganizationPartnerConfigurationTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MultiTenantOrganizationPartnerConfigurationTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "automaticUserConsentSettings", n => { AutomaticUserConsentSettings = n.GetObjectValue<InboundOutboundPolicyConfiguration>(InboundOutboundPolicyConfiguration.CreateFromDiscriminatorValue); } },
                { "b2bCollaborationInbound", n => { B2bCollaborationInbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                { "b2bCollaborationOutbound", n => { B2bCollaborationOutbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                { "b2bDirectConnectInbound", n => { B2bDirectConnectInbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                { "b2bDirectConnectOutbound", n => { B2bDirectConnectOutbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                { "inboundTrust", n => { InboundTrust = n.GetObjectValue<CrossTenantAccessPolicyInboundTrust>(CrossTenantAccessPolicyInboundTrust.CreateFromDiscriminatorValue); } },
                { "templateApplicationLevel", n => { TemplateApplicationLevel = n.GetEnumValue<TemplateApplicationLevel>(); } },
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
            writer.WriteObjectValue<InboundOutboundPolicyConfiguration>("automaticUserConsentSettings", AutomaticUserConsentSettings);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bCollaborationInbound", B2bCollaborationInbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bCollaborationOutbound", B2bCollaborationOutbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectInbound", B2bDirectConnectInbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectOutbound", B2bDirectConnectOutbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyInboundTrust>("inboundTrust", InboundTrust);
            writer.WriteEnumValue<TemplateApplicationLevel>("templateApplicationLevel", TemplateApplicationLevel);
        }
    }
}
