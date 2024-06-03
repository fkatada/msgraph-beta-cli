// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Graph properties for Device Firmware Configuration Interface 
    /// </summary>
    public class Windows10DeviceFirmwareConfigurationInterface : DeviceConfiguration, IParsable
    {
        /// <summary>Possible values of a property</summary>
        public Enablement? Bluetooth { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? BootFromBuiltInNetworkAdapters { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? BootFromExternalMedia { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? Cameras { get; set; }
        /// <summary>Defines the permission level granted to users to enable them change Uefi settings</summary>
        public ApiSdk.Models.ChangeUefiSettingsPermission? ChangeUefiSettingsPermission { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? FrontCamera { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? InfraredCamera { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? Microphone { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? MicrophonesAndSpeakers { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? NearFieldCommunication { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? Radios { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? RearCamera { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? SdCard { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? SimultaneousMultiThreading { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? UsbTypeAPort { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? VirtualizationOfCpuAndIO { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? WakeOnLAN { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? WakeOnPower { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? WiFi { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? WindowsPlatformBinaryTable { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? WirelessWideAreaNetwork { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Windows10DeviceFirmwareConfigurationInterface"/> and sets the default values.
        /// </summary>
        public Windows10DeviceFirmwareConfigurationInterface() : base()
        {
            OdataType = "#microsoft.graph.windows10DeviceFirmwareConfigurationInterface";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Windows10DeviceFirmwareConfigurationInterface"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10DeviceFirmwareConfigurationInterface CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10DeviceFirmwareConfigurationInterface();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bluetooth", n => { Bluetooth = n.GetEnumValue<Enablement>(); } },
                { "bootFromBuiltInNetworkAdapters", n => { BootFromBuiltInNetworkAdapters = n.GetEnumValue<Enablement>(); } },
                { "bootFromExternalMedia", n => { BootFromExternalMedia = n.GetEnumValue<Enablement>(); } },
                { "cameras", n => { Cameras = n.GetEnumValue<Enablement>(); } },
                { "changeUefiSettingsPermission", n => { ChangeUefiSettingsPermission = n.GetEnumValue<ChangeUefiSettingsPermission>(); } },
                { "frontCamera", n => { FrontCamera = n.GetEnumValue<Enablement>(); } },
                { "infraredCamera", n => { InfraredCamera = n.GetEnumValue<Enablement>(); } },
                { "microphone", n => { Microphone = n.GetEnumValue<Enablement>(); } },
                { "microphonesAndSpeakers", n => { MicrophonesAndSpeakers = n.GetEnumValue<Enablement>(); } },
                { "nearFieldCommunication", n => { NearFieldCommunication = n.GetEnumValue<Enablement>(); } },
                { "radios", n => { Radios = n.GetEnumValue<Enablement>(); } },
                { "rearCamera", n => { RearCamera = n.GetEnumValue<Enablement>(); } },
                { "sdCard", n => { SdCard = n.GetEnumValue<Enablement>(); } },
                { "simultaneousMultiThreading", n => { SimultaneousMultiThreading = n.GetEnumValue<Enablement>(); } },
                { "usbTypeAPort", n => { UsbTypeAPort = n.GetEnumValue<Enablement>(); } },
                { "virtualizationOfCpuAndIO", n => { VirtualizationOfCpuAndIO = n.GetEnumValue<Enablement>(); } },
                { "wakeOnLAN", n => { WakeOnLAN = n.GetEnumValue<Enablement>(); } },
                { "wakeOnPower", n => { WakeOnPower = n.GetEnumValue<Enablement>(); } },
                { "wiFi", n => { WiFi = n.GetEnumValue<Enablement>(); } },
                { "windowsPlatformBinaryTable", n => { WindowsPlatformBinaryTable = n.GetEnumValue<Enablement>(); } },
                { "wirelessWideAreaNetwork", n => { WirelessWideAreaNetwork = n.GetEnumValue<Enablement>(); } },
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
            writer.WriteEnumValue<Enablement>("bluetooth", Bluetooth);
            writer.WriteEnumValue<Enablement>("bootFromBuiltInNetworkAdapters", BootFromBuiltInNetworkAdapters);
            writer.WriteEnumValue<Enablement>("bootFromExternalMedia", BootFromExternalMedia);
            writer.WriteEnumValue<Enablement>("cameras", Cameras);
            writer.WriteEnumValue<ChangeUefiSettingsPermission>("changeUefiSettingsPermission", ChangeUefiSettingsPermission);
            writer.WriteEnumValue<Enablement>("frontCamera", FrontCamera);
            writer.WriteEnumValue<Enablement>("infraredCamera", InfraredCamera);
            writer.WriteEnumValue<Enablement>("microphone", Microphone);
            writer.WriteEnumValue<Enablement>("microphonesAndSpeakers", MicrophonesAndSpeakers);
            writer.WriteEnumValue<Enablement>("nearFieldCommunication", NearFieldCommunication);
            writer.WriteEnumValue<Enablement>("radios", Radios);
            writer.WriteEnumValue<Enablement>("rearCamera", RearCamera);
            writer.WriteEnumValue<Enablement>("sdCard", SdCard);
            writer.WriteEnumValue<Enablement>("simultaneousMultiThreading", SimultaneousMultiThreading);
            writer.WriteEnumValue<Enablement>("usbTypeAPort", UsbTypeAPort);
            writer.WriteEnumValue<Enablement>("virtualizationOfCpuAndIO", VirtualizationOfCpuAndIO);
            writer.WriteEnumValue<Enablement>("wakeOnLAN", WakeOnLAN);
            writer.WriteEnumValue<Enablement>("wakeOnPower", WakeOnPower);
            writer.WriteEnumValue<Enablement>("wiFi", WiFi);
            writer.WriteEnumValue<Enablement>("windowsPlatformBinaryTable", WindowsPlatformBinaryTable);
            writer.WriteEnumValue<Enablement>("wirelessWideAreaNetwork", WirelessWideAreaNetwork);
        }
    }
}
