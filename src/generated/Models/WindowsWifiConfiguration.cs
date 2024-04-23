// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Device Configuration.
    /// </summary>
    public class WindowsWifiConfiguration : DeviceConfiguration, IParsable 
    {
        /// <summary>Specify whether the wifi connection should connect automatically when in range.</summary>
        public bool? ConnectAutomatically { get; set; }
        /// <summary>Specify whether the wifi connection should connect to more preferred networks when already connected to this one.  Requires ConnectAutomatically to be true.</summary>
        public bool? ConnectToPreferredNetwork { get; set; }
        /// <summary>Specify whether the wifi connection should connect automatically even when the SSID is not broadcasting.</summary>
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
        /// <summary>Specify whether to force FIPS compliance.</summary>
        public bool? ForceFIPSCompliance { get; set; }
        /// <summary>Specify the metered connection limit type for the wifi connection. Possible values are: unrestricted, fixed, variable.</summary>
        public MeteredConnectionLimitType? MeteredConnectionLimit { get; set; }
        /// <summary>Specify the network configuration name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkName { get; set; }
#nullable restore
#else
        public string NetworkName { get; set; }
#endif
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreSharedKey { get; set; }
#nullable restore
#else
        public string PreSharedKey { get; set; }
#endif
        /// <summary>Specify the URL for the proxy server configuration script.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyAutomaticConfigurationUrl { get; set; }
#nullable restore
#else
        public string ProxyAutomaticConfigurationUrl { get; set; }
#endif
        /// <summary>Specify the IP address for the proxy server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyManualAddress { get; set; }
#nullable restore
#else
        public string ProxyManualAddress { get; set; }
#endif
        /// <summary>Specify the port for the proxy server.</summary>
        public int? ProxyManualPort { get; set; }
        /// <summary>Specify the proxy setting for Wi-Fi configuration. Possible values are: none, manual, automatic, unknownFutureValue.</summary>
        public WiFiProxySetting? ProxySetting { get; set; }
        /// <summary>Specify the SSID of the wifi connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ssid { get; set; }
#nullable restore
#else
        public string Ssid { get; set; }
#endif
        /// <summary>Specify the Wifi Security Type. Possible values are: open, wpaPersonal, wpaEnterprise, wep, wpa2Personal, wpa2Enterprise.</summary>
        public ApiSdk.Models.WiFiSecurityType? WifiSecurityType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WindowsWifiConfiguration"/> and sets the default values.
        /// </summary>
        public WindowsWifiConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windowsWifiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsWifiConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsWifiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.windowsWifiEnterpriseEAPConfiguration" => new WindowsWifiEnterpriseEAPConfiguration(),
                _ => new WindowsWifiConfiguration(),
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
                {"connectAutomatically", n => { ConnectAutomatically = n.GetBoolValue(); } },
                {"connectToPreferredNetwork", n => { ConnectToPreferredNetwork = n.GetBoolValue(); } },
                {"connectWhenNetworkNameIsHidden", n => { ConnectWhenNetworkNameIsHidden = n.GetBoolValue(); } },
                {"forceFIPSCompliance", n => { ForceFIPSCompliance = n.GetBoolValue(); } },
                {"meteredConnectionLimit", n => { MeteredConnectionLimit = n.GetEnumValue<MeteredConnectionLimitType>(); } },
                {"networkName", n => { NetworkName = n.GetStringValue(); } },
                {"preSharedKey", n => { PreSharedKey = n.GetStringValue(); } },
                {"proxyAutomaticConfigurationUrl", n => { ProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                {"proxyManualAddress", n => { ProxyManualAddress = n.GetStringValue(); } },
                {"proxyManualPort", n => { ProxyManualPort = n.GetIntValue(); } },
                {"proxySetting", n => { ProxySetting = n.GetEnumValue<WiFiProxySetting>(); } },
                {"ssid", n => { Ssid = n.GetStringValue(); } },
                {"wifiSecurityType", n => { WifiSecurityType = n.GetEnumValue<WiFiSecurityType>(); } },
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
            writer.WriteBoolValue("connectAutomatically", ConnectAutomatically);
            writer.WriteBoolValue("connectToPreferredNetwork", ConnectToPreferredNetwork);
            writer.WriteBoolValue("connectWhenNetworkNameIsHidden", ConnectWhenNetworkNameIsHidden);
            writer.WriteBoolValue("forceFIPSCompliance", ForceFIPSCompliance);
            writer.WriteEnumValue<MeteredConnectionLimitType>("meteredConnectionLimit", MeteredConnectionLimit);
            writer.WriteStringValue("networkName", NetworkName);
            writer.WriteStringValue("preSharedKey", PreSharedKey);
            writer.WriteStringValue("proxyAutomaticConfigurationUrl", ProxyAutomaticConfigurationUrl);
            writer.WriteStringValue("proxyManualAddress", ProxyManualAddress);
            writer.WriteIntValue("proxyManualPort", ProxyManualPort);
            writer.WriteEnumValue<WiFiProxySetting>("proxySetting", ProxySetting);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<WiFiSecurityType>("wifiSecurityType", WifiSecurityType);
        }
    }
}
