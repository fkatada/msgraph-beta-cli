// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum DeliveryLocation
    {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "inbox_folder")]
        Inbox_folder,
        [EnumMember(Value = "junkFolder")]
        JunkFolder,
        [EnumMember(Value = "deletedFolder")]
        DeletedFolder,
        [EnumMember(Value = "quarantine")]
        Quarantine,
        [EnumMember(Value = "onprem_external")]
        Onprem_external,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "dropped")]
        Dropped,
        [EnumMember(Value = "others")]
        Others,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
