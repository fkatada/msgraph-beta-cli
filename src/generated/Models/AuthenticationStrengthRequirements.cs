// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    [Flags]
    public enum AuthenticationStrengthRequirements
    {
        [EnumMember(Value = "none")]
        None = 1,
        [EnumMember(Value = "mfa")]
        Mfa = 2,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 4,
    }
}
