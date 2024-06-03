// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IdentityGovernance
{
    #pragma warning disable CS1591
    public class IdentityGovernance : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessReviews property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AccessReviewSet? AccessReviews { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AccessReviewSet AccessReviews { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The appConsent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AppConsentApprovalRoute? AppConsent { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AppConsentApprovalRoute AppConsent { get; set; }
#endif
        /// <summary>The entitlementManagement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.EntitlementManagement? EntitlementManagement { get; set; }
#nullable restore
#else
        public ApiSdk.Models.EntitlementManagement EntitlementManagement { get; set; }
#endif
        /// <summary>The lifecycleWorkflows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LifecycleWorkflowsContainer? LifecycleWorkflows { get; set; }
#nullable restore
#else
        public LifecycleWorkflowsContainer LifecycleWorkflows { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The permissionsAnalytics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PermissionsAnalyticsAggregation? PermissionsAnalytics { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PermissionsAnalyticsAggregation PermissionsAnalytics { get; set; }
#endif
        /// <summary>The permissionsManagement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PermissionsManagement? PermissionsManagement { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PermissionsManagement PermissionsManagement { get; set; }
#endif
        /// <summary>The privilegedAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PrivilegedAccessRoot? PrivilegedAccess { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PrivilegedAccessRoot PrivilegedAccess { get; set; }
#endif
        /// <summary>The roleManagementAlerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RoleManagementAlert? RoleManagementAlerts { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RoleManagementAlert RoleManagementAlerts { get; set; }
#endif
        /// <summary>The termsOfUse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.TermsOfUseContainer? TermsOfUse { get; set; }
#nullable restore
#else
        public ApiSdk.Models.TermsOfUseContainer TermsOfUse { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IdentityGovernance"/> and sets the default values.
        /// </summary>
        public IdentityGovernance()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IdentityGovernance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IdentityGovernance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityGovernance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessReviews", n => { AccessReviews = n.GetObjectValue<ApiSdk.Models.AccessReviewSet>(ApiSdk.Models.AccessReviewSet.CreateFromDiscriminatorValue); } },
                { "appConsent", n => { AppConsent = n.GetObjectValue<ApiSdk.Models.AppConsentApprovalRoute>(ApiSdk.Models.AppConsentApprovalRoute.CreateFromDiscriminatorValue); } },
                { "entitlementManagement", n => { EntitlementManagement = n.GetObjectValue<ApiSdk.Models.EntitlementManagement>(ApiSdk.Models.EntitlementManagement.CreateFromDiscriminatorValue); } },
                { "lifecycleWorkflows", n => { LifecycleWorkflows = n.GetObjectValue<LifecycleWorkflowsContainer>(LifecycleWorkflowsContainer.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "permissionsAnalytics", n => { PermissionsAnalytics = n.GetObjectValue<ApiSdk.Models.PermissionsAnalyticsAggregation>(ApiSdk.Models.PermissionsAnalyticsAggregation.CreateFromDiscriminatorValue); } },
                { "permissionsManagement", n => { PermissionsManagement = n.GetObjectValue<ApiSdk.Models.PermissionsManagement>(ApiSdk.Models.PermissionsManagement.CreateFromDiscriminatorValue); } },
                { "privilegedAccess", n => { PrivilegedAccess = n.GetObjectValue<ApiSdk.Models.PrivilegedAccessRoot>(ApiSdk.Models.PrivilegedAccessRoot.CreateFromDiscriminatorValue); } },
                { "roleManagementAlerts", n => { RoleManagementAlerts = n.GetObjectValue<ApiSdk.Models.RoleManagementAlert>(ApiSdk.Models.RoleManagementAlert.CreateFromDiscriminatorValue); } },
                { "termsOfUse", n => { TermsOfUse = n.GetObjectValue<ApiSdk.Models.TermsOfUseContainer>(ApiSdk.Models.TermsOfUseContainer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.AccessReviewSet>("accessReviews", AccessReviews);
            writer.WriteObjectValue<ApiSdk.Models.AppConsentApprovalRoute>("appConsent", AppConsent);
            writer.WriteObjectValue<ApiSdk.Models.EntitlementManagement>("entitlementManagement", EntitlementManagement);
            writer.WriteObjectValue<LifecycleWorkflowsContainer>("lifecycleWorkflows", LifecycleWorkflows);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ApiSdk.Models.PermissionsAnalyticsAggregation>("permissionsAnalytics", PermissionsAnalytics);
            writer.WriteObjectValue<ApiSdk.Models.PermissionsManagement>("permissionsManagement", PermissionsManagement);
            writer.WriteObjectValue<ApiSdk.Models.PrivilegedAccessRoot>("privilegedAccess", PrivilegedAccess);
            writer.WriteObjectValue<ApiSdk.Models.RoleManagementAlert>("roleManagementAlerts", RoleManagementAlerts);
            writer.WriteObjectValue<ApiSdk.Models.TermsOfUseContainer>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
