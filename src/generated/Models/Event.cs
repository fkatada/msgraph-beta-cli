// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Event : OutlookItem, IParsable 
    {
        /// <summary>true if the meeting organizer allows invitees to propose a new time when responding; otherwise false. Optional. Default is true.</summary>
        public bool? AllowNewTimeProposals { get; set; }
        /// <summary>The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Attachment>? Attachments { get; set; }
#nullable restore
#else
        public List<Attachment> Attachments { get; set; }
#endif
        /// <summary>The collection of attendees for the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Attendee>? Attendees { get; set; }
#nullable restore
#else
        public List<Attendee> Attendees { get; set; }
#endif
        /// <summary>The body of the message associated with the event. It can be in HTML or text format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Body { get; set; }
#nullable restore
#else
        public ItemBody Body { get; set; }
#endif
        /// <summary>The preview of the message associated with the event. It is in text format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyPreview { get; set; }
#nullable restore
#else
        public string BodyPreview { get; set; }
#endif
        /// <summary>The calendar that contains the event. Navigation property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Calendar? Calendar { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Calendar Calendar { get; set; }
#endif
        /// <summary>Contains occurrenceId property values of canceled instances in a recurring series, if the event is the series master. Instances in a recurring series that are canceled are called cancelledOccurences.Returned only on $select in a Get operation which specifies the id of a series master event (that is, the seriesMasterId property value).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CancelledOccurrences { get; set; }
#nullable restore
#else
        public List<string> CancelledOccurrences { get; set; }
#endif
        /// <summary>The date, time, and time zone that the event ends. By default, the end time is in UTC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? End { get; set; }
#nullable restore
#else
        public DateTimeTimeZone End { get; set; }
#endif
        /// <summary>The exceptionOccurrences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? ExceptionOccurrences { get; set; }
#nullable restore
#else
        public List<Event> ExceptionOccurrences { get; set; }
#endif
        /// <summary>The collection of open extensions defined for the event. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions { get; set; }
#nullable restore
#else
        public List<Extension> Extensions { get; set; }
#endif
        /// <summary>Set to true if the event has attachments.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.</summary>
        public bool? HideAttendees { get; set; }
        /// <summary>The importance of the event. Possible values are: low, normal, high.</summary>
        public ApiSdk.Models.Importance? Importance { get; set; }
        /// <summary>The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but doesn&apos;t include occurrences that have been canceled from the series. Navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? Instances { get; set; }
#nullable restore
#else
        public List<Event> Instances { get; set; }
#endif
        /// <summary>Set to true if the event lasts all day. If true, regardless of whether it&apos;s a single-day or multi-day event, start and end time must be set to midnight and be in the same time zone.</summary>
        public bool? IsAllDay { get; set; }
        /// <summary>Set to true if the event has been canceled.</summary>
        public bool? IsCancelled { get; set; }
        /// <summary>Set to true if the user has updated the meeting in Outlook but hasn&apos;t sent the updates to attendees. Set to false if all changes have been sent, or if the event is an appointment without any attendees.</summary>
        public bool? IsDraft { get; set; }
        /// <summary>True if this event has online meeting information (that is, onlineMeeting points to an onlineMeetingInfo resource), false otherwise. Default is false (onlineMeeting is null). Optional.  After you set isOnlineMeeting to true, Microsoft Graph initializes onlineMeeting. Subsequently Outlook ignores any further changes to isOnlineMeeting, and the meeting remains available online.</summary>
        public bool? IsOnlineMeeting { get; set; }
        /// <summary>Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event). This also applies if a delegate organized the event on behalf of the owner.</summary>
        public bool? IsOrganizer { get; set; }
        /// <summary>Set to true if an alert is set to remind the user of the event.</summary>
        public bool? IsReminderOn { get; set; }
        /// <summary>The location of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Location? Location { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Location Location { get; set; }
#endif
        /// <summary>The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Location>? Locations { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Location> Locations { get; set; }
#endif
        /// <summary>The collection of multi-value extended properties defined for the event. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
#endif
        /// <summary>An identifier for an occurrence in a recurring event series. Null if the event isn&apos;t part of a recurring series.The format of the property value is OID.{seriesMasterId-value}.{occurrence-start-date}. The time zone for {occurrence-start-date} is the recurrenceTimeZone property defined for the corresponding recurrenceRange.This property can identify any occurrence in a recurring series, including an occurrence that has been modified or canceled. You can use this property to perform all operations supported by occurrences in the recurring series.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OccurrenceId { get; set; }
#nullable restore
#else
        public string OccurrenceId { get; set; }
#endif
        /// <summary>Details for an attendee to join the meeting online. Default is null. Read-only. After you set the isOnlineMeeting and onlineMeetingProvider properties to enable a meeting online, Microsoft Graph initializes onlineMeeting. When set, the meeting remains available online, and you cannot change the isOnlineMeeting, onlineMeetingProvider, and onlneMeeting properties again.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnlineMeetingInfo? OnlineMeeting { get; set; }
#nullable restore
#else
        public OnlineMeetingInfo OnlineMeeting { get; set; }
#endif
        /// <summary>Represents the online meeting service provider. By default, onlineMeetingProvider is unknown. The possible values are unknown, teamsForBusiness, skypeForBusiness, and skypeForConsumer. Optional.  After you set onlineMeetingProvider, Microsoft Graph initializes onlineMeeting. Subsequently you cannot change onlineMeetingProvider again, and the meeting remains available online.</summary>
        public OnlineMeetingProviderType? OnlineMeetingProvider { get; set; }
        /// <summary>A URL for an online meeting. The property is set only when an organizer specifies in Outlook that an event is an online meeting such as Skype. Read-only.To access the URL to join an online meeting, use joinUrl which is exposed via the onlineMeeting property of the event. The onlineMeetingUrl property will be deprecated in the future.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineMeetingUrl { get; set; }
#nullable restore
#else
        public string OnlineMeetingUrl { get; set; }
#endif
        /// <summary>The organizer of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Recipient? Organizer { get; set; }
#nullable restore
#else
        public Recipient Organizer { get; set; }
#endif
        /// <summary>The end time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalEndTimeZone { get; set; }
#nullable restore
#else
        public string OriginalEndTimeZone { get; set; }
#endif
        /// <summary>Represents the start time of an event when it is initially created as an occurrence or exception in a recurring series. This property isn&apos;t returned for events that are single instances. Its date and time information is expressed in ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? OriginalStart { get; set; }
        /// <summary>The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalStartTimeZone { get; set; }
#nullable restore
#else
        public string OriginalStartTimeZone { get; set; }
#endif
        /// <summary>The recurrence pattern for the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PatternedRecurrence? Recurrence { get; set; }
#nullable restore
#else
        public PatternedRecurrence Recurrence { get; set; }
#endif
        /// <summary>The number of minutes before the event start time that the reminder alert occurs.</summary>
        public int? ReminderMinutesBeforeStart { get; set; }
        /// <summary>Default is true, which represents the organizer would like an invitee to send a response to the event.</summary>
        public bool? ResponseRequested { get; set; }
        /// <summary>Indicates the type of response sent in response to an event message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ResponseStatus? ResponseStatus { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ResponseStatus ResponseStatus { get; set; }
#endif
        /// <summary>Possible values are: normal, personal, private, confidential.</summary>
        public ApiSdk.Models.Sensitivity? Sensitivity { get; set; }
        /// <summary>The ID for the recurring series master item, if this event is part of a recurring series.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SeriesMasterId { get; set; }
#nullable restore
#else
        public string SeriesMasterId { get; set; }
#endif
        /// <summary>The status to show. Possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public FreeBusyStatus? ShowAs { get; set; }
        /// <summary>The collection of single-value extended properties defined for the event. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
#endif
        /// <summary>The start date, time, and time zone of the event. By default, the start time is in UTC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? Start { get; set; }
#nullable restore
#else
        public DateTimeTimeZone Start { get; set; }
#endif
        /// <summary>The text of the event&apos;s subject line.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>A custom identifier specified by a client app for the server to avoid redundant POST operations in case of client retries to create the same event. This is useful when low network connectivity causes the client to time out before receiving a response from the server for the client&apos;s prior create-event request. After you set transactionId when creating an event, you cannot change transactionId in a subsequent update. This property is only returned in a response payload if an app has set it. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionId { get; set; }
#nullable restore
#else
        public string TransactionId { get; set; }
#endif
        /// <summary>The event type. Possible values are: singleInstance, occurrence, exception, seriesMaster. Read-only</summary>
        public EventType? Type { get; set; }
        /// <summary>A unique identifier for calendar events. For recurring events, the value is the same for the series master and all of its occurrences including exceptions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uid { get; set; }
#nullable restore
#else
        public string Uid { get; set; }
#endif
        /// <summary>The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox. Otherwise, Outlook on the web prompts you to sign in.This URL cannot be accessed from within an iFrame.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebLink { get; set; }
#nullable restore
#else
        public string WebLink { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Event"/> and sets the default values.
        /// </summary>
        public Event() : base()
        {
            OdataType = "#microsoft.graph.event";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Event"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Event CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Event();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"allowNewTimeProposals", n => { AllowNewTimeProposals = n.GetBoolValue(); } },
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attendees", n => { Attendees = n.GetCollectionOfObjectValues<Attendee>(Attendee.CreateFromDiscriminatorValue)?.ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyPreview", n => { BodyPreview = n.GetStringValue(); } },
                {"calendar", n => { Calendar = n.GetObjectValue<ApiSdk.Models.Calendar>(ApiSdk.Models.Calendar.CreateFromDiscriminatorValue); } },
                {"cancelledOccurrences", n => { CancelledOccurrences = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"end", n => { End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"exceptionOccurrences", n => { ExceptionOccurrences = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"hideAttendees", n => { HideAttendees = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"instances", n => { Instances = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isAllDay", n => { IsAllDay = n.GetBoolValue(); } },
                {"isCancelled", n => { IsCancelled = n.GetBoolValue(); } },
                {"isDraft", n => { IsDraft = n.GetBoolValue(); } },
                {"isOnlineMeeting", n => { IsOnlineMeeting = n.GetBoolValue(); } },
                {"isOrganizer", n => { IsOrganizer = n.GetBoolValue(); } },
                {"isReminderOn", n => { IsReminderOn = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<ApiSdk.Models.Location>(ApiSdk.Models.Location.CreateFromDiscriminatorValue); } },
                {"locations", n => { Locations = n.GetCollectionOfObjectValues<ApiSdk.Models.Location>(ApiSdk.Models.Location.CreateFromDiscriminatorValue)?.ToList(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"occurrenceId", n => { OccurrenceId = n.GetStringValue(); } },
                {"onlineMeeting", n => { OnlineMeeting = n.GetObjectValue<OnlineMeetingInfo>(OnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                {"onlineMeetingProvider", n => { OnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"onlineMeetingUrl", n => { OnlineMeetingUrl = n.GetStringValue(); } },
                {"organizer", n => { Organizer = n.GetObjectValue<Recipient>(Recipient.CreateFromDiscriminatorValue); } },
                {"originalEndTimeZone", n => { OriginalEndTimeZone = n.GetStringValue(); } },
                {"originalStart", n => { OriginalStart = n.GetDateTimeOffsetValue(); } },
                {"originalStartTimeZone", n => { OriginalStartTimeZone = n.GetStringValue(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderMinutesBeforeStart", n => { ReminderMinutesBeforeStart = n.GetIntValue(); } },
                {"responseRequested", n => { ResponseRequested = n.GetBoolValue(); } },
                {"responseStatus", n => { ResponseStatus = n.GetObjectValue<ApiSdk.Models.ResponseStatus>(ApiSdk.Models.ResponseStatus.CreateFromDiscriminatorValue); } },
                {"sensitivity", n => { Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"seriesMasterId", n => { SeriesMasterId = n.GetStringValue(); } },
                {"showAs", n => { ShowAs = n.GetEnumValue<FreeBusyStatus>(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"start", n => { Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"transactionId", n => { TransactionId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<EventType>(); } },
                {"uid", n => { Uid = n.GetStringValue(); } },
                {"webLink", n => { WebLink = n.GetStringValue(); } },
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
            writer.WriteBoolValue("allowNewTimeProposals", AllowNewTimeProposals);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<Attendee>("attendees", Attendees);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("bodyPreview", BodyPreview);
            writer.WriteObjectValue<ApiSdk.Models.Calendar>("calendar", Calendar);
            writer.WriteCollectionOfPrimitiveValues<string>("cancelledOccurrences", CancelledOccurrences);
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteCollectionOfObjectValues<Event>("exceptionOccurrences", ExceptionOccurrences);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("hideAttendees", HideAttendees);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteCollectionOfObjectValues<Event>("instances", Instances);
            writer.WriteBoolValue("isAllDay", IsAllDay);
            writer.WriteBoolValue("isCancelled", IsCancelled);
            writer.WriteBoolValue("isDraft", IsDraft);
            writer.WriteBoolValue("isOnlineMeeting", IsOnlineMeeting);
            writer.WriteBoolValue("isOrganizer", IsOrganizer);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteObjectValue<ApiSdk.Models.Location>("location", Location);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Location>("locations", Locations);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("occurrenceId", OccurrenceId);
            writer.WriteObjectValue<OnlineMeetingInfo>("onlineMeeting", OnlineMeeting);
            writer.WriteEnumValue<OnlineMeetingProviderType>("onlineMeetingProvider", OnlineMeetingProvider);
            writer.WriteStringValue("onlineMeetingUrl", OnlineMeetingUrl);
            writer.WriteObjectValue<Recipient>("organizer", Organizer);
            writer.WriteStringValue("originalEndTimeZone", OriginalEndTimeZone);
            writer.WriteDateTimeOffsetValue("originalStart", OriginalStart);
            writer.WriteStringValue("originalStartTimeZone", OriginalStartTimeZone);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteIntValue("reminderMinutesBeforeStart", ReminderMinutesBeforeStart);
            writer.WriteBoolValue("responseRequested", ResponseRequested);
            writer.WriteObjectValue<ApiSdk.Models.ResponseStatus>("responseStatus", ResponseStatus);
            writer.WriteEnumValue<Sensitivity>("sensitivity", Sensitivity);
            writer.WriteStringValue("seriesMasterId", SeriesMasterId);
            writer.WriteEnumValue<FreeBusyStatus>("showAs", ShowAs);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("transactionId", TransactionId);
            writer.WriteEnumValue<EventType>("type", Type);
            writer.WriteStringValue("uid", Uid);
            writer.WriteStringValue("webLink", WebLink);
        }
    }
}
