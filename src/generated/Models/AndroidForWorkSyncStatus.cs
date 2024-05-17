// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Sync status of the tenant with the Google EMM API</summary>
    public enum AndroidForWorkSyncStatus
    {
        [EnumMember(Value = "success")]
        #pragma warning disable CS1591
        Success,
        #pragma warning restore CS1591
        [EnumMember(Value = "credentialsNotValid")]
        #pragma warning disable CS1591
        CredentialsNotValid,
        #pragma warning restore CS1591
        [EnumMember(Value = "androidForWorkApiError")]
        #pragma warning disable CS1591
        AndroidForWorkApiError,
        #pragma warning restore CS1591
        [EnumMember(Value = "managementServiceError")]
        #pragma warning disable CS1591
        ManagementServiceError,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownError")]
        #pragma warning disable CS1591
        UnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
    }
}
