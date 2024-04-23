// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants {
    public class ManagementTemplateCollectionTenantSummary : ApiSdk.Models.Entity, IParsable 
    {
        /// <summary>The completeStepsCount property</summary>
        public int? CompleteStepsCount { get; set; }
        /// <summary>The completeUsersCount property</summary>
        public int? CompleteUsersCount { get; set; }
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId { get; set; }
#nullable restore
#else
        public string CreatedByUserId { get; set; }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The dismissedStepsCount property</summary>
        public int? DismissedStepsCount { get; set; }
        /// <summary>The excludedUsersCount property</summary>
        public int? ExcludedUsersCount { get; set; }
        /// <summary>The excludedUsersDistinctCount property</summary>
        public int? ExcludedUsersDistinctCount { get; set; }
        /// <summary>The incompleteStepsCount property</summary>
        public int? IncompleteStepsCount { get; set; }
        /// <summary>The incompleteUsersCount property</summary>
        public int? IncompleteUsersCount { get; set; }
        /// <summary>The ineligibleStepsCount property</summary>
        public int? IneligibleStepsCount { get; set; }
        /// <summary>The isComplete property</summary>
        public bool? IsComplete { get; set; }
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId { get; set; }
#nullable restore
#else
        public string LastActionByUserId { get; set; }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The managementTemplateCollectionDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateCollectionDisplayName { get; set; }
#nullable restore
#else
        public string ManagementTemplateCollectionDisplayName { get; set; }
#endif
        /// <summary>The managementTemplateCollectionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateCollectionId { get; set; }
#nullable restore
#else
        public string ManagementTemplateCollectionId { get; set; }
#endif
        /// <summary>The regressedStepsCount property</summary>
        public int? RegressedStepsCount { get; set; }
        /// <summary>The regressedUsersCount property</summary>
        public int? RegressedUsersCount { get; set; }
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The unlicensedUsersCount property</summary>
        public int? UnlicensedUsersCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ManagementTemplateCollectionTenantSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementTemplateCollectionTenantSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateCollectionTenantSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"completeStepsCount", n => { CompleteStepsCount = n.GetIntValue(); } },
                {"completeUsersCount", n => { CompleteUsersCount = n.GetIntValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dismissedStepsCount", n => { DismissedStepsCount = n.GetIntValue(); } },
                {"excludedUsersCount", n => { ExcludedUsersCount = n.GetIntValue(); } },
                {"excludedUsersDistinctCount", n => { ExcludedUsersDistinctCount = n.GetIntValue(); } },
                {"incompleteStepsCount", n => { IncompleteStepsCount = n.GetIntValue(); } },
                {"incompleteUsersCount", n => { IncompleteUsersCount = n.GetIntValue(); } },
                {"ineligibleStepsCount", n => { IneligibleStepsCount = n.GetIntValue(); } },
                {"isComplete", n => { IsComplete = n.GetBoolValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplateCollectionDisplayName", n => { ManagementTemplateCollectionDisplayName = n.GetStringValue(); } },
                {"managementTemplateCollectionId", n => { ManagementTemplateCollectionId = n.GetStringValue(); } },
                {"regressedStepsCount", n => { RegressedStepsCount = n.GetIntValue(); } },
                {"regressedUsersCount", n => { RegressedUsersCount = n.GetIntValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"unlicensedUsersCount", n => { UnlicensedUsersCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("completeStepsCount", CompleteStepsCount);
            writer.WriteIntValue("completeUsersCount", CompleteUsersCount);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("dismissedStepsCount", DismissedStepsCount);
            writer.WriteIntValue("excludedUsersCount", ExcludedUsersCount);
            writer.WriteIntValue("excludedUsersDistinctCount", ExcludedUsersDistinctCount);
            writer.WriteIntValue("incompleteStepsCount", IncompleteStepsCount);
            writer.WriteIntValue("incompleteUsersCount", IncompleteUsersCount);
            writer.WriteIntValue("ineligibleStepsCount", IneligibleStepsCount);
            writer.WriteBoolValue("isComplete", IsComplete);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("managementTemplateCollectionDisplayName", ManagementTemplateCollectionDisplayName);
            writer.WriteStringValue("managementTemplateCollectionId", ManagementTemplateCollectionId);
            writer.WriteIntValue("regressedStepsCount", RegressedStepsCount);
            writer.WriteIntValue("regressedUsersCount", RegressedUsersCount);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteIntValue("unlicensedUsersCount", UnlicensedUsersCount);
        }
    }
}
