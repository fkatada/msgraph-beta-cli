// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.DeviceManagement {
    public class PortalNotification : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The associated alert impact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DeviceManagement.AlertImpact? AlertImpact { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DeviceManagement.AlertImpact AlertImpact { get; set; }
#endif
        /// <summary>The associated alert record ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertRecordId { get; set; }
#nullable restore
#else
        public string AlertRecordId { get; set; }
#endif
        /// <summary>The associated alert rule ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertRuleId { get; set; }
#nullable restore
#else
        public string AlertRuleId { get; set; }
#endif
        /// <summary>The associated alert rule name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertRuleName { get; set; }
#nullable restore
#else
        public string AlertRuleName { get; set; }
#endif
        /// <summary>The associated alert rule template. The possible values are: cloudPcProvisionScenario, cloudPcImageUploadScenario, cloudPcOnPremiseNetworkConnectionCheckScenario, unknownFutureValue, cloudPcInGracePeriodScenario. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: cloudPcInGracePeriodScenario.</summary>
        public ApiSdk.Models.DeviceManagement.AlertRuleTemplate? AlertRuleTemplate { get; set; }
        /// <summary>The unique identifier for the portal notification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>true if the portal notification has already been sent to the user; false otherwise.</summary>
        public bool? IsPortalNotificationSent { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The associated alert rule severity. The possible values are: unknown, informational, warning, critical, unknownFutureValue.</summary>
        public RuleSeverityType? Severity { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PortalNotification"/> and sets the default values.
        /// </summary>
        public PortalNotification()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PortalNotification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PortalNotification CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PortalNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"alertImpact", n => { AlertImpact = n.GetObjectValue<ApiSdk.Models.DeviceManagement.AlertImpact>(ApiSdk.Models.DeviceManagement.AlertImpact.CreateFromDiscriminatorValue); } },
                {"alertRecordId", n => { AlertRecordId = n.GetStringValue(); } },
                {"alertRuleId", n => { AlertRuleId = n.GetStringValue(); } },
                {"alertRuleName", n => { AlertRuleName = n.GetStringValue(); } },
                {"alertRuleTemplate", n => { AlertRuleTemplate = n.GetEnumValue<AlertRuleTemplate>(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isPortalNotificationSent", n => { IsPortalNotificationSent = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<RuleSeverityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.DeviceManagement.AlertImpact>("alertImpact", AlertImpact);
            writer.WriteStringValue("alertRecordId", AlertRecordId);
            writer.WriteStringValue("alertRuleId", AlertRuleId);
            writer.WriteStringValue("alertRuleName", AlertRuleName);
            writer.WriteEnumValue<AlertRuleTemplate>("alertRuleTemplate", AlertRuleTemplate);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isPortalNotificationSent", IsPortalNotificationSent);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RuleSeverityType>("severity", Severity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
