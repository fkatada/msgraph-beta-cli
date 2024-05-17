// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public enum MailDestinationRoutingReason
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "mailFlowRule")]
        #pragma warning disable CS1591
        MailFlowRule,
        #pragma warning restore CS1591
        [EnumMember(Value = "safeSender")]
        #pragma warning disable CS1591
        SafeSender,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedSender")]
        #pragma warning disable CS1591
        BlockedSender,
        #pragma warning restore CS1591
        [EnumMember(Value = "advancedSpamFiltering")]
        #pragma warning disable CS1591
        AdvancedSpamFiltering,
        #pragma warning restore CS1591
        [EnumMember(Value = "domainAllowList")]
        #pragma warning disable CS1591
        DomainAllowList,
        #pragma warning restore CS1591
        [EnumMember(Value = "domainBlockList")]
        #pragma warning disable CS1591
        DomainBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "notInAddressBook")]
        #pragma warning disable CS1591
        NotInAddressBook,
        #pragma warning restore CS1591
        [EnumMember(Value = "firstTimeSender")]
        #pragma warning disable CS1591
        FirstTimeSender,
        #pragma warning restore CS1591
        [EnumMember(Value = "autoPurgeToInbox")]
        #pragma warning disable CS1591
        AutoPurgeToInbox,
        #pragma warning restore CS1591
        [EnumMember(Value = "autoPurgeToJunk")]
        #pragma warning disable CS1591
        AutoPurgeToJunk,
        #pragma warning restore CS1591
        [EnumMember(Value = "autoPurgeToDeleted")]
        #pragma warning disable CS1591
        AutoPurgeToDeleted,
        #pragma warning restore CS1591
        [EnumMember(Value = "outbound")]
        #pragma warning disable CS1591
        Outbound,
        #pragma warning restore CS1591
        [EnumMember(Value = "notJunk")]
        #pragma warning disable CS1591
        NotJunk,
        #pragma warning restore CS1591
        [EnumMember(Value = "junk")]
        #pragma warning disable CS1591
        Junk,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
    }
}
