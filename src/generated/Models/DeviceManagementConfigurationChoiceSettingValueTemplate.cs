// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Choice Setting Value Template
    /// </summary>
    public class DeviceManagementConfigurationChoiceSettingValueTemplate : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Choice Setting Value Default Template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationChoiceSettingValueDefaultTemplate? DefaultValue { get; set; }
#nullable restore
#else
        public DeviceManagementConfigurationChoiceSettingValueDefaultTemplate DefaultValue { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Recommended definition override.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate? RecommendedValueDefinition { get; set; }
#nullable restore
#else
        public DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate RecommendedValueDefinition { get; set; }
#endif
        /// <summary>Required definition override.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate? RequiredValueDefinition { get; set; }
#nullable restore
#else
        public DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate RequiredValueDefinition { get; set; }
#endif
        /// <summary>Setting Value Template Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingValueTemplateId { get; set; }
#nullable restore
#else
        public string SettingValueTemplateId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementConfigurationChoiceSettingValueTemplate"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingValueTemplate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementConfigurationChoiceSettingValueTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementConfigurationChoiceSettingValueTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationChoiceSettingValueTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"defaultValue", n => { DefaultValue = n.GetObjectValue<DeviceManagementConfigurationChoiceSettingValueDefaultTemplate>(DeviceManagementConfigurationChoiceSettingValueDefaultTemplate.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recommendedValueDefinition", n => { RecommendedValueDefinition = n.GetObjectValue<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>(DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate.CreateFromDiscriminatorValue); } },
                {"requiredValueDefinition", n => { RequiredValueDefinition = n.GetObjectValue<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>(DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate.CreateFromDiscriminatorValue); } },
                {"settingValueTemplateId", n => { SettingValueTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceManagementConfigurationChoiceSettingValueDefaultTemplate>("defaultValue", DefaultValue);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>("recommendedValueDefinition", RecommendedValueDefinition);
            writer.WriteObjectValue<DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate>("requiredValueDefinition", RequiredValueDefinition);
            writer.WriteStringValue("settingValueTemplateId", SettingValueTemplateId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
