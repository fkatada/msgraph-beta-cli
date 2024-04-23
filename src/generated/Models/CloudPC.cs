// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class CloudPC : Entity, IParsable 
    {
        /// <summary>The Microsoft Entra device ID of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AadDeviceId { get; set; }
#nullable restore
#else
        public string AadDeviceId { get; set; }
#endif
        /// <summary>The connectionSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcConnectionSettings? ConnectionSettings { get; set; }
#nullable restore
#else
        public CloudPcConnectionSettings ConnectionSettings { get; set; }
#endif
        /// <summary>The connectivity health check result of a Cloud PC, including the updated timestamp and whether the Cloud PC can be connected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcConnectivityResult? ConnectivityResult { get; set; }
#nullable restore
#else
        public CloudPcConnectivityResult ConnectivityResult { get; set; }
#endif
        /// <summary>The disasterRecoveryCapability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcDisasterRecoveryCapability? DisasterRecoveryCapability { get; set; }
#nullable restore
#else
        public CloudPcDisasterRecoveryCapability DisasterRecoveryCapability { get; set; }
#endif
        /// <summary>The disk encryption applied to the Cloud PC. Possible values: notAvailable, notEncrypted, encryptedUsingPlatformManagedKey, encryptedUsingCustomerManagedKey, and unknownFutureValue.</summary>
        public CloudPcDiskEncryptionState? DiskEncryptionState { get; set; }
        /// <summary>The display name of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The date and time when the grace period ends and reprovisioning or deprovisioning happen. Required only if the status is inGracePeriod. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? GracePeriodEndDateTime { get; set; }
        /// <summary>Name of the OS image that&apos;s on the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageDisplayName { get; set; }
#nullable restore
#else
        public string ImageDisplayName { get; set; }
#endif
        /// <summary>The last login result of the Cloud PC. For example, { &apos;time&apos;: &apos;2014-01-01T00:00:00Z&apos;}.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcLoginResult? LastLoginResult { get; set; }
#nullable restore
#else
        public CloudPcLoginResult LastLoginResult { get; set; }
#endif
        /// <summary>The last modified date and time of the Cloud PC. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The last remote action result of the enterprise Cloud PCs. The supported remote actions are: Reboot, Rename, Reprovision, Restore, and Troubleshoot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcRemoteActionResult? LastRemoteActionResult { get; set; }
#nullable restore
#else
        public CloudPcRemoteActionResult LastRemoteActionResult { get; set; }
#endif
        /// <summary>The Intune device ID of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId { get; set; }
#nullable restore
#else
        public string ManagedDeviceId { get; set; }
#endif
        /// <summary>The Intune device name of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceName { get; set; }
#nullable restore
#else
        public string ManagedDeviceName { get; set; }
#endif
        /// <summary>The Azure network connection that is applied during the provisioning of Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesConnectionName { get; set; }
#nullable restore
#else
        public string OnPremisesConnectionName { get; set; }
#endif
        /// <summary>The version of the operating system (OS) to provision on Cloud PCs. Possible values are: windows10, windows11, and unknownFutureValue.</summary>
        public CloudPcOperatingSystem? OsVersion { get; set; }
        /// <summary>The results of every partner agent&apos;s installation status on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcPartnerAgentInstallResult>? PartnerAgentInstallResults { get; set; }
#nullable restore
#else
        public List<CloudPcPartnerAgentInstallResult> PartnerAgentInstallResults { get; set; }
#endif
        /// <summary>The power state of a Cloud PC. The possible values are: running, poweredOff and unknown. This property only supports shift work Cloud PCs.</summary>
        public CloudPcPowerState? PowerState { get; set; }
        /// <summary>The provisioning policy ID of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningPolicyId { get; set; }
#nullable restore
#else
        public string ProvisioningPolicyId { get; set; }
#endif
        /// <summary>The provisioning policy that is applied during the provisioning of Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningPolicyName { get; set; }
#nullable restore
#else
        public string ProvisioningPolicyName { get; set; }
#endif
        /// <summary>The type of licenses to be used when provisioning Cloud PCs using this policy. Possible values are: dedicated, shared, unknownFutureValue. Default value is dedicated.</summary>
        public CloudPcProvisioningType? ProvisioningType { get; set; }
        /// <summary>The scopeIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScopeIds { get; set; }
#nullable restore
#else
        public List<string> ScopeIds { get; set; }
#endif
        /// <summary>The service plan ID of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePlanId { get; set; }
#nullable restore
#else
        public string ServicePlanId { get; set; }
#endif
        /// <summary>The service plan name of the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePlanName { get; set; }
#nullable restore
#else
        public string ServicePlanName { get; set; }
#endif
        /// <summary>The service plan type of the Cloud PC.</summary>
        public CloudPcServicePlanType? ServicePlanType { get; set; }
        /// <summary>The status property</summary>
        public CloudPcStatus? Status { get; set; }
        /// <summary>The details of the Cloud PC status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcStatusDetails? StatusDetails { get; set; }
#nullable restore
#else
        public CloudPcStatusDetails StatusDetails { get; set; }
#endif
        /// <summary>The account type of the user on provisioned Cloud PCs. Possible values are: standardUser, administrator, and unknownFutureValue.</summary>
        public CloudPcUserAccountType? UserAccountType { get; set; }
        /// <summary>The user principal name (UPN) of the user assigned to the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPC"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPC CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPC();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"aadDeviceId", n => { AadDeviceId = n.GetStringValue(); } },
                {"connectionSettings", n => { ConnectionSettings = n.GetObjectValue<CloudPcConnectionSettings>(CloudPcConnectionSettings.CreateFromDiscriminatorValue); } },
                {"connectivityResult", n => { ConnectivityResult = n.GetObjectValue<CloudPcConnectivityResult>(CloudPcConnectivityResult.CreateFromDiscriminatorValue); } },
                {"disasterRecoveryCapability", n => { DisasterRecoveryCapability = n.GetObjectValue<CloudPcDisasterRecoveryCapability>(CloudPcDisasterRecoveryCapability.CreateFromDiscriminatorValue); } },
                {"diskEncryptionState", n => { DiskEncryptionState = n.GetEnumValue<CloudPcDiskEncryptionState>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"gracePeriodEndDateTime", n => { GracePeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"imageDisplayName", n => { ImageDisplayName = n.GetStringValue(); } },
                {"lastLoginResult", n => { LastLoginResult = n.GetObjectValue<CloudPcLoginResult>(CloudPcLoginResult.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRemoteActionResult", n => { LastRemoteActionResult = n.GetObjectValue<CloudPcRemoteActionResult>(CloudPcRemoteActionResult.CreateFromDiscriminatorValue); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"onPremisesConnectionName", n => { OnPremisesConnectionName = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetEnumValue<CloudPcOperatingSystem>(); } },
                {"partnerAgentInstallResults", n => { PartnerAgentInstallResults = n.GetCollectionOfObjectValues<CloudPcPartnerAgentInstallResult>(CloudPcPartnerAgentInstallResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"powerState", n => { PowerState = n.GetEnumValue<CloudPcPowerState>(); } },
                {"provisioningPolicyId", n => { ProvisioningPolicyId = n.GetStringValue(); } },
                {"provisioningPolicyName", n => { ProvisioningPolicyName = n.GetStringValue(); } },
                {"provisioningType", n => { ProvisioningType = n.GetEnumValue<CloudPcProvisioningType>(); } },
                {"scopeIds", n => { ScopeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"servicePlanId", n => { ServicePlanId = n.GetStringValue(); } },
                {"servicePlanName", n => { ServicePlanName = n.GetStringValue(); } },
                {"servicePlanType", n => { ServicePlanType = n.GetEnumValue<CloudPcServicePlanType>(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcStatus>(); } },
                {"statusDetails", n => { StatusDetails = n.GetObjectValue<CloudPcStatusDetails>(CloudPcStatusDetails.CreateFromDiscriminatorValue); } },
                {"userAccountType", n => { UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("aadDeviceId", AadDeviceId);
            writer.WriteObjectValue<CloudPcConnectionSettings>("connectionSettings", ConnectionSettings);
            writer.WriteObjectValue<CloudPcConnectivityResult>("connectivityResult", ConnectivityResult);
            writer.WriteObjectValue<CloudPcDisasterRecoveryCapability>("disasterRecoveryCapability", DisasterRecoveryCapability);
            writer.WriteEnumValue<CloudPcDiskEncryptionState>("diskEncryptionState", DiskEncryptionState);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("gracePeriodEndDateTime", GracePeriodEndDateTime);
            writer.WriteStringValue("imageDisplayName", ImageDisplayName);
            writer.WriteObjectValue<CloudPcLoginResult>("lastLoginResult", LastLoginResult);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<CloudPcRemoteActionResult>("lastRemoteActionResult", LastRemoteActionResult);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteStringValue("onPremisesConnectionName", OnPremisesConnectionName);
            writer.WriteEnumValue<CloudPcOperatingSystem>("osVersion", OsVersion);
            writer.WriteCollectionOfObjectValues<CloudPcPartnerAgentInstallResult>("partnerAgentInstallResults", PartnerAgentInstallResults);
            writer.WriteEnumValue<CloudPcPowerState>("powerState", PowerState);
            writer.WriteStringValue("provisioningPolicyId", ProvisioningPolicyId);
            writer.WriteStringValue("provisioningPolicyName", ProvisioningPolicyName);
            writer.WriteEnumValue<CloudPcProvisioningType>("provisioningType", ProvisioningType);
            writer.WriteCollectionOfPrimitiveValues<string>("scopeIds", ScopeIds);
            writer.WriteStringValue("servicePlanId", ServicePlanId);
            writer.WriteStringValue("servicePlanName", ServicePlanName);
            writer.WriteEnumValue<CloudPcServicePlanType>("servicePlanType", ServicePlanType);
            writer.WriteEnumValue<CloudPcStatus>("status", Status);
            writer.WriteObjectValue<CloudPcStatusDetails>("statusDetails", StatusDetails);
            writer.WriteEnumValue<CloudPcUserAccountType>("userAccountType", UserAccountType);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
