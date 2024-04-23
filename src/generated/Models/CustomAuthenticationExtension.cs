// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class CustomAuthenticationExtension : CustomCalloutExtension, IParsable 
    {
        /// <summary>
        /// Instantiates a new <see cref="CustomAuthenticationExtension"/> and sets the default values.
        /// </summary>
        public CustomAuthenticationExtension() : base()
        {
            OdataType = "#microsoft.graph.customAuthenticationExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CustomAuthenticationExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomAuthenticationExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.onAttributeCollectionStartCustomExtension" => new OnAttributeCollectionStartCustomExtension(),
                "#microsoft.graph.onAttributeCollectionSubmitCustomExtension" => new OnAttributeCollectionSubmitCustomExtension(),
                "#microsoft.graph.onTokenIssuanceStartCustomExtension" => new OnTokenIssuanceStartCustomExtension(),
                _ => new CustomAuthenticationExtension(),
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
        }
    }
}
