// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Describes a relationship between two mobile apps.
    /// </summary>
    public class MobileAppRelationship : Entity, IParsable
    {
        /// <summary>The target mobile app&apos;s display name. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetDisplayName { get; private set; }
#nullable restore
#else
        public string TargetDisplayName { get; private set; }
#endif
        /// <summary>The target mobile app&apos;s display version. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetDisplayVersion { get; private set; }
#nullable restore
#else
        public string TargetDisplayVersion { get; private set; }
#endif
        /// <summary>The target mobile app&apos;s app id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetId { get; set; }
#nullable restore
#else
        public string TargetId { get; set; }
#endif
        /// <summary>The target mobile app&apos;s publisher. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetPublisher { get; private set; }
#nullable restore
#else
        public string TargetPublisher { get; private set; }
#endif
        /// <summary>Indicates whether the target of a relationship is the parent or the child in the relationship.</summary>
        public MobileAppRelationshipType? TargetType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MobileAppRelationship"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppRelationship CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.mobileAppDependency" => new MobileAppDependency(),
                "#microsoft.graph.mobileAppSupersedence" => new MobileAppSupersedence(),
                _ => new MobileAppRelationship(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "targetDisplayName", n => { TargetDisplayName = n.GetStringValue(); } },
                { "targetDisplayVersion", n => { TargetDisplayVersion = n.GetStringValue(); } },
                { "targetId", n => { TargetId = n.GetStringValue(); } },
                { "targetPublisher", n => { TargetPublisher = n.GetStringValue(); } },
                { "targetType", n => { TargetType = n.GetEnumValue<MobileAppRelationshipType>(); } },
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
            writer.WriteStringValue("targetId", TargetId);
            writer.WriteEnumValue<MobileAppRelationshipType>("targetType", TargetType);
        }
    }
}
