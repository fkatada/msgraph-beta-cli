using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SettingSourceType {
        [EnumMember(Value = "deviceConfiguration")]
        DeviceConfiguration,
        [EnumMember(Value = "deviceIntent")]
        DeviceIntent,
    }
}
