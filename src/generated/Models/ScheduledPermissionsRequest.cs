// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ScheduledPermissionsRequest : Entity, IParsable 
    {
        /// <summary>The action property</summary>
        public UnifiedRoleScheduleRequestActions? Action { get; set; }
        /// <summary>Defines when the identity created the request.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The identity&apos;s justification for the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification { get; set; }
#nullable restore
#else
        public string Justification { get; set; }
#endif
        /// <summary>Additional context for the permissions request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>The requestedPermissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PermissionsDefinition? RequestedPermissions { get; set; }
#nullable restore
#else
        public PermissionsDefinition RequestedPermissions { get; set; }
#endif
        /// <summary>When to assign the requested permissions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestSchedule? ScheduleInfo { get; set; }
#nullable restore
#else
        public RequestSchedule ScheduleInfo { get; set; }
#endif
        /// <summary>The statusDetail property</summary>
        public ApiSdk.Models.StatusDetail? StatusDetail { get; set; }
        /// <summary>Ticketing-related metadata that you can use to correlate to the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.TicketInfo? TicketInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.TicketInfo TicketInfo { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ScheduledPermissionsRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ScheduledPermissionsRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduledPermissionsRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"action", n => { Action = n.GetEnumValue<UnifiedRoleScheduleRequestActions>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"requestedPermissions", n => { RequestedPermissions = n.GetObjectValue<PermissionsDefinition>(PermissionsDefinition.CreateFromDiscriminatorValue); } },
                {"scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                {"statusDetail", n => { StatusDetail = n.GetEnumValue<StatusDetail>(); } },
                {"ticketInfo", n => { TicketInfo = n.GetObjectValue<ApiSdk.Models.TicketInfo>(ApiSdk.Models.TicketInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<UnifiedRoleScheduleRequestActions>("action", Action);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("justification", Justification);
            writer.WriteStringValue("notes", Notes);
            writer.WriteObjectValue<PermissionsDefinition>("requestedPermissions", RequestedPermissions);
            writer.WriteObjectValue<RequestSchedule>("scheduleInfo", ScheduleInfo);
            writer.WriteEnumValue<StatusDetail>("statusDetail", StatusDetail);
            writer.WriteObjectValue<ApiSdk.Models.TicketInfo>("ticketInfo", TicketInfo);
        }
    }
}
