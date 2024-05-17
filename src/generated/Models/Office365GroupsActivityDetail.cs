// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class Office365GroupsActivityDetail : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The storage used of the group mailbox.</summary>
        public long? ExchangeMailboxStorageUsedInBytes { get; set; }
        /// <summary>The number of items in the group mailbox.</summary>
        public long? ExchangeMailboxTotalItemCount { get; set; }
        /// <summary>The number of emails that the group mailbox received.</summary>
        public long? ExchangeReceivedEmailCount { get; set; }
        /// <summary>The group external member count.</summary>
        public long? ExternalMemberCount { get; set; }
        /// <summary>The display name of the group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupDisplayName { get; set; }
#nullable restore
#else
        public string GroupDisplayName { get; set; }
#endif
        /// <summary>The group id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId { get; set; }
#nullable restore
#else
        public string GroupId { get; set; }
#endif
        /// <summary>The group type. Possible values are: Public or Private.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupType { get; set; }
#nullable restore
#else
        public string GroupType { get; set; }
#endif
        /// <summary>Whether this user has been deleted or soft deleted.</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>The last activity date for the following scenarios:  group mailbox received email; user viewed, edited, shared, or synced files in SharePoint document library; user viewed SharePoint pages; user posted, read, or liked messages in Yammer groups.</summary>
        public Date? LastActivityDate { get; set; }
        /// <summary>The group member count.</summary>
        public long? MemberCount { get; set; }
        /// <summary>The group owner principal name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerPrincipalName { get; set; }
#nullable restore
#else
        public string OwnerPrincipalName { get; set; }
#endif
        /// <summary>The number of days the report covers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportPeriod { get; set; }
#nullable restore
#else
        public string ReportPeriod { get; set; }
#endif
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The number of active files in SharePoint Group site.</summary>
        public long? SharePointActiveFileCount { get; set; }
        /// <summary>The storage used by SharePoint Group site.</summary>
        public long? SharePointSiteStorageUsedInBytes { get; set; }
        /// <summary>The total number of files in SharePoint Group site.</summary>
        public long? SharePointTotalFileCount { get; set; }
        /// <summary>The number of channel messages in Teams team.</summary>
        public long? TeamsChannelMessagesCount { get; set; }
        /// <summary>The number of meetings organized in Teams team.</summary>
        public long? TeamsMeetingsOrganizedCount { get; set; }
        /// <summary>The number of messages liked in Yammer groups.</summary>
        public long? YammerLikedMessageCount { get; set; }
        /// <summary>The number of messages posted to Yammer groups.</summary>
        public long? YammerPostedMessageCount { get; set; }
        /// <summary>The number of messages read in Yammer groups.</summary>
        public long? YammerReadMessageCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Office365GroupsActivityDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Office365GroupsActivityDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365GroupsActivityDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"exchangeMailboxStorageUsedInBytes", n => { ExchangeMailboxStorageUsedInBytes = n.GetLongValue(); } },
                {"exchangeMailboxTotalItemCount", n => { ExchangeMailboxTotalItemCount = n.GetLongValue(); } },
                {"exchangeReceivedEmailCount", n => { ExchangeReceivedEmailCount = n.GetLongValue(); } },
                {"externalMemberCount", n => { ExternalMemberCount = n.GetLongValue(); } },
                {"groupDisplayName", n => { GroupDisplayName = n.GetStringValue(); } },
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"groupType", n => { GroupType = n.GetStringValue(); } },
                {"isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                {"lastActivityDate", n => { LastActivityDate = n.GetDateValue(); } },
                {"memberCount", n => { MemberCount = n.GetLongValue(); } },
                {"ownerPrincipalName", n => { OwnerPrincipalName = n.GetStringValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"sharePointActiveFileCount", n => { SharePointActiveFileCount = n.GetLongValue(); } },
                {"sharePointSiteStorageUsedInBytes", n => { SharePointSiteStorageUsedInBytes = n.GetLongValue(); } },
                {"sharePointTotalFileCount", n => { SharePointTotalFileCount = n.GetLongValue(); } },
                {"teamsChannelMessagesCount", n => { TeamsChannelMessagesCount = n.GetLongValue(); } },
                {"teamsMeetingsOrganizedCount", n => { TeamsMeetingsOrganizedCount = n.GetLongValue(); } },
                {"yammerLikedMessageCount", n => { YammerLikedMessageCount = n.GetLongValue(); } },
                {"yammerPostedMessageCount", n => { YammerPostedMessageCount = n.GetLongValue(); } },
                {"yammerReadMessageCount", n => { YammerReadMessageCount = n.GetLongValue(); } },
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
            writer.WriteLongValue("exchangeMailboxStorageUsedInBytes", ExchangeMailboxStorageUsedInBytes);
            writer.WriteLongValue("exchangeMailboxTotalItemCount", ExchangeMailboxTotalItemCount);
            writer.WriteLongValue("exchangeReceivedEmailCount", ExchangeReceivedEmailCount);
            writer.WriteLongValue("externalMemberCount", ExternalMemberCount);
            writer.WriteStringValue("groupDisplayName", GroupDisplayName);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("groupType", GroupType);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteDateValue("lastActivityDate", LastActivityDate);
            writer.WriteLongValue("memberCount", MemberCount);
            writer.WriteStringValue("ownerPrincipalName", OwnerPrincipalName);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("sharePointActiveFileCount", SharePointActiveFileCount);
            writer.WriteLongValue("sharePointSiteStorageUsedInBytes", SharePointSiteStorageUsedInBytes);
            writer.WriteLongValue("sharePointTotalFileCount", SharePointTotalFileCount);
            writer.WriteLongValue("teamsChannelMessagesCount", TeamsChannelMessagesCount);
            writer.WriteLongValue("teamsMeetingsOrganizedCount", TeamsMeetingsOrganizedCount);
            writer.WriteLongValue("yammerLikedMessageCount", YammerLikedMessageCount);
            writer.WriteLongValue("yammerPostedMessageCount", YammerPostedMessageCount);
            writer.WriteLongValue("yammerReadMessageCount", YammerReadMessageCount);
        }
    }
}
