// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>Certificate Issuance State Options.</summary>
    public enum CertificateIssuanceStates
    {
        [EnumMember(Value = "unknown")]
        #pragma warning disable CS1591
        Unknown,
        #pragma warning restore CS1591
        [EnumMember(Value = "challengeIssued")]
        #pragma warning disable CS1591
        ChallengeIssued,
        #pragma warning restore CS1591
        [EnumMember(Value = "challengeIssueFailed")]
        #pragma warning disable CS1591
        ChallengeIssueFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "requestCreationFailed")]
        #pragma warning disable CS1591
        RequestCreationFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "requestSubmitFailed")]
        #pragma warning disable CS1591
        RequestSubmitFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "challengeValidationSucceeded")]
        #pragma warning disable CS1591
        ChallengeValidationSucceeded,
        #pragma warning restore CS1591
        [EnumMember(Value = "challengeValidationFailed")]
        #pragma warning disable CS1591
        ChallengeValidationFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "issueFailed")]
        #pragma warning disable CS1591
        IssueFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "issuePending")]
        #pragma warning disable CS1591
        IssuePending,
        #pragma warning restore CS1591
        [EnumMember(Value = "issued")]
        #pragma warning disable CS1591
        Issued,
        #pragma warning restore CS1591
        [EnumMember(Value = "responseProcessingFailed")]
        #pragma warning disable CS1591
        ResponseProcessingFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "responsePending")]
        #pragma warning disable CS1591
        ResponsePending,
        #pragma warning restore CS1591
        [EnumMember(Value = "enrollmentSucceeded")]
        #pragma warning disable CS1591
        EnrollmentSucceeded,
        #pragma warning restore CS1591
        [EnumMember(Value = "enrollmentNotNeeded")]
        #pragma warning disable CS1591
        EnrollmentNotNeeded,
        #pragma warning restore CS1591
        [EnumMember(Value = "revoked")]
        #pragma warning disable CS1591
        Revoked,
        #pragma warning restore CS1591
        [EnumMember(Value = "removedFromCollection")]
        #pragma warning disable CS1591
        RemovedFromCollection,
        #pragma warning restore CS1591
        [EnumMember(Value = "renewVerified")]
        #pragma warning disable CS1591
        RenewVerified,
        #pragma warning restore CS1591
        [EnumMember(Value = "installFailed")]
        #pragma warning disable CS1591
        InstallFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "installed")]
        #pragma warning disable CS1591
        Installed,
        #pragma warning restore CS1591
        [EnumMember(Value = "deleteFailed")]
        #pragma warning disable CS1591
        DeleteFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "deleted")]
        #pragma warning disable CS1591
        Deleted,
        #pragma warning restore CS1591
        [EnumMember(Value = "renewalRequested")]
        #pragma warning disable CS1591
        RenewalRequested,
        #pragma warning restore CS1591
        [EnumMember(Value = "requested")]
        #pragma warning disable CS1591
        Requested,
        #pragma warning restore CS1591
    }
}
