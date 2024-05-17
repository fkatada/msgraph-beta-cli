// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Communications.Presences.Item.SetStatusMessage {
    #pragma warning disable CS1591
    public class SetStatusMessagePostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The statusMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PresenceStatusMessage? StatusMessage { get; set; }
#nullable restore
#else
        public PresenceStatusMessage StatusMessage { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SetStatusMessagePostRequestBody"/> and sets the default values.
        /// </summary>
        public SetStatusMessagePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SetStatusMessagePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SetStatusMessagePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetStatusMessagePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"statusMessage", n => { StatusMessage = n.GetObjectValue<PresenceStatusMessage>(PresenceStatusMessage.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PresenceStatusMessage>("statusMessage", StatusMessage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
