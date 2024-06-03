// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetSharedUseLicenseUsageReport
{
    #pragma warning disable CS1591
    public class GetSharedUseLicenseUsageReportPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The filter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filter { get; set; }
#nullable restore
#else
        public string Filter { get; set; }
#endif
        /// <summary>The groupBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GroupBy { get; set; }
#nullable restore
#else
        public List<string> GroupBy { get; set; }
#endif
        /// <summary>The orderBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OrderBy { get; set; }
#nullable restore
#else
        public List<string> OrderBy { get; set; }
#endif
        /// <summary>The reportName property</summary>
        public CloudPcReportName? ReportName { get; set; }
        /// <summary>The search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Search { get; set; }
#nullable restore
#else
        public string Search { get; set; }
#endif
        /// <summary>The select property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Select { get; set; }
#nullable restore
#else
        public List<string> Select { get; set; }
#endif
        /// <summary>The skip property</summary>
        public int? Skip { get; set; }
        /// <summary>The top property</summary>
        public int? Top { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="GetSharedUseLicenseUsageReportPostRequestBody"/> and sets the default values.
        /// </summary>
        public GetSharedUseLicenseUsageReportPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetSharedUseLicenseUsageReportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetSharedUseLicenseUsageReportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetSharedUseLicenseUsageReportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "filter", n => { Filter = n.GetStringValue(); } },
                { "groupBy", n => { GroupBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "reportName", n => { ReportName = n.GetEnumValue<CloudPcReportName>(); } },
                { "search", n => { Search = n.GetStringValue(); } },
                { "select", n => { Select = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "skip", n => { Skip = n.GetIntValue(); } },
                { "top", n => { Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("filter", Filter);
            writer.WriteCollectionOfPrimitiveValues<string>("groupBy", GroupBy);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteEnumValue<CloudPcReportName>("reportName", ReportName);
            writer.WriteStringValue("search", Search);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
