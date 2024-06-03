// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.TrustFramework.KeySets.Item.GenerateKey
{
    #pragma warning disable CS1591
    public class GenerateKeyPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The exp property</summary>
        public long? Exp { get; set; }
        /// <summary>The kty property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kty { get; set; }
#nullable restore
#else
        public string Kty { get; set; }
#endif
        /// <summary>The nbf property</summary>
        public long? Nbf { get; set; }
        /// <summary>The use property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Use { get; set; }
#nullable restore
#else
        public string Use { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GenerateKeyPostRequestBody"/> and sets the default values.
        /// </summary>
        public GenerateKeyPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GenerateKeyPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GenerateKeyPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GenerateKeyPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "exp", n => { Exp = n.GetLongValue(); } },
                { "kty", n => { Kty = n.GetStringValue(); } },
                { "nbf", n => { Nbf = n.GetLongValue(); } },
                { "use", n => { Use = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("exp", Exp);
            writer.WriteStringValue("kty", Kty);
            writer.WriteLongValue("nbf", Nbf);
            writer.WriteStringValue("use", Use);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
