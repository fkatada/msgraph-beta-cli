// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class ManagedAllDeviceCertificateState : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Certificate expiry date</summary>
        public DateTimeOffset? CertificateExpirationDateTime { get; set; }
        /// <summary>Enhanced Key Usage</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateExtendedKeyUsages { get; set; }
#nullable restore
#else
        public string CertificateExtendedKeyUsages { get; set; }
#endif
        /// <summary>Issuance date</summary>
        public DateTimeOffset? CertificateIssuanceDateTime { get; set; }
        /// <summary>Issuer</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateIssuerName { get; set; }
#nullable restore
#else
        public string CertificateIssuerName { get; set; }
#endif
        /// <summary>Key Usage</summary>
        public int? CertificateKeyUsages { get; set; }
        /// <summary>Certificate Revocation Status.</summary>
        public CertificateRevocationStatus? CertificateRevokeStatus { get; set; }
        /// <summary>The time the revoke status was last changed</summary>
        public DateTimeOffset? CertificateRevokeStatusLastChangeDateTime { get; set; }
        /// <summary>Serial number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateSerialNumber { get; set; }
#nullable restore
#else
        public string CertificateSerialNumber { get; set; }
#endif
        /// <summary>Certificate subject name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateSubjectName { get; set; }
#nullable restore
#else
        public string CertificateSubjectName { get; set; }
#endif
        /// <summary>Thumbprint</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateThumbprint { get; set; }
#nullable restore
#else
        public string CertificateThumbprint { get; set; }
#endif
        /// <summary>Device display name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceDisplayName { get; set; }
#nullable restore
#else
        public string ManagedDeviceDisplayName { get; set; }
#endif
        /// <summary>User principal name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ManagedAllDeviceCertificateState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedAllDeviceCertificateState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAllDeviceCertificateState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificateExpirationDateTime", n => { CertificateExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "certificateExtendedKeyUsages", n => { CertificateExtendedKeyUsages = n.GetStringValue(); } },
                { "certificateIssuanceDateTime", n => { CertificateIssuanceDateTime = n.GetDateTimeOffsetValue(); } },
                { "certificateIssuerName", n => { CertificateIssuerName = n.GetStringValue(); } },
                { "certificateKeyUsages", n => { CertificateKeyUsages = n.GetIntValue(); } },
                { "certificateRevokeStatus", n => { CertificateRevokeStatus = n.GetEnumValue<CertificateRevocationStatus>(); } },
                { "certificateRevokeStatusLastChangeDateTime", n => { CertificateRevokeStatusLastChangeDateTime = n.GetDateTimeOffsetValue(); } },
                { "certificateSerialNumber", n => { CertificateSerialNumber = n.GetStringValue(); } },
                { "certificateSubjectName", n => { CertificateSubjectName = n.GetStringValue(); } },
                { "certificateThumbprint", n => { CertificateThumbprint = n.GetStringValue(); } },
                { "managedDeviceDisplayName", n => { ManagedDeviceDisplayName = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("certificateExpirationDateTime", CertificateExpirationDateTime);
            writer.WriteStringValue("certificateExtendedKeyUsages", CertificateExtendedKeyUsages);
            writer.WriteDateTimeOffsetValue("certificateIssuanceDateTime", CertificateIssuanceDateTime);
            writer.WriteStringValue("certificateIssuerName", CertificateIssuerName);
            writer.WriteIntValue("certificateKeyUsages", CertificateKeyUsages);
            writer.WriteEnumValue<CertificateRevocationStatus>("certificateRevokeStatus", CertificateRevokeStatus);
            writer.WriteDateTimeOffsetValue("certificateRevokeStatusLastChangeDateTime", CertificateRevokeStatusLastChangeDateTime);
            writer.WriteStringValue("certificateSerialNumber", CertificateSerialNumber);
            writer.WriteStringValue("certificateSubjectName", CertificateSubjectName);
            writer.WriteStringValue("certificateThumbprint", CertificateThumbprint);
            writer.WriteStringValue("managedDeviceDisplayName", ManagedDeviceDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
