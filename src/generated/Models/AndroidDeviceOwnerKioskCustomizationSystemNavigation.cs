// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>An enum representing possible values for kiosk customization system navigation.</summary>
    public enum AndroidDeviceOwnerKioskCustomizationSystemNavigation
    {
        /// <summary>Not configured; this value defaults to NAVIGATION_DISABLED.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Home and overview buttons are enabled.</summary>
        [EnumMember(Value = "navigationEnabled")]
        NavigationEnabled,
        /// <summary>Only the home button is enabled.</summary>
        [EnumMember(Value = "homeButtonOnly")]
        HomeButtonOnly,
    }
}
