// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.ManagedTenants {
    public enum TenantOnboardingEligibilityReason
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "contractType")]
        ContractType,
        [EnumMember(Value = "delegatedAdminPrivileges")]
        DelegatedAdminPrivileges,
        [EnumMember(Value = "usersCount")]
        UsersCount,
        [EnumMember(Value = "license")]
        License,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
