// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    [Flags]
    #pragma warning disable CS1591
    public enum AllowedAudiences
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "me")]
        #pragma warning disable CS1591
        Me = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "family")]
        #pragma warning disable CS1591
        Family = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "contacts")]
        #pragma warning disable CS1591
        Contacts = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "groupMembers")]
        #pragma warning disable CS1591
        GroupMembers = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "organization")]
        #pragma warning disable CS1591
        Organization = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "federatedOrganizations")]
        #pragma warning disable CS1591
        FederatedOrganizations = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "everyone")]
        #pragma warning disable CS1591
        Everyone = 64,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 128,
        #pragma warning restore CS1591
    }
}
