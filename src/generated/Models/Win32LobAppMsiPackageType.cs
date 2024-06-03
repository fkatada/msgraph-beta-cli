// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Indicates the package type of an MSI Win32LobApp.</summary>
    public enum Win32LobAppMsiPackageType
    {
        /// <summary>Indicates a per-machine app package.</summary>
        [EnumMember(Value = "perMachine")]
        PerMachine,
        /// <summary>Indicates a per-user app package.</summary>
        [EnumMember(Value = "perUser")]
        PerUser,
        /// <summary>Indicates a dual-purpose app package.</summary>
        [EnumMember(Value = "dualPurpose")]
        DualPurpose,
    }
}
