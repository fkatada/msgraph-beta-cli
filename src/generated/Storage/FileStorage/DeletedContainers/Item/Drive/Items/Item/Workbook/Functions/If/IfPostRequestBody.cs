// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.If
{
    #pragma warning disable CS1591
    public class IfPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The logicalTest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LogicalTest { get; set; }
#nullable restore
#else
        public Json LogicalTest { get; set; }
#endif
        /// <summary>The valueIfFalse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ValueIfFalse { get; set; }
#nullable restore
#else
        public Json ValueIfFalse { get; set; }
#endif
        /// <summary>The valueIfTrue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ValueIfTrue { get; set; }
#nullable restore
#else
        public Json ValueIfTrue { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IfPostRequestBody"/> and sets the default values.
        /// </summary>
        public IfPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IfPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IfPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IfPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "logicalTest", n => { LogicalTest = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "valueIfFalse", n => { ValueIfFalse = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "valueIfTrue", n => { ValueIfTrue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("logicalTest", LogicalTest);
            writer.WriteObjectValue<Json>("valueIfFalse", ValueIfFalse);
            writer.WriteObjectValue<Json>("valueIfTrue", ValueIfTrue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
