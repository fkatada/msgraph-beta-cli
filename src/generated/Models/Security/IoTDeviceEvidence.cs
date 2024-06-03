// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security
{
    #pragma warning disable CS1591
    public class IoTDeviceEvidence : AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The deviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>The deviceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>The devicePageLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DevicePageLink { get; set; }
#nullable restore
#else
        public string DevicePageLink { get; set; }
#endif
        /// <summary>The deviceSubType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceSubType { get; set; }
#nullable restore
#else
        public string DeviceSubType { get; set; }
#endif
        /// <summary>The deviceType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceType { get; set; }
#nullable restore
#else
        public string DeviceType { get; set; }
#endif
        /// <summary>The importance property</summary>
        public IoTDeviceImportanceType? Importance { get; set; }
        /// <summary>The ioTHub property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AzureResourceEvidence? IoTHub { get; set; }
#nullable restore
#else
        public AzureResourceEvidence IoTHub { get; set; }
#endif
        /// <summary>The ioTSecurityAgentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IoTSecurityAgentId { get; set; }
#nullable restore
#else
        public string IoTSecurityAgentId { get; set; }
#endif
        /// <summary>The ipAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? IpAddress { get; set; }
#nullable restore
#else
        public IpEvidence IpAddress { get; set; }
#endif
        /// <summary>The isAuthorized property</summary>
        public bool? IsAuthorized { get; set; }
        /// <summary>The isProgramming property</summary>
        public bool? IsProgramming { get; set; }
        /// <summary>The isScanner property</summary>
        public bool? IsScanner { get; set; }
        /// <summary>The macAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacAddress { get; set; }
#nullable restore
#else
        public string MacAddress { get; set; }
#endif
        /// <summary>The manufacturer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; set; }
#nullable restore
#else
        public string Manufacturer { get; set; }
#endif
        /// <summary>The model property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>The nics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NicEvidence? Nics { get; set; }
#nullable restore
#else
        public NicEvidence Nics { get; set; }
#endif
        /// <summary>The operatingSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem { get; set; }
#nullable restore
#else
        public string OperatingSystem { get; set; }
#endif
        /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Owners { get; set; }
#nullable restore
#else
        public List<string> Owners { get; set; }
#endif
        /// <summary>The protocols property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Protocols { get; set; }
#nullable restore
#else
        public List<string> Protocols { get; set; }
#endif
        /// <summary>The purdueLayer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PurdueLayer { get; set; }
#nullable restore
#else
        public string PurdueLayer { get; set; }
#endif
        /// <summary>The sensor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sensor { get; set; }
#nullable restore
#else
        public string Sensor { get; set; }
#endif
        /// <summary>The serialNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>The site property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Site { get; set; }
#nullable restore
#else
        public string Site { get; set; }
#endif
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The sourceRef property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UrlEvidence? SourceRef { get; set; }
#nullable restore
#else
        public UrlEvidence SourceRef { get; set; }
#endif
        /// <summary>The zone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zone { get; set; }
#nullable restore
#else
        public string Zone { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IoTDeviceEvidence"/> and sets the default values.
        /// </summary>
        public IoTDeviceEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.ioTDeviceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IoTDeviceEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IoTDeviceEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IoTDeviceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "devicePageLink", n => { DevicePageLink = n.GetStringValue(); } },
                { "deviceSubType", n => { DeviceSubType = n.GetStringValue(); } },
                { "deviceType", n => { DeviceType = n.GetStringValue(); } },
                { "importance", n => { Importance = n.GetEnumValue<IoTDeviceImportanceType>(); } },
                { "ioTHub", n => { IoTHub = n.GetObjectValue<AzureResourceEvidence>(AzureResourceEvidence.CreateFromDiscriminatorValue); } },
                { "ioTSecurityAgentId", n => { IoTSecurityAgentId = n.GetStringValue(); } },
                { "ipAddress", n => { IpAddress = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                { "isAuthorized", n => { IsAuthorized = n.GetBoolValue(); } },
                { "isProgramming", n => { IsProgramming = n.GetBoolValue(); } },
                { "isScanner", n => { IsScanner = n.GetBoolValue(); } },
                { "macAddress", n => { MacAddress = n.GetStringValue(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "nics", n => { Nics = n.GetObjectValue<NicEvidence>(NicEvidence.CreateFromDiscriminatorValue); } },
                { "operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "protocols", n => { Protocols = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "purdueLayer", n => { PurdueLayer = n.GetStringValue(); } },
                { "sensor", n => { Sensor = n.GetStringValue(); } },
                { "serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                { "site", n => { Site = n.GetStringValue(); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "sourceRef", n => { SourceRef = n.GetObjectValue<UrlEvidence>(UrlEvidence.CreateFromDiscriminatorValue); } },
                { "zone", n => { Zone = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("devicePageLink", DevicePageLink);
            writer.WriteStringValue("deviceSubType", DeviceSubType);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteEnumValue<IoTDeviceImportanceType>("importance", Importance);
            writer.WriteObjectValue<AzureResourceEvidence>("ioTHub", IoTHub);
            writer.WriteStringValue("ioTSecurityAgentId", IoTSecurityAgentId);
            writer.WriteObjectValue<IpEvidence>("ipAddress", IpAddress);
            writer.WriteBoolValue("isAuthorized", IsAuthorized);
            writer.WriteBoolValue("isProgramming", IsProgramming);
            writer.WriteBoolValue("isScanner", IsScanner);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteObjectValue<NicEvidence>("nics", Nics);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteCollectionOfPrimitiveValues<string>("owners", Owners);
            writer.WriteCollectionOfPrimitiveValues<string>("protocols", Protocols);
            writer.WriteStringValue("purdueLayer", PurdueLayer);
            writer.WriteStringValue("sensor", Sensor);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("site", Site);
            writer.WriteStringValue("source", Source);
            writer.WriteObjectValue<UrlEvidence>("sourceRef", SourceRef);
            writer.WriteStringValue("zone", Zone);
        }
    }
}
