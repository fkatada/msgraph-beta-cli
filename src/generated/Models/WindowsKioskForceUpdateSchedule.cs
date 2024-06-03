// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Windows 10 force update schedule for Kiosk devices.
    /// </summary>
    public class WindowsKioskForceUpdateSchedule : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Day of month. Valid values 1 to 31</summary>
        public int? DayofMonth { get; set; }
        /// <summary>The dayofWeek property</summary>
        public DayOfWeekObject? DayofWeek { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Possible values for App update on Windows10 recurrence.</summary>
        public Windows10AppsUpdateRecurrence? Recurrence { get; set; }
        /// <summary>If true, runs the task immediately if StartDateTime is in the past, else, runs at the next recurrence.</summary>
        public bool? RunImmediatelyIfAfterStartDateTime { get; set; }
        /// <summary>The start time for the force restart.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WindowsKioskForceUpdateSchedule"/> and sets the default values.
        /// </summary>
        public WindowsKioskForceUpdateSchedule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsKioskForceUpdateSchedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WindowsKioskForceUpdateSchedule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskForceUpdateSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dayofMonth", n => { DayofMonth = n.GetIntValue(); } },
                { "dayofWeek", n => { DayofWeek = n.GetEnumValue<DayOfWeekObject>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "recurrence", n => { Recurrence = n.GetEnumValue<Windows10AppsUpdateRecurrence>(); } },
                { "runImmediatelyIfAfterStartDateTime", n => { RunImmediatelyIfAfterStartDateTime = n.GetBoolValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("dayofMonth", DayofMonth);
            writer.WriteEnumValue<DayOfWeekObject>("dayofWeek", DayofWeek);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Windows10AppsUpdateRecurrence>("recurrence", Recurrence);
            writer.WriteBoolValue("runImmediatelyIfAfterStartDateTime", RunImmediatelyIfAfterStartDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
