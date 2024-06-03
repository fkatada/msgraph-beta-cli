// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AccessPackageAssignmentPolicy : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The access package with this policy. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AccessPackage? AccessPackage { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AccessPackage AccessPackage { get; set; }
#endif
        /// <summary>The accessPackageCatalog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AccessPackageCatalog? AccessPackageCatalog { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AccessPackageCatalog AccessPackageCatalog { get; set; }
#endif
        /// <summary>Identifier of the access package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessPackageId { get; set; }
#nullable restore
#else
        public string AccessPackageId { get; set; }
#endif
        /// <summary>Who must review, and how often, the assignments to the access package from this policy. This property is null if reviews aren&apos;t required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AssignmentReviewSettings? AccessReviewSettings { get; set; }
#nullable restore
#else
        public AssignmentReviewSettings AccessReviewSettings { get; set; }
#endif
        /// <summary>Indicates whether a user can extend the access package assignment duration after approval.</summary>
        public bool? CanExtend { get; set; }
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionHandler>? CustomExtensionHandlers { get; set; }
#nullable restore
#else
        public List<CustomExtensionHandler> CustomExtensionHandlers { get; set; }
#endif
        /// <summary>The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionStageSetting>? CustomExtensionStageSettings { get; set; }
#nullable restore
#else
        public List<CustomExtensionStageSetting> CustomExtensionStageSettings { get; set; }
#endif
        /// <summary>The description of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the policy. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The number of days in which assignments from this policy last until they&apos;re expired.</summary>
        public int? DurationInDays { get; set; }
        /// <summary>The expiration date for assignments created in this policy. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The modifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModifiedBy { get; set; }
#nullable restore
#else
        public string ModifiedBy { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Questions that are posed to the  requestor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageQuestion>? Questions { get; set; }
#nullable restore
#else
        public List<AccessPackageQuestion> Questions { get; set; }
#endif
        /// <summary>Who must approve requests for access package in this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApprovalSettings? RequestApprovalSettings { get; set; }
#nullable restore
#else
        public ApprovalSettings RequestApprovalSettings { get; set; }
#endif
        /// <summary>Who can request this access package from this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RequestorSettings? RequestorSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RequestorSettings RequestorSettings { get; set; }
#endif
        /// <summary>Settings for verifiable credentials set up through the Microsoft Entra Verified I D service. These settings represent the verifiable credentials that a requestor of an access package in this policy can present to be assigned the access package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.VerifiableCredentialSettings? VerifiableCredentialSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.VerifiableCredentialSettings VerifiableCredentialSettings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccessPackageAssignmentPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignmentPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentPolicy();
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
                { "accessPackageCatalog", n => { AccessPackageCatalog = n.GetObjectValue<ApiSdk.Models.AccessPackageCatalog>(ApiSdk.Models.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                { "accessPackageId", n => { AccessPackageId = n.GetStringValue(); } },
                { "accessReviewSettings", n => { AccessReviewSettings = n.GetObjectValue<AssignmentReviewSettings>(AssignmentReviewSettings.CreateFromDiscriminatorValue); } },
                { "canExtend", n => { CanExtend = n.GetBoolValue(); } },
                { "createdBy", n => { CreatedBy = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customExtensionHandlers", n => { CustomExtensionHandlers = n.GetCollectionOfObjectValues<CustomExtensionHandler>(CustomExtensionHandler.CreateFromDiscriminatorValue)?.ToList(); } },
                { "customExtensionStageSettings", n => { CustomExtensionStageSettings = n.GetCollectionOfObjectValues<CustomExtensionStageSetting>(CustomExtensionStageSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "questions", n => { Questions = n.GetCollectionOfObjectValues<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue)?.ToList(); } },
                { "requestApprovalSettings", n => { RequestApprovalSettings = n.GetObjectValue<ApprovalSettings>(ApprovalSettings.CreateFromDiscriminatorValue); } },
                { "requestorSettings", n => { RequestorSettings = n.GetObjectValue<ApiSdk.Models.RequestorSettings>(ApiSdk.Models.RequestorSettings.CreateFromDiscriminatorValue); } },
                { "verifiableCredentialSettings", n => { VerifiableCredentialSettings = n.GetObjectValue<ApiSdk.Models.VerifiableCredentialSettings>(ApiSdk.Models.VerifiableCredentialSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.AccessPackageCatalog>("accessPackageCatalog", AccessPackageCatalog);
            writer.WriteStringValue("accessPackageId", AccessPackageId);
            writer.WriteObjectValue<AssignmentReviewSettings>("accessReviewSettings", AccessReviewSettings);
            writer.WriteBoolValue("canExtend", CanExtend);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomExtensionHandler>("customExtensionHandlers", CustomExtensionHandlers);
            writer.WriteCollectionOfObjectValues<CustomExtensionStageSetting>("customExtensionStageSettings", CustomExtensionStageSettings);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteCollectionOfObjectValues<AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<ApprovalSettings>("requestApprovalSettings", RequestApprovalSettings);
            writer.WriteObjectValue<ApiSdk.Models.RequestorSettings>("requestorSettings", RequestorSettings);
            writer.WriteObjectValue<ApiSdk.Models.VerifiableCredentialSettings>("verifiableCredentialSettings", VerifiableCredentialSettings);
        }
    }
}
