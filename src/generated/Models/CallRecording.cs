// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CallRecording : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The callId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId { get; set; }
#nullable restore
#else
        public string CallId { get; set; }
#endif
        /// <summary>The content of the recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content { get; set; }
#nullable restore
#else
        public byte[] Content { get; set; }
#endif
        /// <summary>The contentCorrelationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentCorrelationId { get; set; }
#nullable restore
#else
        public string ContentCorrelationId { get; set; }
#endif
        /// <summary>Date and time at which the recording was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The endDateTime property</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The unique identifier of the onlineMeeting related to this recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MeetingId { get; set; }
#nullable restore
#else
        public string MeetingId { get; set; }
#endif
        /// <summary>The identity information of the organizer of the onlineMeeting related to this recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? MeetingOrganizer { get; set; }
#nullable restore
#else
        public IdentitySet MeetingOrganizer { get; set; }
#endif
        /// <summary>The unique identifier of the organizer of the onlineMeeting related to this recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MeetingOrganizerId { get; set; }
#nullable restore
#else
        public string MeetingOrganizerId { get; set; }
#endif
        /// <summary>The URL which can be used to access the content of the recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingContentUrl { get; set; }
#nullable restore
#else
        public string RecordingContentUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CallRecording"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CallRecording CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallRecording();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callId", n => { CallId = n.GetStringValue(); } },
                { "content", n => { Content = n.GetByteArrayValue(); } },
                { "contentCorrelationId", n => { ContentCorrelationId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "meetingId", n => { MeetingId = n.GetStringValue(); } },
                { "meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                { "meetingOrganizerId", n => { MeetingOrganizerId = n.GetStringValue(); } },
                { "recordingContentUrl", n => { RecordingContentUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("callId", CallId);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("contentCorrelationId", ContentCorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("meetingId", MeetingId);
            writer.WriteObjectValue<IdentitySet>("meetingOrganizer", MeetingOrganizer);
            writer.WriteStringValue("meetingOrganizerId", MeetingOrganizerId);
            writer.WriteStringValue("recordingContentUrl", RecordingContentUrl);
        }
    }
}
