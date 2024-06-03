// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security
{
    #pragma warning disable CS1591
    public class ApplyLabelAction : InformationProtectionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of actions that should be implemented by the caller.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InformationProtectionAction>? Actions { get; set; }
#nullable restore
#else
        public List<InformationProtectionAction> Actions { get; set; }
#endif
        /// <summary>The actionSource property</summary>
        public ApiSdk.Models.Security.ActionSource? ActionSource { get; set; }
        /// <summary>If the label was the result of an automatic classification, supply the list of sensitive info type GUIDs that resulted in the returned label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResponsibleSensitiveTypeIds { get; set; }
#nullable restore
#else
        public List<string> ResponsibleSensitiveTypeIds { get; set; }
#endif
        /// <summary>The sensitivityLabelId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SensitivityLabelId { get; set; }
#nullable restore
#else
        public string SensitivityLabelId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ApplyLabelAction"/> and sets the default values.
        /// </summary>
        public ApplyLabelAction() : base()
        {
            OdataType = "#microsoft.graph.security.applyLabelAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ApplyLabelAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ApplyLabelAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplyLabelAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionSource", n => { ActionSource = n.GetEnumValue<ActionSource>(); } },
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<InformationProtectionAction>(InformationProtectionAction.CreateFromDiscriminatorValue)?.ToList(); } },
                { "responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "sensitivityLabelId", n => { SensitivityLabelId = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<InformationProtectionAction>("actions", Actions);
            writer.WriteEnumValue<ActionSource>("actionSource", ActionSource);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
            writer.WriteStringValue("sensitivityLabelId", SensitivityLabelId);
        }
    }
}
