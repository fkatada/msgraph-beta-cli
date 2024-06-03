// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Constraint enforcing a given profile metadata
    /// </summary>
    public class DeviceManagementSettingProfileConstraint : DeviceManagementConstraint, IParsable
    {
        /// <summary>The source of the entity</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>A collection of types this entity carries</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Types { get; set; }
#nullable restore
#else
        public List<string> Types { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementSettingProfileConstraint"/> and sets the default values.
        /// </summary>
        public DeviceManagementSettingProfileConstraint() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementSettingProfileConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementSettingProfileConstraint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingProfileConstraint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingProfileConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "source", n => { Source = n.GetStringValue(); } },
                { "types", n => { Types = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteStringValue("source", Source);
            writer.WriteCollectionOfPrimitiveValues<string>("types", Types);
        }
    }
}
