// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Specifies the type of scope for a Role Assignment.</summary>
    public enum RoleAssignmentScopeType
    {
        /// <summary>Allow assignments to the specified ResourceScopes.</summary>
        [EnumMember(Value = "resourceScope")]
        ResourceScope,
        /// <summary>Allow assignments to all Intune devices.</summary>
        [EnumMember(Value = "allDevices")]
        AllDevices,
        /// <summary>Allow assignments to all Intune licensed users.</summary>
        [EnumMember(Value = "allLicensedUsers")]
        AllLicensedUsers,
        /// <summary>Allow assignments to all Intune devices and licensed users.</summary>
        [EnumMember(Value = "allDevicesAndLicensedUsers")]
        AllDevicesAndLicensedUsers,
    }
}
