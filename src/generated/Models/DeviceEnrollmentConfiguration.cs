// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The Base Class of Device Enrollment Configuration
    /// </summary>
    public class DeviceEnrollmentConfiguration : Entity, IParsable 
    {
        /// <summary>The list of group assignments for the device configuration profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EnrollmentConfigurationAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<EnrollmentConfigurationAssignment> Assignments { get; set; }
#endif
        /// <summary>Created date time in UTC of the device enrollment configuration</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the device enrollment configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Describes the TemplateFamily for the Template entity</summary>
        public ApiSdk.Models.DeviceEnrollmentConfigurationType? DeviceEnrollmentConfigurationType { get; set; }
        /// <summary>The display name of the device enrollment configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Last modified date time in UTC of the device enrollment configuration</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Priority is used when a user exists in multiple groups that are assigned enrollment configuration. Users are subject only to the configuration with the lowest priority value.</summary>
        public int? Priority { get; set; }
        /// <summary>Optional role scope tags for the enrollment restrictions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>The version of the device enrollment configuration</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceEnrollmentConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceEnrollmentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.deviceComanagementAuthorityConfiguration" => new DeviceComanagementAuthorityConfiguration(),
                "#microsoft.graph.deviceEnrollmentLimitConfiguration" => new DeviceEnrollmentLimitConfiguration(),
                "#microsoft.graph.deviceEnrollmentNotificationConfiguration" => new DeviceEnrollmentNotificationConfiguration(),
                "#microsoft.graph.deviceEnrollmentPlatformRestrictionConfiguration" => new DeviceEnrollmentPlatformRestrictionConfiguration(),
                "#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration" => new DeviceEnrollmentPlatformRestrictionsConfiguration(),
                "#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration" => new DeviceEnrollmentWindowsHelloForBusinessConfiguration(),
                "#microsoft.graph.windows10EnrollmentCompletionPageConfiguration" => new Windows10EnrollmentCompletionPageConfiguration(),
                _ => new DeviceEnrollmentConfiguration(),
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
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<EnrollmentConfigurationAssignment>(EnrollmentConfigurationAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceEnrollmentConfigurationType", n => { DeviceEnrollmentConfigurationType = n.GetEnumValue<DeviceEnrollmentConfigurationType>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"version", n => { Version = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<EnrollmentConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DeviceEnrollmentConfigurationType>("deviceEnrollmentConfigurationType", DeviceEnrollmentConfigurationType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteIntValue("version", Version);
        }
    }
}
