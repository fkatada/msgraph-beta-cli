// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    #pragma warning disable CS1591
    public class BlobEvidence : AlertEvidence, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The container which the blob belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BlobContainerEvidence? BlobContainer { get; set; }
#nullable restore
#else
        public BlobContainerEvidence BlobContainer { get; set; }
#endif
        /// <summary>The Etag associated with this blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etag { get; set; }
#nullable restore
#else
        public string Etag { get; set; }
#endif
        /// <summary>The file hashes associated with this blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FileHash>? FileHashes { get; set; }
#nullable restore
#else
        public List<FileHash> FileHashes { get; set; }
#endif
        /// <summary>The name of the blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The full URL representation of the blob.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BlobEvidence"/> and sets the default values.
        /// </summary>
        public BlobEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.blobEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BlobEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BlobEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BlobEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"blobContainer", n => { BlobContainer = n.GetObjectValue<BlobContainerEvidence>(BlobContainerEvidence.CreateFromDiscriminatorValue); } },
                {"etag", n => { Etag = n.GetStringValue(); } },
                {"fileHashes", n => { FileHashes = n.GetCollectionOfObjectValues<FileHash>(FileHash.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteObjectValue<BlobContainerEvidence>("blobContainer", BlobContainer);
            writer.WriteStringValue("etag", Etag);
            writer.WriteCollectionOfObjectValues<FileHash>("fileHashes", FileHashes);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("url", Url);
        }
    }
}
