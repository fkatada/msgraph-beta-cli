// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// iOS available update version details
    /// </summary>
    public class IosAvailableUpdateVersion : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expiration date of the update.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The posting date of the update.</summary>
        public DateTimeOffset? PostingDateTime { get; set; }
        /// <summary>The version of the update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductVersion { get; set; }
#nullable restore
#else
        public string ProductVersion { get; set; }
#endif
        /// <summary>List of supported devices for the update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedDevices { get; set; }
#nullable restore
#else
        public List<string> SupportedDevices { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IosAvailableUpdateVersion"/> and sets the default values.
        /// </summary>
        public IosAvailableUpdateVersion()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IosAvailableUpdateVersion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IosAvailableUpdateVersion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosAvailableUpdateVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"postingDateTime", n => { PostingDateTime = n.GetDateTimeOffsetValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
                {"supportedDevices", n => { SupportedDevices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("postingDateTime", PostingDateTime);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDevices", SupportedDevices);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
