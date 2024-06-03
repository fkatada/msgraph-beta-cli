// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an Android device
    /// </summary>
    public class AndroidManagedAppProtection : TargetedManagedAppProtection, IParsable
    {
        /// <summary>Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AllowedAndroidDeviceManufacturers { get; set; }
#nullable restore
#else
        public string AllowedAndroidDeviceManufacturers { get; set; }
#endif
        /// <summary>List of device models allowed, as a string, for the managed app to work.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedAndroidDeviceModels { get; set; }
#nullable restore
#else
        public List<string> AllowedAndroidDeviceModels { get; set; }
#endif
        /// <summary>Defines a managed app behavior, either block or warn, if the user is clocked out (non-working time). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAccountIsClockedOut { get; set; }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed { get; set; }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceModelNotAllowed { get; set; }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed { get; set; }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed { get; set; }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceLockNotSet { get; set; }
        /// <summary>If the device does not have a passcode of high complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanHigh { get; set; }
        /// <summary>If the device does not have a passcode of low complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanLow { get; set; }
        /// <summary>If the device does not have a passcode of medium complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanMedium { get; set; }
        /// <summary>Defines the behavior of a managed app when Samsung Knox Attestation is required. Possible values are null, warn, block &amp; wipe. If the admin does not set this action, the default is null, which indicates this setting is not configured. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfSamsungKnoxAttestationRequired { get; set; }
        /// <summary>If Keyboard Restriction is enabled, only keyboards in this approved list will be allowed. A key should be Android package id for a keyboard and value should be a friendly name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? ApprovedKeyboards { get; set; }
#nullable restore
#else
        public List<KeyValuePair> ApprovedKeyboards { get; set; }
#endif
        /// <summary>List of apps to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedMobileApp>? Apps { get; set; }
#nullable restore
#else
        public List<ManagedMobileApp> Apps { get; set; }
#endif
        /// <summary>Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? BiometricAuthenticationBlocked { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.</summary>
        public int? BlockAfterCompanyPortalUpdateDeferralInDays { get; set; }
        /// <summary>Whether the app should connect to the configured VPN on launch.</summary>
        public bool? ConnectToVpnOnLaunch { get; set; }
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserDisplayName { get; set; }
#nullable restore
#else
        public string CustomBrowserDisplayName { get; set; }
#endif
        /// <summary>Unique identifier of the preferred custom browser to open weblink on Android. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserPackageId { get; set; }
#nullable restore
#else
        public string CustomBrowserPackageId { get; set; }
#endif
        /// <summary>Friendly name of a custom dialer app to click-to-open a phone number on Android.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDialerAppDisplayName { get; set; }
#nullable restore
#else
        public string CustomDialerAppDisplayName { get; set; }
#endif
        /// <summary>PackageId of a custom dialer app to click-to-open a phone number on Android.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDialerAppPackageId { get; set; }
#nullable restore
#else
        public string CustomDialerAppPackageId { get; set; }
#endif
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedAppPolicyDeploymentSummary? DeploymentSummary { get; set; }
#nullable restore
#else
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
#endif
        /// <summary>Defines if any kind of lock must be required on android device</summary>
        public bool? DeviceLockRequired { get; set; }
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
        /// <summary>Indicates whether application data for managed apps should be encrypted</summary>
        public bool? EncryptAppData { get; set; }
        /// <summary>App packages in this list will be exempt from the policy and will be able to receive data from managed apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? ExemptedAppPackages { get; set; }
#nullable restore
#else
        public List<KeyValuePair> ExemptedAppPackages { get; set; }
#endif
        /// <summary>If null, this setting will be ignored. If false both fingerprints and biometrics will not be enabled. If true, both fingerprints and biometrics will be enabled.</summary>
        public bool? FingerprintAndBiometricEnabled { get; set; }
        /// <summary>Indicates if keyboard restriction is enabled. If enabled list of approved keyboards must be provided as well.</summary>
        public bool? KeyboardsRestricted { get; set; }
        /// <summary>When a specific app redirection is enforced by protectedMessagingRedirectAppType in an App Protection Policy, this value defines the app name which is allowed to be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessagingRedirectAppDisplayName { get; set; }
#nullable restore
#else
        public string MessagingRedirectAppDisplayName { get; set; }
#endif
        /// <summary>When a specific app redirection is enforced by protectedMessagingRedirectAppType in an App Protection Policy, this value defines the app package id which is allowed to be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessagingRedirectAppPackageId { get; set; }
#nullable restore
#else
        public string MessagingRedirectAppPackageId { get; set; }
#endif
        /// <summary>Minimum version of the Company portal that must be installed on the device or app access will be blocked</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredCompanyPortalVersion { get; set; }
#nullable restore
#else
        public string MinimumRequiredCompanyPortalVersion { get; set; }
#endif
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredPatchVersion { get; set; }
#nullable restore
#else
        public string MinimumRequiredPatchVersion { get; set; }
#endif
        /// <summary>Minimum version of the Company portal that must be installed on the device or the user will receive a warning</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningCompanyPortalVersion { get; set; }
#nullable restore
#else
        public string MinimumWarningCompanyPortalVersion { get; set; }
#endif
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningPatchVersion { get; set; }
#nullable restore
#else
        public string MinimumWarningPatchVersion { get; set; }
#endif
        /// <summary>Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipeCompanyPortalVersion { get; set; }
#nullable restore
#else
        public string MinimumWipeCompanyPortalVersion { get; set; }
#endif
        /// <summary>Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipePatchVersion { get; set; }
#nullable restore
#else
        public string MinimumWipePatchVersion { get; set; }
#endif
        /// <summary>Require user to apply Class 3 Biometrics on their Android device.</summary>
        public bool? RequireClass3Biometrics { get; set; }
        /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType { get; set; }
        /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType { get; set; }
        /// <summary>An admin enforced Android SafetyNet evaluation type requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetEvaluationType? RequiredAndroidSafetyNetEvaluationType { get; set; }
        /// <summary>A PIN prompt will override biometric prompts if class 3 biometrics are updated on the device.</summary>
        public bool? RequirePinAfterBiometricChange { get; set; }
        /// <summary>Indicates whether a managed user can take screen captures of managed apps</summary>
        public bool? ScreenCaptureBlocked { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning</summary>
        public int? WarnAfterCompanyPortalUpdateDeferralInDays { get; set; }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped</summary>
        public int? WipeAfterCompanyPortalUpdateDeferralInDays { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AndroidManagedAppProtection"/> and sets the default values.
        /// </summary>
        public AndroidManagedAppProtection() : base()
        {
            OdataType = "#microsoft.graph.androidManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidManagedAppProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedAndroidDeviceManufacturers", n => { AllowedAndroidDeviceManufacturers = n.GetStringValue(); } },
                { "allowedAndroidDeviceModels", n => { AllowedAndroidDeviceModels = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "appActionIfAccountIsClockedOut", n => { AppActionIfAccountIsClockedOut = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfAndroidDeviceManufacturerNotAllowed", n => { AppActionIfAndroidDeviceManufacturerNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfAndroidDeviceModelNotAllowed", n => { AppActionIfAndroidDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfAndroidSafetyNetAppsVerificationFailed", n => { AppActionIfAndroidSafetyNetAppsVerificationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfAndroidSafetyNetDeviceAttestationFailed", n => { AppActionIfAndroidSafetyNetDeviceAttestationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfDeviceLockNotSet", n => { AppActionIfDeviceLockNotSet = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfDevicePasscodeComplexityLessThanHigh", n => { AppActionIfDevicePasscodeComplexityLessThanHigh = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfDevicePasscodeComplexityLessThanLow", n => { AppActionIfDevicePasscodeComplexityLessThanLow = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfDevicePasscodeComplexityLessThanMedium", n => { AppActionIfDevicePasscodeComplexityLessThanMedium = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "appActionIfSamsungKnoxAttestationRequired", n => { AppActionIfSamsungKnoxAttestationRequired = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                { "approvedKeyboards", n => { ApprovedKeyboards = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                { "biometricAuthenticationBlocked", n => { BiometricAuthenticationBlocked = n.GetBoolValue(); } },
                { "blockAfterCompanyPortalUpdateDeferralInDays", n => { BlockAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                { "connectToVpnOnLaunch", n => { ConnectToVpnOnLaunch = n.GetBoolValue(); } },
                { "customBrowserDisplayName", n => { CustomBrowserDisplayName = n.GetStringValue(); } },
                { "customBrowserPackageId", n => { CustomBrowserPackageId = n.GetStringValue(); } },
                { "customDialerAppDisplayName", n => { CustomDialerAppDisplayName = n.GetStringValue(); } },
                { "customDialerAppPackageId", n => { CustomDialerAppPackageId = n.GetStringValue(); } },
                { "deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                { "deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                { "deviceLockRequired", n => { DeviceLockRequired = n.GetBoolValue(); } },
                { "disableAppEncryptionIfDeviceEncryptionIsEnabled", n => { DisableAppEncryptionIfDeviceEncryptionIsEnabled = n.GetBoolValue(); } },
                { "encryptAppData", n => { EncryptAppData = n.GetBoolValue(); } },
                { "exemptedAppPackages", n => { ExemptedAppPackages = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "fingerprintAndBiometricEnabled", n => { FingerprintAndBiometricEnabled = n.GetBoolValue(); } },
                { "keyboardsRestricted", n => { KeyboardsRestricted = n.GetBoolValue(); } },
                { "messagingRedirectAppDisplayName", n => { MessagingRedirectAppDisplayName = n.GetStringValue(); } },
                { "messagingRedirectAppPackageId", n => { MessagingRedirectAppPackageId = n.GetStringValue(); } },
                { "minimumRequiredCompanyPortalVersion", n => { MinimumRequiredCompanyPortalVersion = n.GetStringValue(); } },
                { "minimumRequiredPatchVersion", n => { MinimumRequiredPatchVersion = n.GetStringValue(); } },
                { "minimumWarningCompanyPortalVersion", n => { MinimumWarningCompanyPortalVersion = n.GetStringValue(); } },
                { "minimumWarningPatchVersion", n => { MinimumWarningPatchVersion = n.GetStringValue(); } },
                { "minimumWipeCompanyPortalVersion", n => { MinimumWipeCompanyPortalVersion = n.GetStringValue(); } },
                { "minimumWipePatchVersion", n => { MinimumWipePatchVersion = n.GetStringValue(); } },
                { "requireClass3Biometrics", n => { RequireClass3Biometrics = n.GetBoolValue(); } },
                { "requirePinAfterBiometricChange", n => { RequirePinAfterBiometricChange = n.GetBoolValue(); } },
                { "requiredAndroidSafetyNetAppsVerificationType", n => { RequiredAndroidSafetyNetAppsVerificationType = n.GetEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>(); } },
                { "requiredAndroidSafetyNetDeviceAttestationType", n => { RequiredAndroidSafetyNetDeviceAttestationType = n.GetEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>(); } },
                { "requiredAndroidSafetyNetEvaluationType", n => { RequiredAndroidSafetyNetEvaluationType = n.GetEnumValue<AndroidManagedAppSafetyNetEvaluationType>(); } },
                { "screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                { "warnAfterCompanyPortalUpdateDeferralInDays", n => { WarnAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                { "wipeAfterCompanyPortalUpdateDeferralInDays", n => { WipeAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
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
            writer.WriteStringValue("allowedAndroidDeviceManufacturers", AllowedAndroidDeviceManufacturers);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedAndroidDeviceModels", AllowedAndroidDeviceModels);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAccountIsClockedOut", AppActionIfAccountIsClockedOut);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceManufacturerNotAllowed", AppActionIfAndroidDeviceManufacturerNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceModelNotAllowed", AppActionIfAndroidDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetAppsVerificationFailed", AppActionIfAndroidSafetyNetAppsVerificationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetDeviceAttestationFailed", AppActionIfAndroidSafetyNetDeviceAttestationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDeviceLockNotSet", AppActionIfDeviceLockNotSet);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanHigh", AppActionIfDevicePasscodeComplexityLessThanHigh);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanLow", AppActionIfDevicePasscodeComplexityLessThanLow);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanMedium", AppActionIfDevicePasscodeComplexityLessThanMedium);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfSamsungKnoxAttestationRequired", AppActionIfSamsungKnoxAttestationRequired);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("approvedKeyboards", ApprovedKeyboards);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteBoolValue("biometricAuthenticationBlocked", BiometricAuthenticationBlocked);
            writer.WriteIntValue("blockAfterCompanyPortalUpdateDeferralInDays", BlockAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteBoolValue("connectToVpnOnLaunch", ConnectToVpnOnLaunch);
            writer.WriteStringValue("customBrowserDisplayName", CustomBrowserDisplayName);
            writer.WriteStringValue("customBrowserPackageId", CustomBrowserPackageId);
            writer.WriteStringValue("customDialerAppDisplayName", CustomDialerAppDisplayName);
            writer.WriteStringValue("customDialerAppPackageId", CustomDialerAppPackageId);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("deviceLockRequired", DeviceLockRequired);
            writer.WriteBoolValue("disableAppEncryptionIfDeviceEncryptionIsEnabled", DisableAppEncryptionIfDeviceEncryptionIsEnabled);
            writer.WriteBoolValue("encryptAppData", EncryptAppData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("exemptedAppPackages", ExemptedAppPackages);
            writer.WriteBoolValue("fingerprintAndBiometricEnabled", FingerprintAndBiometricEnabled);
            writer.WriteBoolValue("keyboardsRestricted", KeyboardsRestricted);
            writer.WriteStringValue("messagingRedirectAppDisplayName", MessagingRedirectAppDisplayName);
            writer.WriteStringValue("messagingRedirectAppPackageId", MessagingRedirectAppPackageId);
            writer.WriteStringValue("minimumRequiredCompanyPortalVersion", MinimumRequiredCompanyPortalVersion);
            writer.WriteStringValue("minimumRequiredPatchVersion", MinimumRequiredPatchVersion);
            writer.WriteStringValue("minimumWarningCompanyPortalVersion", MinimumWarningCompanyPortalVersion);
            writer.WriteStringValue("minimumWarningPatchVersion", MinimumWarningPatchVersion);
            writer.WriteStringValue("minimumWipeCompanyPortalVersion", MinimumWipeCompanyPortalVersion);
            writer.WriteStringValue("minimumWipePatchVersion", MinimumWipePatchVersion);
            writer.WriteBoolValue("requireClass3Biometrics", RequireClass3Biometrics);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>("requiredAndroidSafetyNetAppsVerificationType", RequiredAndroidSafetyNetAppsVerificationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>("requiredAndroidSafetyNetDeviceAttestationType", RequiredAndroidSafetyNetDeviceAttestationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetEvaluationType>("requiredAndroidSafetyNetEvaluationType", RequiredAndroidSafetyNetEvaluationType);
            writer.WriteBoolValue("requirePinAfterBiometricChange", RequirePinAfterBiometricChange);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteIntValue("warnAfterCompanyPortalUpdateDeferralInDays", WarnAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteIntValue("wipeAfterCompanyPortalUpdateDeferralInDays", WipeAfterCompanyPortalUpdateDeferralInDays);
        }
    }
}
