// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// A new entity to represent driver inventories.
    /// </summary>
    public class WindowsDriverUpdateInventory : Entity, IParsable
    {
        /// <summary>The number of devices for which this driver is applicable.</summary>
        public int? ApplicableDeviceCount { get; set; }
        /// <summary>An enum type to represent approval status of a driver.</summary>
        public DriverApprovalStatus? ApprovalStatus { get; set; }
        /// <summary>An enum type to represent which category a driver belongs to.</summary>
        public DriverCategory? Category { get; set; }
        /// <summary>The date time when a driver should be deployed if approvalStatus is approved.</summary>
        public DateTimeOffset? DeployDateTime { get; set; }
        /// <summary>The class of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriverClass { get; set; }
#nullable restore
#else
        public string DriverClass { get; set; }
#endif
        /// <summary>The manufacturer of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; set; }
#nullable restore
#else
        public string Manufacturer { get; set; }
#endif
        /// <summary>The name of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The release date time of the driver.</summary>
        public DateTimeOffset? ReleaseDateTime { get; set; }
        /// <summary>The version of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsDriverUpdateInventory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsDriverUpdateInventory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDriverUpdateInventory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicableDeviceCount", n => { ApplicableDeviceCount = n.GetIntValue(); } },
                { "approvalStatus", n => { ApprovalStatus = n.GetEnumValue<DriverApprovalStatus>(); } },
                { "category", n => { Category = n.GetEnumValue<DriverCategory>(); } },
                { "deployDateTime", n => { DeployDateTime = n.GetDateTimeOffsetValue(); } },
                { "driverClass", n => { DriverClass = n.GetStringValue(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteIntValue("applicableDeviceCount", ApplicableDeviceCount);
            writer.WriteEnumValue<DriverApprovalStatus>("approvalStatus", ApprovalStatus);
            writer.WriteEnumValue<DriverCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("deployDateTime", DeployDateTime);
            writer.WriteStringValue("driverClass", DriverClass);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
