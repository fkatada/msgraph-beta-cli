// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class UnifiedRoleManagementAlertConfiguration : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The definition of the alert that contains its description, impact, and measures to mitigate or prevent it. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleManagementAlertDefinition? AlertDefinition { get; set; }
#nullable restore
#else
        public UnifiedRoleManagementAlertDefinition AlertDefinition { get; set; }
#endif
        /// <summary>The identifier of an alert definition. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertDefinitionId { get; set; }
#nullable restore
#else
        public string AlertDefinitionId { get; set; }
#endif
        /// <summary>true if the alert is enabled. Setting it to false disables PIM scanning the tenant to identify instances that trigger the alert.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The identifier of the scope to which the alert is related. Only / is supported to represent the tenant scope. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeId { get; set; }
#nullable restore
#else
        public string ScopeId { get; set; }
#endif
        /// <summary>The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Microsoft Entra roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeType { get; set; }
#nullable restore
#else
        public string ScopeType { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UnifiedRoleManagementAlertConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementAlertConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.invalidLicenseAlertConfiguration" => new InvalidLicenseAlertConfiguration(),
                "#microsoft.graph.noMfaOnRoleActivationAlertConfiguration" => new NoMfaOnRoleActivationAlertConfiguration(),
                "#microsoft.graph.redundantAssignmentAlertConfiguration" => new RedundantAssignmentAlertConfiguration(),
                "#microsoft.graph.rolesAssignedOutsidePrivilegedIdentityManagementAlertConfiguration" => new RolesAssignedOutsidePrivilegedIdentityManagementAlertConfiguration(),
                "#microsoft.graph.sequentialActivationRenewalsAlertConfiguration" => new SequentialActivationRenewalsAlertConfiguration(),
                "#microsoft.graph.staleSignInAlertConfiguration" => new StaleSignInAlertConfiguration(),
                "#microsoft.graph.tooManyGlobalAdminsAssignedToTenantAlertConfiguration" => new TooManyGlobalAdminsAssignedToTenantAlertConfiguration(),
                _ => new UnifiedRoleManagementAlertConfiguration(),
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
                { "alertDefinition", n => { AlertDefinition = n.GetObjectValue<UnifiedRoleManagementAlertDefinition>(UnifiedRoleManagementAlertDefinition.CreateFromDiscriminatorValue); } },
                { "alertDefinitionId", n => { AlertDefinitionId = n.GetStringValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "scopeId", n => { ScopeId = n.GetStringValue(); } },
                { "scopeType", n => { ScopeType = n.GetStringValue(); } },
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
            writer.WriteObjectValue<UnifiedRoleManagementAlertDefinition>("alertDefinition", AlertDefinition);
            writer.WriteStringValue("alertDefinitionId", AlertDefinitionId);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}
