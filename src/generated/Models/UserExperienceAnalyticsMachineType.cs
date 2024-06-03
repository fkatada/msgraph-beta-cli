// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Indicates if machine is physical or virtual. Possible values are: physical or virtual</summary>
    public enum UserExperienceAnalyticsMachineType
    {
        /// <summary>Indicates that the type is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the Machine is physical.</summary>
        [EnumMember(Value = "physical")]
        Physical,
        /// <summary>Indicates that the machine is virtual.</summary>
        [EnumMember(Value = "virtual")]
        Virtual,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
