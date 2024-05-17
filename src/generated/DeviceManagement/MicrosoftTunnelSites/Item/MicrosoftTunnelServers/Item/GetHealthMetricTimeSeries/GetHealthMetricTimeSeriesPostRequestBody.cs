// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.GetHealthMetricTimeSeries {
    #pragma warning disable CS1591
    public class GetHealthMetricTimeSeriesPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The endDateTime property</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The metricName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MetricName { get; set; }
#nullable restore
#else
        public string MetricName { get; set; }
#endif
        /// <summary>The startDateTime property</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="GetHealthMetricTimeSeriesPostRequestBody"/> and sets the default values.
        /// </summary>
        public GetHealthMetricTimeSeriesPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetHealthMetricTimeSeriesPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetHealthMetricTimeSeriesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetHealthMetricTimeSeriesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"metricName", n => { MetricName = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("metricName", MetricName);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
