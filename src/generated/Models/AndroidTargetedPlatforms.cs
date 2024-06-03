// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Specifies which platform(s) can be targeted for a given Android LOB application or Managed Android LOB application.</summary>
    [Flags]
    public enum AndroidTargetedPlatforms
    {
        /// <summary>Indicates the Android targeted platform is Android Device Administrator.</summary>
        [EnumMember(Value = "androidDeviceAdministrator")]
        AndroidDeviceAdministrator = 1,
        /// <summary>Indicates the Android targeted platform is Android Open Source Project.</summary>
        [EnumMember(Value = "androidOpenSourceProject")]
        AndroidOpenSourceProject = 2,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 4,
    }
}
