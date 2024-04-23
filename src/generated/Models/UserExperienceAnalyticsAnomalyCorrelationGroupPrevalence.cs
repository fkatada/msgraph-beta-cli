// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Indicates the level of prevalence of the correlation group features in the anomaly. Possible values are: high, medium or low</summary>
    public enum UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence
    {
        /// <summary>Indicates that we have a high prevalence in the correlation between the anomaly and correlation group.</summary>
        [EnumMember(Value = "high")]
        High,
        /// <summary>Indicates that we have a medium prevalence in the correlation between the anomaly and correlation group.</summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>Indicates that we have a low prevalence in the correlation between the anomaly and correlation group.</summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
