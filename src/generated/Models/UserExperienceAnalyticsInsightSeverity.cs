// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Indicates severity of insights. Possible values are: None, Informational, Warning, Error.</summary>
    public enum UserExperienceAnalyticsInsightSeverity
    {
        /// <summary>Indicates that the insight severity is none.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Indicates that the insight severity is informational.</summary>
        [EnumMember(Value = "informational")]
        Informational,
        /// <summary>Indicates that the insight severity is warning.</summary>
        [EnumMember(Value = "warning")]
        Warning,
        /// <summary>Indicates that the insight severity is error.</summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
