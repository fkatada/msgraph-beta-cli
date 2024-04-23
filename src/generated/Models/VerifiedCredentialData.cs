// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class VerifiedCredentialData : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The authority ID for the issuer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Authority { get; set; }
#nullable restore
#else
        public string Authority { get; set; }
#endif
        /// <summary>Key-value pair of claims retrieved from the credential that the user presented, and the service verified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VerifiedCredentialClaims? Claims { get; set; }
#nullable restore
#else
        public VerifiedCredentialClaims Claims { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The list of credential types provided by the issuer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Type { get; set; }
#nullable restore
#else
        public List<string> Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="VerifiedCredentialData"/> and sets the default values.
        /// </summary>
        public VerifiedCredentialData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VerifiedCredentialData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VerifiedCredentialData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifiedCredentialData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"authority", n => { Authority = n.GetStringValue(); } },
                {"claims", n => { Claims = n.GetObjectValue<VerifiedCredentialClaims>(VerifiedCredentialClaims.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"type", n => { Type = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authority", Authority);
            writer.WriteObjectValue<VerifiedCredentialClaims>("claims", Claims);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
