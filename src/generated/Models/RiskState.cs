using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RiskState {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "confirmedSafe")]
        ConfirmedSafe,
        [EnumMember(Value = "remediated")]
        Remediated,
        [EnumMember(Value = "dismissed")]
        Dismissed,
        [EnumMember(Value = "atRisk")]
        AtRisk,
        [EnumMember(Value = "confirmedCompromised")]
        ConfirmedCompromised,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
