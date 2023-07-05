using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Communications.Calls.Item.Participants.Item.StartHoldMusic {
    public class StartHoldMusicPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The clientContext property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientContext { get; set; }
#nullable restore
#else
        public string ClientContext { get; set; }
#endif
        /// <summary>The customPrompt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Prompt? CustomPrompt { get; set; }
#nullable restore
#else
        public Prompt CustomPrompt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new startHoldMusicPostRequestBody and sets the default values.
        /// </summary>
        public StartHoldMusicPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StartHoldMusicPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StartHoldMusicPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientContext", n => { ClientContext = n.GetStringValue(); } },
                {"customPrompt", n => { CustomPrompt = n.GetObjectValue<Prompt>(Prompt.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteObjectValue<Prompt>("customPrompt", CustomPrompt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
