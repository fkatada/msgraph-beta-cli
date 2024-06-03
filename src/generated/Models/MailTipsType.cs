// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    [Flags]
    #pragma warning disable CS1591
    public enum MailTipsType
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "automaticReplies")]
        #pragma warning disable CS1591
        AutomaticReplies = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "mailboxFullStatus")]
        #pragma warning disable CS1591
        MailboxFullStatus = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "customMailTip")]
        #pragma warning disable CS1591
        CustomMailTip = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "externalMemberCount")]
        #pragma warning disable CS1591
        ExternalMemberCount = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "totalMemberCount")]
        #pragma warning disable CS1591
        TotalMemberCount = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "maxMessageSize")]
        #pragma warning disable CS1591
        MaxMessageSize = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "deliveryRestriction")]
        #pragma warning disable CS1591
        DeliveryRestriction = 64,
        #pragma warning restore CS1591
        [EnumMember(Value = "moderationStatus")]
        #pragma warning disable CS1591
        ModerationStatus = 128,
        #pragma warning restore CS1591
        [EnumMember(Value = "recipientScope")]
        #pragma warning disable CS1591
        RecipientScope = 256,
        #pragma warning restore CS1591
        [EnumMember(Value = "recipientSuggestions")]
        #pragma warning disable CS1591
        RecipientSuggestions = 512,
        #pragma warning restore CS1591
    }
}
