// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class MeetingParticipants : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information of the meeting attendees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingParticipantInfo>? Attendees { get; set; }
#nullable restore
#else
        public List<MeetingParticipantInfo> Attendees { get; set; }
#endif
        /// <summary>The contributors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingParticipantInfo>? Contributors { get; set; }
#nullable restore
#else
        public List<MeetingParticipantInfo> Contributors { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Information of the meeting organizer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MeetingParticipantInfo? Organizer { get; set; }
#nullable restore
#else
        public MeetingParticipantInfo Organizer { get; set; }
#endif
        /// <summary>The producers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingParticipantInfo>? Producers { get; set; }
#nullable restore
#else
        public List<MeetingParticipantInfo> Producers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MeetingParticipants"/> and sets the default values.
        /// </summary>
        public MeetingParticipants()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MeetingParticipants"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MeetingParticipants CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingParticipants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attendees", n => { Attendees = n.GetCollectionOfObjectValues<MeetingParticipantInfo>(MeetingParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contributors", n => { Contributors = n.GetCollectionOfObjectValues<MeetingParticipantInfo>(MeetingParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organizer", n => { Organizer = n.GetObjectValue<MeetingParticipantInfo>(MeetingParticipantInfo.CreateFromDiscriminatorValue); } },
                {"producers", n => { Producers = n.GetCollectionOfObjectValues<MeetingParticipantInfo>(MeetingParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MeetingParticipantInfo>("attendees", Attendees);
            writer.WriteCollectionOfObjectValues<MeetingParticipantInfo>("contributors", Contributors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<MeetingParticipantInfo>("organizer", Organizer);
            writer.WriteCollectionOfObjectValues<MeetingParticipantInfo>("producers", Producers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
