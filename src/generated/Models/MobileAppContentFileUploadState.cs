// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Contains properties for upload request states.</summary>
    public enum MobileAppContentFileUploadState
    {
        [EnumMember(Value = "success")]
        #pragma warning disable CS1591
        Success,
        #pragma warning restore CS1591
        [EnumMember(Value = "transientError")]
        #pragma warning disable CS1591
        TransientError,
        #pragma warning restore CS1591
        [EnumMember(Value = "error")]
        #pragma warning disable CS1591
        Error,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknown")]
        #pragma warning disable CS1591
        Unknown,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureStorageUriRequestSuccess")]
        #pragma warning disable CS1591
        AzureStorageUriRequestSuccess,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureStorageUriRequestPending")]
        #pragma warning disable CS1591
        AzureStorageUriRequestPending,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureStorageUriRequestFailed")]
        #pragma warning disable CS1591
        AzureStorageUriRequestFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureStorageUriRequestTimedOut")]
        #pragma warning disable CS1591
        AzureStorageUriRequestTimedOut,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureStorageUriRenewalSuccess")]
        #pragma warning disable CS1591
        AzureStorageUriRenewalSuccess,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureStorageUriRenewalPending")]
        #pragma warning disable CS1591
        AzureStorageUriRenewalPending,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureStorageUriRenewalFailed")]
        #pragma warning disable CS1591
        AzureStorageUriRenewalFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureStorageUriRenewalTimedOut")]
        #pragma warning disable CS1591
        AzureStorageUriRenewalTimedOut,
        #pragma warning restore CS1591
        [EnumMember(Value = "commitFileSuccess")]
        #pragma warning disable CS1591
        CommitFileSuccess,
        #pragma warning restore CS1591
        [EnumMember(Value = "commitFilePending")]
        #pragma warning disable CS1591
        CommitFilePending,
        #pragma warning restore CS1591
        [EnumMember(Value = "commitFileFailed")]
        #pragma warning disable CS1591
        CommitFileFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "commitFileTimedOut")]
        #pragma warning disable CS1591
        CommitFileTimedOut,
        #pragma warning restore CS1591
    }
}
