// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Android For Work certificate profile base.
    /// </summary>
    public class AndroidForWorkCertificateProfileBase : DeviceConfiguration, IParsable
    {
        /// <summary>Certificate Validity Period Options.</summary>
        public ApiSdk.Models.CertificateValidityPeriodScale? CertificateValidityPeriodScale { get; set; }
        /// <summary>Value for the Certificate Validity Period.</summary>
        public int? CertificateValidityPeriodValue { get; set; }
        /// <summary>Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExtendedKeyUsage>? ExtendedKeyUsages { get; set; }
#nullable restore
#else
        public List<ExtendedKeyUsage> ExtendedKeyUsages { get; set; }
#endif
        /// <summary>Certificate renewal threshold percentage. Valid values 1 to 99</summary>
        public int? RenewalThresholdPercentage { get; set; }
        /// <summary>Trusted Root Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidForWorkTrustedRootCertificate? RootCertificate { get; set; }
#nullable restore
#else
        public AndroidForWorkTrustedRootCertificate RootCertificate { get; set; }
#endif
        /// <summary>Certificate Subject Alternative Name Type. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.</summary>
        public ApiSdk.Models.SubjectAlternativeNameType? SubjectAlternativeNameType { get; set; }
        /// <summary>Subject Name Format Options.</summary>
        public ApiSdk.Models.SubjectNameFormat? SubjectNameFormat { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AndroidForWorkCertificateProfileBase"/> and sets the default values.
        /// </summary>
        public AndroidForWorkCertificateProfileBase() : base()
        {
            OdataType = "#microsoft.graph.androidForWorkCertificateProfileBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidForWorkCertificateProfileBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidForWorkCertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidForWorkPkcsCertificateProfile" => new AndroidForWorkPkcsCertificateProfile(),
                "#microsoft.graph.androidForWorkScepCertificateProfile" => new AndroidForWorkScepCertificateProfile(),
                _ => new AndroidForWorkCertificateProfileBase(),
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
                { "certificateValidityPeriodScale", n => { CertificateValidityPeriodScale = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                { "certificateValidityPeriodValue", n => { CertificateValidityPeriodValue = n.GetIntValue(); } },
                { "extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
                { "rootCertificate", n => { RootCertificate = n.GetObjectValue<AndroidForWorkTrustedRootCertificate>(AndroidForWorkTrustedRootCertificate.CreateFromDiscriminatorValue); } },
                { "subjectAlternativeNameType", n => { SubjectAlternativeNameType = n.GetEnumValue<SubjectAlternativeNameType>(); } },
                { "subjectNameFormat", n => { SubjectNameFormat = n.GetEnumValue<SubjectNameFormat>(); } },
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
            writer.WriteEnumValue<CertificateValidityPeriodScale>("certificateValidityPeriodScale", CertificateValidityPeriodScale);
            writer.WriteIntValue("certificateValidityPeriodValue", CertificateValidityPeriodValue);
            writer.WriteCollectionOfObjectValues<ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
            writer.WriteObjectValue<AndroidForWorkTrustedRootCertificate>("rootCertificate", RootCertificate);
            writer.WriteEnumValue<SubjectAlternativeNameType>("subjectAlternativeNameType", SubjectAlternativeNameType);
            writer.WriteEnumValue<SubjectNameFormat>("subjectNameFormat", SubjectNameFormat);
        }
    }
}
