// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.DeviceManagement {
    public class AlertRule : ApiSdk.Models.Entity, IParsable 
    {
        /// <summary>The rule template of the alert event. The possible values are: cloudPcProvisionScenario, cloudPcImageUploadScenario, cloudPcOnPremiseNetworkConnectionCheckScenario, cloudPcInGracePeriodScenario, cloudPcFrontlineInsufficientLicensesScenario, cloudPcInaccessibleScenario. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: cloudPcInGracePeriodScenario.</summary>
        public ApiSdk.Models.DeviceManagement.AlertRuleTemplate? AlertRuleTemplate { get; set; }
        /// <summary>The conditions that determine when to send alerts. For example, you can configure a condition to send an alert when provisioning fails for six or more Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RuleCondition>? Conditions { get; set; }
#nullable restore
#else
        public List<RuleCondition> Conditions { get; set; }
#endif
        /// <summary>The rule description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The status of the rule that indicates whether the rule is enabled or disabled. If true, the rule is enabled; otherwise, the rule is disabled.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Indicates whether the rule is a system rule. If true, the rule is a system rule; otherwise, the rule is a custom-defined rule and can be edited. System rules are built in and only a few properties can be edited.</summary>
        public bool? IsSystemRule { get; set; }
        /// <summary>The notification channels of the rule selected by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NotificationChannel>? NotificationChannels { get; set; }
#nullable restore
#else
        public List<NotificationChannel> NotificationChannels { get; set; }
#endif
        /// <summary>The severity of the rule. The possible values are: unknown, informational, warning, critical, unknownFutureValue.</summary>
        public RuleSeverityType? Severity { get; set; }
        /// <summary>The conditions that determine when to send alerts. For example, you can configure a condition to send an alert when provisioning fails for six or more Cloud PCs. This property is deprecated. Use conditions instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RuleThreshold? Threshold { get; set; }
#nullable restore
#else
        public RuleThreshold Threshold { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AlertRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AlertRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlertRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"alertRuleTemplate", n => { AlertRuleTemplate = n.GetEnumValue<AlertRuleTemplate>(); } },
                {"conditions", n => { Conditions = n.GetCollectionOfObjectValues<RuleCondition>(RuleCondition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"isSystemRule", n => { IsSystemRule = n.GetBoolValue(); } },
                {"notificationChannels", n => { NotificationChannels = n.GetCollectionOfObjectValues<NotificationChannel>(NotificationChannel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"severity", n => { Severity = n.GetEnumValue<RuleSeverityType>(); } },
                {"threshold", n => { Threshold = n.GetObjectValue<RuleThreshold>(RuleThreshold.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<AlertRuleTemplate>("alertRuleTemplate", AlertRuleTemplate);
            writer.WriteCollectionOfObjectValues<RuleCondition>("conditions", Conditions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteBoolValue("isSystemRule", IsSystemRule);
            writer.WriteCollectionOfObjectValues<NotificationChannel>("notificationChannels", NotificationChannels);
            writer.WriteEnumValue<RuleSeverityType>("severity", Severity);
            writer.WriteObjectValue<RuleThreshold>("threshold", Threshold);
        }
    }
}
