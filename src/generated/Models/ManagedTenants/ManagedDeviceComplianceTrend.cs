// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants {
    public class ManagedDeviceComplianceTrend : ApiSdk.Models.Entity, IParsable 
    {
        /// <summary>The number of devices with a compliant status. Required. Read-only.</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>The number of devices manged by Configuration Manager. Required. Read-only.</summary>
        public int? ConfigManagerDeviceCount { get; set; }
        /// <summary>The date and time compliance snapshot was performed. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountDateTime { get; set; }
#nullable restore
#else
        public string CountDateTime { get; set; }
#endif
        /// <summary>The number of devices with an error status. Required. Read-only.</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>The number of devices that are in a grace period status. Required. Read-only.</summary>
        public int? InGracePeriodDeviceCount { get; set; }
        /// <summary>The number of devices that are in a non-compliant status. Required. Read-only.</summary>
        public int? NoncompliantDeviceCount { get; set; }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName { get; set; }
#nullable restore
#else
        public string TenantDisplayName { get; set; }
#endif
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The number of devices in an unknown status. Required. Read-only.</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ManagedDeviceComplianceTrend"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedDeviceComplianceTrend CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceComplianceTrend();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"configManagerDeviceCount", n => { ConfigManagerDeviceCount = n.GetIntValue(); } },
                {"countDateTime", n => { CountDateTime = n.GetStringValue(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"inGracePeriodDeviceCount", n => { InGracePeriodDeviceCount = n.GetIntValue(); } },
                {"noncompliantDeviceCount", n => { NoncompliantDeviceCount = n.GetIntValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("configManagerDeviceCount", ConfigManagerDeviceCount);
            writer.WriteStringValue("countDateTime", CountDateTime);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("inGracePeriodDeviceCount", InGracePeriodDeviceCount);
            writer.WriteIntValue("noncompliantDeviceCount", NoncompliantDeviceCount);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
