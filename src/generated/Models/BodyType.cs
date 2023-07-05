using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BodyType {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html")]
        Html,
    }
}
