// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// By providing the configurations in this profile you can instruct the iOS device to connect to desired IKEv2 VPN endpoint.
    /// </summary>
    public class IosikEv2VpnConfiguration : IosVpnConfiguration, IParsable 
    {
        /// <summary>Allows the use of child security association parameters by setting all parameters to the device&apos;s default unless explicitly specified.</summary>
        public bool? AllowDefaultChildSecurityAssociationParameters { get; set; }
        /// <summary>Allows the use of security association parameters by setting all parameters to the device&apos;s default unless explicitly specified.</summary>
        public bool? AllowDefaultSecurityAssociationParameters { get; set; }
        /// <summary>AlwaysOn Configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppleVpnAlwaysOnConfiguration? AlwaysOnConfiguration { get; set; }
#nullable restore
#else
        public AppleVpnAlwaysOnConfiguration AlwaysOnConfiguration { get; set; }
#endif
        /// <summary>Child Security Association Parameters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosVpnSecurityAssociationParameters? ChildSecurityAssociationParameters { get; set; }
#nullable restore
#else
        public IosVpnSecurityAssociationParameters ChildSecurityAssociationParameters { get; set; }
#endif
        /// <summary>The type of VPN client authentication type</summary>
        public VpnClientAuthenticationType? ClientAuthenticationType { get; set; }
        /// <summary>Determine how often to check if a peer connection is still active. . Possible values are: medium, none, low, high.</summary>
        public VpnDeadPeerDetectionRate? DeadPeerDetectionRate { get; set; }
        /// <summary>Disable MOBIKE</summary>
        public bool? DisableMobilityAndMultihoming { get; set; }
        /// <summary>Disable Redirect</summary>
        public bool? DisableRedirect { get; set; }
        /// <summary>Determines if Always on VPN is enabled</summary>
        public bool? EnableAlwaysOnConfiguration { get; set; }
        /// <summary>Enables a best-effort revocation check; server response timeouts will not cause it to fail</summary>
        public bool? EnableCertificateRevocationCheck { get; set; }
        /// <summary>Enables EAP only authentication</summary>
        public bool? EnableEAP { get; set; }
        /// <summary>Enable Perfect Forward Secrecy (PFS).</summary>
        public bool? EnablePerfectForwardSecrecy { get; set; }
        /// <summary>Enable Use Internal Subnet Attributes.</summary>
        public bool? EnableUseInternalSubnetAttributes { get; set; }
        /// <summary>The type of VPN local identifier</summary>
        public VpnLocalIdentifier? LocalIdentifier { get; set; }
        /// <summary>Maximum transmission unit. Valid values 1280 to 1400</summary>
        public int? MtuSizeInBytes { get; set; }
        /// <summary>Address of the IKEv2 server. Must be a FQDN, UserFQDN, network address, or ASN1DN</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteIdentifier { get; set; }
#nullable restore
#else
        public string RemoteIdentifier { get; set; }
#endif
        /// <summary>Security Association Parameters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosVpnSecurityAssociationParameters? SecurityAssociationParameters { get; set; }
#nullable restore
#else
        public IosVpnSecurityAssociationParameters SecurityAssociationParameters { get; set; }
#endif
        /// <summary>Common name of the IKEv2 Server Certificate used in Server Authentication</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerCertificateCommonName { get; set; }
#nullable restore
#else
        public string ServerCertificateCommonName { get; set; }
#endif
        /// <summary>Issuer Common name of the IKEv2 Server Certificate issuer used in Authentication</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerCertificateIssuerCommonName { get; set; }
#nullable restore
#else
        public string ServerCertificateIssuerCommonName { get; set; }
#endif
        /// <summary>The type of certificate the VPN server will present to the VPN client for authentication. Possible values are: rsa, ecdsa256, ecdsa384, ecdsa521.</summary>
        public VpnServerCertificateType? ServerCertificateType { get; set; }
        /// <summary>Used when Shared Secret Authentication is selected</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SharedSecret { get; set; }
#nullable restore
#else
        public string SharedSecret { get; set; }
#endif
        /// <summary>The maximum TLS version to be used with EAP-TLS authentication</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TlsMaximumVersion { get; set; }
#nullable restore
#else
        public string TlsMaximumVersion { get; set; }
#endif
        /// <summary>The minimum TLS version to be used with EAP-TLS authentication</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TlsMinimumVersion { get; set; }
#nullable restore
#else
        public string TlsMinimumVersion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IosikEv2VpnConfiguration"/> and sets the default values.
        /// </summary>
        public IosikEv2VpnConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosikEv2VpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IosikEv2VpnConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosikEv2VpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosikEv2VpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"allowDefaultChildSecurityAssociationParameters", n => { AllowDefaultChildSecurityAssociationParameters = n.GetBoolValue(); } },
                {"allowDefaultSecurityAssociationParameters", n => { AllowDefaultSecurityAssociationParameters = n.GetBoolValue(); } },
                {"alwaysOnConfiguration", n => { AlwaysOnConfiguration = n.GetObjectValue<AppleVpnAlwaysOnConfiguration>(AppleVpnAlwaysOnConfiguration.CreateFromDiscriminatorValue); } },
                {"childSecurityAssociationParameters", n => { ChildSecurityAssociationParameters = n.GetObjectValue<IosVpnSecurityAssociationParameters>(IosVpnSecurityAssociationParameters.CreateFromDiscriminatorValue); } },
                {"clientAuthenticationType", n => { ClientAuthenticationType = n.GetEnumValue<VpnClientAuthenticationType>(); } },
                {"deadPeerDetectionRate", n => { DeadPeerDetectionRate = n.GetEnumValue<VpnDeadPeerDetectionRate>(); } },
                {"disableMobilityAndMultihoming", n => { DisableMobilityAndMultihoming = n.GetBoolValue(); } },
                {"disableRedirect", n => { DisableRedirect = n.GetBoolValue(); } },
                {"enableAlwaysOnConfiguration", n => { EnableAlwaysOnConfiguration = n.GetBoolValue(); } },
                {"enableCertificateRevocationCheck", n => { EnableCertificateRevocationCheck = n.GetBoolValue(); } },
                {"enableEAP", n => { EnableEAP = n.GetBoolValue(); } },
                {"enablePerfectForwardSecrecy", n => { EnablePerfectForwardSecrecy = n.GetBoolValue(); } },
                {"enableUseInternalSubnetAttributes", n => { EnableUseInternalSubnetAttributes = n.GetBoolValue(); } },
                {"localIdentifier", n => { LocalIdentifier = n.GetEnumValue<VpnLocalIdentifier>(); } },
                {"mtuSizeInBytes", n => { MtuSizeInBytes = n.GetIntValue(); } },
                {"remoteIdentifier", n => { RemoteIdentifier = n.GetStringValue(); } },
                {"securityAssociationParameters", n => { SecurityAssociationParameters = n.GetObjectValue<IosVpnSecurityAssociationParameters>(IosVpnSecurityAssociationParameters.CreateFromDiscriminatorValue); } },
                {"serverCertificateCommonName", n => { ServerCertificateCommonName = n.GetStringValue(); } },
                {"serverCertificateIssuerCommonName", n => { ServerCertificateIssuerCommonName = n.GetStringValue(); } },
                {"serverCertificateType", n => { ServerCertificateType = n.GetEnumValue<VpnServerCertificateType>(); } },
                {"sharedSecret", n => { SharedSecret = n.GetStringValue(); } },
                {"tlsMaximumVersion", n => { TlsMaximumVersion = n.GetStringValue(); } },
                {"tlsMinimumVersion", n => { TlsMinimumVersion = n.GetStringValue(); } },
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
            writer.WriteBoolValue("allowDefaultChildSecurityAssociationParameters", AllowDefaultChildSecurityAssociationParameters);
            writer.WriteBoolValue("allowDefaultSecurityAssociationParameters", AllowDefaultSecurityAssociationParameters);
            writer.WriteObjectValue<AppleVpnAlwaysOnConfiguration>("alwaysOnConfiguration", AlwaysOnConfiguration);
            writer.WriteObjectValue<IosVpnSecurityAssociationParameters>("childSecurityAssociationParameters", ChildSecurityAssociationParameters);
            writer.WriteEnumValue<VpnClientAuthenticationType>("clientAuthenticationType", ClientAuthenticationType);
            writer.WriteEnumValue<VpnDeadPeerDetectionRate>("deadPeerDetectionRate", DeadPeerDetectionRate);
            writer.WriteBoolValue("disableMobilityAndMultihoming", DisableMobilityAndMultihoming);
            writer.WriteBoolValue("disableRedirect", DisableRedirect);
            writer.WriteBoolValue("enableAlwaysOnConfiguration", EnableAlwaysOnConfiguration);
            writer.WriteBoolValue("enableCertificateRevocationCheck", EnableCertificateRevocationCheck);
            writer.WriteBoolValue("enableEAP", EnableEAP);
            writer.WriteBoolValue("enablePerfectForwardSecrecy", EnablePerfectForwardSecrecy);
            writer.WriteBoolValue("enableUseInternalSubnetAttributes", EnableUseInternalSubnetAttributes);
            writer.WriteEnumValue<VpnLocalIdentifier>("localIdentifier", LocalIdentifier);
            writer.WriteIntValue("mtuSizeInBytes", MtuSizeInBytes);
            writer.WriteStringValue("remoteIdentifier", RemoteIdentifier);
            writer.WriteObjectValue<IosVpnSecurityAssociationParameters>("securityAssociationParameters", SecurityAssociationParameters);
            writer.WriteStringValue("serverCertificateCommonName", ServerCertificateCommonName);
            writer.WriteStringValue("serverCertificateIssuerCommonName", ServerCertificateIssuerCommonName);
            writer.WriteEnumValue<VpnServerCertificateType>("serverCertificateType", ServerCertificateType);
            writer.WriteStringValue("sharedSecret", SharedSecret);
            writer.WriteStringValue("tlsMaximumVersion", TlsMaximumVersion);
            writer.WriteStringValue("tlsMinimumVersion", TlsMinimumVersion);
        }
    }
}
