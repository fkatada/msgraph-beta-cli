using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>TV content rating labels in France</summary>
    public enum RatingFranceTelevisionType {
        /// <summary>Default value, allow all TV shows content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The -10 classification is not recommended for children under 10</summary>
        [EnumMember(Value = "agesAbove10")]
        AgesAbove10,
        /// <summary>The -12 classification is not recommended for children under 12</summary>
        [EnumMember(Value = "agesAbove12")]
        AgesAbove12,
        /// <summary>The -16 classification is not recommended for children under 16</summary>
        [EnumMember(Value = "agesAbove16")]
        AgesAbove16,
        /// <summary>The -18 classification is not recommended for persons under 18</summary>
        [EnumMember(Value = "agesAbove18")]
        AgesAbove18,
    }
}
