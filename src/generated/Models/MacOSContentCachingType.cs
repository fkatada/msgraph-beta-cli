// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Indicates the type of content allowed to be cached by Apple&apos;s content caching service.</summary>
    public enum MacOSContentCachingType
    {
        /// <summary>Default. Both user iCloud data and non-iCloud data will be cached.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Allow Apple&apos;s content caching service to cache user iCloud data.</summary>
        [EnumMember(Value = "userContentOnly")]
        UserContentOnly,
        /// <summary>Allow Apple&apos;s content caching service to cache non-iCloud data (e.g. app and software updates).</summary>
        [EnumMember(Value = "sharedContentOnly")]
        SharedContentOnly,
    }
}
