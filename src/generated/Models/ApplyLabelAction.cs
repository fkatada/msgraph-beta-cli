// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ApplyLabelAction : InformationProtectionAction, IParsable 
    {
        /// <summary>The collection of specific actions that should be taken by the consuming application to label the document. See  informationProtectionAction for the full list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InformationProtectionAction>? Actions { get; set; }
#nullable restore
#else
        public List<InformationProtectionAction> Actions { get; set; }
#endif
        /// <summary>The actionSource property</summary>
        public ApiSdk.Models.ActionSource? ActionSource { get; set; }
        /// <summary>Object that describes the details of the label to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LabelDetails? Label { get; set; }
#nullable restore
#else
        public LabelDetails Label { get; set; }
#endif
        /// <summary>If the label was the result of an automatic classification, supply the list of sensitive info type GUIDs that resulted in the returned label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? ResponsibleSensitiveTypeIds { get; set; }
#nullable restore
#else
        public List<Guid?> ResponsibleSensitiveTypeIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ApplyLabelAction"/> and sets the default values.
        /// </summary>
        public ApplyLabelAction() : base()
        {
            OdataType = "#microsoft.graph.applyLabelAction";
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
                {"actionSource", n => { ActionSource = n.GetEnumValue<ActionSource>(); } },
                {"actions", n => { Actions = n.GetCollectionOfObjectValues<InformationProtectionAction>(InformationProtectionAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"label", n => { Label = n.GetObjectValue<LabelDetails>(LabelDetails.CreateFromDiscriminatorValue); } },
                {"responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
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
            writer.WriteObjectValue<LabelDetails>("label", Label);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
        }
    }
}
