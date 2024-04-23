// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Always On VPN configuration for MacOS and iOS IKEv2
    /// </summary>
    public class AppleVpnAlwaysOnConfiguration : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Determine whether AirPrint service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? AirPrintExceptionAction { get; set; }
        /// <summary>Specifies whether traffic from all captive network plugins should be allowed outside the vpn</summary>
        public bool? AllowAllCaptiveNetworkPlugins { get; set; }
        /// <summary>Determines whether traffic from the Websheet app is allowed outside of the VPN</summary>
        public bool? AllowCaptiveWebSheet { get; set; }
        /// <summary>Determines whether all, some, or no non-native captive networking apps are allowed</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SpecifiedCaptiveNetworkPlugins? AllowedCaptiveNetworkPlugins { get; set; }
#nullable restore
#else
        public SpecifiedCaptiveNetworkPlugins AllowedCaptiveNetworkPlugins { get; set; }
#endif
        /// <summary>Determine whether Cellular service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? CellularExceptionAction { get; set; }
        /// <summary>Specifies how often in seconds to send a network address translation keepalive package through the VPN</summary>
        public int? NatKeepAliveIntervalInSeconds { get; set; }
        /// <summary>Enable hardware offloading of NAT keepalive signals when the device is asleep</summary>
        public bool? NatKeepAliveOffloadEnable { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The type of tunnels that will be present to the VPN client for configuration</summary>
        public VpnTunnelConfigurationType? TunnelConfiguration { get; set; }
        /// <summary>Allow the user to toggle the VPN configuration using the UI</summary>
        public bool? UserToggleEnabled { get; set; }
        /// <summary>Determine whether voicemail service will be exempt from the always-on VPN connection. Possible values are: forceTrafficViaVPN, allowTrafficOutside, dropTraffic.</summary>
        public VpnServiceExceptionAction? VoicemailExceptionAction { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AppleVpnAlwaysOnConfiguration"/> and sets the default values.
        /// </summary>
        public AppleVpnAlwaysOnConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AppleVpnAlwaysOnConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppleVpnAlwaysOnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppleVpnAlwaysOnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"airPrintExceptionAction", n => { AirPrintExceptionAction = n.GetEnumValue<VpnServiceExceptionAction>(); } },
                {"allowAllCaptiveNetworkPlugins", n => { AllowAllCaptiveNetworkPlugins = n.GetBoolValue(); } },
                {"allowCaptiveWebSheet", n => { AllowCaptiveWebSheet = n.GetBoolValue(); } },
                {"allowedCaptiveNetworkPlugins", n => { AllowedCaptiveNetworkPlugins = n.GetObjectValue<SpecifiedCaptiveNetworkPlugins>(SpecifiedCaptiveNetworkPlugins.CreateFromDiscriminatorValue); } },
                {"cellularExceptionAction", n => { CellularExceptionAction = n.GetEnumValue<VpnServiceExceptionAction>(); } },
                {"natKeepAliveIntervalInSeconds", n => { NatKeepAliveIntervalInSeconds = n.GetIntValue(); } },
                {"natKeepAliveOffloadEnable", n => { NatKeepAliveOffloadEnable = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tunnelConfiguration", n => { TunnelConfiguration = n.GetEnumValue<VpnTunnelConfigurationType>(); } },
                {"userToggleEnabled", n => { UserToggleEnabled = n.GetBoolValue(); } },
                {"voicemailExceptionAction", n => { VoicemailExceptionAction = n.GetEnumValue<VpnServiceExceptionAction>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<VpnServiceExceptionAction>("airPrintExceptionAction", AirPrintExceptionAction);
            writer.WriteBoolValue("allowAllCaptiveNetworkPlugins", AllowAllCaptiveNetworkPlugins);
            writer.WriteBoolValue("allowCaptiveWebSheet", AllowCaptiveWebSheet);
            writer.WriteObjectValue<SpecifiedCaptiveNetworkPlugins>("allowedCaptiveNetworkPlugins", AllowedCaptiveNetworkPlugins);
            writer.WriteEnumValue<VpnServiceExceptionAction>("cellularExceptionAction", CellularExceptionAction);
            writer.WriteIntValue("natKeepAliveIntervalInSeconds", NatKeepAliveIntervalInSeconds);
            writer.WriteBoolValue("natKeepAliveOffloadEnable", NatKeepAliveOffloadEnable);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<VpnTunnelConfigurationType>("tunnelConfiguration", TunnelConfiguration);
            writer.WriteBoolValue("userToggleEnabled", UserToggleEnabled);
            writer.WriteEnumValue<VpnServiceExceptionAction>("voicemailExceptionAction", VoicemailExceptionAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
