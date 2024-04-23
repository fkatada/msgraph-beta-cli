// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class JournalLine : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Account? Account { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Account Account { get; set; }
#endif
        /// <summary>The accountId property</summary>
        public Guid? AccountId { get; set; }
        /// <summary>The accountNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountNumber { get; set; }
#nullable restore
#else
        public string AccountNumber { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
        public decimal? Amount { get; set; }
        /// <summary>The comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The documentNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentNumber { get; set; }
#nullable restore
#else
        public string DocumentNumber { get; set; }
#endif
        /// <summary>The externalDocumentNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalDocumentNumber { get; set; }
#nullable restore
#else
        public string ExternalDocumentNumber { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The journalDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JournalDisplayName { get; set; }
#nullable restore
#else
        public string JournalDisplayName { get; set; }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The lineNumber property</summary>
        public int? LineNumber { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The postingDate property</summary>
        public Date? PostingDate { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="JournalLine"/> and sets the default values.
        /// </summary>
        public JournalLine()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="JournalLine"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JournalLine CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JournalLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"account", n => { Account = n.GetObjectValue<ApiSdk.Models.Account>(ApiSdk.Models.Account.CreateFromDiscriminatorValue); } },
                {"accountId", n => { AccountId = n.GetGuidValue(); } },
                {"accountNumber", n => { AccountNumber = n.GetStringValue(); } },
                {"amount", n => { Amount = n.GetDecimalValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"documentNumber", n => { DocumentNumber = n.GetStringValue(); } },
                {"externalDocumentNumber", n => { ExternalDocumentNumber = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"journalDisplayName", n => { JournalDisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lineNumber", n => { LineNumber = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"postingDate", n => { PostingDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Account>("account", Account);
            writer.WriteGuidValue("accountId", AccountId);
            writer.WriteStringValue("accountNumber", AccountNumber);
            writer.WriteDecimalValue("amount", Amount);
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("documentNumber", DocumentNumber);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("journalDisplayName", JournalDisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("lineNumber", LineNumber);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateValue("postingDate", PostingDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
