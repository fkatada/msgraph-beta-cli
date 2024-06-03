// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.TeamTemplateDefinition.Item.TeamDefinition.Schedule.TimeCards.ClockIn
{
    #pragma warning disable CS1591
    public class ClockInPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The atApprovedLocation property</summary>
        public bool? AtApprovedLocation { get; set; }
        /// <summary>The notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Notes { get; set; }
#nullable restore
#else
        public ItemBody Notes { get; set; }
#endif
        /// <summary>The onBehalfOfUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnBehalfOfUserId { get; set; }
#nullable restore
#else
        public string OnBehalfOfUserId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ClockInPostRequestBody"/> and sets the default values.
        /// </summary>
        public ClockInPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ClockInPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ClockInPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClockInPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "atApprovedLocation", n => { AtApprovedLocation = n.GetBoolValue(); } },
                { "notes", n => { Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                { "onBehalfOfUserId", n => { OnBehalfOfUserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("atApprovedLocation", AtApprovedLocation);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteStringValue("onBehalfOfUserId", OnBehalfOfUserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
