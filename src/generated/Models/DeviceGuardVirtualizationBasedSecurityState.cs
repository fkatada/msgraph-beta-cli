// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public enum DeviceGuardVirtualizationBasedSecurityState
    #pragma warning restore CS1591
    {
        /// <summary>Running</summary>
        [EnumMember(Value = "running")]
        Running,
        /// <summary>Root required</summary>
        [EnumMember(Value = "rebootRequired")]
        RebootRequired,
        /// <summary>64 bit architecture required</summary>
        [EnumMember(Value = "require64BitArchitecture")]
        Require64BitArchitecture,
        /// <summary>Not licensed</summary>
        [EnumMember(Value = "notLicensed")]
        NotLicensed,
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>System does not meet hardware requirements</summary>
        [EnumMember(Value = "doesNotMeetHardwareRequirements")]
        DoesNotMeetHardwareRequirements,
        /// <summary>Other. Event logs in microsoft-Windows-DeviceGuard have more details.</summary>
        [EnumMember(Value = "other")]
        Other,
    }
}
