// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants {
    public class ManagementTemplateStepTenantSummary : ApiSdk.Models.Entity, IParsable 
    {
        /// <summary>The assignedTenantsCount property</summary>
        public int? AssignedTenantsCount { get; set; }
        /// <summary>The compliantTenantsCount property</summary>
        public int? CompliantTenantsCount { get; set; }
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
        /// <summary>The dismissedTenantsCount property</summary>
        public int? DismissedTenantsCount { get; set; }
        /// <summary>The ineligibleTenantsCount property</summary>
        public int? IneligibleTenantsCount { get; set; }
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
        /// <summary>The managementTemplateDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateDisplayName { get; set; }
#nullable restore
#else
        public string ManagementTemplateDisplayName { get; set; }
#endif
        /// <summary>The managementTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateId { get; set; }
#nullable restore
#else
        public string ManagementTemplateId { get; set; }
#endif
        /// <summary>The managementTemplateStepDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateStepDisplayName { get; set; }
#nullable restore
#else
        public string ManagementTemplateStepDisplayName { get; set; }
#endif
        /// <summary>The managementTemplateStepId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementTemplateStepId { get; set; }
#nullable restore
#else
        public string ManagementTemplateStepId { get; set; }
#endif
        /// <summary>The notCompliantTenantsCount property</summary>
        public int? NotCompliantTenantsCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ManagementTemplateStepTenantSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementTemplateStepTenantSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStepTenantSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"assignedTenantsCount", n => { AssignedTenantsCount = n.GetIntValue(); } },
                {"compliantTenantsCount", n => { CompliantTenantsCount = n.GetIntValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dismissedTenantsCount", n => { DismissedTenantsCount = n.GetIntValue(); } },
                {"ineligibleTenantsCount", n => { IneligibleTenantsCount = n.GetIntValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplateCollectionDisplayName", n => { ManagementTemplateCollectionDisplayName = n.GetStringValue(); } },
                {"managementTemplateCollectionId", n => { ManagementTemplateCollectionId = n.GetStringValue(); } },
                {"managementTemplateDisplayName", n => { ManagementTemplateDisplayName = n.GetStringValue(); } },
                {"managementTemplateId", n => { ManagementTemplateId = n.GetStringValue(); } },
                {"managementTemplateStepDisplayName", n => { ManagementTemplateStepDisplayName = n.GetStringValue(); } },
                {"managementTemplateStepId", n => { ManagementTemplateStepId = n.GetStringValue(); } },
                {"notCompliantTenantsCount", n => { NotCompliantTenantsCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("assignedTenantsCount", AssignedTenantsCount);
            writer.WriteIntValue("compliantTenantsCount", CompliantTenantsCount);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("dismissedTenantsCount", DismissedTenantsCount);
            writer.WriteIntValue("ineligibleTenantsCount", IneligibleTenantsCount);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("managementTemplateCollectionDisplayName", ManagementTemplateCollectionDisplayName);
            writer.WriteStringValue("managementTemplateCollectionId", ManagementTemplateCollectionId);
            writer.WriteStringValue("managementTemplateDisplayName", ManagementTemplateDisplayName);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteStringValue("managementTemplateStepDisplayName", ManagementTemplateStepDisplayName);
            writer.WriteStringValue("managementTemplateStepId", ManagementTemplateStepId);
            writer.WriteIntValue("notCompliantTenantsCount", NotCompliantTenantsCount);
        }
    }
}
