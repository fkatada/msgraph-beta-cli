// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class PlannerTaskPropertyRule : PlannerPropertyRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Rules and restrictions for applied categories. This value doesn&apos;t currently support overrides. Accepted values for the default rule and individual overrides are allow, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? AppliedCategories { get; set; }
#nullable restore
#else
        public PlannerFieldRules AppliedCategories { get; set; }
#endif
        /// <summary>Rules and restrictions for approval. Allowed overrides are userCreated and applicationCreated. Accepted values for the default rule and individual overrides are: allow, add, remove, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? ApprovalAttachment { get; set; }
#nullable restore
#else
        public PlannerFieldRules ApprovalAttachment { get; set; }
#endif
        /// <summary>Rules and restrictions for assignments. Allowed overrides are userCreated and applicationCreated. Accepted values for the default rule and individual overrides are allow, add, addSelf, addOther, remove, removeSelf, removeOther, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? Assignments { get; set; }
#nullable restore
#else
        public PlannerFieldRules Assignments { get; set; }
#endif
        /// <summary>Rules and restrictions for checklist. Allowed overrides are userCreated and applicationCreated. Accepted values for the default rule and individual overrides are allow, add, remove, update, check, reorder, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? CheckLists { get; set; }
#nullable restore
#else
        public PlannerFieldRules CheckLists { get; set; }
#endif
        /// <summary>Rules and restrictions for completion requirements of the task. Accepted values are allow, add, remove, edit, and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CompletionRequirements { get; set; }
#nullable restore
#else
        public List<string> CompletionRequirements { get; set; }
#endif
        /// <summary>Rules and restrictions for deleting the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Delete { get; set; }
#nullable restore
#else
        public List<string> Delete { get; set; }
#endif
        /// <summary>Rules and restrictions for changing the due date of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DueDate { get; set; }
#nullable restore
#else
        public List<string> DueDate { get; set; }
#endif
        /// <summary>Rules and restrictions for forms. Allowed overrides are userCreated and applicationCreated. The following are the accepted values for the default rule and individual overrides: allow, add, addResponse, remove, update, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? Forms { get; set; }
#nullable restore
#else
        public PlannerFieldRules Forms { get; set; }
#endif
        /// <summary>Rules and restrictions for moving the task between buckets or plans. Accepted values are allow, moveBetweenPlans, moveBetweenBuckets, and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Move { get; set; }
#nullable restore
#else
        public List<string> Move { get; set; }
#endif
        /// <summary>Rules and restrictions for changing the notes of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Notes { get; set; }
#nullable restore
#else
        public List<string> Notes { get; set; }
#endif
        /// <summary>Rules and restrictions for changing the order of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Order { get; set; }
#nullable restore
#else
        public List<string> Order { get; set; }
#endif
        /// <summary>Rules and restrictions for changing the completion percentage of the task. Accepted values are allow, setToComplete, overrideRequirements, setToNotStarted, setToInProgress, and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PercentComplete { get; set; }
#nullable restore
#else
        public List<string> PercentComplete { get; set; }
#endif
        /// <summary>Rules and restrictions for changing the preview type of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PreviewType { get; set; }
#nullable restore
#else
        public List<string> PreviewType { get; set; }
#endif
        /// <summary>Rules and restrictions for changing the priority of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Priority { get; set; }
#nullable restore
#else
        public List<string> Priority { get; set; }
#endif
        /// <summary>Rules and restrictions for references. Allowed overrides are userCreated and applicationCreated. Accepted values for the default rule and individual overrides are allow, add, remove, block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerFieldRules? References { get; set; }
#nullable restore
#else
        public PlannerFieldRules References { get; set; }
#endif
        /// <summary>Rules and restrictions for changing the start date of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StartDate { get; set; }
#nullable restore
#else
        public List<string> StartDate { get; set; }
#endif
        /// <summary>Rules and restrictions for changing the title of the task. Accepted values are allow and block.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Title { get; set; }
#nullable restore
#else
        public List<string> Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PlannerTaskPropertyRule"/> and sets the default values.
        /// </summary>
        public PlannerTaskPropertyRule() : base()
        {
            OdataType = "#microsoft.graph.plannerTaskPropertyRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PlannerTaskPropertyRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerTaskPropertyRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskPropertyRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appliedCategories", n => { AppliedCategories = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                { "approvalAttachment", n => { ApprovalAttachment = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                { "assignments", n => { Assignments = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                { "checkLists", n => { CheckLists = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                { "completionRequirements", n => { CompletionRequirements = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "delete", n => { Delete = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "dueDate", n => { DueDate = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "forms", n => { Forms = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                { "move", n => { Move = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "notes", n => { Notes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "order", n => { Order = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "percentComplete", n => { PercentComplete = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "previewType", n => { PreviewType = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "priority", n => { Priority = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "references", n => { References = n.GetObjectValue<PlannerFieldRules>(PlannerFieldRules.CreateFromDiscriminatorValue); } },
                { "startDate", n => { StartDate = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "title", n => { Title = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteObjectValue<PlannerFieldRules>("appliedCategories", AppliedCategories);
            writer.WriteObjectValue<PlannerFieldRules>("approvalAttachment", ApprovalAttachment);
            writer.WriteObjectValue<PlannerFieldRules>("assignments", Assignments);
            writer.WriteObjectValue<PlannerFieldRules>("checkLists", CheckLists);
            writer.WriteCollectionOfPrimitiveValues<string>("completionRequirements", CompletionRequirements);
            writer.WriteCollectionOfPrimitiveValues<string>("delete", Delete);
            writer.WriteCollectionOfPrimitiveValues<string>("dueDate", DueDate);
            writer.WriteObjectValue<PlannerFieldRules>("forms", Forms);
            writer.WriteCollectionOfPrimitiveValues<string>("move", Move);
            writer.WriteCollectionOfPrimitiveValues<string>("notes", Notes);
            writer.WriteCollectionOfPrimitiveValues<string>("order", Order);
            writer.WriteCollectionOfPrimitiveValues<string>("percentComplete", PercentComplete);
            writer.WriteCollectionOfPrimitiveValues<string>("previewType", PreviewType);
            writer.WriteCollectionOfPrimitiveValues<string>("priority", Priority);
            writer.WriteObjectValue<PlannerFieldRules>("references", References);
            writer.WriteCollectionOfPrimitiveValues<string>("startDate", StartDate);
            writer.WriteCollectionOfPrimitiveValues<string>("title", Title);
        }
    }
}
