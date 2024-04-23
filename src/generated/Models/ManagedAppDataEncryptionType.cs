// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Represents the level to which app data is encrypted for managed apps</summary>
    public enum ManagedAppDataEncryptionType
    {
        /// <summary>App data is encrypted based on the default settings on the device.</summary>
        [EnumMember(Value = "useDeviceSettings")]
        UseDeviceSettings,
        /// <summary>App data is encrypted when the device is restarted.</summary>
        [EnumMember(Value = "afterDeviceRestart")]
        AfterDeviceRestart,
        /// <summary>App data associated with this policy is encrypted when the device is locked, except data in files that are open</summary>
        [EnumMember(Value = "whenDeviceLockedExceptOpenFiles")]
        WhenDeviceLockedExceptOpenFiles,
        /// <summary>App data associated with this policy is encrypted when the device is locked</summary>
        [EnumMember(Value = "whenDeviceLocked")]
        WhenDeviceLocked,
    }
}
