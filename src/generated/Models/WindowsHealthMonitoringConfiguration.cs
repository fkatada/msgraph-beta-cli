// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Windows device health monitoring configuration
    /// </summary>
    public class WindowsHealthMonitoringConfiguration : DeviceConfiguration, IParsable
    {
        /// <summary>Possible values of a property</summary>
        public Enablement? AllowDeviceHealthMonitoring { get; set; }
        /// <summary>Specifies custom set of events collected from the device where health monitoring is enabled</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigDeviceHealthMonitoringCustomScope { get; set; }
#nullable restore
#else
        public string ConfigDeviceHealthMonitoringCustomScope { get; set; }
#endif
        /// <summary>Device health monitoring scope</summary>
        public WindowsHealthMonitoringScope? ConfigDeviceHealthMonitoringScope { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WindowsHealthMonitoringConfiguration"/> and sets the default values.
        /// </summary>
        public WindowsHealthMonitoringConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windowsHealthMonitoringConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsHealthMonitoringConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsHealthMonitoringConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsHealthMonitoringConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowDeviceHealthMonitoring", n => { AllowDeviceHealthMonitoring = n.GetEnumValue<Enablement>(); } },
                { "configDeviceHealthMonitoringCustomScope", n => { ConfigDeviceHealthMonitoringCustomScope = n.GetStringValue(); } },
                { "configDeviceHealthMonitoringScope", n => { ConfigDeviceHealthMonitoringScope = n.GetEnumValue<WindowsHealthMonitoringScope>(); } },
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
            writer.WriteEnumValue<Enablement>("allowDeviceHealthMonitoring", AllowDeviceHealthMonitoring);
            writer.WriteStringValue("configDeviceHealthMonitoringCustomScope", ConfigDeviceHealthMonitoringCustomScope);
            writer.WriteEnumValue<WindowsHealthMonitoringScope>("configDeviceHealthMonitoringScope", ConfigDeviceHealthMonitoringScope);
        }
    }
}
