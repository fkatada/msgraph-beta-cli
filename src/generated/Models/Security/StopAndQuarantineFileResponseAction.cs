// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security
{
    #pragma warning disable CS1591
    public class StopAndQuarantineFileResponseAction : ResponseAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identifier property</summary>
        public StopAndQuarantineFileEntityIdentifier? Identifier { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="StopAndQuarantineFileResponseAction"/> and sets the default values.
        /// </summary>
        public StopAndQuarantineFileResponseAction() : base()
        {
            OdataType = "#microsoft.graph.security.stopAndQuarantineFileResponseAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="StopAndQuarantineFileResponseAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new StopAndQuarantineFileResponseAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StopAndQuarantineFileResponseAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "identifier", n => { Identifier = n.GetEnumValue<StopAndQuarantineFileEntityIdentifier>(); } },
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
            writer.WriteEnumValue<StopAndQuarantineFileEntityIdentifier>("identifier", Identifier);
        }
    }
}
