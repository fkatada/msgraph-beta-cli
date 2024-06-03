// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Represents a custom attribute script for macOS.
    /// </summary>
    public class DeviceCustomAttributeShellScript : Entity, IParsable
    {
        /// <summary>The list of group assignments for the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementScriptAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<DeviceManagementScriptAssignment> Assignments { get; set; }
#endif
        /// <summary>The date and time the device management script was created. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>The name of the custom attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomAttributeName { get; set; }
#nullable restore
#else
        public string CustomAttributeName { get; set; }
#endif
        /// <summary>Represents the expected type for a macOS custom attribute script value.</summary>
        public DeviceCustomAttributeValueType? CustomAttributeType { get; set; }
        /// <summary>Optional description for the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>List of run states for this script across all devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementScriptDeviceState>? DeviceRunStates { get; set; }
#nullable restore
#else
        public List<DeviceManagementScriptDeviceState> DeviceRunStates { get; set; }
#endif
        /// <summary>Name of the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Script file name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The list of group assignments for the device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementScriptGroupAssignment>? GroupAssignments { get; set; }
#nullable restore
#else
        public List<DeviceManagementScriptGroupAssignment> GroupAssignments { get; set; }
#endif
        /// <summary>The date and time the device management script was last modified. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>List of Scope Tag IDs for this PowerShellScript instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>Indicates the type of execution context the app runs in.</summary>
        public RunAsAccountType? RunAsAccount { get; set; }
        /// <summary>Run summary for device management script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementScriptRunSummary? RunSummary { get; set; }
#nullable restore
#else
        public DeviceManagementScriptRunSummary RunSummary { get; set; }
#endif
        /// <summary>The script content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ScriptContent { get; set; }
#nullable restore
#else
        public byte[] ScriptContent { get; set; }
#endif
        /// <summary>List of run states for this script across all users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementScriptUserState>? UserRunStates { get; set; }
#nullable restore
#else
        public List<DeviceManagementScriptUserState> UserRunStates { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceCustomAttributeShellScript"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceCustomAttributeShellScript CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceCustomAttributeShellScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceManagementScriptAssignment>(DeviceManagementScriptAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customAttributeName", n => { CustomAttributeName = n.GetStringValue(); } },
                { "customAttributeType", n => { CustomAttributeType = n.GetEnumValue<DeviceCustomAttributeValueType>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceRunStates", n => { DeviceRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptDeviceState>(DeviceManagementScriptDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "groupAssignments", n => { GroupAssignments = n.GetCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>(DeviceManagementScriptGroupAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
                { "runSummary", n => { RunSummary = n.GetObjectValue<DeviceManagementScriptRunSummary>(DeviceManagementScriptRunSummary.CreateFromDiscriminatorValue); } },
                { "scriptContent", n => { ScriptContent = n.GetByteArrayValue(); } },
                { "userRunStates", n => { UserRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptUserState>(DeviceManagementScriptUserState.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptAssignment>("assignments", Assignments);
            writer.WriteStringValue("customAttributeName", CustomAttributeName);
            writer.WriteEnumValue<DeviceCustomAttributeValueType>("customAttributeType", CustomAttributeType);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteObjectValue<DeviceManagementScriptRunSummary>("runSummary", RunSummary);
            writer.WriteByteArrayValue("scriptContent", ScriptContent);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptUserState>("userRunStates", UserRunStates);
        }
    }
}
