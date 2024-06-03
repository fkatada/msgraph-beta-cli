// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AccessPackageAssignmentRequest : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The access package associated with the accessPackageAssignmentRequest. An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AccessPackage? AccessPackage { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AccessPackage AccessPackage { get; set; }
#endif
        /// <summary>For a requestType of UserAdd or AdminAdd, an access package assignment requested to be created. For a requestType of UserRemove, AdminRemove, or SystemRemove, this property has the id property of an existing assignment to be removed. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AccessPackageAssignment? AccessPackageAssignment { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AccessPackageAssignment AccessPackageAssignment { get; set; }
#endif
        /// <summary>Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAnswer>? Answers { get; set; }
#nullable restore
#else
        public List<AccessPackageAnswer> Answers { get; set; }
#endif
        /// <summary>The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CompletedDate { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Information about all the custom extension calls that were made during the access package assignment request workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionCalloutInstance>? CustomExtensionCalloutInstances { get; set; }
#nullable restore
#else
        public List<CustomExtensionCalloutInstance> CustomExtensionCalloutInstances { get; set; }
#endif
        /// <summary>A collection of custom workflow extension instances being run on an assignment request. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionHandlerInstance>? CustomExtensionHandlerInstances { get; set; }
#nullable restore
#else
        public List<CustomExtensionHandlerInstance> CustomExtensionHandlerInstances { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>True if the request isn&apos;t to be processed for assignment.</summary>
        public bool? IsValidationOnly { get; set; }
        /// <summary>The requestor&apos;s supplied justification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification { get; set; }
#nullable restore
#else
        public string Justification { get; set; }
#endif
        /// <summary>The subject who requested or, if a direct assignment, was assigned. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageSubject? Requestor { get; set; }
#nullable restore
#else
        public AccessPackageSubject Requestor { get; set; }
#endif
        /// <summary>One of PendingApproval, Canceled,  Denied, Delivering, Delivered, PartiallyDelivered, DeliveryFailed, Submitted, or Scheduled. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestState { get; set; }
#nullable restore
#else
        public string RequestState { get; set; }
#endif
        /// <summary>More information on the request processing status. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestStatus { get; set; }
#nullable restore
#else
        public string RequestStatus { get; set; }
#endif
        /// <summary>One of UserAdd, UserExtend, UserUpdate, UserRemove, AdminAdd, AdminRemove, or SystemRemove. A request from the user has a requestType of UserAdd, UserUpdate, or UserRemove. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestType { get; set; }
#nullable restore
#else
        public string RequestType { get; set; }
#endif
        /// <summary>The range of dates that access is to be assigned to the requestor. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestSchedule? Schedule { get; set; }
#nullable restore
#else
        public RequestSchedule Schedule { get; set; }
#endif
        /// <summary>The details of the verifiable credential that the requestor presented, such as the issuer and claims. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VerifiedCredentialData>? VerifiedCredentialsData { get; set; }
#nullable restore
#else
        public List<VerifiedCredentialData> VerifiedCredentialsData { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccessPackageAssignmentRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignmentRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackage", n => { AccessPackage = n.GetObjectValue<ApiSdk.Models.AccessPackage>(ApiSdk.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                { "accessPackageAssignment", n => { AccessPackageAssignment = n.GetObjectValue<ApiSdk.Models.AccessPackageAssignment>(ApiSdk.Models.AccessPackageAssignment.CreateFromDiscriminatorValue); } },
                { "answers", n => { Answers = n.GetCollectionOfObjectValues<AccessPackageAnswer>(AccessPackageAnswer.CreateFromDiscriminatorValue)?.ToList(); } },
                { "completedDate", n => { CompletedDate = n.GetDateTimeOffsetValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customExtensionCalloutInstances", n => { CustomExtensionCalloutInstances = n.GetCollectionOfObjectValues<CustomExtensionCalloutInstance>(CustomExtensionCalloutInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "customExtensionHandlerInstances", n => { CustomExtensionHandlerInstances = n.GetCollectionOfObjectValues<CustomExtensionHandlerInstance>(CustomExtensionHandlerInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                { "justification", n => { Justification = n.GetStringValue(); } },
                { "requestState", n => { RequestState = n.GetStringValue(); } },
                { "requestStatus", n => { RequestStatus = n.GetStringValue(); } },
                { "requestType", n => { RequestType = n.GetStringValue(); } },
                { "requestor", n => { Requestor = n.GetObjectValue<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue); } },
                { "schedule", n => { Schedule = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                { "verifiedCredentialsData", n => { VerifiedCredentialsData = n.GetCollectionOfObjectValues<VerifiedCredentialData>(VerifiedCredentialData.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<ApiSdk.Models.AccessPackageAssignment>("accessPackageAssignment", AccessPackageAssignment);
            writer.WriteCollectionOfObjectValues<AccessPackageAnswer>("answers", Answers);
            writer.WriteDateTimeOffsetValue("completedDate", CompletedDate);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomExtensionCalloutInstance>("customExtensionCalloutInstances", CustomExtensionCalloutInstances);
            writer.WriteCollectionOfObjectValues<CustomExtensionHandlerInstance>("customExtensionHandlerInstances", CustomExtensionHandlerInstances);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<AccessPackageSubject>("requestor", Requestor);
            writer.WriteStringValue("requestState", RequestState);
            writer.WriteStringValue("requestStatus", RequestStatus);
            writer.WriteStringValue("requestType", RequestType);
            writer.WriteObjectValue<RequestSchedule>("schedule", Schedule);
            writer.WriteCollectionOfObjectValues<VerifiedCredentialData>("verifiedCredentialsData", VerifiedCredentialsData);
        }
    }
}
