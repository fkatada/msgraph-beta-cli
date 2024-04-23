// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Firewall rule traffic directions.</summary>
    public enum WindowsFirewallRuleTrafficDirectionType
    {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>The rule applies to outbound traffic.</summary>
        [EnumMember(Value = "out")]
        Out,
        /// <summary>The rule applies to inbound traffic.</summary>
        [EnumMember(Value = "in")]
        In,
    }
}
