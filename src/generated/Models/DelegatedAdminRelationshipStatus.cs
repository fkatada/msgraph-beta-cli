using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum DelegatedAdminRelationshipStatus {
        [EnumMember(Value = "activating")]
        Activating,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "approvalPending")]
        ApprovalPending,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "expiring")]
        Expiring,
        [EnumMember(Value = "terminated")]
        Terminated,
        [EnumMember(Value = "terminating")]
        Terminating,
        [EnumMember(Value = "terminationRequested")]
        TerminationRequested,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
