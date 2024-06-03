// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class PolicyTemplate : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines an optional cross-tenant access policy template with user synchronization settings for a multi-tenant organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MultiTenantOrganizationIdentitySyncPolicyTemplate? MultiTenantOrganizationIdentitySynchronization { get; set; }
#nullable restore
#else
        public MultiTenantOrganizationIdentitySyncPolicyTemplate MultiTenantOrganizationIdentitySynchronization { get; set; }
#endif
        /// <summary>Defines an optional cross-tenant access policy template with inbound and outbound partner configuration settings for a multi-tenant organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MultiTenantOrganizationPartnerConfigurationTemplate? MultiTenantOrganizationPartnerConfiguration { get; set; }
#nullable restore
#else
        public MultiTenantOrganizationPartnerConfigurationTemplate MultiTenantOrganizationPartnerConfiguration { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PolicyTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "multiTenantOrganizationIdentitySynchronization", n => { MultiTenantOrganizationIdentitySynchronization = n.GetObjectValue<MultiTenantOrganizationIdentitySyncPolicyTemplate>(MultiTenantOrganizationIdentitySyncPolicyTemplate.CreateFromDiscriminatorValue); } },
                { "multiTenantOrganizationPartnerConfiguration", n => { MultiTenantOrganizationPartnerConfiguration = n.GetObjectValue<MultiTenantOrganizationPartnerConfigurationTemplate>(MultiTenantOrganizationPartnerConfigurationTemplate.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MultiTenantOrganizationIdentitySyncPolicyTemplate>("multiTenantOrganizationIdentitySynchronization", MultiTenantOrganizationIdentitySynchronization);
            writer.WriteObjectValue<MultiTenantOrganizationPartnerConfigurationTemplate>("multiTenantOrganizationPartnerConfiguration", MultiTenantOrganizationPartnerConfiguration);
        }
    }
}
