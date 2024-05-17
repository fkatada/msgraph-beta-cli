// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class VerifiedCustomDomainCertificatesMetadata : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpiryDate { get; set; }
        /// <summary>The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? IssueDate { get; set; }
        /// <summary>The issuer name of the custom domain certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerName { get; set; }
#nullable restore
#else
        public string IssuerName { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The subject name of the custom domain certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectName { get; set; }
#nullable restore
#else
        public string SubjectName { get; set; }
#endif
        /// <summary>The thumbprint associated with the custom domain certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Thumbprint { get; set; }
#nullable restore
#else
        public string Thumbprint { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="VerifiedCustomDomainCertificatesMetadata"/> and sets the default values.
        /// </summary>
        public VerifiedCustomDomainCertificatesMetadata()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VerifiedCustomDomainCertificatesMetadata"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VerifiedCustomDomainCertificatesMetadata CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifiedCustomDomainCertificatesMetadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"expiryDate", n => { ExpiryDate = n.GetDateTimeOffsetValue(); } },
                {"issueDate", n => { IssueDate = n.GetDateTimeOffsetValue(); } },
                {"issuerName", n => { IssuerName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"subjectName", n => { SubjectName = n.GetStringValue(); } },
                {"thumbprint", n => { Thumbprint = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expiryDate", ExpiryDate);
            writer.WriteDateTimeOffsetValue("issueDate", IssueDate);
            writer.WriteStringValue("issuerName", IssuerName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteStringValue("thumbprint", Thumbprint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
