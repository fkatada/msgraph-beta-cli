// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Search {
    public class AnswerKeyword : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of keywords used to trigger the search answer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Keywords { get; set; }
#nullable restore
#else
        public List<string> Keywords { get; set; }
#endif
        /// <summary>If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.</summary>
        public bool? MatchSimilarKeywords { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Unique keywords that guarantee the search answer is triggered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ReservedKeywords { get; set; }
#nullable restore
#else
        public List<string> ReservedKeywords { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AnswerKeyword"/> and sets the default values.
        /// </summary>
        public AnswerKeyword()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AnswerKeyword"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AnswerKeyword CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnswerKeyword();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"keywords", n => { Keywords = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"matchSimilarKeywords", n => { MatchSimilarKeywords = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reservedKeywords", n => { ReservedKeywords = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("keywords", Keywords);
            writer.WriteBoolValue("matchSimilarKeywords", MatchSimilarKeywords);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("reservedKeywords", ReservedKeywords);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
