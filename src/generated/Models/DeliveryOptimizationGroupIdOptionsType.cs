// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for the DeliveryOptimizationGroupIdOptionsType setting.</summary>
    public enum DeliveryOptimizationGroupIdOptionsType
    {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Active Directory site.</summary>
        [EnumMember(Value = "adSite")]
        AdSite,
        /// <summary>Authenticated domain SID.</summary>
        [EnumMember(Value = "authenticatedDomainSid")]
        AuthenticatedDomainSid,
        /// <summary>DHCP user option.</summary>
        [EnumMember(Value = "dhcpUserOption")]
        DhcpUserOption,
        /// <summary>DNS suffix.</summary>
        [EnumMember(Value = "dnsSuffix")]
        DnsSuffix,
    }
}
