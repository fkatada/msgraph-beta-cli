// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Access Level in Exchange.</summary>
    public enum DeviceManagementExchangeAccessLevel
    {
        /// <summary>No device access rule has been configured in Exchange.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Allow the device access to Exchange.</summary>
        [EnumMember(Value = "allow")]
        Allow,
        /// <summary>Block the device from accessing Exchange.</summary>
        [EnumMember(Value = "block")]
        Block,
        /// <summary>Quarantine the device in Exchange.</summary>
        [EnumMember(Value = "quarantine")]
        Quarantine,
    }
}
