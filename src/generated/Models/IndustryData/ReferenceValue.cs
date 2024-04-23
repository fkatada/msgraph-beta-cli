// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IndustryData {
    public class ReferenceValue : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The code of the desired referenceDefinition entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ReferenceDefinition? Value { get; set; }
#nullable restore
#else
        public ReferenceDefinition Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ReferenceValue"/> and sets the default values.
        /// </summary>
        public ReferenceValue()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ReferenceValue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReferenceValue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.industryData.identifierTypeReferenceValue" => new IdentifierTypeReferenceValue(),
                "#microsoft.graph.industryData.roleReferenceValue" => new RoleReferenceValue(),
                "#microsoft.graph.industryData.userMatchTargetReferenceValue" => new UserMatchTargetReferenceValue(),
                "#microsoft.graph.industryData.yearReferenceValue" => new YearReferenceValue(),
                _ => new ReferenceValue(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"code", n => { Code = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"value", n => { Value = n.GetObjectValue<ReferenceDefinition>(ReferenceDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ReferenceDefinition>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
