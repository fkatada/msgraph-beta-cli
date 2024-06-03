// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants
{
    #pragma warning disable CS1591
    public class ManagementTemplateStep : ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The acceptedVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagementTemplateStepVersion? AcceptedVersion { get; set; }
#nullable restore
#else
        public ManagementTemplateStepVersion AcceptedVersion { get; set; }
#endif
        /// <summary>The category property</summary>
        public ManagementCategory? Category { get; set; }
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
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The informationLinks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.ActionUrl>? InformationLinks { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.ActionUrl> InformationLinks { get; set; }
#endif
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
        /// <summary>The managementTemplate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ManagedTenants.ManagementTemplate? ManagementTemplate { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ManagedTenants.ManagementTemplate ManagementTemplate { get; set; }
#endif
        /// <summary>The portalLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ActionUrl? PortalLink { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ActionUrl PortalLink { get; set; }
#endif
        /// <summary>The priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The userImpact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserImpact { get; set; }
#nullable restore
#else
        public string UserImpact { get; set; }
#endif
        /// <summary>The versions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateStepVersion>? Versions { get; set; }
#nullable restore
#else
        public List<ManagementTemplateStepVersion> Versions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ManagementTemplateStep"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementTemplateStep CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStep();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "acceptedVersion", n => { AcceptedVersion = n.GetObjectValue<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue); } },
                { "category", n => { Category = n.GetEnumValue<ManagementCategory>(); } },
                { "createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "informationLinks", n => { InformationLinks = n.GetCollectionOfObjectValues<ApiSdk.Models.ActionUrl>(ApiSdk.Models.ActionUrl.CreateFromDiscriminatorValue)?.ToList(); } },
                { "lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                { "lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                { "managementTemplate", n => { ManagementTemplate = n.GetObjectValue<ApiSdk.Models.ManagedTenants.ManagementTemplate>(ApiSdk.Models.ManagedTenants.ManagementTemplate.CreateFromDiscriminatorValue); } },
                { "portalLink", n => { PortalLink = n.GetObjectValue<ApiSdk.Models.ActionUrl>(ApiSdk.Models.ActionUrl.CreateFromDiscriminatorValue); } },
                { "priority", n => { Priority = n.GetIntValue(); } },
                { "userImpact", n => { UserImpact = n.GetStringValue(); } },
                { "versions", n => { Versions = n.GetCollectionOfObjectValues<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<ManagementTemplateStepVersion>("acceptedVersion", AcceptedVersion);
            writer.WriteEnumValue<ManagementCategory>("category", Category);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.ActionUrl>("informationLinks", InformationLinks);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteObjectValue<ApiSdk.Models.ManagedTenants.ManagementTemplate>("managementTemplate", ManagementTemplate);
            writer.WriteObjectValue<ApiSdk.Models.ActionUrl>("portalLink", PortalLink);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("userImpact", UserImpact);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepVersion>("versions", Versions);
        }
    }
}
