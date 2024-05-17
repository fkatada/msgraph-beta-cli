// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.WindowsUpdates {
    #pragma warning disable CS1591
    public class ApplicableContent : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Catalog entry for the update or content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.WindowsUpdates.CatalogEntry? CatalogEntry { get; set; }
#nullable restore
#else
        public ApiSdk.Models.WindowsUpdates.CatalogEntry CatalogEntry { get; set; }
#endif
        /// <summary>ID of the catalog entry for the applicable content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogEntryId { get; set; }
#nullable restore
#else
        public string CatalogEntryId { get; set; }
#endif
        /// <summary>Collection of devices and recommendations for applicable catalog content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApplicableContentDeviceMatch>? MatchedDevices { get; set; }
#nullable restore
#else
        public List<ApplicableContentDeviceMatch> MatchedDevices { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ApplicableContent"/> and sets the default values.
        /// </summary>
        public ApplicableContent()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ApplicableContent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplicableContent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicableContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"catalogEntry", n => { CatalogEntry = n.GetObjectValue<ApiSdk.Models.WindowsUpdates.CatalogEntry>(ApiSdk.Models.WindowsUpdates.CatalogEntry.CreateFromDiscriminatorValue); } },
                {"catalogEntryId", n => { CatalogEntryId = n.GetStringValue(); } },
                {"matchedDevices", n => { MatchedDevices = n.GetCollectionOfObjectValues<ApplicableContentDeviceMatch>(ApplicableContentDeviceMatch.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.WindowsUpdates.CatalogEntry>("catalogEntry", CatalogEntry);
            writer.WriteStringValue("catalogEntryId", CatalogEntryId);
            writer.WriteCollectionOfObjectValues<ApplicableContentDeviceMatch>("matchedDevices", MatchedDevices);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
