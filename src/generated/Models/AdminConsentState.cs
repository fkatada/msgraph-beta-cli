// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Admin consent state.</summary>
    public enum AdminConsentState
    {
        /// <summary>Admin did not configure the item</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Admin granted item</summary>
        [EnumMember(Value = "granted")]
        Granted,
        /// <summary>Admin deos not grant item</summary>
        [EnumMember(Value = "notGranted")]
        NotGranted,
    }
}
