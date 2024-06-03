// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Indicates the type of restart action.</summary>
    public enum Win32LobAppRestartBehavior
    {
        /// <summary>Intune will restart the device after running the app installation if the operation returns a reboot code.</summary>
        [EnumMember(Value = "basedOnReturnCode")]
        BasedOnReturnCode,
        /// <summary>Intune will not take any specific action on reboot codes resulting from app installations. Intune will not attempt to suppress restarts for MSI apps.</summary>
        [EnumMember(Value = "allow")]
        Allow,
        /// <summary>Intune will attempt to suppress restarts for MSI apps.</summary>
        [EnumMember(Value = "suppress")]
        Suppress,
        /// <summary>Intune will force the device to restart immediately after the app installation operation.</summary>
        [EnumMember(Value = "force")]
        Force,
    }
}
