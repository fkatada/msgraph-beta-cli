// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class RelyingPartyDetailedSummary : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Number of failed sign in on Active Directory Federation Service in the period specified.</summary>
        public long? FailedSignInCount { get; set; }
        /// <summary>The migrationStatus property</summary>
        public ApiSdk.Models.MigrationStatus? MigrationStatus { get; set; }
        /// <summary>Specifies all the validations check done on applications configuration details to evaluate if the application is ready to be moved to Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? MigrationValidationDetails { get; set; }
#nullable restore
#else
        public List<KeyValuePair> MigrationValidationDetails { get; set; }
#endif
        /// <summary>This identifier is used to identify the relying party to this Federation Service. It&apos;s used when issuing claims to the relying party.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelyingPartyId { get; set; }
#nullable restore
#else
        public string RelyingPartyId { get; set; }
#endif
        /// <summary>Name of application or other entity on the internet that uses an identity provider to authenticate a user who wants to sign in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelyingPartyName { get; set; }
#nullable restore
#else
        public string RelyingPartyName { get; set; }
#endif
        /// <summary>Specifies where the relying party expects to receive the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ReplyUrls { get; set; }
#nullable restore
#else
        public List<string> ReplyUrls { get; set; }
#endif
        /// <summary>Uniquely identifies the Active Directory forest.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceId { get; set; }
#nullable restore
#else
        public string ServiceId { get; set; }
#endif
        /// <summary>Number of successful / (number of successful + number of failed sign ins) on Active Directory Federation Service in the period specified.</summary>
        public double? SignInSuccessRate { get; set; }
        /// <summary>Number of successful sign ins on Active Directory Federation Service.</summary>
        public long? SuccessfulSignInCount { get; set; }
        /// <summary>Number of successful + failed sign ins on Active Directory Federation Service in the period specified.</summary>
        public long? TotalSignInCount { get; set; }
        /// <summary>Number of unique users that have signed into the application.</summary>
        public long? UniqueUserCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RelyingPartyDetailedSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RelyingPartyDetailedSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RelyingPartyDetailedSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "failedSignInCount", n => { FailedSignInCount = n.GetLongValue(); } },
                { "migrationStatus", n => { MigrationStatus = n.GetEnumValue<MigrationStatus>(); } },
                { "migrationValidationDetails", n => { MigrationValidationDetails = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "relyingPartyId", n => { RelyingPartyId = n.GetStringValue(); } },
                { "relyingPartyName", n => { RelyingPartyName = n.GetStringValue(); } },
                { "replyUrls", n => { ReplyUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "serviceId", n => { ServiceId = n.GetStringValue(); } },
                { "signInSuccessRate", n => { SignInSuccessRate = n.GetDoubleValue(); } },
                { "successfulSignInCount", n => { SuccessfulSignInCount = n.GetLongValue(); } },
                { "totalSignInCount", n => { TotalSignInCount = n.GetLongValue(); } },
                { "uniqueUserCount", n => { UniqueUserCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("failedSignInCount", FailedSignInCount);
            writer.WriteEnumValue<MigrationStatus>("migrationStatus", MigrationStatus);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("migrationValidationDetails", MigrationValidationDetails);
            writer.WriteStringValue("relyingPartyId", RelyingPartyId);
            writer.WriteStringValue("relyingPartyName", RelyingPartyName);
            writer.WriteCollectionOfPrimitiveValues<string>("replyUrls", ReplyUrls);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteDoubleValue("signInSuccessRate", SignInSuccessRate);
            writer.WriteLongValue("successfulSignInCount", SuccessfulSignInCount);
            writer.WriteLongValue("totalSignInCount", TotalSignInCount);
            writer.WriteLongValue("uniqueUserCount", UniqueUserCount);
        }
    }
}
