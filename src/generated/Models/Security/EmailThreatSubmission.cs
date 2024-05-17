// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    #pragma warning disable CS1591
    public class EmailThreatSubmission : ThreatSubmission, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>If the email is phishing simulation, this field won&apos;t be null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.AttackSimulationInfo? AttackSimulationInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.AttackSimulationInfo AttackSimulationInfo { get; set; }
#endif
        /// <summary>Specifies the internet message ID of the email being submitted. This information is present in the email header.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId { get; set; }
#nullable restore
#else
        public string InternetMessageId { get; set; }
#endif
        /// <summary>The original category of the submission. The possible values are: notJunk, spam, phishing, malware and unkownFutureValue.</summary>
        public SubmissionCategory? OriginalCategory { get; set; }
        /// <summary>Specifies the date and time stamp when the email was received.</summary>
        public DateTimeOffset? ReceivedDateTime { get; set; }
        /// <summary>Specifies the email address (in smtp format) of the recipient who received the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientEmailAddress { get; set; }
#nullable restore
#else
        public string RecipientEmailAddress { get; set; }
#endif
        /// <summary>Specifies the email address of the sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sender { get; set; }
#nullable restore
#else
        public string Sender { get; set; }
#endif
        /// <summary>Specifies the IP address of the sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderIP { get; set; }
#nullable restore
#else
        public string SenderIP { get; set; }
#endif
        /// <summary>Specifies the subject of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>It&apos;s used to automatically add allows for the components such as URL, file, sender; which are deemed bad by Microsoft so that similar messages in the future can be allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.TenantAllowOrBlockListAction? TenantAllowOrBlockListAction { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.TenantAllowOrBlockListAction TenantAllowOrBlockListAction { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EmailThreatSubmission"/> and sets the default values.
        /// </summary>
        public EmailThreatSubmission() : base()
        {
            OdataType = "#microsoft.graph.security.emailThreatSubmission";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EmailThreatSubmission"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmailThreatSubmission CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.emailContentThreatSubmission" => new EmailContentThreatSubmission(),
                "#microsoft.graph.security.emailUrlThreatSubmission" => new EmailUrlThreatSubmission(),
                _ => new EmailThreatSubmission(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"attackSimulationInfo", n => { AttackSimulationInfo = n.GetObjectValue<ApiSdk.Models.Security.AttackSimulationInfo>(ApiSdk.Models.Security.AttackSimulationInfo.CreateFromDiscriminatorValue); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"originalCategory", n => { OriginalCategory = n.GetEnumValue<SubmissionCategory>(); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipientEmailAddress", n => { RecipientEmailAddress = n.GetStringValue(); } },
                {"sender", n => { Sender = n.GetStringValue(); } },
                {"senderIP", n => { SenderIP = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"tenantAllowOrBlockListAction", n => { TenantAllowOrBlockListAction = n.GetObjectValue<ApiSdk.Models.Security.TenantAllowOrBlockListAction>(ApiSdk.Models.Security.TenantAllowOrBlockListAction.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Security.AttackSimulationInfo>("attackSimulationInfo", AttackSimulationInfo);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteEnumValue<SubmissionCategory>("originalCategory", OriginalCategory);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteStringValue("recipientEmailAddress", RecipientEmailAddress);
            writer.WriteStringValue("sender", Sender);
            writer.WriteStringValue("senderIP", SenderIP);
            writer.WriteStringValue("subject", Subject);
            writer.WriteObjectValue<ApiSdk.Models.Security.TenantAllowOrBlockListAction>("tenantAllowOrBlockListAction", TenantAllowOrBlockListAction);
        }
    }
}
