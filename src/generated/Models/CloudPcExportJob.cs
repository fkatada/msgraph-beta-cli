// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CloudPcExportJob : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date and time when the export job expires.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The status of the export job. The possible values are: notStarted, inProgress, completed, unknownFutureValue. Read-only.</summary>
        public CloudPcExportJobStatus? ExportJobStatus { get; set; }
        /// <summary>The storage account URL of the exported report. It can be used to download the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExportUrl { get; set; }
#nullable restore
#else
        public string ExportUrl { get; set; }
#endif
        /// <summary>The filter applied on the report.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filter { get; set; }
#nullable restore
#else
        public string Filter { get; set; }
#endif
        /// <summary>The format of the exported report.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Format { get; set; }
#nullable restore
#else
        public string Format { get; set; }
#endif
        /// <summary>The report name. The possible values are: remoteConnectionHistoricalReports, dailyAggregatedRemoteConnectionReports, totalAggregatedRemoteConnectionReports, sharedUseLicenseUsageReport, sharedUseLicenseUsageRealTimeReport, unknownFutureValue,  noLicenseAvailableConnectivityFailureReport, frontlineLicenseUsageReport, frontlineLicenseUsageRealTimeReport,  remoteConnectionQualityReports, inaccessibleCloudPcReports, rawRemoteConnectionReports, cloudPcUsageCategoryReports. You must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: noLicenseAvailableConnectivityFailureReport, frontlineLicenseUsageReport, frontlineLicenseUsageRealTimeReport, remoteConnectionQualityReports, inaccessibleCloudPcReports, rawRemoteConnectionReports, cloudPcUsageCategoryReports.</summary>
        public CloudPcReportName? ReportName { get; set; }
        /// <summary>The date and time when the export job was requested.</summary>
        public DateTimeOffset? RequestDateTime { get; set; }
        /// <summary>The selected columns of the report.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Select { get; set; }
#nullable restore
#else
        public List<string> Select { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcExportJob"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcExportJob CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcExportJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "exportJobStatus", n => { ExportJobStatus = n.GetEnumValue<CloudPcExportJobStatus>(); } },
                { "exportUrl", n => { ExportUrl = n.GetStringValue(); } },
                { "filter", n => { Filter = n.GetStringValue(); } },
                { "format", n => { Format = n.GetStringValue(); } },
                { "reportName", n => { ReportName = n.GetEnumValue<CloudPcReportName>(); } },
                { "requestDateTime", n => { RequestDateTime = n.GetDateTimeOffsetValue(); } },
                { "select", n => { Select = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteEnumValue<CloudPcExportJobStatus>("exportJobStatus", ExportJobStatus);
            writer.WriteStringValue("exportUrl", ExportUrl);
            writer.WriteStringValue("filter", Filter);
            writer.WriteStringValue("format", Format);
            writer.WriteEnumValue<CloudPcReportName>("reportName", ReportName);
            writer.WriteDateTimeOffsetValue("requestDateTime", RequestDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
        }
    }
}
