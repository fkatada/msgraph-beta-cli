// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Windows 10 Enrollment Status Page Configuration
    /// </summary>
    public class Windows10EnrollmentCompletionPageConfiguration : DeviceEnrollmentConfiguration, IParsable
    {
        /// <summary>When TRUE, allows device reset on installation failure. When false, reset is blocked. The default is false.</summary>
        public bool? AllowDeviceResetOnInstallFailure { get; set; }
        /// <summary>When TRUE, allows the user to continue using the device on installation failure. When false, blocks the user on installation failure. The default is false.</summary>
        public bool? AllowDeviceUseOnInstallFailure { get; set; }
        /// <summary>When TRUE, allows log collection on installation failure. When false, log collection is not allowed. The default is false.</summary>
        public bool? AllowLogCollectionOnInstallFailure { get; set; }
        /// <summary>When TRUE, ESP (Enrollment Status Page) installs all required apps targeted during technician phase and ignores any failures for non-blocking apps. When FALSE, ESP fails on any error during app install. The default is false.</summary>
        public bool? AllowNonBlockingAppInstallation { get; set; }
        /// <summary>When TRUE, blocks user from retrying the setup on installation failure. When false, user is allowed to retry. The default is false.</summary>
        public bool? BlockDeviceSetupRetryByUser { get; set; }
        /// <summary>The custom error message to show upon installation failure. Max length is 10000. example: &apos;Setup could not be completed. Please try again or contact your support person for help.&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomErrorMessage { get; set; }
#nullable restore
#else
        public string CustomErrorMessage { get; set; }
#endif
        /// <summary>When TRUE, disables showing installation progress for first user post enrollment. When false, enables showing progress. The default is false.</summary>
        public bool? DisableUserStatusTrackingAfterFirstUser { get; set; }
        /// <summary>The installation progress timeout in minutes. Default is 60 minutes.</summary>
        public int? InstallProgressTimeoutInMinutes { get; set; }
        /// <summary>Allows quality updates installation during OOBE</summary>
        public bool? InstallQualityUpdates { get; set; }
        /// <summary>Selected applications to track the installation status. It is in the form of an array of GUIDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SelectedMobileAppIds { get; set; }
#nullable restore
#else
        public List<string> SelectedMobileAppIds { get; set; }
#endif
        /// <summary>When TRUE, shows installation progress to user. When false, hides installation progress. The default is false.</summary>
        public bool? ShowInstallationProgress { get; set; }
        /// <summary>When TRUE, installation progress is tracked for only Autopilot enrollment scenarios. When false, other scenarios are tracked as well. The default is false.</summary>
        public bool? TrackInstallProgressForAutopilotOnly { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Windows10EnrollmentCompletionPageConfiguration"/> and sets the default values.
        /// </summary>
        public Windows10EnrollmentCompletionPageConfiguration() : base()
        {
            OdataType = "#microsoft.graph.windows10EnrollmentCompletionPageConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Windows10EnrollmentCompletionPageConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10EnrollmentCompletionPageConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EnrollmentCompletionPageConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowDeviceResetOnInstallFailure", n => { AllowDeviceResetOnInstallFailure = n.GetBoolValue(); } },
                { "allowDeviceUseOnInstallFailure", n => { AllowDeviceUseOnInstallFailure = n.GetBoolValue(); } },
                { "allowLogCollectionOnInstallFailure", n => { AllowLogCollectionOnInstallFailure = n.GetBoolValue(); } },
                { "allowNonBlockingAppInstallation", n => { AllowNonBlockingAppInstallation = n.GetBoolValue(); } },
                { "blockDeviceSetupRetryByUser", n => { BlockDeviceSetupRetryByUser = n.GetBoolValue(); } },
                { "customErrorMessage", n => { CustomErrorMessage = n.GetStringValue(); } },
                { "disableUserStatusTrackingAfterFirstUser", n => { DisableUserStatusTrackingAfterFirstUser = n.GetBoolValue(); } },
                { "installProgressTimeoutInMinutes", n => { InstallProgressTimeoutInMinutes = n.GetIntValue(); } },
                { "installQualityUpdates", n => { InstallQualityUpdates = n.GetBoolValue(); } },
                { "selectedMobileAppIds", n => { SelectedMobileAppIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "showInstallationProgress", n => { ShowInstallationProgress = n.GetBoolValue(); } },
                { "trackInstallProgressForAutopilotOnly", n => { TrackInstallProgressForAutopilotOnly = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("allowDeviceResetOnInstallFailure", AllowDeviceResetOnInstallFailure);
            writer.WriteBoolValue("allowDeviceUseOnInstallFailure", AllowDeviceUseOnInstallFailure);
            writer.WriteBoolValue("allowLogCollectionOnInstallFailure", AllowLogCollectionOnInstallFailure);
            writer.WriteBoolValue("allowNonBlockingAppInstallation", AllowNonBlockingAppInstallation);
            writer.WriteBoolValue("blockDeviceSetupRetryByUser", BlockDeviceSetupRetryByUser);
            writer.WriteStringValue("customErrorMessage", CustomErrorMessage);
            writer.WriteBoolValue("disableUserStatusTrackingAfterFirstUser", DisableUserStatusTrackingAfterFirstUser);
            writer.WriteIntValue("installProgressTimeoutInMinutes", InstallProgressTimeoutInMinutes);
            writer.WriteBoolValue("installQualityUpdates", InstallQualityUpdates);
            writer.WriteCollectionOfPrimitiveValues<string>("selectedMobileAppIds", SelectedMobileAppIds);
            writer.WriteBoolValue("showInstallationProgress", ShowInstallationProgress);
            writer.WriteBoolValue("trackInstallProgressForAutopilotOnly", TrackInstallProgressForAutopilotOnly);
        }
    }
}
