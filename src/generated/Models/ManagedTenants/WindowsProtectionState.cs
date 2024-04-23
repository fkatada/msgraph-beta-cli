// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants {
    public class WindowsProtectionState : ApiSdk.Models.Entity, IParsable 
    {
        /// <summary>The anti-malware version for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AntiMalwareVersion { get; set; }
#nullable restore
#else
        public string AntiMalwareVersion { get; set; }
#endif
        /// <summary>A flag indicating whether attention is required for the managed device. Optional. Read-only.</summary>
        public bool? AttentionRequired { get; set; }
        /// <summary>A flag indicating whether the managed device has been deleted. Optional. Read-only.</summary>
        public bool? DeviceDeleted { get; set; }
        /// <summary>The date and time the device property has been refreshed. Optional. Read-only.</summary>
        public DateTimeOffset? DevicePropertyRefreshDateTime { get; set; }
        /// <summary>The anti-virus engine version for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EngineVersion { get; set; }
#nullable restore
#else
        public string EngineVersion { get; set; }
#endif
        /// <summary>A flag indicating whether quick scan is overdue for the managed device. Optional. Read-only.</summary>
        public bool? FullScanOverdue { get; set; }
        /// <summary>A flag indicating whether full scan is overdue for the managed device. Optional. Read-only.</summary>
        public bool? FullScanRequired { get; set; }
        /// <summary>The date and time a full scan was completed. Optional. Read-only.</summary>
        public DateTimeOffset? LastFullScanDateTime { get; set; }
        /// <summary>The version anti-malware version used to perform the last full scan. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastFullScanSignatureVersion { get; set; }
#nullable restore
#else
        public string LastFullScanSignatureVersion { get; set; }
#endif
        /// <summary>The date and time a quick scan was completed. Optional. Read-only.</summary>
        public DateTimeOffset? LastQuickScanDateTime { get; set; }
        /// <summary>The version anti-malware version used to perform the last full scan. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastQuickScanSignatureVersion { get; set; }
#nullable restore
#else
        public string LastQuickScanSignatureVersion { get; set; }
#endif
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The date and time the protection state was last reported for the managed device. Optional. Read-only.</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>A flag indicating whether malware protection is enabled for the managed device. Optional. Read-only.</summary>
        public bool? MalwareProtectionEnabled { get; set; }
        /// <summary>The health state for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceHealthState { get; set; }
#nullable restore
#else
        public string ManagedDeviceHealthState { get; set; }
#endif
        /// <summary>The unique identifier for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId { get; set; }
#nullable restore
#else
        public string ManagedDeviceId { get; set; }
#endif
        /// <summary>The display name for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceName { get; set; }
#nullable restore
#else
        public string ManagedDeviceName { get; set; }
#endif
        /// <summary>A flag indicating whether the network inspection system is enabled. Optional. Read-only.</summary>
        public bool? NetworkInspectionSystemEnabled { get; set; }
        /// <summary>A flag indicating weather a quick scan is overdue. Optional. Read-only.</summary>
        public bool? QuickScanOverdue { get; set; }
        /// <summary>A flag indicating whether real time protection is enabled. Optional. Read-only.</summary>
        public bool? RealTimeProtectionEnabled { get; set; }
        /// <summary>A flag indicating whether a reboot is required. Optional. Read-only.</summary>
        public bool? RebootRequired { get; set; }
        /// <summary>A flag indicating whether an signature update is overdue. Optional. Read-only.</summary>
        public bool? SignatureUpdateOverdue { get; set; }
        /// <summary>The signature version for the managed device. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignatureVersion { get; set; }
#nullable restore
#else
        public string SignatureVersion { get; set; }
#endif
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName { get; set; }
#nullable restore
#else
        public string TenantDisplayName { get; set; }
#endif
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsProtectionState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsProtectionState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsProtectionState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"antiMalwareVersion", n => { AntiMalwareVersion = n.GetStringValue(); } },
                {"attentionRequired", n => { AttentionRequired = n.GetBoolValue(); } },
                {"deviceDeleted", n => { DeviceDeleted = n.GetBoolValue(); } },
                {"devicePropertyRefreshDateTime", n => { DevicePropertyRefreshDateTime = n.GetDateTimeOffsetValue(); } },
                {"engineVersion", n => { EngineVersion = n.GetStringValue(); } },
                {"fullScanOverdue", n => { FullScanOverdue = n.GetBoolValue(); } },
                {"fullScanRequired", n => { FullScanRequired = n.GetBoolValue(); } },
                {"lastFullScanDateTime", n => { LastFullScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastFullScanSignatureVersion", n => { LastFullScanSignatureVersion = n.GetStringValue(); } },
                {"lastQuickScanDateTime", n => { LastQuickScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastQuickScanSignatureVersion", n => { LastQuickScanSignatureVersion = n.GetStringValue(); } },
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareProtectionEnabled", n => { MalwareProtectionEnabled = n.GetBoolValue(); } },
                {"managedDeviceHealthState", n => { ManagedDeviceHealthState = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"networkInspectionSystemEnabled", n => { NetworkInspectionSystemEnabled = n.GetBoolValue(); } },
                {"quickScanOverdue", n => { QuickScanOverdue = n.GetBoolValue(); } },
                {"realTimeProtectionEnabled", n => { RealTimeProtectionEnabled = n.GetBoolValue(); } },
                {"rebootRequired", n => { RebootRequired = n.GetBoolValue(); } },
                {"signatureUpdateOverdue", n => { SignatureUpdateOverdue = n.GetBoolValue(); } },
                {"signatureVersion", n => { SignatureVersion = n.GetStringValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteStringValue("antiMalwareVersion", AntiMalwareVersion);
            writer.WriteBoolValue("attentionRequired", AttentionRequired);
            writer.WriteBoolValue("deviceDeleted", DeviceDeleted);
            writer.WriteDateTimeOffsetValue("devicePropertyRefreshDateTime", DevicePropertyRefreshDateTime);
            writer.WriteStringValue("engineVersion", EngineVersion);
            writer.WriteBoolValue("fullScanOverdue", FullScanOverdue);
            writer.WriteBoolValue("fullScanRequired", FullScanRequired);
            writer.WriteDateTimeOffsetValue("lastFullScanDateTime", LastFullScanDateTime);
            writer.WriteStringValue("lastFullScanSignatureVersion", LastFullScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastQuickScanDateTime", LastQuickScanDateTime);
            writer.WriteStringValue("lastQuickScanSignatureVersion", LastQuickScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteBoolValue("malwareProtectionEnabled", MalwareProtectionEnabled);
            writer.WriteStringValue("managedDeviceHealthState", ManagedDeviceHealthState);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteBoolValue("networkInspectionSystemEnabled", NetworkInspectionSystemEnabled);
            writer.WriteBoolValue("quickScanOverdue", QuickScanOverdue);
            writer.WriteBoolValue("realTimeProtectionEnabled", RealTimeProtectionEnabled);
            writer.WriteBoolValue("rebootRequired", RebootRequired);
            writer.WriteBoolValue("signatureUpdateOverdue", SignatureUpdateOverdue);
            writer.WriteStringValue("signatureVersion", SignatureVersion);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
