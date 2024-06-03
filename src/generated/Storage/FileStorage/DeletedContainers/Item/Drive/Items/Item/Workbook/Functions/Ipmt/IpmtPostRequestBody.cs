// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.Ipmt
{
    #pragma warning disable CS1591
    public class IpmtPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fv property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Fv { get; set; }
#nullable restore
#else
        public Json Fv { get; set; }
#endif
        /// <summary>The nper property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Nper { get; set; }
#nullable restore
#else
        public Json Nper { get; set; }
#endif
        /// <summary>The per property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Per { get; set; }
#nullable restore
#else
        public Json Per { get; set; }
#endif
        /// <summary>The pv property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Pv { get; set; }
#nullable restore
#else
        public Json Pv { get; set; }
#endif
        /// <summary>The rate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Rate { get; set; }
#nullable restore
#else
        public Json Rate { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Type { get; set; }
#nullable restore
#else
        public Json Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IpmtPostRequestBody"/> and sets the default values.
        /// </summary>
        public IpmtPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IpmtPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IpmtPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpmtPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fv", n => { Fv = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "nper", n => { Nper = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "per", n => { Per = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "pv", n => { Pv = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "rate", n => { Rate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fv", Fv);
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("per", Per);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
