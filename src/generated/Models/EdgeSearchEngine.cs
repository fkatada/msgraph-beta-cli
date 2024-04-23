// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Allows IT admins to set a predefined default search engine for MDM-Controlled devices.
    /// </summary>
    public class EdgeSearchEngine : EdgeSearchEngineBase, IParsable 
    {
        /// <summary>Allows IT admind to set a predefined default search engine for MDM-Controlled devices</summary>
        public ApiSdk.Models.EdgeSearchEngineType? EdgeSearchEngineType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="EdgeSearchEngine"/> and sets the default values.
        /// </summary>
        public EdgeSearchEngine() : base()
        {
            OdataType = "#microsoft.graph.edgeSearchEngine";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EdgeSearchEngine"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdgeSearchEngine CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdgeSearchEngine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"edgeSearchEngineType", n => { EdgeSearchEngineType = n.GetEnumValue<EdgeSearchEngineType>(); } },
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
            writer.WriteEnumValue<EdgeSearchEngineType>("edgeSearchEngineType", EdgeSearchEngineType);
        }
    }
}
