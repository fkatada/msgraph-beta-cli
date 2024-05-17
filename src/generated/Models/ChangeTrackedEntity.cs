// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class ChangeTrackedEntity : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Identity of the user who created the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>Identity of the user who last modified the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy { get; private set; }
#nullable restore
#else
        public IdentitySet LastModifiedBy { get; private set; }
#endif
        /// <summary>The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ChangeTrackedEntity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChangeTrackedEntity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.dayNote" => new DayNote(),
                "#microsoft.graph.offerShiftRequest" => new OfferShiftRequest(),
                "#microsoft.graph.openShift" => new OpenShift(),
                "#microsoft.graph.openShiftChangeRequest" => new OpenShiftChangeRequest(),
                "#microsoft.graph.scheduleChangeRequest" => new ScheduleChangeRequest(),
                "#microsoft.graph.schedulingGroup" => new SchedulingGroup(),
                "#microsoft.graph.shift" => new Shift(),
                "#microsoft.graph.shiftPreferences" => new ShiftPreferences(),
                "#microsoft.graph.swapShiftsChangeRequest" => new SwapShiftsChangeRequest(),
                "#microsoft.graph.timeCard" => new TimeCard(),
                "#microsoft.graph.timeOff" => new TimeOff(),
                "#microsoft.graph.timeOffReason" => new TimeOffReason(),
                "#microsoft.graph.timeOffRequest" => new TimeOffRequest(),
                "#microsoft.graph.workforceIntegration" => new WorkforceIntegration(),
                _ => new ChangeTrackedEntity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
        }
    }
}
