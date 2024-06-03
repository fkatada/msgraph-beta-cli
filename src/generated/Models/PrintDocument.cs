// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class PrintDocument : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The configuration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrinterDocumentConfiguration? Configuration { get; set; }
#nullable restore
#else
        public PrinterDocumentConfiguration Configuration { get; set; }
#endif
        /// <summary>The document&apos;s content (MIME) type. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>The document&apos;s name. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The downloadedDateTime property</summary>
        public DateTimeOffset? DownloadedDateTime { get; set; }
        /// <summary>The document&apos;s size in bytes. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>The uploadedDateTime property</summary>
        public DateTimeOffset? UploadedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrintDocument"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrintDocument CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintDocument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configuration", n => { Configuration = n.GetObjectValue<PrinterDocumentConfiguration>(PrinterDocumentConfiguration.CreateFromDiscriminatorValue); } },
                { "contentType", n => { ContentType = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "downloadedDateTime", n => { DownloadedDateTime = n.GetDateTimeOffsetValue(); } },
                { "size", n => { Size = n.GetLongValue(); } },
                { "uploadedDateTime", n => { UploadedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<PrinterDocumentConfiguration>("configuration", Configuration);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("downloadedDateTime", DownloadedDateTime);
            writer.WriteLongValue("size", Size);
            writer.WriteDateTimeOffsetValue("uploadedDateTime", UploadedDateTime);
        }
    }
}
