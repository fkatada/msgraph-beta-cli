// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ExternalConnectors {
    public class ItemIdResolver : UrlToItemResolverBase, IParsable 
    {
        /// <summary>Pattern that specifies how to form the ID of the external item that the URL represents. The named groups from the regular expression in urlPattern within the urlMatchInfo can be referenced by inserting the group name inside curly brackets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemId { get; set; }
#nullable restore
#else
        public string ItemId { get; set; }
#endif
        /// <summary>Configurations to match and resolve URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ExternalConnectors.UrlMatchInfo? UrlMatchInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ExternalConnectors.UrlMatchInfo UrlMatchInfo { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ItemIdResolver"/> and sets the default values.
        /// </summary>
        public ItemIdResolver() : base()
        {
            OdataType = "#microsoft.graph.externalConnectors.itemIdResolver";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ItemIdResolver"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemIdResolver CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemIdResolver();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"urlMatchInfo", n => { UrlMatchInfo = n.GetObjectValue<ApiSdk.Models.ExternalConnectors.UrlMatchInfo>(ApiSdk.Models.ExternalConnectors.UrlMatchInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteObjectValue<ApiSdk.Models.ExternalConnectors.UrlMatchInfo>("urlMatchInfo", UrlMatchInfo);
        }
    }
}
