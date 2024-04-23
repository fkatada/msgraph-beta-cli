// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// IOS Update Configuration, allows you to configure time window within week to install iOS updates
    /// </summary>
    public class IosUpdateConfiguration : DeviceConfiguration, IParsable 
    {
        /// <summary>Active Hours End (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursEnd { get; set; }
        /// <summary>Active Hours Start (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursStart { get; set; }
        /// <summary>If update schedule type is set to use time window scheduling, custom time windows when updates will be scheduled. This collection can contain a maximum of 20 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomUpdateTimeWindow>? CustomUpdateTimeWindows { get; set; }
#nullable restore
#else
        public List<CustomUpdateTimeWindow> CustomUpdateTimeWindows { get; set; }
#endif
        /// <summary>If left unspecified, devices will update to the latest version of the OS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DesiredOsVersion { get; set; }
#nullable restore
#else
        public string DesiredOsVersion { get; set; }
#endif
        /// <summary>Days before software updates are visible to iOS devices ranging from 0 to 90 inclusive</summary>
        public int? EnforcedSoftwareUpdateDelayInDays { get; set; }
        /// <summary>Is setting enabled in UI</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Days in week for which active hours are configured. This collection can contain a maximum of 7 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DayOfWeekObject?>? ScheduledInstallDays { get; set; }
#nullable restore
#else
        public List<DayOfWeekObject?> ScheduledInstallDays { get; set; }
#endif
        /// <summary>Update schedule type for iOS software updates.</summary>
        public IosSoftwareUpdateScheduleType? UpdateScheduleType { get; set; }
        /// <summary>UTC Time Offset indicated in minutes</summary>
        public int? UtcTimeOffsetInMinutes { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="IosUpdateConfiguration"/> and sets the default values.
        /// </summary>
        public IosUpdateConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosUpdateConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IosUpdateConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosUpdateConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosUpdateConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"activeHoursEnd", n => { ActiveHoursEnd = n.GetTimeValue(); } },
                {"activeHoursStart", n => { ActiveHoursStart = n.GetTimeValue(); } },
                {"customUpdateTimeWindows", n => { CustomUpdateTimeWindows = n.GetCollectionOfObjectValues<CustomUpdateTimeWindow>(CustomUpdateTimeWindow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"desiredOsVersion", n => { DesiredOsVersion = n.GetStringValue(); } },
                {"enforcedSoftwareUpdateDelayInDays", n => { EnforcedSoftwareUpdateDelayInDays = n.GetIntValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"scheduledInstallDays", n => { ScheduledInstallDays = n.GetCollectionOfEnumValues<DayOfWeekObject>()?.ToList(); } },
                {"updateScheduleType", n => { UpdateScheduleType = n.GetEnumValue<IosSoftwareUpdateScheduleType>(); } },
                {"utcTimeOffsetInMinutes", n => { UtcTimeOffsetInMinutes = n.GetIntValue(); } },
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
            writer.WriteTimeValue("activeHoursEnd", ActiveHoursEnd);
            writer.WriteTimeValue("activeHoursStart", ActiveHoursStart);
            writer.WriteCollectionOfObjectValues<CustomUpdateTimeWindow>("customUpdateTimeWindows", CustomUpdateTimeWindows);
            writer.WriteStringValue("desiredOsVersion", DesiredOsVersion);
            writer.WriteIntValue("enforcedSoftwareUpdateDelayInDays", EnforcedSoftwareUpdateDelayInDays);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfEnumValues<DayOfWeekObject>("scheduledInstallDays", ScheduledInstallDays);
            writer.WriteEnumValue<IosSoftwareUpdateScheduleType>("updateScheduleType", UpdateScheduleType);
            writer.WriteIntValue("utcTimeOffsetInMinutes", UtcTimeOffsetInMinutes);
        }
    }
}
