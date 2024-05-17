// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class PlannerTaskCompletionRequirementDetails : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information about the requirements of an approval.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerApprovalRequirement? ApprovalRequirement { get; set; }
#nullable restore
#else
        public PlannerApprovalRequirement ApprovalRequirement { get; set; }
#endif
        /// <summary>Information about the requirements for completing the checklist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerChecklistRequirement? ChecklistRequirement { get; set; }
#nullable restore
#else
        public PlannerChecklistRequirement ChecklistRequirement { get; set; }
#endif
        /// <summary>Information about the requirements for completing the forms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFormsRequirement? FormsRequirement { get; set; }
#nullable restore
#else
        public PlannerFormsRequirement FormsRequirement { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PlannerTaskCompletionRequirementDetails"/> and sets the default values.
        /// </summary>
        public PlannerTaskCompletionRequirementDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PlannerTaskCompletionRequirementDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlannerTaskCompletionRequirementDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskCompletionRequirementDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"approvalRequirement", n => { ApprovalRequirement = n.GetObjectValue<PlannerApprovalRequirement>(PlannerApprovalRequirement.CreateFromDiscriminatorValue); } },
                {"checklistRequirement", n => { ChecklistRequirement = n.GetObjectValue<PlannerChecklistRequirement>(PlannerChecklistRequirement.CreateFromDiscriminatorValue); } },
                {"formsRequirement", n => { FormsRequirement = n.GetObjectValue<PlannerFormsRequirement>(PlannerFormsRequirement.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PlannerApprovalRequirement>("approvalRequirement", ApprovalRequirement);
            writer.WriteObjectValue<PlannerChecklistRequirement>("checklistRequirement", ChecklistRequirement);
            writer.WriteObjectValue<PlannerFormsRequirement>("formsRequirement", FormsRequirement);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
