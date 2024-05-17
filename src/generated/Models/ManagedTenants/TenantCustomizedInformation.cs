// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants {
    #pragma warning disable CS1591
    public class TenantCustomizedInformation : ApiSdk.Models.Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Describes the relationship between the Managed Services Provider and the managed tenant; for example, Managed, Co-managed, Licensing. The maximum length is 250 characters. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessRelationship { get; set; }
#nullable restore
#else
        public string BusinessRelationship { get; set; }
#endif
        /// <summary>Contains the compliance requirements for the customer tenant; for example, HIPPA, NIST, CMMC. The maximum length is 250 characters per compliance requirement. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ComplianceRequirements { get; set; }
#nullable restore
#else
        public List<string> ComplianceRequirements { get; set; }
#endif
        /// <summary>The collection of contacts for the managed tenant. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TenantContactInformation>? Contacts { get; set; }
#nullable restore
#else
        public List<TenantContactInformation> Contacts { get; set; }
#endif
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>This is the Managed Services Plans for the customer tenant that the Managed Services Provider manages. The maximum length is 250 characters per managed service plan. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ManagedServicesPlans { get; set; }
#nullable restore
#else
        public List<string> ManagedServicesPlans { get; set; }
#endif
        /// <summary>A field for the Managed Services Provider technician to input custom text to share notes between technicians within the Managed Service Providers. The maximum length is 5000 characters. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The date on which the note field of this entity was last modified. Optional.</summary>
        public DateTimeOffset? NoteLastModifiedDateTime { get; set; }
        /// <summary>The list of Entra user IDs for users in the Managed Services Provider that manage the relationship with the managed tenant. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PartnerRelationshipManagerUserIds { get; set; }
#nullable restore
#else
        public List<string> PartnerRelationshipManagerUserIds { get; set; }
#endif
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The website for the managed tenant. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TenantCustomizedInformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantCustomizedInformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantCustomizedInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"businessRelationship", n => { BusinessRelationship = n.GetStringValue(); } },
                {"complianceRequirements", n => { ComplianceRequirements = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"contacts", n => { Contacts = n.GetCollectionOfObjectValues<TenantContactInformation>(TenantContactInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"managedServicesPlans", n => { ManagedServicesPlans = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"note", n => { Note = n.GetStringValue(); } },
                {"noteLastModifiedDateTime", n => { NoteLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"partnerRelationshipManagerUserIds", n => { PartnerRelationshipManagerUserIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"website", n => { Website = n.GetStringValue(); } },
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
            writer.WriteStringValue("businessRelationship", BusinessRelationship);
            writer.WriteCollectionOfPrimitiveValues<string>("complianceRequirements", ComplianceRequirements);
            writer.WriteCollectionOfObjectValues<TenantContactInformation>("contacts", Contacts);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("managedServicesPlans", ManagedServicesPlans);
            writer.WriteStringValue("note", Note);
            writer.WriteDateTimeOffsetValue("noteLastModifiedDateTime", NoteLastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("partnerRelationshipManagerUserIds", PartnerRelationshipManagerUserIds);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("website", Website);
        }
    }
}
