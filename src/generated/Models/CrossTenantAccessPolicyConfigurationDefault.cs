// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CrossTenantAccessPolicyConfigurationDefault : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines the default configuration for automatic user consent settings. The inboundAllowed and outboundAllowed properties are always false and can&apos;t be updated in the default configuration. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InboundOutboundPolicyConfiguration? AutomaticUserConsentSettings { get; set; }
#nullable restore
#else
        public InboundOutboundPolicyConfiguration AutomaticUserConsentSettings { get; set; }
#endif
        /// <summary>Defines your default configuration for users from other organizations accessing your resources via Microsoft Entra B2B collaboration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bCollaborationInbound { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationInbound { get; set; }
#endif
        /// <summary>Defines your default configuration for users in your organization going outbound to access resources in another organization via Microsoft Entra B2B collaboration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bCollaborationOutbound { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationOutbound { get; set; }
#endif
        /// <summary>Defines your default configuration for users from other organizations accessing your resources via Microsoft Entra B2B direct connect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bDirectConnectInbound { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectInbound { get; set; }
#endif
        /// <summary>Defines your default configuration for users in your organization going outbound to access resources in another organization via Microsoft Entra B2B direct connect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyB2BSetting? B2bDirectConnectOutbound { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectOutbound { get; set; }
#endif
        /// <summary>Determines the default configuration for trusting other Conditional Access claims from external Microsoft Entra organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyInboundTrust? InboundTrust { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyInboundTrust InboundTrust { get; set; }
#endif
        /// <summary>Defines the priority order based on which an identity provider is selected during invitation redemption for a guest user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DefaultInvitationRedemptionIdentityProviderConfiguration? InvitationRedemptionIdentityProviderConfiguration { get; set; }
#nullable restore
#else
        public DefaultInvitationRedemptionIdentityProviderConfiguration InvitationRedemptionIdentityProviderConfiguration { get; set; }
#endif
        /// <summary>If true, the default configuration is set to the system default configuration. If false, the default settings are customized.</summary>
        public bool? IsServiceDefault { get; set; }
        /// <summary>Defines the default tenant restrictions configuration for your organization users accessing an external organization on your network or devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CrossTenantAccessPolicyTenantRestrictions? TenantRestrictions { get; set; }
#nullable restore
#else
        public CrossTenantAccessPolicyTenantRestrictions TenantRestrictions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CrossTenantAccessPolicyConfigurationDefault"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CrossTenantAccessPolicyConfigurationDefault CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyConfigurationDefault();
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
                { "invitationRedemptionIdentityProviderConfiguration", n => { InvitationRedemptionIdentityProviderConfiguration = n.GetObjectValue<DefaultInvitationRedemptionIdentityProviderConfiguration>(DefaultInvitationRedemptionIdentityProviderConfiguration.CreateFromDiscriminatorValue); } },
                { "isServiceDefault", n => { IsServiceDefault = n.GetBoolValue(); } },
                { "tenantRestrictions", n => { TenantRestrictions = n.GetObjectValue<CrossTenantAccessPolicyTenantRestrictions>(CrossTenantAccessPolicyTenantRestrictions.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<DefaultInvitationRedemptionIdentityProviderConfiguration>("invitationRedemptionIdentityProviderConfiguration", InvitationRedemptionIdentityProviderConfiguration);
            writer.WriteBoolValue("isServiceDefault", IsServiceDefault);
            writer.WriteObjectValue<CrossTenantAccessPolicyTenantRestrictions>("tenantRestrictions", TenantRestrictions);
        }
    }
}
