// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Entity representing the defintion for a given setting
    /// </summary>
    public class DeviceManagementSettingDefinition : Entity, IParsable 
    {
        /// <summary>Collection of constraints for the setting value</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConstraint>? Constraints { get; set; }
#nullable restore
#else
        public List<DeviceManagementConstraint> Constraints { get; set; }
#endif
        /// <summary>Collection of dependencies on other settings</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementSettingDependency>? Dependencies { get; set; }
#nullable restore
#else
        public List<DeviceManagementSettingDependency> Dependencies { get; set; }
#endif
        /// <summary>The setting&apos;s description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The setting&apos;s display name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Url to setting documentation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentationUrl { get; set; }
#nullable restore
#else
        public string DocumentationUrl { get; set; }
#endif
        /// <summary>subtitle of the setting header for more details about the category/section</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeaderSubtitle { get; set; }
#nullable restore
#else
        public string HeaderSubtitle { get; set; }
#endif
        /// <summary>title of the setting header represents a category/section of a setting/settings</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeaderTitle { get; set; }
#nullable restore
#else
        public string HeaderTitle { get; set; }
#endif
        /// <summary>If the setting is top level, it can be configured without the need to be wrapped in a collection or complex setting</summary>
        public bool? IsTopLevel { get; set; }
        /// <summary>Keywords associated with the setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Keywords { get; set; }
#nullable restore
#else
        public List<string> Keywords { get; set; }
#endif
        /// <summary>Placeholder text as an example of valid input</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlaceholderText { get; set; }
#nullable restore
#else
        public string PlaceholderText { get; set; }
#endif
        /// <summary>The valueType property</summary>
        public DeviceManangementIntentValueType? ValueType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementSettingDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.deviceManagementAbstractComplexSettingDefinition" => new DeviceManagementAbstractComplexSettingDefinition(),
                "#microsoft.graph.deviceManagementCollectionSettingDefinition" => new DeviceManagementCollectionSettingDefinition(),
                "#microsoft.graph.deviceManagementComplexSettingDefinition" => new DeviceManagementComplexSettingDefinition(),
                _ => new DeviceManagementSettingDefinition(),
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
                {"constraints", n => { Constraints = n.GetCollectionOfObjectValues<DeviceManagementConstraint>(DeviceManagementConstraint.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dependencies", n => { Dependencies = n.GetCollectionOfObjectValues<DeviceManagementSettingDependency>(DeviceManagementSettingDependency.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"documentationUrl", n => { DocumentationUrl = n.GetStringValue(); } },
                {"headerSubtitle", n => { HeaderSubtitle = n.GetStringValue(); } },
                {"headerTitle", n => { HeaderTitle = n.GetStringValue(); } },
                {"isTopLevel", n => { IsTopLevel = n.GetBoolValue(); } },
                {"keywords", n => { Keywords = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"placeholderText", n => { PlaceholderText = n.GetStringValue(); } },
                {"valueType", n => { ValueType = n.GetEnumValue<DeviceManangementIntentValueType>(); } },
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
            writer.WriteCollectionOfObjectValues<DeviceManagementConstraint>("constraints", Constraints);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingDependency>("dependencies", Dependencies);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("documentationUrl", DocumentationUrl);
            writer.WriteStringValue("headerSubtitle", HeaderSubtitle);
            writer.WriteStringValue("headerTitle", HeaderTitle);
            writer.WriteBoolValue("isTopLevel", IsTopLevel);
            writer.WriteCollectionOfPrimitiveValues<string>("keywords", Keywords);
            writer.WriteStringValue("placeholderText", PlaceholderText);
            writer.WriteEnumValue<DeviceManangementIntentValueType>("valueType", ValueType);
        }
    }
}
