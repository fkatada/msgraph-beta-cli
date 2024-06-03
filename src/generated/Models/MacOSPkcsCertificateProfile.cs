// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// MacOS PKCS certificate profile.
    /// </summary>
    public class MacOSPkcsCertificateProfile : MacOSCertificateProfileBase, IParsable
    {
        /// <summary>AllowAllAppsAccess setting</summary>
        public bool? AllowAllAppsAccess { get; set; }
        /// <summary>Target store certificate. Possible values are: user, machine.</summary>
        public ApiSdk.Models.CertificateStore? CertificateStore { get; set; }
        /// <summary>PKCS certificate template name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateTemplateName { get; set; }
#nullable restore
#else
        public string CertificateTemplateName { get; set; }
#endif
        /// <summary>PKCS certification authority FQDN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationAuthority { get; set; }
#nullable restore
#else
        public string CertificationAuthority { get; set; }
#endif
        /// <summary>PKCS certification authority Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationAuthorityName { get; set; }
#nullable restore
#else
        public string CertificationAuthorityName { get; set; }
#endif
        /// <summary>Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomSubjectAlternativeName>? CustomSubjectAlternativeNames { get; set; }
#nullable restore
#else
        public List<CustomSubjectAlternativeName> CustomSubjectAlternativeNames { get; set; }
#endif
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDeviceCertificateState>? ManagedDeviceCertificateStates { get; set; }
#nullable restore
#else
        public List<ManagedDeviceCertificateState> ManagedDeviceCertificateStates { get; set; }
#endif
        /// <summary>Format string that defines the subject alternative name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectAlternativeNameFormatString { get; set; }
#nullable restore
#else
        public string SubjectAlternativeNameFormatString { get; set; }
#endif
        /// <summary>Format string that defines the subject name. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectNameFormatString { get; set; }
#nullable restore
#else
        public string SubjectNameFormatString { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MacOSPkcsCertificateProfile"/> and sets the default values.
        /// </summary>
        public MacOSPkcsCertificateProfile() : base()
        {
            OdataType = "#microsoft.graph.macOSPkcsCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MacOSPkcsCertificateProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSPkcsCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSPkcsCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowAllAppsAccess", n => { AllowAllAppsAccess = n.GetBoolValue(); } },
                { "certificateStore", n => { CertificateStore = n.GetEnumValue<CertificateStore>(); } },
                { "certificateTemplateName", n => { CertificateTemplateName = n.GetStringValue(); } },
                { "certificationAuthority", n => { CertificationAuthority = n.GetStringValue(); } },
                { "certificationAuthorityName", n => { CertificationAuthorityName = n.GetStringValue(); } },
                { "customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<CustomSubjectAlternativeName>(CustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.ToList(); } },
                { "managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<ManagedDeviceCertificateState>(ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.ToList(); } },
                { "subjectAlternativeNameFormatString", n => { SubjectAlternativeNameFormatString = n.GetStringValue(); } },
                { "subjectNameFormatString", n => { SubjectNameFormatString = n.GetStringValue(); } },
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
            writer.WriteBoolValue("allowAllAppsAccess", AllowAllAppsAccess);
            writer.WriteEnumValue<CertificateStore>("certificateStore", CertificateStore);
            writer.WriteStringValue("certificateTemplateName", CertificateTemplateName);
            writer.WriteStringValue("certificationAuthority", CertificationAuthority);
            writer.WriteStringValue("certificationAuthorityName", CertificationAuthorityName);
            writer.WriteCollectionOfObjectValues<CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
