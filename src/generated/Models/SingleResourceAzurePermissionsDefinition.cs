// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class SingleResourceAzurePermissionsDefinition : PermissionsDefinition, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actionInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AzurePermissionsDefinitionAction? ActionInfo { get; set; }
#nullable restore
#else
        public AzurePermissionsDefinitionAction ActionInfo { get; set; }
#endif
        /// <summary>Identifier for the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId { get; set; }
#nullable restore
#else
        public string ResourceId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SingleResourceAzurePermissionsDefinition"/> and sets the default values.
        /// </summary>
        public SingleResourceAzurePermissionsDefinition() : base()
        {
            OdataType = "#microsoft.graph.singleResourceAzurePermissionsDefinition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SingleResourceAzurePermissionsDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SingleResourceAzurePermissionsDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SingleResourceAzurePermissionsDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionInfo", n => { ActionInfo = n.GetObjectValue<AzurePermissionsDefinitionAction>(AzurePermissionsDefinitionAction.CreateFromDiscriminatorValue); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<AzurePermissionsDefinitionAction>("actionInfo", ActionInfo);
            writer.WriteStringValue("resourceId", ResourceId);
        }
    }
}
