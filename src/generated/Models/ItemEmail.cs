// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class ItemEmail : ItemFacet, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The email address itself.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address { get; set; }
#nullable restore
#else
        public string Address { get; set; }
#endif
        /// <summary>The name or label a user has associated with a particular email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The type property</summary>
        public EmailType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ItemEmail"/> and sets the default values.
        /// </summary>
        public ItemEmail() : base()
        {
            OdataType = "#microsoft.graph.itemEmail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ItemEmail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemEmail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemEmail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"address", n => { Address = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<EmailType>(); } },
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
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EmailType>("type", Type);
        }
    }
}
