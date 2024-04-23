// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// These are elevation approval requests for EPM support arbitrated scenario initiated by IW user that admins can take action on.
    /// </summary>
    public class PrivilegeManagementElevationRequest : Entity, IParsable 
    {
        /// <summary>Details of the application which is being requested to elevate, allowing the admin to understand the identity of the application. It includes file info such as FilePath, FileHash, FilePublisher, and etc. Returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ApplicationDetail? ApplicationDetail { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ApplicationDetail ApplicationDetail { get; set; }
#endif
        /// <summary>The device name used to initiate the elevation request. For example: &apos;cotonso-laptop&apos;. Returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>The date and time when the elevation request was submitted/created. The value cannot be modified and is automatically populated when the elevation request is submitted/created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only.</summary>
        public DateTimeOffset? RequestCreatedDateTime { get; set; }
        /// <summary>The Azure Active Directory (AAD) identifier of the end user who is requesting this elevation. For example: &apos;F1A57311-B9EB-45B7-9415-8555E68EDC9E&apos;. Returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestedByUserId { get; set; }
#nullable restore
#else
        public string RequestedByUserId { get; set; }
#endif
        /// <summary>The User Principal Name (UPN) of the end user who requested this elevation. For example: &apos;user1@contoso.com&apos;. Returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestedByUserPrincipalName { get; set; }
#nullable restore
#else
        public string RequestedByUserPrincipalName { get; set; }
#endif
        /// <summary>The Intune Device Identifier of the managed device used to initiate the elevation request. For example: &apos;90F5F6E8-CA09-4811-97F6-4D0DD532D916&apos;. Returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestedOnDeviceId { get; set; }
#nullable restore
#else
        public string RequestedOnDeviceId { get; set; }
#endif
        /// <summary>Expiration set for the request when it was created, regardless of approved or denied status. For example: &apos;2023-08-03T14:24:22Z&apos;. Returned by default. Returned by default. Read-only.</summary>
        public DateTimeOffset? RequestExpiryDateTime { get; set; }
        /// <summary>Justification provided by the end user for the elevation request. For example :&apos;Need to elevate to install microsoft word&apos;. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestJustification { get; set; }
#nullable restore
#else
        public string RequestJustification { get; set; }
#endif
        /// <summary>The date and time when the elevation request was either submitted/created or approved/denied. The value cannot be modified and is automatically populated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only.</summary>
        public DateTimeOffset? RequestLastModifiedDateTime { get; set; }
        /// <summary>This is the Azure Active Directory (AAD) user id of the administrator who approved or denied the request. For example: &apos;F1A57311-B9EB-45B7-9415-8555E68EDC9E&apos;. This field would be String.Empty before the request is either approved or denied. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewCompletedByUserId { get; set; }
#nullable restore
#else
        public string ReviewCompletedByUserId { get; set; }
#endif
        /// <summary>This is the User Principal Name (UPN) of the administrator who approved or denied the request. For example: &apos;admin@contoso.com&apos;. This field would be String.Empty before the request is either approved or denied. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewCompletedByUserPrincipalName { get; set; }
#nullable restore
#else
        public string ReviewCompletedByUserPrincipalName { get; set; }
#endif
        /// <summary>The DateTime for which the request was approved or denied. For example, midnight UTC on August 3rd, 2023 would look like this: &apos;2023-08-03T00:00:00Z&apos;. Read-only.</summary>
        public DateTimeOffset? ReviewCompletedDateTime { get; set; }
        /// <summary>An optional justification provided by approver at approval or denied time. This field will be String.Empty if approver decides to not provide a justification. For example: &apos;Run this installer today&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewerJustification { get; set; }
#nullable restore
#else
        public string ReviewerJustification { get; set; }
#endif
        /// <summary>Indicates state of elevation request</summary>
        public ElevationRequestState? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivilegeManagementElevationRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegeManagementElevationRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegeManagementElevationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"applicationDetail", n => { ApplicationDetail = n.GetObjectValue<ApiSdk.Models.ApplicationDetail>(ApiSdk.Models.ApplicationDetail.CreateFromDiscriminatorValue); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"requestCreatedDateTime", n => { RequestCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestExpiryDateTime", n => { RequestExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestJustification", n => { RequestJustification = n.GetStringValue(); } },
                {"requestLastModifiedDateTime", n => { RequestLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestedByUserId", n => { RequestedByUserId = n.GetStringValue(); } },
                {"requestedByUserPrincipalName", n => { RequestedByUserPrincipalName = n.GetStringValue(); } },
                {"requestedOnDeviceId", n => { RequestedOnDeviceId = n.GetStringValue(); } },
                {"reviewCompletedByUserId", n => { ReviewCompletedByUserId = n.GetStringValue(); } },
                {"reviewCompletedByUserPrincipalName", n => { ReviewCompletedByUserPrincipalName = n.GetStringValue(); } },
                {"reviewCompletedDateTime", n => { ReviewCompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewerJustification", n => { ReviewerJustification = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<ElevationRequestState>(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.ApplicationDetail>("applicationDetail", ApplicationDetail);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDateTimeOffsetValue("requestCreatedDateTime", RequestCreatedDateTime);
            writer.WriteStringValue("requestedByUserId", RequestedByUserId);
            writer.WriteStringValue("requestedByUserPrincipalName", RequestedByUserPrincipalName);
            writer.WriteStringValue("requestedOnDeviceId", RequestedOnDeviceId);
            writer.WriteDateTimeOffsetValue("requestExpiryDateTime", RequestExpiryDateTime);
            writer.WriteStringValue("requestJustification", RequestJustification);
            writer.WriteDateTimeOffsetValue("requestLastModifiedDateTime", RequestLastModifiedDateTime);
            writer.WriteStringValue("reviewCompletedByUserId", ReviewCompletedByUserId);
            writer.WriteStringValue("reviewCompletedByUserPrincipalName", ReviewCompletedByUserPrincipalName);
            writer.WriteDateTimeOffsetValue("reviewCompletedDateTime", ReviewCompletedDateTime);
            writer.WriteStringValue("reviewerJustification", ReviewerJustification);
            writer.WriteEnumValue<ElevationRequestState>("status", Status);
        }
    }
}
