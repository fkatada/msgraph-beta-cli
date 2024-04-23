// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// By providing the configurations in this profile you can instruct the Android Fully Managed device to connect to desired VPN endpoint. By specifying the authentication method and security types expected by VPN endpoint you can make the VPN connection seamless for end user.
    /// </summary>
    public class AndroidDeviceOwnerVpnConfiguration : VpnConfiguration, IParsable 
    {
        /// <summary>Whether or not to enable always-on VPN connection.</summary>
        public bool? AlwaysOn { get; set; }
        /// <summary>If always-on VPN connection is enabled, whether or not to lock network traffic when that VPN is disconnected.</summary>
        public bool? AlwaysOnLockdown { get; set; }
        /// <summary>Android VPN connection type.</summary>
        public AndroidVpnConnectionType? ConnectionType { get; set; }
        /// <summary>Custom data to define key/value pairs specific to a VPN provider. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? CustomData { get; set; }
#nullable restore
#else
        public List<KeyValue> CustomData { get; set; }
#endif
        /// <summary>Custom data to define key/value pairs specific to a VPN provider. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? CustomKeyValueData { get; set; }
#nullable restore
#else
        public List<KeyValuePair> CustomKeyValueData { get; set; }
#endif
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementDerivedCredentialSettings? DerivedCredentialSettings { get; set; }
#nullable restore
#else
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings { get; set; }
#endif
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidDeviceOwnerCertificateProfileBase? IdentityCertificate { get; set; }
#nullable restore
#else
        public AndroidDeviceOwnerCertificateProfileBase IdentityCertificate { get; set; }
#endif
        /// <summary>Microsoft Tunnel site ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftTunnelSiteId { get; set; }
#nullable restore
#else
        public string MicrosoftTunnelSiteId { get; set; }
#endif
        /// <summary>List of hosts to exclude using the proxy on connections for. These hosts can use wildcards such as .example.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProxyExclusionList { get; set; }
#nullable restore
#else
        public List<string> ProxyExclusionList { get; set; }
#endif
        /// <summary>Proxy server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VpnProxyServer? ProxyServer { get; set; }
#nullable restore
#else
        public VpnProxyServer ProxyServer { get; set; }
#endif
        /// <summary>Targeted mobile apps. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppListItem>? TargetedMobileApps { get; set; }
#nullable restore
#else
        public List<AppListItem> TargetedMobileApps { get; set; }
#endif
        /// <summary>Targeted App package IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TargetedPackageIds { get; set; }
#nullable restore
#else
        public List<string> TargetedPackageIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AndroidDeviceOwnerVpnConfiguration"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerVpnConfiguration() : base()
        {
            OdataType = "#microsoft.graph.androidDeviceOwnerVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidDeviceOwnerVpnConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerVpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"alwaysOn", n => { AlwaysOn = n.GetBoolValue(); } },
                {"alwaysOnLockdown", n => { AlwaysOnLockdown = n.GetBoolValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<AndroidVpnConnectionType>(); } },
                {"customData", n => { CustomData = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customKeyValueData", n => { CustomKeyValueData = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidDeviceOwnerCertificateProfileBase>(AndroidDeviceOwnerCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelSiteId", n => { MicrosoftTunnelSiteId = n.GetStringValue(); } },
                {"proxyExclusionList", n => { ProxyExclusionList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"proxyServer", n => { ProxyServer = n.GetObjectValue<VpnProxyServer>(VpnProxyServer.CreateFromDiscriminatorValue); } },
                {"targetedMobileApps", n => { TargetedMobileApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"targetedPackageIds", n => { TargetedPackageIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteBoolValue("alwaysOn", AlwaysOn);
            writer.WriteBoolValue("alwaysOnLockdown", AlwaysOnLockdown);
            writer.WriteEnumValue<AndroidVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteCollectionOfObjectValues<KeyValue>("customData", CustomData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customKeyValueData", CustomKeyValueData);
            writer.WriteObjectValue<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteObjectValue<AndroidDeviceOwnerCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("microsoftTunnelSiteId", MicrosoftTunnelSiteId);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyExclusionList", ProxyExclusionList);
            writer.WriteObjectValue<VpnProxyServer>("proxyServer", ProxyServer);
            writer.WriteCollectionOfObjectValues<AppListItem>("targetedMobileApps", TargetedMobileApps);
            writer.WriteCollectionOfPrimitiveValues<string>("targetedPackageIds", TargetedPackageIds);
        }
    }
}
