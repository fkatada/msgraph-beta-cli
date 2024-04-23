// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The DepIOSEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile specific to iOS configuration. This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
    /// </summary>
    public class DepIOSEnrollmentProfile : DepEnrollmentBaseProfile, IParsable 
    {
        /// <summary>Indicates if Apperance screen is disabled</summary>
        public bool? AppearanceScreenDisabled { get; set; }
        /// <summary>Indicates if the device will need to wait for configured confirmation</summary>
        public bool? AwaitDeviceConfiguredConfirmation { get; set; }
        /// <summary>Carrier URL for activating device eSIM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CarrierActivationUrl { get; set; }
#nullable restore
#else
        public string CarrierActivationUrl { get; set; }
#endif
        /// <summary>If set, indicates which Vpp token should be used to deploy the Company Portal w/ device licensing. &apos;enableAuthenticationViaCompanyPortal&apos; must be set in order for this property to be set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyPortalVppTokenId { get; set; }
#nullable restore
#else
        public string CompanyPortalVppTokenId { get; set; }
#endif
        /// <summary>Indicates if Device To Device Migration is disabled</summary>
        public bool? DeviceToDeviceMigrationDisabled { get; set; }
        /// <summary>This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.</summary>
        public bool? EnableSharedIPad { get; set; }
        /// <summary>Tells the device to enable single app mode and apply app-lock during enrollment. Default is false. &apos;enableAuthenticationViaCompanyPortal&apos; and &apos;companyPortalVppTokenId&apos; must be set for this property to be set.</summary>
        public bool? EnableSingleAppEnrollmentMode { get; set; }
        /// <summary>Indicates if Express Language screen is disabled</summary>
        public bool? ExpressLanguageScreenDisabled { get; set; }
        /// <summary>Indicates if temporary sessions is enabled</summary>
        public bool? ForceTemporarySession { get; set; }
        /// <summary>Indicates if home button sensitivity screen is disabled</summary>
        public bool? HomeButtonScreenDisabled { get; set; }
        /// <summary>Indicates if iMessage and FaceTime screen is disabled</summary>
        public bool? IMessageAndFaceTimeScreenDisabled { get; set; }
        /// <summary>The iTunesPairingMode property</summary>
        public ApiSdk.Models.ITunesPairingMode? ITunesPairingMode { get; set; }
        /// <summary>Management certificates for Apple Configurator</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementCertificateWithThumbprint>? ManagementCertificates { get; set; }
#nullable restore
#else
        public List<ManagementCertificateWithThumbprint> ManagementCertificates { get; set; }
#endif
        /// <summary>Indicates if onboarding setup screen is disabled</summary>
        public bool? OnBoardingScreenDisabled { get; set; }
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled { get; set; }
        /// <summary>Indicates timeout before locked screen requires the user to enter the device passocde to unlock it</summary>
        public int? PasscodeLockGracePeriodInSeconds { get; set; }
        /// <summary>Indicates if Preferred language screen is disabled</summary>
        public bool? PreferredLanguageScreenDisabled { get; set; }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? RestoreCompletedScreenDisabled { get; set; }
        /// <summary>Indicates if Restore from Android is disabled</summary>
        public bool? RestoreFromAndroidDisabled { get; set; }
        /// <summary>This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.</summary>
        public int? SharedIPadMaximumUserCount { get; set; }
        /// <summary>Indicates if the SIMSetup screen is disabled</summary>
        public bool? SimSetupScreenDisabled { get; set; }
        /// <summary>Indicates if the mandatory sofware update screen is disabled</summary>
        public bool? SoftwareUpdateScreenDisabled { get; set; }
        /// <summary>Indicates timeout of temporary session</summary>
        public int? TemporarySessionTimeoutInSeconds { get; set; }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? UpdateCompleteScreenDisabled { get; set; }
        /// <summary>Indicates that this apple device is designated to support &apos;shared device mode&apos; scenarios. This is distinct from the &apos;shared iPad&apos; scenario. See https://learn.microsoft.com/mem/intune/enrollment/device-enrollment-shared-ios</summary>
        public bool? UserlessSharedAadModeEnabled { get; set; }
        /// <summary>Indicates timeout of temporary session</summary>
        public int? UserSessionTimeoutInSeconds { get; set; }
        /// <summary>Indicates if the watch migration screen is disabled</summary>
        public bool? WatchMigrationScreenDisabled { get; set; }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? WelcomeScreenDisabled { get; set; }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DepIOSEnrollmentProfile"/> and sets the default values.
        /// </summary>
        public DepIOSEnrollmentProfile() : base()
        {
            OdataType = "#microsoft.graph.depIOSEnrollmentProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DepIOSEnrollmentProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DepIOSEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepIOSEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"appearanceScreenDisabled", n => { AppearanceScreenDisabled = n.GetBoolValue(); } },
                {"awaitDeviceConfiguredConfirmation", n => { AwaitDeviceConfiguredConfirmation = n.GetBoolValue(); } },
                {"carrierActivationUrl", n => { CarrierActivationUrl = n.GetStringValue(); } },
                {"companyPortalVppTokenId", n => { CompanyPortalVppTokenId = n.GetStringValue(); } },
                {"deviceToDeviceMigrationDisabled", n => { DeviceToDeviceMigrationDisabled = n.GetBoolValue(); } },
                {"enableSharedIPad", n => { EnableSharedIPad = n.GetBoolValue(); } },
                {"enableSingleAppEnrollmentMode", n => { EnableSingleAppEnrollmentMode = n.GetBoolValue(); } },
                {"expressLanguageScreenDisabled", n => { ExpressLanguageScreenDisabled = n.GetBoolValue(); } },
                {"forceTemporarySession", n => { ForceTemporarySession = n.GetBoolValue(); } },
                {"homeButtonScreenDisabled", n => { HomeButtonScreenDisabled = n.GetBoolValue(); } },
                {"iMessageAndFaceTimeScreenDisabled", n => { IMessageAndFaceTimeScreenDisabled = n.GetBoolValue(); } },
                {"iTunesPairingMode", n => { ITunesPairingMode = n.GetEnumValue<ITunesPairingMode>(); } },
                {"managementCertificates", n => { ManagementCertificates = n.GetCollectionOfObjectValues<ManagementCertificateWithThumbprint>(ManagementCertificateWithThumbprint.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onBoardingScreenDisabled", n => { OnBoardingScreenDisabled = n.GetBoolValue(); } },
                {"passCodeDisabled", n => { PassCodeDisabled = n.GetBoolValue(); } },
                {"passcodeLockGracePeriodInSeconds", n => { PasscodeLockGracePeriodInSeconds = n.GetIntValue(); } },
                {"preferredLanguageScreenDisabled", n => { PreferredLanguageScreenDisabled = n.GetBoolValue(); } },
                {"restoreCompletedScreenDisabled", n => { RestoreCompletedScreenDisabled = n.GetBoolValue(); } },
                {"restoreFromAndroidDisabled", n => { RestoreFromAndroidDisabled = n.GetBoolValue(); } },
                {"sharedIPadMaximumUserCount", n => { SharedIPadMaximumUserCount = n.GetIntValue(); } },
                {"simSetupScreenDisabled", n => { SimSetupScreenDisabled = n.GetBoolValue(); } },
                {"softwareUpdateScreenDisabled", n => { SoftwareUpdateScreenDisabled = n.GetBoolValue(); } },
                {"temporarySessionTimeoutInSeconds", n => { TemporarySessionTimeoutInSeconds = n.GetIntValue(); } },
                {"updateCompleteScreenDisabled", n => { UpdateCompleteScreenDisabled = n.GetBoolValue(); } },
                {"userSessionTimeoutInSeconds", n => { UserSessionTimeoutInSeconds = n.GetIntValue(); } },
                {"userlessSharedAadModeEnabled", n => { UserlessSharedAadModeEnabled = n.GetBoolValue(); } },
                {"watchMigrationScreenDisabled", n => { WatchMigrationScreenDisabled = n.GetBoolValue(); } },
                {"welcomeScreenDisabled", n => { WelcomeScreenDisabled = n.GetBoolValue(); } },
                {"zoomDisabled", n => { ZoomDisabled = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("appearanceScreenDisabled", AppearanceScreenDisabled);
            writer.WriteBoolValue("awaitDeviceConfiguredConfirmation", AwaitDeviceConfiguredConfirmation);
            writer.WriteStringValue("carrierActivationUrl", CarrierActivationUrl);
            writer.WriteStringValue("companyPortalVppTokenId", CompanyPortalVppTokenId);
            writer.WriteBoolValue("deviceToDeviceMigrationDisabled", DeviceToDeviceMigrationDisabled);
            writer.WriteBoolValue("enableSharedIPad", EnableSharedIPad);
            writer.WriteBoolValue("enableSingleAppEnrollmentMode", EnableSingleAppEnrollmentMode);
            writer.WriteBoolValue("expressLanguageScreenDisabled", ExpressLanguageScreenDisabled);
            writer.WriteBoolValue("forceTemporarySession", ForceTemporarySession);
            writer.WriteBoolValue("homeButtonScreenDisabled", HomeButtonScreenDisabled);
            writer.WriteBoolValue("iMessageAndFaceTimeScreenDisabled", IMessageAndFaceTimeScreenDisabled);
            writer.WriteEnumValue<ITunesPairingMode>("iTunesPairingMode", ITunesPairingMode);
            writer.WriteCollectionOfObjectValues<ManagementCertificateWithThumbprint>("managementCertificates", ManagementCertificates);
            writer.WriteBoolValue("onBoardingScreenDisabled", OnBoardingScreenDisabled);
            writer.WriteBoolValue("passCodeDisabled", PassCodeDisabled);
            writer.WriteIntValue("passcodeLockGracePeriodInSeconds", PasscodeLockGracePeriodInSeconds);
            writer.WriteBoolValue("preferredLanguageScreenDisabled", PreferredLanguageScreenDisabled);
            writer.WriteBoolValue("restoreCompletedScreenDisabled", RestoreCompletedScreenDisabled);
            writer.WriteBoolValue("restoreFromAndroidDisabled", RestoreFromAndroidDisabled);
            writer.WriteIntValue("sharedIPadMaximumUserCount", SharedIPadMaximumUserCount);
            writer.WriteBoolValue("simSetupScreenDisabled", SimSetupScreenDisabled);
            writer.WriteBoolValue("softwareUpdateScreenDisabled", SoftwareUpdateScreenDisabled);
            writer.WriteIntValue("temporarySessionTimeoutInSeconds", TemporarySessionTimeoutInSeconds);
            writer.WriteBoolValue("updateCompleteScreenDisabled", UpdateCompleteScreenDisabled);
            writer.WriteBoolValue("userlessSharedAadModeEnabled", UserlessSharedAadModeEnabled);
            writer.WriteIntValue("userSessionTimeoutInSeconds", UserSessionTimeoutInSeconds);
            writer.WriteBoolValue("watchMigrationScreenDisabled", WatchMigrationScreenDisabled);
            writer.WriteBoolValue("welcomeScreenDisabled", WelcomeScreenDisabled);
            writer.WriteBoolValue("zoomDisabled", ZoomDisabled);
        }
    }
}
