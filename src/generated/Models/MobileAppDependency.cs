// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Describes a dependency type between two mobile apps.
    /// </summary>
    public class MobileAppDependency : MobileAppRelationship, IParsable
    {
        /// <summary>Indicates the dependency type associated with a relationship between two mobile apps.</summary>
        public MobileAppDependencyType? DependencyType { get; set; }
        /// <summary>The total number of apps that directly or indirectly depend on the parent app. This property is read-only.</summary>
        public int? DependentAppCount { get; private set; }
        /// <summary>The total number of apps the child app directly or indirectly depends on. This property is read-only.</summary>
        public int? DependsOnAppCount { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="MobileAppDependency"/> and sets the default values.
        /// </summary>
        public MobileAppDependency() : base()
        {
            OdataType = "#microsoft.graph.mobileAppDependency";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MobileAppDependency"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppDependency CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppDependency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "dependencyType", n => { DependencyType = n.GetEnumValue<MobileAppDependencyType>(); } },
                { "dependentAppCount", n => { DependentAppCount = n.GetIntValue(); } },
                { "dependsOnAppCount", n => { DependsOnAppCount = n.GetIntValue(); } },
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
            writer.WriteEnumValue<MobileAppDependencyType>("dependencyType", DependencyType);
        }
    }
}
