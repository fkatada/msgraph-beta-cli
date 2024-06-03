// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.Complex
{
    #pragma warning disable CS1591
    public class ComplexPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The iNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? INum { get; set; }
#nullable restore
#else
        public Json INum { get; set; }
#endif
        /// <summary>The realNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? RealNum { get; set; }
#nullable restore
#else
        public Json RealNum { get; set; }
#endif
        /// <summary>The suffix property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Suffix { get; set; }
#nullable restore
#else
        public Json Suffix { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ComplexPostRequestBody"/> and sets the default values.
        /// </summary>
        public ComplexPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ComplexPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ComplexPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ComplexPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "iNum", n => { INum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "realNum", n => { RealNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "suffix", n => { Suffix = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("iNum", INum);
            writer.WriteObjectValue<Json>("realNum", RealNum);
            writer.WriteObjectValue<Json>("suffix", Suffix);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
