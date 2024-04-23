// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Policy status detail item contained by an autopilot event.
    /// </summary>
    public class DeviceManagementAutopilotPolicyStatusDetail : Entity, IParsable 
    {
        /// <summary>The complianceStatus property</summary>
        public DeviceManagementAutopilotPolicyComplianceStatus? ComplianceStatus { get; set; }
        /// <summary>The friendly name of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The errorode associated with the compliance or enforcement status of the policy. Error code for enforcement status takes precedence if it exists.</summary>
        public int? ErrorCode { get; set; }
        /// <summary>Timestamp of the reported policy status</summary>
        public DateTimeOffset? LastReportedDateTime { get; set; }
        /// <summary>The policyType property</summary>
        public DeviceManagementAutopilotPolicyType? PolicyType { get; set; }
        /// <summary>Indicates if this policy was tracked as part of the autopilot bootstrap enrollment sync session</summary>
        public bool? TrackedOnEnrollmentStatus { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementAutopilotPolicyStatusDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementAutopilotPolicyStatusDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementAutopilotPolicyStatusDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"complianceStatus", n => { ComplianceStatus = n.GetEnumValue<DeviceManagementAutopilotPolicyComplianceStatus>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"policyType", n => { PolicyType = n.GetEnumValue<DeviceManagementAutopilotPolicyType>(); } },
                {"trackedOnEnrollmentStatus", n => { TrackedOnEnrollmentStatus = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<DeviceManagementAutopilotPolicyComplianceStatus>("complianceStatus", ComplianceStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteEnumValue<DeviceManagementAutopilotPolicyType>("policyType", PolicyType);
            writer.WriteBoolValue("trackedOnEnrollmentStatus", TrackedOnEnrollmentStatus);
        }
    }
}
