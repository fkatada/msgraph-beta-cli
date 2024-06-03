// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AccessPackageAssignmentRequestRequirements : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Answers that have already been provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAnswer>? ExistingAnswers { get; set; }
#nullable restore
#else
        public List<AccessPackageAnswer> ExistingAnswers { get; set; }
#endif
        /// <summary>Indicates whether a request must be approved by an approver.</summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary>Indicates whether approval is required when a user tries to extend their access.</summary>
        public bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary>Indicates whether the requestor is allowed to set a custom schedule.</summary>
        public bool? IsCustomAssignmentScheduleAllowed { get; set; }
        /// <summary>Indicates whether a requestor must supply justification when submitting an assignment request.</summary>
        public bool? IsRequestorJustificationRequired { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The description of the policy that the user is trying to request access using.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyDescription { get; set; }
#nullable restore
#else
        public string PolicyDescription { get; set; }
#endif
        /// <summary>The display name of the policy that the user is trying to request access using.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyDisplayName { get; set; }
#nullable restore
#else
        public string PolicyDisplayName { get; set; }
#endif
        /// <summary>The identifier of the policy that these requirements are associated with. This identifier can be used when creating a new assignment request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId { get; set; }
#nullable restore
#else
        public string PolicyId { get; set; }
#endif
        /// <summary>Questions that are configured on the policy. The questions can be required or optional; callers can determine whether a question is required or optional based on the isRequired property on accessPackageQuestion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageQuestion>? Questions { get; set; }
#nullable restore
#else
        public List<AccessPackageQuestion> Questions { get; set; }
#endif
        /// <summary>Schedule restrictions enforced, if any.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestSchedule? Schedule { get; set; }
#nullable restore
#else
        public RequestSchedule Schedule { get; set; }
#endif
        /// <summary>The status of the process to process the verifiable credential, if any.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.VerifiableCredentialRequirementStatus? VerifiableCredentialRequirementStatus { get; set; }
#nullable restore
#else
        public ApiSdk.Models.VerifiableCredentialRequirementStatus VerifiableCredentialRequirementStatus { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AccessPackageAssignmentRequestRequirements"/> and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestRequirements()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccessPackageAssignmentRequestRequirements"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessPackageAssignmentRequestRequirements CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequestRequirements();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "existingAnswers", n => { ExistingAnswers = n.GetCollectionOfObjectValues<AccessPackageAnswer>(AccessPackageAnswer.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isApprovalRequired", n => { IsApprovalRequired = n.GetBoolValue(); } },
                { "isApprovalRequiredForExtension", n => { IsApprovalRequiredForExtension = n.GetBoolValue(); } },
                { "isCustomAssignmentScheduleAllowed", n => { IsCustomAssignmentScheduleAllowed = n.GetBoolValue(); } },
                { "isRequestorJustificationRequired", n => { IsRequestorJustificationRequired = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "policyDescription", n => { PolicyDescription = n.GetStringValue(); } },
                { "policyDisplayName", n => { PolicyDisplayName = n.GetStringValue(); } },
                { "policyId", n => { PolicyId = n.GetStringValue(); } },
                { "questions", n => { Questions = n.GetCollectionOfObjectValues<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue)?.ToList(); } },
                { "schedule", n => { Schedule = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                { "verifiableCredentialRequirementStatus", n => { VerifiableCredentialRequirementStatus = n.GetObjectValue<ApiSdk.Models.VerifiableCredentialRequirementStatus>(ApiSdk.Models.VerifiableCredentialRequirementStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AccessPackageAnswer>("existingAnswers", ExistingAnswers);
            writer.WriteBoolValue("isApprovalRequired", IsApprovalRequired);
            writer.WriteBoolValue("isApprovalRequiredForExtension", IsApprovalRequiredForExtension);
            writer.WriteBoolValue("isCustomAssignmentScheduleAllowed", IsCustomAssignmentScheduleAllowed);
            writer.WriteBoolValue("isRequestorJustificationRequired", IsRequestorJustificationRequired);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyDescription", PolicyDescription);
            writer.WriteStringValue("policyDisplayName", PolicyDisplayName);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteCollectionOfObjectValues<AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<RequestSchedule>("schedule", Schedule);
            writer.WriteObjectValue<ApiSdk.Models.VerifiableCredentialRequirementStatus>("verifiableCredentialRequirementStatus", VerifiableCredentialRequirementStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
