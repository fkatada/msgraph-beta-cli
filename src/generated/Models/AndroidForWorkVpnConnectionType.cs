// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Android For Work VPN connection type.</summary>
    public enum AndroidForWorkVpnConnectionType
    {
        /// <summary>Cisco AnyConnect.</summary>
        [EnumMember(Value = "ciscoAnyConnect")]
        CiscoAnyConnect,
        /// <summary>Pulse Secure.</summary>
        [EnumMember(Value = "pulseSecure")]
        PulseSecure,
        /// <summary>F5 Edge Client.</summary>
        [EnumMember(Value = "f5EdgeClient")]
        F5EdgeClient,
        /// <summary>Dell SonicWALL Mobile Connection.</summary>
        [EnumMember(Value = "dellSonicWallMobileConnect")]
        DellSonicWallMobileConnect,
        /// <summary>Check Point Capsule VPN.</summary>
        [EnumMember(Value = "checkPointCapsuleVpn")]
        CheckPointCapsuleVpn,
        /// <summary>Citrix</summary>
        [EnumMember(Value = "citrix")]
        Citrix,
    }
}
