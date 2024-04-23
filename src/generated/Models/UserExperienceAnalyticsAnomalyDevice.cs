// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The user experience analytics anomaly entity contains device details.
    /// </summary>
    public class UserExperienceAnalyticsAnomalyDevice : Entity, IParsable 
    {
        /// <summary>The unique identifier of the anomaly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnomalyId { get; set; }
#nullable restore
#else
        public string AnomalyId { get; set; }
#endif
        /// <summary>Indicates the first occurance date and time for the anomaly on the device.</summary>
        public DateTimeOffset? AnomalyOnDeviceFirstOccurrenceDateTime { get; set; }
        /// <summary>Indicates the latest occurance date and time for the anomaly on the device.</summary>
        public DateTimeOffset? AnomalyOnDeviceLatestOccurrenceDateTime { get; set; }
        /// <summary>The unique identifier of the correlation group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationGroupId { get; set; }
#nullable restore
#else
        public string CorrelationGroupId { get; set; }
#endif
        /// <summary>The unique identifier of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>The manufacturer name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceManufacturer { get; set; }
#nullable restore
#else
        public string DeviceManufacturer { get; set; }
#endif
        /// <summary>The model name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel { get; set; }
#nullable restore
#else
        public string DeviceModel { get; set; }
#endif
        /// <summary>The name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>Indicates the status of the device in the correlation group. Eg: Device status can be anomalous, affected, at risk.</summary>
        public UserExperienceAnalyticsDeviceStatus? DeviceStatus { get; set; }
        /// <summary>The name of the OS installed on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsName { get; set; }
#nullable restore
#else
        public string OsName { get; set; }
#endif
        /// <summary>The OS version installed on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; set; }
#nullable restore
#else
        public string OsVersion { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserExperienceAnalyticsAnomalyDevice"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsAnomalyDevice CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAnomalyDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"anomalyId", n => { AnomalyId = n.GetStringValue(); } },
                {"anomalyOnDeviceFirstOccurrenceDateTime", n => { AnomalyOnDeviceFirstOccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"anomalyOnDeviceLatestOccurrenceDateTime", n => { AnomalyOnDeviceLatestOccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"correlationGroupId", n => { CorrelationGroupId = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceStatus", n => { DeviceStatus = n.GetEnumValue<UserExperienceAnalyticsDeviceStatus>(); } },
                {"osName", n => { OsName = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
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
            writer.WriteStringValue("anomalyId", AnomalyId);
            writer.WriteDateTimeOffsetValue("anomalyOnDeviceFirstOccurrenceDateTime", AnomalyOnDeviceFirstOccurrenceDateTime);
            writer.WriteDateTimeOffsetValue("anomalyOnDeviceLatestOccurrenceDateTime", AnomalyOnDeviceLatestOccurrenceDateTime);
            writer.WriteStringValue("correlationGroupId", CorrelationGroupId);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<UserExperienceAnalyticsDeviceStatus>("deviceStatus", DeviceStatus);
            writer.WriteStringValue("osName", OsName);
            writer.WriteStringValue("osVersion", OsVersion);
        }
    }
}
