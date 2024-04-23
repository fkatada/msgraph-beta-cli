// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ContentInfo : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The format property</summary>
        public ContentFormat? Format { get; set; }
        /// <summary>Identifier used for Azure Information Protection Analytics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier { get; set; }
#nullable restore
#else
        public string Identifier { get; set; }
#endif
        /// <summary>Existing Microsoft Purview Information Protection metadata is passed as key/value pairs, where the key is the MSIPLabelGUID_PropName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? Metadata { get; set; }
#nullable restore
#else
        public List<KeyValuePair> Metadata { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The state property</summary>
        public ContentState? State { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ContentInfo"/> and sets the default values.
        /// </summary>
        public ContentInfo()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ContentInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ContentInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"format", n => { Format = n.GetEnumValue<ContentFormat>(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<ContentState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ContentFormat>("format", Format);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("metadata", Metadata);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ContentState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
