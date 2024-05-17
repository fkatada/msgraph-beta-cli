// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class EmailPayloadDetail : PayloadDetail, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Email address of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromEmail { get; set; }
#nullable restore
#else
        public string FromEmail { get; set; }
#endif
        /// <summary>Display name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromName { get; set; }
#nullable restore
#else
        public string FromName { get; set; }
#endif
        /// <summary>Indicates whether the sender isn&apos;t from the user&apos;s organization.</summary>
        public bool? IsExternalSender { get; set; }
        /// <summary>The subject of the email address sent to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EmailPayloadDetail"/> and sets the default values.
        /// </summary>
        public EmailPayloadDetail() : base()
        {
            OdataType = "#microsoft.graph.emailPayloadDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EmailPayloadDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmailPayloadDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailPayloadDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"fromEmail", n => { FromEmail = n.GetStringValue(); } },
                {"fromName", n => { FromName = n.GetStringValue(); } },
                {"isExternalSender", n => { IsExternalSender = n.GetBoolValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
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
            writer.WriteStringValue("fromEmail", FromEmail);
            writer.WriteStringValue("fromName", FromName);
            writer.WriteBoolValue("isExternalSender", IsExternalSender);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
