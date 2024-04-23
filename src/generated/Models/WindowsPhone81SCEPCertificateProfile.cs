// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Windows Phone 8.1+ SCEP certificate profile
    /// </summary>
    public class WindowsPhone81SCEPCertificateProfile : WindowsPhone81CertificateProfileBase, IParsable 
    {
        /// <summary>Hash Algorithm Options.</summary>
        public HashAlgorithms? HashAlgorithm { get; set; }
        /// <summary>Key Size Options.</summary>
        public ApiSdk.Models.KeySize? KeySize { get; set; }
        /// <summary>Key Usage Options.</summary>
        public KeyUsages? KeyUsage { get; set; }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDeviceCertificateState>? ManagedDeviceCertificateStates { get; set; }
#nullable restore
#else
        public List<ManagedDeviceCertificateState> ManagedDeviceCertificateStates { get; set; }
#endif
        /// <summary>Trusted Root Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsPhone81TrustedRootCertificate? RootCertificate { get; set; }
#nullable restore
#else
        public WindowsPhone81TrustedRootCertificate RootCertificate { get; set; }
#endif
        /// <summary>SCEP Server Url(s).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScepServerUrls { get; set; }
#nullable restore
#else
        public List<string> ScepServerUrls { get; set; }
#endif
        /// <summary>Custom String that defines the AAD Attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectAlternativeNameFormatString { get; set; }
#nullable restore
#else
        public string SubjectAlternativeNameFormatString { get; set; }
#endif
        /// <summary>Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectNameFormatString { get; set; }
#nullable restore
#else
        public string SubjectNameFormatString { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WindowsPhone81SCEPCertificateProfile"/> and sets the default values.
        /// </summary>
        public WindowsPhone81SCEPCertificateProfile() : base()
        {
            OdataType = "#microsoft.graph.windowsPhone81SCEPCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsPhone81SCEPCertificateProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsPhone81SCEPCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81SCEPCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"hashAlgorithm", n => { HashAlgorithm = n.GetEnumValue<HashAlgorithms>(); } },
                {"keySize", n => { KeySize = n.GetEnumValue<KeySize>(); } },
                {"keyUsage", n => { KeyUsage = n.GetEnumValue<KeyUsages>(); } },
                {"managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"rootCertificate", n => { RootCertificate = n.GetObjectValue<WindowsPhone81TrustedRootCertificate>(WindowsPhone81TrustedRootCertificate.CreateFromDiscriminatorValue); } },
                {"scepServerUrls", n => { ScepServerUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"subjectAlternativeNameFormatString", n => { SubjectAlternativeNameFormatString = n.GetStringValue(); } },
                {"subjectNameFormatString", n => { SubjectNameFormatString = n.GetStringValue(); } },
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
            writer.WriteEnumValue<HashAlgorithms>("hashAlgorithm", HashAlgorithm);
            writer.WriteEnumValue<KeySize>("keySize", KeySize);
            writer.WriteEnumValue<KeyUsages>("keyUsage", KeyUsage);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteObjectValue<WindowsPhone81TrustedRootCertificate>("rootCertificate", RootCertificate);
            writer.WriteCollectionOfPrimitiveValues<string>("scepServerUrls", ScepServerUrls);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
