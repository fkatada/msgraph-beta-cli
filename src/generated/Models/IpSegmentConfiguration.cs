// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class IpSegmentConfiguration : SegmentConfiguration, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The applicationSegments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpApplicationSegment>? ApplicationSegments { get; set; }
#nullable restore
#else
        public List<IpApplicationSegment> ApplicationSegments { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IpSegmentConfiguration"/> and sets the default values.
        /// </summary>
        public IpSegmentConfiguration() : base()
        {
            OdataType = "#microsoft.graph.ipSegmentConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IpSegmentConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IpSegmentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpSegmentConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"applicationSegments", n => { ApplicationSegments = n.GetCollectionOfObjectValues<IpApplicationSegment>(IpApplicationSegment.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<IpApplicationSegment>("applicationSegments", ApplicationSegments);
        }
    }
}
