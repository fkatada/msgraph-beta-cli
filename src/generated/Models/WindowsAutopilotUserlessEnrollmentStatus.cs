// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Userless enrollment block status, indicating whether the next device enrollment will be blocked.</summary>
    public enum WindowsAutopilotUserlessEnrollmentStatus
    {
        /// <summary>Unknown userless enrollment block status. Next userless enrollment may fail. This is the default value.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates next userless enrollment can proceed.</summary>
        [EnumMember(Value = "allowed")]
        Allowed,
        /// <summary>Indicates next userless enrollment cannot proceed without resetting the windowsAutopilotUserlessEnrollmentStatus.</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
