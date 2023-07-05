using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for welcome screen meeting information.</summary>
    public enum WelcomeScreenMeetingInformation {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Show organizer and time only.</summary>
        [EnumMember(Value = "showOrganizerAndTimeOnly")]
        ShowOrganizerAndTimeOnly,
        /// <summary>Show organizer, time and subject (subject is hidden for private meetings).</summary>
        [EnumMember(Value = "showOrganizerAndTimeAndSubject")]
        ShowOrganizerAndTimeAndSubject,
    }
}
