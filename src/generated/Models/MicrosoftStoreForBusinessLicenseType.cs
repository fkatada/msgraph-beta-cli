using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum MicrosoftStoreForBusinessLicenseType {
        [EnumMember(Value = "offline")]
        Offline,
        [EnumMember(Value = "online")]
        Online,
    }
}
