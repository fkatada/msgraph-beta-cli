using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Delivery optimization mode for peer distribution</summary>
    public enum WindowsDeliveryOptimizationMode {
        /// <summary>Allow the user to set.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>HTTP only, no peering</summary>
        [EnumMember(Value = "httpOnly")]
        HttpOnly,
        /// <summary>OS default – Http blended with peering behind the same network address translator</summary>
        [EnumMember(Value = "httpWithPeeringNat")]
        HttpWithPeeringNat,
        /// <summary>HTTP blended with peering across a private group</summary>
        [EnumMember(Value = "httpWithPeeringPrivateGroup")]
        HttpWithPeeringPrivateGroup,
        /// <summary>HTTP blended with Internet peering</summary>
        [EnumMember(Value = "httpWithInternetPeering")]
        HttpWithInternetPeering,
        /// <summary>Simple download mode with no peering</summary>
        [EnumMember(Value = "simpleDownload")]
        SimpleDownload,
        /// <summary>Bypass mode. Do not use Delivery Optimization and use BITS instead</summary>
        [EnumMember(Value = "bypassMode")]
        BypassMode,
    }
}
