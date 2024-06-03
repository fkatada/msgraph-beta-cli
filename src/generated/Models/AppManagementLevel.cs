// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Management levels for apps</summary>
    [Flags]
    public enum AppManagementLevel
    {
        /// <summary>Unspecified</summary>
        [EnumMember(Value = "unspecified")]
        Unspecified = 1,
        /// <summary>Unmanaged</summary>
        [EnumMember(Value = "unmanaged")]
        Unmanaged = 2,
        /// <summary>MDM</summary>
        [EnumMember(Value = "mdm")]
        Mdm = 4,
        /// <summary>Android Enterprise</summary>
        [EnumMember(Value = "androidEnterprise")]
        AndroidEnterprise = 8,
        /// <summary>Android Enterprise dedicated devices with Azure AD Shared mode</summary>
        [EnumMember(Value = "androidEnterpriseDedicatedDevicesWithAzureAdSharedMode")]
        AndroidEnterpriseDedicatedDevicesWithAzureAdSharedMode = 16,
        /// <summary>Android Open Source Project (AOSP) devices</summary>
        [EnumMember(Value = "androidOpenSourceProjectUserAssociated")]
        AndroidOpenSourceProjectUserAssociated = 32,
        /// <summary>Android Open Source Project (AOSP) userless devices</summary>
        [EnumMember(Value = "androidOpenSourceProjectUserless")]
        AndroidOpenSourceProjectUserless = 64,
        /// <summary>Place holder for evolvable enum</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 128,
    }
}
