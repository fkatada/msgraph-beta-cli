// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    #pragma warning disable CS1591
    public class MailboxEvidence : AlertEvidence, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The name associated with the mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The primary email address of the mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryAddress { get; set; }
#nullable restore
#else
        public string PrimaryAddress { get; set; }
#endif
        /// <summary>The user account of the mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.UserAccount? UserAccount { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.UserAccount UserAccount { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MailboxEvidence"/> and sets the default values.
        /// </summary>
        public MailboxEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.mailboxEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MailboxEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MailboxEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailboxEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"primaryAddress", n => { PrimaryAddress = n.GetStringValue(); } },
                {"userAccount", n => { UserAccount = n.GetObjectValue<ApiSdk.Models.Security.UserAccount>(ApiSdk.Models.Security.UserAccount.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("primaryAddress", PrimaryAddress);
            writer.WriteObjectValue<ApiSdk.Models.Security.UserAccount>("userAccount", UserAccount);
        }
    }
}
