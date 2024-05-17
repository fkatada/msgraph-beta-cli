// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IndustryData {
    #pragma warning disable CS1591
    public class BasicFilter : Filter, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The attribute property</summary>
        public FilterOptions? Attribute { get; set; }
        /// <summary>The condition to filter with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? In { get; set; }
#nullable restore
#else
        public List<string> In { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BasicFilter"/> and sets the default values.
        /// </summary>
        public BasicFilter() : base()
        {
            OdataType = "#microsoft.graph.industryData.basicFilter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BasicFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BasicFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BasicFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"attribute", n => { Attribute = n.GetEnumValue<FilterOptions>(); } },
                {"in", n => { In = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteEnumValue<FilterOptions>("attribute", Attribute);
            writer.WriteCollectionOfPrimitiveValues<string>("in", In);
        }
    }
}
