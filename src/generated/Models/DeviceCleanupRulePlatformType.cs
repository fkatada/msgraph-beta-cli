// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Define the platform type for which the admin wants to create the device clean up rule</summary>
    public enum DeviceCleanupRulePlatformType
    {
        /// <summary>Default. Indicates that clean up rule is associated with all managed device platforms.</summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>Indicates that clean up rule is associated with Android open source project managed device platforms.</summary>
        [EnumMember(Value = "androidAOSP")]
        AndroidAOSP,
        /// <summary>Indicates that clean up rule is associated with Android device administrator managed device platforms.</summary>
        [EnumMember(Value = "androidDeviceAdministrator")]
        AndroidDeviceAdministrator,
        /// <summary>Indicates that clean up rule is associated with Android dedicated and fully managed and Corporate Owned Work Profile managed device platforms.</summary>
        [EnumMember(Value = "androidDedicatedAndFullyManagedCorporateOwnedWorkProfile")]
        AndroidDedicatedAndFullyManagedCorporateOwnedWorkProfile,
        /// <summary>Indicates that clean up rule is associated with ChromeOS managed device platforms.</summary>
        [EnumMember(Value = "chromeOS")]
        ChromeOS,
        /// <summary>Indicates that clean up rule is associated with Android personally owned work profile managed device platforms.</summary>
        [EnumMember(Value = "androidPersonallyOwnedWorkProfile")]
        AndroidPersonallyOwnedWorkProfile,
        /// <summary>Indicates that clean up rule is associated with IOS managed device platforms.</summary>
        [EnumMember(Value = "ios")]
        Ios,
        /// <summary>Indicates that clean up rule is associated with MacOS managed device platforms.</summary>
        [EnumMember(Value = "macOS")]
        MacOS,
        /// <summary>Indicates that clean up rule is associated with Windows managed device platforms.</summary>
        [EnumMember(Value = "windows")]
        Windows,
        /// <summary>Indicates that clean up rule is associated with Windows Holographic managed device platforms.</summary>
        [EnumMember(Value = "windowsHolographic")]
        WindowsHolographic,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
