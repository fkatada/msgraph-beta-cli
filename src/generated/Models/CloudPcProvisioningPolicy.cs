// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CloudPcProvisioningPolicy : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The URL of the alternate resource that links to this provisioning policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternateResourceUrl { get; set; }
#nullable restore
#else
        public string AlternateResourceUrl { get; set; }
#endif
        /// <summary>A defined collection of provisioning policy assignments. Represents the set of Microsoft 365 groups and security groups in Microsoft Entra ID that have provisioning policy assigned. Returned only on $expand. For an example about how to get the assignments relationship, see Get cloudPcProvisioningPolicy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcProvisioningPolicyAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<CloudPcProvisioningPolicyAssignment> Assignments { get; set; }
#endif
        /// <summary>The autopatch property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcProvisioningPolicyAutopatch? Autopatch { get; set; }
#nullable restore
#else
        public CloudPcProvisioningPolicyAutopatch Autopatch { get; set; }
#endif
        /// <summary>The display name of the Cloud PC group that the Cloud PCs reside in. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudPcGroupDisplayName { get; set; }
#nullable restore
#else
        public string CloudPcGroupDisplayName { get; set; }
#endif
        /// <summary>The template used to name Cloud PCs provisioned using this policy. The template can contain custom text and replacement tokens, including %USERNAME:x% and %RAND:x%, which represent the user&apos;s name and a randomly generated number, respectively. For example, CPC-%USERNAME:4%-%RAND:5% means that the name of the Cloud PC starts with CPC-, followed by a four-character username, a - character, and then five random characters. The total length of the text generated by the template can&apos;t exceed 15 characters. Supports $filter, $select, and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudPcNamingTemplate { get; set; }
#nullable restore
#else
        public string CloudPcNamingTemplate { get; set; }
#endif
        /// <summary>The provisioning policy description. Supports $filter, $select, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name for the provisioning policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Specifies a list ordered by priority on how Cloud PCs join Microsoft Entra ID (Azure AD). Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcDomainJoinConfiguration>? DomainJoinConfigurations { get; set; }
#nullable restore
#else
        public List<CloudPcDomainJoinConfiguration> DomainJoinConfigurations { get; set; }
#endif
        /// <summary>True if single sign-on can access the provisioned Cloud PC. False indicates that the provisioned Cloud PC doesn&apos;t support this feature. The default value is false. Windows 365 users can use single sign-on to authenticate to Microsoft Entra ID with passwordless options (for example, FIDO keys) to access their Cloud PC. Optional.</summary>
        public bool? EnableSingleSignOn { get; set; }
        /// <summary>The number of hours to wait before reprovisioning/deprovisioning happens. Read-only.</summary>
        public int? GracePeriodInHours { get; set; }
        /// <summary>The display name of the operating system image that is used for provisioning. For example, Windows 11 Preview + Microsoft 365 Apps 23H2 23H2. Supports $filter, $select, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageDisplayName { get; set; }
#nullable restore
#else
        public string ImageDisplayName { get; set; }
#endif
        /// <summary>The unique identifier that represents an operating system image that is used for provisioning new Cloud PCs. The format for a gallery type image is: {publisherNameofferNameskuName}. Supported values for each of the parameters are:publisher: Microsoftwindowsdesktop offer: windows-ent-cpc sku: 21h1-ent-cpc-m365, 21h1-ent-cpc-os, 20h2-ent-cpc-m365, 20h2-ent-cpc-os, 20h1-ent-cpc-m365, 20h1-ent-cpc-os, 19h2-ent-cpc-m365, and 19h2-ent-cpc-os Supports $filter, $select, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageId { get; set; }
#nullable restore
#else
        public string ImageId { get; set; }
#endif
        /// <summary>The imageType property</summary>
        public CloudPcProvisioningPolicyImageType? ImageType { get; set; }
        /// <summary>When true, the local admin is enabled for Cloud PCs; false indicates that the local admin isn&apos;t enabled for Cloud PCs. The default value is false. Supports $filter, $select, and $orderBy.</summary>
        public bool? LocalAdminEnabled { get; set; }
        /// <summary>The managedBy property</summary>
        public CloudPcManagementService? ManagedBy { get; set; }
        /// <summary>The specific settings to microsoftManagedDesktop that enables Microsoft Managed Desktop customers to get device managed experience for Cloud PC. To enable microsoftManagedDesktop to provide more value, an admin needs to specify certain settings in it. Supports $filter, $select, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.MicrosoftManagedDesktop? MicrosoftManagedDesktop { get; set; }
#nullable restore
#else
        public ApiSdk.Models.MicrosoftManagedDesktop MicrosoftManagedDesktop { get; set; }
#endif
        /// <summary>Specifies the type of licenses to be used when provisioning Cloud PCs using this policy. The possible values are dedicated, shared, unknownFutureValue, sharedByUser, sharedByEntraGroup. You must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: sharedByUser, sharedByEntraGroup. The shared member is deprecated and will stop returning on April 30, 2027; going forward, use the sharedByUser member. For example, a dedicated service plan can be assigned to only one user and provision only one Cloud PC. The shared and sharedByUser plans require customers to purchase a shared service plan. Each shared license purchased can enable up to three Cloud PCs, with only one user signed in at a time. The sharedByEntraGroup plan also requires the purchase of a shared service plan. Each shared license under this plan can enable one Cloud PC, which is shared for the group according to the assignments of this policy. By default, the license type is dedicated if the provisioningType isn&apos;t specified when you create the cloudPcProvisioningPolicy. You can&apos;t change this property after the cloudPcProvisioningPolicy is created.</summary>
        public CloudPcProvisioningType? ProvisioningType { get; set; }
        /// <summary>The scopeIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScopeIds { get; set; }
#nullable restore
#else
        public List<string> ScopeIds { get; set; }
#endif
        /// <summary>Indicates a specific Windows setting to configure during the creation of Cloud PCs for this provisioning policy. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcWindowsSetting? WindowsSetting { get; set; }
#nullable restore
#else
        public CloudPcWindowsSetting WindowsSetting { get; set; }
#endif
        /// <summary>Specific Windows settings to configure during the creation of Cloud PCs for this provisioning policy. Supports $select. The windowsSettings property is deprecated and will stop returning data on January 31, 2024. Going forward, use the windowsSetting property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcWindowsSettings? WindowsSettings { get; set; }
#nullable restore
#else
        public CloudPcWindowsSettings WindowsSettings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcProvisioningPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcProvisioningPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcProvisioningPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alternateResourceUrl", n => { AlternateResourceUrl = n.GetStringValue(); } },
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicyAssignment>(CloudPcProvisioningPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "autopatch", n => { Autopatch = n.GetObjectValue<CloudPcProvisioningPolicyAutopatch>(CloudPcProvisioningPolicyAutopatch.CreateFromDiscriminatorValue); } },
                { "cloudPcGroupDisplayName", n => { CloudPcGroupDisplayName = n.GetStringValue(); } },
                { "cloudPcNamingTemplate", n => { CloudPcNamingTemplate = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "domainJoinConfigurations", n => { DomainJoinConfigurations = n.GetCollectionOfObjectValues<CloudPcDomainJoinConfiguration>(CloudPcDomainJoinConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                { "enableSingleSignOn", n => { EnableSingleSignOn = n.GetBoolValue(); } },
                { "gracePeriodInHours", n => { GracePeriodInHours = n.GetIntValue(); } },
                { "imageDisplayName", n => { ImageDisplayName = n.GetStringValue(); } },
                { "imageId", n => { ImageId = n.GetStringValue(); } },
                { "imageType", n => { ImageType = n.GetEnumValue<CloudPcProvisioningPolicyImageType>(); } },
                { "localAdminEnabled", n => { LocalAdminEnabled = n.GetBoolValue(); } },
                { "managedBy", n => { ManagedBy = n.GetEnumValue<CloudPcManagementService>(); } },
                { "microsoftManagedDesktop", n => { MicrosoftManagedDesktop = n.GetObjectValue<ApiSdk.Models.MicrosoftManagedDesktop>(ApiSdk.Models.MicrosoftManagedDesktop.CreateFromDiscriminatorValue); } },
                { "provisioningType", n => { ProvisioningType = n.GetEnumValue<CloudPcProvisioningType>(); } },
                { "scopeIds", n => { ScopeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "windowsSetting", n => { WindowsSetting = n.GetObjectValue<CloudPcWindowsSetting>(CloudPcWindowsSetting.CreateFromDiscriminatorValue); } },
                { "windowsSettings", n => { WindowsSettings = n.GetObjectValue<CloudPcWindowsSettings>(CloudPcWindowsSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("alternateResourceUrl", AlternateResourceUrl);
            writer.WriteCollectionOfObjectValues<CloudPcProvisioningPolicyAssignment>("assignments", Assignments);
            writer.WriteObjectValue<CloudPcProvisioningPolicyAutopatch>("autopatch", Autopatch);
            writer.WriteStringValue("cloudPcGroupDisplayName", CloudPcGroupDisplayName);
            writer.WriteStringValue("cloudPcNamingTemplate", CloudPcNamingTemplate);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<CloudPcDomainJoinConfiguration>("domainJoinConfigurations", DomainJoinConfigurations);
            writer.WriteBoolValue("enableSingleSignOn", EnableSingleSignOn);
            writer.WriteIntValue("gracePeriodInHours", GracePeriodInHours);
            writer.WriteStringValue("imageDisplayName", ImageDisplayName);
            writer.WriteStringValue("imageId", ImageId);
            writer.WriteEnumValue<CloudPcProvisioningPolicyImageType>("imageType", ImageType);
            writer.WriteBoolValue("localAdminEnabled", LocalAdminEnabled);
            writer.WriteEnumValue<CloudPcManagementService>("managedBy", ManagedBy);
            writer.WriteObjectValue<ApiSdk.Models.MicrosoftManagedDesktop>("microsoftManagedDesktop", MicrosoftManagedDesktop);
            writer.WriteEnumValue<CloudPcProvisioningType>("provisioningType", ProvisioningType);
            writer.WriteCollectionOfPrimitiveValues<string>("scopeIds", ScopeIds);
            writer.WriteObjectValue<CloudPcWindowsSetting>("windowsSetting", WindowsSetting);
            writer.WriteObjectValue<CloudPcWindowsSettings>("windowsSettings", WindowsSettings);
        }
    }
}
