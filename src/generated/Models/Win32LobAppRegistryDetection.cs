// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Contains registry properties to detect a Win32 App
    /// </summary>
    public class Win32LobAppRegistryDetection : Win32LobAppDetection, IParsable
    {
        /// <summary>A value indicating whether this registry path is for checking 32-bit app on 64-bit system</summary>
        public bool? Check32BitOn64System { get; set; }
        /// <summary>Contains all supported registry data detection type.</summary>
        public Win32LobAppRegistryDetectionType? DetectionType { get; set; }
        /// <summary>The registry detection value</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetectionValue { get; set; }
#nullable restore
#else
        public string DetectionValue { get; set; }
#endif
        /// <summary>The registry key path to detect Win32 Line of Business (LoB) app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyPath { get; set; }
#nullable restore
#else
        public string KeyPath { get; set; }
#endif
        /// <summary>Contains properties for detection operator.</summary>
        public Win32LobAppDetectionOperator? Operator { get; set; }
        /// <summary>The registry value name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueName { get; set; }
#nullable restore
#else
        public string ValueName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Win32LobAppRegistryDetection"/> and sets the default values.
        /// </summary>
        public Win32LobAppRegistryDetection() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppRegistryDetection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Win32LobAppRegistryDetection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Win32LobAppRegistryDetection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppRegistryDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "check32BitOn64System", n => { Check32BitOn64System = n.GetBoolValue(); } },
                { "detectionType", n => { DetectionType = n.GetEnumValue<Win32LobAppRegistryDetectionType>(); } },
                { "detectionValue", n => { DetectionValue = n.GetStringValue(); } },
                { "keyPath", n => { KeyPath = n.GetStringValue(); } },
                { "operator", n => { Operator = n.GetEnumValue<Win32LobAppDetectionOperator>(); } },
                { "valueName", n => { ValueName = n.GetStringValue(); } },
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
            writer.WriteBoolValue("check32BitOn64System", Check32BitOn64System);
            writer.WriteEnumValue<Win32LobAppRegistryDetectionType>("detectionType", DetectionType);
            writer.WriteStringValue("detectionValue", DetectionValue);
            writer.WriteStringValue("keyPath", KeyPath);
            writer.WriteEnumValue<Win32LobAppDetectionOperator>("operator", Operator);
            writer.WriteStringValue("valueName", ValueName);
        }
    }
}
