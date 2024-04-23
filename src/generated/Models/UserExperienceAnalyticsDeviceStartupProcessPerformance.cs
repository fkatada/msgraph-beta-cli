// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The user experience analytics device startup process performance.
    /// </summary>
    public class UserExperienceAnalyticsDeviceStartupProcessPerformance : Entity, IParsable 
    {
        /// <summary>The count of devices which initiated this process on startup. Supports: $filter, $select, $OrderBy. Read-only.</summary>
        public long? DeviceCount { get; set; }
        /// <summary>The median impact of startup process on device boot time in milliseconds. Supports: $filter, $select, $OrderBy. Read-only.</summary>
        public long? MedianImpactInMs { get; set; }
        /// <summary>The name of the startup process. Examples: outlook, excel. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcessName { get; set; }
#nullable restore
#else
        public string ProcessName { get; set; }
#endif
        /// <summary>The product name of the startup process. Examples: Microsoft Outlook, Microsoft Excel. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName { get; set; }
#nullable restore
#else
        public string ProductName { get; set; }
#endif
        /// <summary>The publisher of the startup process. Examples: Microsoft Corporation, Contoso Corp. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher { get; set; }
#nullable restore
#else
        public string Publisher { get; set; }
#endif
        /// <summary>The total impact of startup process on device boot time in milliseconds. Supports: $filter, $select, $OrderBy. Read-only.</summary>
        public long? TotalImpactInMs { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserExperienceAnalyticsDeviceStartupProcessPerformance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsDeviceStartupProcessPerformance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceStartupProcessPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"deviceCount", n => { DeviceCount = n.GetLongValue(); } },
                {"medianImpactInMs", n => { MedianImpactInMs = n.GetLongValue(); } },
                {"processName", n => { ProcessName = n.GetStringValue(); } },
                {"productName", n => { ProductName = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"totalImpactInMs", n => { TotalImpactInMs = n.GetLongValue(); } },
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
            writer.WriteLongValue("deviceCount", DeviceCount);
            writer.WriteLongValue("medianImpactInMs", MedianImpactInMs);
            writer.WriteStringValue("processName", ProcessName);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteLongValue("totalImpactInMs", TotalImpactInMs);
        }
    }
}
