// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    [Flags]
    public enum AllowedRolePrincipalTypes
    {
        [EnumMember(Value = "user")]
        User = 1,
        [EnumMember(Value = "servicePrincipal")]
        ServicePrincipal = 2,
        [EnumMember(Value = "group")]
        Group = 4,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 8,
    }
}
