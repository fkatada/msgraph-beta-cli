// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    [Flags]
    public enum ConfirmedBy
    {
        [EnumMember(Value = "none")]
        None = 1,
        [EnumMember(Value = "user")]
        User = 2,
        [EnumMember(Value = "manager")]
        Manager = 4,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 8,
    }
}
