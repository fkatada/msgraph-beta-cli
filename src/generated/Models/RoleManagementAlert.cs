// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class RoleManagementAlert : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The various configurations of an alert for Microsoft Entra roles. The configurations are predefined and can&apos;t be created or deleted, but some of the configurations can be modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementAlertConfiguration>? AlertConfigurations { get; set; }
#nullable restore
#else
        public List<UnifiedRoleManagementAlertConfiguration> AlertConfigurations { get; set; }
#endif
        /// <summary>Defines an alert, its impact, and measures to mitigate or prevent it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementAlertDefinition>? AlertDefinitions { get; set; }
#nullable restore
#else
        public List<UnifiedRoleManagementAlertDefinition> AlertDefinitions { get; set; }
#endif
        /// <summary>Represents the alert entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementAlert>? Alerts { get; set; }
#nullable restore
#else
        public List<UnifiedRoleManagementAlert> Alerts { get; set; }
#endif
        /// <summary>Represents operations on resources that take a long time to complete and can run in the background until completion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LongRunningOperation>? Operations { get; set; }
#nullable restore
#else
        public List<LongRunningOperation> Operations { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RoleManagementAlert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RoleManagementAlert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleManagementAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alertConfigurations", n => { AlertConfigurations = n.GetCollectionOfObjectValues<UnifiedRoleManagementAlertConfiguration>(UnifiedRoleManagementAlertConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                { "alertDefinitions", n => { AlertDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleManagementAlertDefinition>(UnifiedRoleManagementAlertDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                { "alerts", n => { Alerts = n.GetCollectionOfObjectValues<UnifiedRoleManagementAlert>(UnifiedRoleManagementAlert.CreateFromDiscriminatorValue)?.ToList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<LongRunningOperation>(LongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementAlertConfiguration>("alertConfigurations", AlertConfigurations);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementAlertDefinition>("alertDefinitions", AlertDefinitions);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementAlert>("alerts", Alerts);
            writer.WriteCollectionOfObjectValues<LongRunningOperation>("operations", Operations);
        }
    }
}
