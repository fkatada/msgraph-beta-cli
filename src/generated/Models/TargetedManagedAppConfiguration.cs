// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Configuration used to deliver a set of custom settings as-is to all users in the targeted security group
    /// </summary>
    public class TargetedManagedAppConfiguration : ManagedAppConfiguration, IParsable 
    {
        /// <summary>Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps</summary>
        public TargetedManagedAppGroupType? AppGroupType { get; set; }
        /// <summary>List of apps to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedMobileApp>? Apps { get; set; }
#nullable restore
#else
        public List<ManagedMobileApp> Apps { get; set; }
#endif
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TargetedManagedAppPolicyAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<TargetedManagedAppPolicyAssignment> Assignments { get; set; }
#endif
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedAppPolicyDeploymentSummary? DeploymentSummary { get; set; }
#nullable restore
#else
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
#endif
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>Management levels for apps</summary>
        public AppManagementLevel? TargetedAppManagementLevels { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="TargetedManagedAppConfiguration"/> and sets the default values.
        /// </summary>
        public TargetedManagedAppConfiguration() : base()
        {
            OdataType = "#microsoft.graph.targetedManagedAppConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TargetedManagedAppConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TargetedManagedAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TargetedManagedAppConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"appGroupType", n => { AppGroupType = n.GetEnumValue<TargetedManagedAppGroupType>(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>(TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"targetedAppManagementLevels", n => { TargetedAppManagementLevels = n.GetEnumValue<AppManagementLevel>(); } },
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
            writer.WriteEnumValue<TargetedManagedAppGroupType>("appGroupType", AppGroupType);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteEnumValue<AppManagementLevel>("targetedAppManagementLevels", TargetedAppManagementLevels);
        }
    }
}
