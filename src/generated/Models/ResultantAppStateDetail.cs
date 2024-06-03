// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Enum indicating additional details regarding why an application has a particular install state.</summary>
    public enum ResultantAppStateDetail
    {
        /// <summary>Device architecture (e.g. x86/amd64) is not applicable for the application.</summary>
        [EnumMember(Value = "processorArchitectureNotApplicable")]
        ProcessorArchitectureNotApplicable,
        /// <summary>Available disk space on the target device is less than the configured minimum.</summary>
        [EnumMember(Value = "minimumDiskSpaceNotMet")]
        MinimumDiskSpaceNotMet,
        /// <summary>OS version on the target device is less than the configured minimum.</summary>
        [EnumMember(Value = "minimumOsVersionNotMet")]
        MinimumOsVersionNotMet,
        /// <summary>Amount of RAM on the target device is less than the configured minimum.</summary>
        [EnumMember(Value = "minimumPhysicalMemoryNotMet")]
        MinimumPhysicalMemoryNotMet,
        /// <summary>Count of logical processors on the target device is less than the configured minimum.</summary>
        [EnumMember(Value = "minimumLogicalProcessorCountNotMet")]
        MinimumLogicalProcessorCountNotMet,
        /// <summary>CPU speed on the target device is less than the configured minimum.</summary>
        [EnumMember(Value = "minimumCpuSpeedNotMet")]
        MinimumCpuSpeedNotMet,
        /// <summary>Application is not applicable to this platform. (e.g. Android app targeted to IOS)</summary>
        [EnumMember(Value = "platformNotApplicable")]
        PlatformNotApplicable,
        /// <summary>File system requirement rule is not met</summary>
        [EnumMember(Value = "fileSystemRequirementNotMet")]
        FileSystemRequirementNotMet,
        /// <summary>Registry requirement rule is not met</summary>
        [EnumMember(Value = "registryRequirementNotMet")]
        RegistryRequirementNotMet,
        /// <summary>PowerShell script requirement rule is not met</summary>
        [EnumMember(Value = "powerShellScriptRequirementNotMet")]
        PowerShellScriptRequirementNotMet,
        /// <summary>All targeted, superseding apps are not applicable.</summary>
        [EnumMember(Value = "supersedingAppsNotApplicable")]
        SupersedingAppsNotApplicable,
        /// <summary>No additional details are available.</summary>
        [EnumMember(Value = "noAdditionalDetails")]
        NoAdditionalDetails,
        /// <summary>One or more of the application&apos;s dependencies failed to install.</summary>
        [EnumMember(Value = "dependencyFailedToInstall")]
        DependencyFailedToInstall,
        /// <summary>One or more of the application&apos;s dependencies have requirements which are not met.</summary>
        [EnumMember(Value = "dependencyWithRequirementsNotMet")]
        DependencyWithRequirementsNotMet,
        /// <summary>One or more of the application&apos;s dependencies require a device reboot to complete installation.</summary>
        [EnumMember(Value = "dependencyPendingReboot")]
        DependencyPendingReboot,
        /// <summary>One or more of the application&apos;s dependencies are configured to not automatically install.</summary>
        [EnumMember(Value = "dependencyWithAutoInstallDisabled")]
        DependencyWithAutoInstallDisabled,
        /// <summary>A superseded app failed to uninstall.</summary>
        [EnumMember(Value = "supersededAppUninstallFailed")]
        SupersededAppUninstallFailed,
        /// <summary>A superseded app requires a reboot to complete uninstall.</summary>
        [EnumMember(Value = "supersededAppUninstallPendingReboot")]
        SupersededAppUninstallPendingReboot,
        /// <summary>Superseded apps are being removed.</summary>
        [EnumMember(Value = "removingSupersededApps")]
        RemovingSupersededApps,
        /// <summary>The latest version of the app failed to update from an earlier version.</summary>
        [EnumMember(Value = "iosAppStoreUpdateFailedToInstall")]
        IosAppStoreUpdateFailedToInstall,
        /// <summary>An update is available.</summary>
        [EnumMember(Value = "vppAppHasUpdateAvailable")]
        VppAppHasUpdateAvailable,
        /// <summary>The user rejected the app update.</summary>
        [EnumMember(Value = "userRejectedUpdate")]
        UserRejectedUpdate,
        /// <summary>To complete the removal of the app, the device must be rebooted.</summary>
        [EnumMember(Value = "uninstallPendingReboot")]
        UninstallPendingReboot,
        /// <summary>Superseding applications are detected.</summary>
        [EnumMember(Value = "supersedingAppsDetected")]
        SupersedingAppsDetected,
        /// <summary>Superseded applications are detected.</summary>
        [EnumMember(Value = "supersededAppsDetected")]
        SupersededAppsDetected,
        /// <summary>Application failed to install. See error code property for more details.</summary>
        [EnumMember(Value = "seeInstallErrorCode")]
        SeeInstallErrorCode,
        /// <summary>Application is configured to not be automatically installed.</summary>
        [EnumMember(Value = "autoInstallDisabled")]
        AutoInstallDisabled,
        /// <summary>The app is managed but no longer installed.</summary>
        [EnumMember(Value = "managedAppNoLongerPresent")]
        ManagedAppNoLongerPresent,
        /// <summary>The user rejected the app install.</summary>
        [EnumMember(Value = "userRejectedInstall")]
        UserRejectedInstall,
        /// <summary>The user must log into the App Store to install app.</summary>
        [EnumMember(Value = "userIsNotLoggedIntoAppStore")]
        UserIsNotLoggedIntoAppStore,
        /// <summary>App cannot be installed. An untargeted, superseding app was detected, which created a conflict.</summary>
        [EnumMember(Value = "untargetedSupersedingAppsDetected")]
        UntargetedSupersedingAppsDetected,
        /// <summary>App was removed in order to install a superseding app.</summary>
        [EnumMember(Value = "appRemovedBySupersedence")]
        AppRemovedBySupersedence,
        /// <summary>Application failed to uninstall. See error code property for more details.</summary>
        [EnumMember(Value = "seeUninstallErrorCode")]
        SeeUninstallErrorCode,
        /// <summary>Device must be rebooted to complete installation of the application.</summary>
        [EnumMember(Value = "pendingReboot")]
        PendingReboot,
        /// <summary>One or more of the application&apos;s dependencies are installing.</summary>
        [EnumMember(Value = "installingDependencies")]
        InstallingDependencies,
        /// <summary>Application content was downloaded to the device.</summary>
        [EnumMember(Value = "contentDownloaded")]
        ContentDownloaded,
    }
}
