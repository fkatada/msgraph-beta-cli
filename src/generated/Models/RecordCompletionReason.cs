// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public enum RecordCompletionReason
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "operationCanceled")]
        #pragma warning disable CS1591
        OperationCanceled,
        #pragma warning restore CS1591
        [EnumMember(Value = "stopToneDetected")]
        #pragma warning disable CS1591
        StopToneDetected,
        #pragma warning restore CS1591
        [EnumMember(Value = "maxRecordDurationReached")]
        #pragma warning disable CS1591
        MaxRecordDurationReached,
        #pragma warning restore CS1591
        [EnumMember(Value = "initialSilenceTimeout")]
        #pragma warning disable CS1591
        InitialSilenceTimeout,
        #pragma warning restore CS1591
        [EnumMember(Value = "maxSilenceTimeout")]
        #pragma warning disable CS1591
        MaxSilenceTimeout,
        #pragma warning restore CS1591
        [EnumMember(Value = "playPromptFailed")]
        #pragma warning disable CS1591
        PlayPromptFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "playBeepFailed")]
        #pragma warning disable CS1591
        PlayBeepFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "mediaReceiveTimeout")]
        #pragma warning disable CS1591
        MediaReceiveTimeout,
        #pragma warning restore CS1591
        [EnumMember(Value = "unspecifiedError")]
        #pragma warning disable CS1591
        UnspecifiedError,
        #pragma warning restore CS1591
    }
}
