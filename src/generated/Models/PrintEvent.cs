using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrintEvent {
        [EnumMember(Value = "jobStarted")]
        JobStarted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
