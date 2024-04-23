// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class DirectoryObject1 : Entity, IParsable 
    {
        /// <summary>Conceptual container for user and group directory objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AdministrativeUnit>? AdministrativeUnits { get; set; }
#nullable restore
#else
        public List<AdministrativeUnit> AdministrativeUnits { get; set; }
#endif
        /// <summary>Group of related custom security attribute definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttributeSet>? AttributeSets { get; set; }
#nullable restore
#else
        public List<AttributeSet> AttributeSets { get; set; }
#endif
        /// <summary>The certificateAuthorities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CertificateAuthorityPath? CertificateAuthorities { get; set; }
#nullable restore
#else
        public CertificateAuthorityPath CertificateAuthorities { get; set; }
#endif
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomSecurityAttributeDefinition>? CustomSecurityAttributeDefinitions { get; set; }
#nullable restore
#else
        public List<CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions { get; set; }
#endif
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? DeletedItems { get; set; }
#nullable restore
#else
        public List<DirectoryObject> DeletedItems { get; set; }
#endif
        /// <summary>The credentials of the device&apos;s local administrator account backed up to Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceLocalCredentialInfo>? DeviceLocalCredentials { get; set; }
#nullable restore
#else
        public List<DeviceLocalCredentialInfo> DeviceLocalCredentials { get; set; }
#endif
        /// <summary>Collection of external user profiles that represent collaborators in the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExternalUserProfile>? ExternalUserProfiles { get; set; }
#nullable restore
#else
        public List<ExternalUserProfile> ExternalUserProfiles { get; set; }
#endif
        /// <summary>The featureRolloutPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FeatureRolloutPolicy>? FeatureRolloutPolicies { get; set; }
#nullable restore
#else
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
#endif
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? FederationConfigurations { get; set; }
#nullable restore
#else
        public List<IdentityProviderBase> FederationConfigurations { get; set; }
#endif
        /// <summary>The impactedResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImpactedResource>? ImpactedResources { get; set; }
#nullable restore
#else
        public List<ImpactedResource> ImpactedResources { get; set; }
#endif
        /// <summary>A collection of external users whose profile data is shared with the Microsoft Entra tenant. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InboundSharedUserProfile>? InboundSharedUserProfiles { get; set; }
#nullable restore
#else
        public List<InboundSharedUserProfile> InboundSharedUserProfiles { get; set; }
#endif
        /// <summary>A container for on-premises directory synchronization functionalities that are available for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesDirectorySynchronization>? OnPremisesSynchronization { get; set; }
#nullable restore
#else
        public List<OnPremisesDirectorySynchronization> OnPremisesSynchronization { get; set; }
#endif
        /// <summary>The outboundSharedUserProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OutboundSharedUserProfile>? OutboundSharedUserProfiles { get; set; }
#nullable restore
#else
        public List<OutboundSharedUserProfile> OutboundSharedUserProfiles { get; set; }
#endif
        /// <summary>Collection of pending external user profiles representing collaborators in the directory that are unredeemed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PendingExternalUserProfile>? PendingExternalUserProfiles { get; set; }
#nullable restore
#else
        public List<PendingExternalUserProfile> PendingExternalUserProfiles { get; set; }
#endif
        /// <summary>List of recommended improvements to improve tenant posture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recommendation>? Recommendations { get; set; }
#nullable restore
#else
        public List<Recommendation> Recommendations { get; set; }
#endif
        /// <summary>The sharedEmailDomains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SharedEmailDomain>? SharedEmailDomains { get; set; }
#nullable restore
#else
        public List<SharedEmailDomain> SharedEmailDomains { get; set; }
#endif
        /// <summary>List of commercial subscriptions that an organization has.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CompanySubscription>? Subscriptions { get; set; }
#nullable restore
#else
        public List<CompanySubscription> Subscriptions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DirectoryObject1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryObject1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryObject1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<AdministrativeUnit>(AdministrativeUnit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attributeSets", n => { AttributeSets = n.GetCollectionOfObjectValues<AttributeSet>(AttributeSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"certificateAuthorities", n => { CertificateAuthorities = n.GetObjectValue<CertificateAuthorityPath>(CertificateAuthorityPath.CreateFromDiscriminatorValue); } },
                {"customSecurityAttributeDefinitions", n => { CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<CustomSecurityAttributeDefinition>(CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceLocalCredentials", n => { DeviceLocalCredentials = n.GetCollectionOfObjectValues<DeviceLocalCredentialInfo>(DeviceLocalCredentialInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalUserProfiles", n => { ExternalUserProfiles = n.GetCollectionOfObjectValues<ExternalUserProfile>(ExternalUserProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<ImpactedResource>(ImpactedResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"inboundSharedUserProfiles", n => { InboundSharedUserProfiles = n.GetCollectionOfObjectValues<InboundSharedUserProfile>(InboundSharedUserProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesSynchronization", n => { OnPremisesSynchronization = n.GetCollectionOfObjectValues<OnPremisesDirectorySynchronization>(OnPremisesDirectorySynchronization.CreateFromDiscriminatorValue)?.ToList(); } },
                {"outboundSharedUserProfiles", n => { OutboundSharedUserProfiles = n.GetCollectionOfObjectValues<OutboundSharedUserProfile>(OutboundSharedUserProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pendingExternalUserProfiles", n => { PendingExternalUserProfiles = n.GetCollectionOfObjectValues<PendingExternalUserProfile>(PendingExternalUserProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"recommendations", n => { Recommendations = n.GetCollectionOfObjectValues<Recommendation>(Recommendation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sharedEmailDomains", n => { SharedEmailDomains = n.GetCollectionOfObjectValues<SharedEmailDomain>(SharedEmailDomain.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<CompanySubscription>(CompanySubscription.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<AttributeSet>("attributeSets", AttributeSets);
            writer.WriteObjectValue<CertificateAuthorityPath>("certificateAuthorities", CertificateAuthorities);
            writer.WriteCollectionOfObjectValues<CustomSecurityAttributeDefinition>("customSecurityAttributeDefinitions", CustomSecurityAttributeDefinitions);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("deletedItems", DeletedItems);
            writer.WriteCollectionOfObjectValues<DeviceLocalCredentialInfo>("deviceLocalCredentials", DeviceLocalCredentials);
            writer.WriteCollectionOfObjectValues<ExternalUserProfile>("externalUserProfiles", ExternalUserProfiles);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("federationConfigurations", FederationConfigurations);
            writer.WriteCollectionOfObjectValues<ImpactedResource>("impactedResources", ImpactedResources);
            writer.WriteCollectionOfObjectValues<InboundSharedUserProfile>("inboundSharedUserProfiles", InboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<OnPremisesDirectorySynchronization>("onPremisesSynchronization", OnPremisesSynchronization);
            writer.WriteCollectionOfObjectValues<OutboundSharedUserProfile>("outboundSharedUserProfiles", OutboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<PendingExternalUserProfile>("pendingExternalUserProfiles", PendingExternalUserProfiles);
            writer.WriteCollectionOfObjectValues<Recommendation>("recommendations", Recommendations);
            writer.WriteCollectionOfObjectValues<SharedEmailDomain>("sharedEmailDomains", SharedEmailDomains);
            writer.WriteCollectionOfObjectValues<CompanySubscription>("subscriptions", Subscriptions);
        }
    }
}
