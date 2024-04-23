// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class AnalyzedEmail : ApiSdk.Models.Entity, IParsable 
    {
        /// <summary>A collection of values that contain the IDs of any alerts associated with the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AlertIds { get; set; }
#nullable restore
#else
        public List<string> AlertIds { get; set; }
#endif
        /// <summary>A collection of the attachments in the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnalyzedEmailAttachment>? Attachments { get; set; }
#nullable restore
#else
        public List<AnalyzedEmailAttachment> Attachments { get; set; }
#endif
        /// <summary>The number of attachments in the email.</summary>
        public int? AttachmentsCount { get; set; }
        /// <summary>The authentication details associated with the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnalyzedEmailAuthenticationDetail? AuthenticationDetails { get; set; }
#nullable restore
#else
        public AnalyzedEmailAuthenticationDetail AuthenticationDetails { get; set; }
#endif
        /// <summary>The bulk complaint level of the email. A higher level is more likely to be spam.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BulkComplaintLevel { get; set; }
#nullable restore
#else
        public string BulkComplaintLevel { get; set; }
#endif
        /// <summary>Provides context of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Contexts { get; set; }
#nullable restore
#else
        public List<string> Contexts { get; set; }
#endif
        /// <summary>The methods of detection used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DetectionMethods { get; set; }
#nullable restore
#else
        public List<string> DetectionMethods { get; set; }
#endif
        /// <summary>The direction of the emails. The possible values are: unknown, inbound, outbound, intraOrg, unknownFutureValue.</summary>
        public AntispamDirectionality? Directionality { get; set; }
        /// <summary>The distribution list details to which the email was sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DistributionList { get; set; }
#nullable restore
#else
        public string DistributionList { get; set; }
#endif
        /// <summary>The identifier for the group of similar emails clustered based on heuristic analysis of their content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailClusterId { get; set; }
#nullable restore
#else
        public string EmailClusterId { get; set; }
#endif
        /// <summary>The name of the Exchange transport rules (ETRs) associated with the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnalyzedEmailExchangeTransportRuleInfo>? ExchangeTransportRules { get; set; }
#nullable restore
#else
        public List<AnalyzedEmailExchangeTransportRuleInfo> ExchangeTransportRules { get; set; }
#endif
        /// <summary>A public-facing identifier for the email that is sent. The message ID is in the format specified by RFC2822.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId { get; set; }
#nullable restore
#else
        public string InternetMessageId { get; set; }
#endif
        /// <summary>The detected language of the email content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>The latest delivery details of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnalyzedEmailDeliveryDetail? LatestDelivery { get; set; }
#nullable restore
#else
        public AnalyzedEmailDeliveryDetail LatestDelivery { get; set; }
#endif
        /// <summary>Date-time when the email record was logged.</summary>
        public DateTimeOffset? LoggedDateTime { get; set; }
        /// <summary>An internal identifier for the email generated by Microsoft 365.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMessageId { get; set; }
#nullable restore
#else
        public string NetworkMessageId { get; set; }
#endif
        /// <summary>The original delivery details of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnalyzedEmailDeliveryDetail? OriginalDelivery { get; set; }
#nullable restore
#else
        public AnalyzedEmailDeliveryDetail OriginalDelivery { get; set; }
#endif
        /// <summary>An aggregated list of all overrides with source on email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OverrideSources { get; set; }
#nullable restore
#else
        public List<string> OverrideSources { get; set; }
#endif
        /// <summary>The phish confidence level associated with the email</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhishConfidenceLevel { get; set; }
#nullable restore
#else
        public string PhishConfidenceLevel { get; set; }
#endif
        /// <summary>The action policy that took effect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Policy { get; set; }
#nullable restore
#else
        public string Policy { get; set; }
#endif
        /// <summary>The action taken on the email based on the configured policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyAction { get; set; }
#nullable restore
#else
        public string PolicyAction { get; set; }
#endif
        /// <summary>Contains the email addresses of the recipients.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RecipientEmailAddresses { get; set; }
#nullable restore
#else
        public List<string> RecipientEmailAddresses { get; set; }
#endif
        /// <summary>A field that indicates where and how bounced emails are processed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReturnPath { get; set; }
#nullable restore
#else
        public string ReturnPath { get; set; }
#endif
        /// <summary>Sender details of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AnalyzedEmailSenderDetail? SenderDetail { get; set; }
#nullable restore
#else
        public AnalyzedEmailSenderDetail SenderDetail { get; set; }
#endif
        /// <summary>Size of the email in bytes.</summary>
        public int? SizeInBytes { get; set; }
        /// <summary>Spam confidence of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpamConfidenceLevel { get; set; }
#nullable restore
#else
        public string SpamConfidenceLevel { get; set; }
#endif
        /// <summary>Subject of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>Indicates the threat types. The possible values are: unknown, spam, malware, phishing, none, unknownFutureValue.</summary>
        public ApiSdk.Models.Security.ThreatType? ThreatType { get; set; }
        /// <summary>A collection of the URLs in the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnalyzedEmailUrl>? Urls { get; set; }
#nullable restore
#else
        public List<AnalyzedEmailUrl> Urls { get; set; }
#endif
        /// <summary>The number of URLs in the email.</summary>
        public int? UrlsCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AnalyzedEmail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AnalyzedEmail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnalyzedEmail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"alertIds", n => { AlertIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<AnalyzedEmailAttachment>(AnalyzedEmailAttachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attachmentsCount", n => { AttachmentsCount = n.GetIntValue(); } },
                {"authenticationDetails", n => { AuthenticationDetails = n.GetObjectValue<AnalyzedEmailAuthenticationDetail>(AnalyzedEmailAuthenticationDetail.CreateFromDiscriminatorValue); } },
                {"bulkComplaintLevel", n => { BulkComplaintLevel = n.GetStringValue(); } },
                {"contexts", n => { Contexts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"detectionMethods", n => { DetectionMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"directionality", n => { Directionality = n.GetEnumValue<AntispamDirectionality>(); } },
                {"distributionList", n => { DistributionList = n.GetStringValue(); } },
                {"emailClusterId", n => { EmailClusterId = n.GetStringValue(); } },
                {"exchangeTransportRules", n => { ExchangeTransportRules = n.GetCollectionOfObjectValues<AnalyzedEmailExchangeTransportRuleInfo>(AnalyzedEmailExchangeTransportRuleInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"latestDelivery", n => { LatestDelivery = n.GetObjectValue<AnalyzedEmailDeliveryDetail>(AnalyzedEmailDeliveryDetail.CreateFromDiscriminatorValue); } },
                {"loggedDateTime", n => { LoggedDateTime = n.GetDateTimeOffsetValue(); } },
                {"networkMessageId", n => { NetworkMessageId = n.GetStringValue(); } },
                {"originalDelivery", n => { OriginalDelivery = n.GetObjectValue<AnalyzedEmailDeliveryDetail>(AnalyzedEmailDeliveryDetail.CreateFromDiscriminatorValue); } },
                {"overrideSources", n => { OverrideSources = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"phishConfidenceLevel", n => { PhishConfidenceLevel = n.GetStringValue(); } },
                {"policy", n => { Policy = n.GetStringValue(); } },
                {"policyAction", n => { PolicyAction = n.GetStringValue(); } },
                {"recipientEmailAddresses", n => { RecipientEmailAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"returnPath", n => { ReturnPath = n.GetStringValue(); } },
                {"senderDetail", n => { SenderDetail = n.GetObjectValue<AnalyzedEmailSenderDetail>(AnalyzedEmailSenderDetail.CreateFromDiscriminatorValue); } },
                {"sizeInBytes", n => { SizeInBytes = n.GetIntValue(); } },
                {"spamConfidenceLevel", n => { SpamConfidenceLevel = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"threatType", n => { ThreatType = n.GetEnumValue<ThreatType>(); } },
                {"urls", n => { Urls = n.GetCollectionOfObjectValues<AnalyzedEmailUrl>(AnalyzedEmailUrl.CreateFromDiscriminatorValue)?.ToList(); } },
                {"urlsCount", n => { UrlsCount = n.GetIntValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("alertIds", AlertIds);
            writer.WriteCollectionOfObjectValues<AnalyzedEmailAttachment>("attachments", Attachments);
            writer.WriteIntValue("attachmentsCount", AttachmentsCount);
            writer.WriteObjectValue<AnalyzedEmailAuthenticationDetail>("authenticationDetails", AuthenticationDetails);
            writer.WriteStringValue("bulkComplaintLevel", BulkComplaintLevel);
            writer.WriteCollectionOfPrimitiveValues<string>("contexts", Contexts);
            writer.WriteCollectionOfPrimitiveValues<string>("detectionMethods", DetectionMethods);
            writer.WriteEnumValue<AntispamDirectionality>("directionality", Directionality);
            writer.WriteStringValue("distributionList", DistributionList);
            writer.WriteStringValue("emailClusterId", EmailClusterId);
            writer.WriteCollectionOfObjectValues<AnalyzedEmailExchangeTransportRuleInfo>("exchangeTransportRules", ExchangeTransportRules);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteStringValue("language", Language);
            writer.WriteObjectValue<AnalyzedEmailDeliveryDetail>("latestDelivery", LatestDelivery);
            writer.WriteDateTimeOffsetValue("loggedDateTime", LoggedDateTime);
            writer.WriteStringValue("networkMessageId", NetworkMessageId);
            writer.WriteObjectValue<AnalyzedEmailDeliveryDetail>("originalDelivery", OriginalDelivery);
            writer.WriteCollectionOfPrimitiveValues<string>("overrideSources", OverrideSources);
            writer.WriteStringValue("phishConfidenceLevel", PhishConfidenceLevel);
            writer.WriteStringValue("policy", Policy);
            writer.WriteStringValue("policyAction", PolicyAction);
            writer.WriteCollectionOfPrimitiveValues<string>("recipientEmailAddresses", RecipientEmailAddresses);
            writer.WriteStringValue("returnPath", ReturnPath);
            writer.WriteObjectValue<AnalyzedEmailSenderDetail>("senderDetail", SenderDetail);
            writer.WriteIntValue("sizeInBytes", SizeInBytes);
            writer.WriteStringValue("spamConfidenceLevel", SpamConfidenceLevel);
            writer.WriteStringValue("subject", Subject);
            writer.WriteEnumValue<ThreatType>("threatType", ThreatType);
            writer.WriteCollectionOfObjectValues<AnalyzedEmailUrl>("urls", Urls);
            writer.WriteIntValue("urlsCount", UrlsCount);
        }
    }
}
