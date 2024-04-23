// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class OfficeGraphInsights : Entity, IParsable 
    {
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SharedInsight>? Shared { get; set; }
#nullable restore
#else
        public List<SharedInsight> Shared { get; set; }
#endif
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Trending>? Trending { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Trending> Trending { get; set; }
#endif
        /// <summary>Access this property from the derived type itemInsights.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UsedInsight>? Used { get; set; }
#nullable restore
#else
        public List<UsedInsight> Used { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OfficeGraphInsights"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OfficeGraphInsights CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.itemInsights" => new ItemInsights(),
                _ => new OfficeGraphInsights(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"shared", n => { Shared = n.GetCollectionOfObjectValues<SharedInsight>(SharedInsight.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trending", n => { Trending = n.GetCollectionOfObjectValues<ApiSdk.Models.Trending>(ApiSdk.Models.Trending.CreateFromDiscriminatorValue)?.ToList(); } },
                {"used", n => { Used = n.GetCollectionOfObjectValues<UsedInsight>(UsedInsight.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<SharedInsight>("shared", Shared);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Trending>("trending", Trending);
            writer.WriteCollectionOfObjectValues<UsedInsight>("used", Used);
        }
    }
}
