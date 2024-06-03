// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>System Update Types for Android Device Owner.</summary>
    public enum AndroidDeviceOwnerSystemUpdateInstallType
    {
        /// <summary>Device default behavior, which typically prompts the user to accept system updates.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Postpone automatic install of updates up to 30 days.</summary>
        [EnumMember(Value = "postpone")]
        Postpone,
        /// <summary>Install automatically inside a daily maintenance window.</summary>
        [EnumMember(Value = "windowed")]
        Windowed,
        /// <summary>Automatically install updates as soon as possible.</summary>
        [EnumMember(Value = "automatic")]
        Automatic,
    }
}
