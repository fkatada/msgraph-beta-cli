// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Entity representing the configuration of a cached report.
    /// </summary>
    public class DeviceManagementCachedReportConfiguration : Entity, IParsable
    {
        /// <summary>Time that the cached report expires.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Filters applied on report creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filter { get; set; }
#nullable restore
#else
        public string Filter { get; set; }
#endif
        /// <summary>Time that the cached report was last refreshed.</summary>
        public DateTimeOffset? LastRefreshDateTime { get; set; }
        /// <summary>Caller-managed metadata associated with the report.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Metadata { get; set; }
#nullable restore
#else
        public string Metadata { get; set; }
#endif
        /// <summary>Ordering of columns in the report.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OrderBy { get; set; }
#nullable restore
#else
        public List<string> OrderBy { get; set; }
#endif
        /// <summary>Name of the report.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportName { get; set; }
#nullable restore
#else
        public string ReportName { get; set; }
#endif
        /// <summary>Columns selected from the report.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Select { get; set; }
#nullable restore
#else
        public List<string> Select { get; set; }
#endif
        /// <summary>Possible statuses associated with a generated report.</summary>
        public DeviceManagementReportStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementCachedReportConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementCachedReportConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementCachedReportConfiguration();
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
                { "filter", n => { Filter = n.GetStringValue(); } },
                { "lastRefreshDateTime", n => { LastRefreshDateTime = n.GetDateTimeOffsetValue(); } },
                { "metadata", n => { Metadata = n.GetStringValue(); } },
                { "orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "reportName", n => { ReportName = n.GetStringValue(); } },
                { "select", n => { Select = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "status", n => { Status = n.GetEnumValue<DeviceManagementReportStatus>(); } },
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
            writer.WriteStringValue("filter", Filter);
            writer.WriteDateTimeOffsetValue("lastRefreshDateTime", LastRefreshDateTime);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteStringValue("reportName", ReportName);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteEnumValue<DeviceManagementReportStatus>("status", Status);
        }
    }
}
