// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Setting value
    /// </summary>
    public class DeviceManagementConfigurationChoiceSettingValue : DeviceManagementConfigurationSettingValue, IParsable
    {
        /// <summary>Child settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationSettingInstance>? Children { get; set; }
#nullable restore
#else
        public List<DeviceManagementConfigurationSettingInstance> Children { get; set; }
#endif
        /// <summary>Choice setting value: an OptionDefinition ItemId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementConfigurationChoiceSettingValue"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingValue() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationChoiceSettingValue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementConfigurationChoiceSettingValue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationChoiceSettingValue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationChoiceSettingValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "children", n => { Children = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingInstance>(DeviceManagementConfigurationSettingInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "value", n => { Value = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingInstance>("children", Children);
            writer.WriteStringValue("value", Value);
        }
    }
}
