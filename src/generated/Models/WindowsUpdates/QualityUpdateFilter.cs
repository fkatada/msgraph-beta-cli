// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.WindowsUpdates
{
    #pragma warning disable CS1591
    public class QualityUpdateFilter : WindowsUpdateFilter, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The cadence property</summary>
        public QualityUpdateCadence? Cadence { get; set; }
        /// <summary>The classification property</summary>
        public QualityUpdateClassification? Classification { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="QualityUpdateFilter"/> and sets the default values.
        /// </summary>
        public QualityUpdateFilter() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.qualityUpdateFilter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="QualityUpdateFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new QualityUpdateFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new QualityUpdateFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cadence", n => { Cadence = n.GetEnumValue<QualityUpdateCadence>(); } },
                { "classification", n => { Classification = n.GetEnumValue<QualityUpdateClassification>(); } },
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
            writer.WriteEnumValue<QualityUpdateCadence>("cadence", Cadence);
            writer.WriteEnumValue<QualityUpdateClassification>("classification", Classification);
        }
    }
}
