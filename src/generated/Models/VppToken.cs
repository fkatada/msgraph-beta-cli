// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education. This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune. You can then synchronize your volume purchase information with Intune and track your volume-purchased app use. You can upload multiple Apple VPP Business or Education tokens.
    /// </summary>
    public class VppToken : Entity, IParsable
    {
        /// <summary>The apple Id associated with the given Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppleId { get; set; }
#nullable restore
#else
        public string AppleId { get; set; }
#endif
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public bool? AutomaticallyUpdateApps { get; set; }
        /// <summary>Admin consent to allow claiming token management from external MDM.</summary>
        public bool? ClaimTokenManagementFromExternalMdm { get; set; }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion { get; set; }
#nullable restore
#else
        public string CountryOrRegion { get; set; }
#endif
        /// <summary>Consent granted for data sharing with the Apple Volume Purchase Program.</summary>
        public bool? DataSharingConsentGranted { get; set; }
        /// <summary>An admin specified token friendly name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The expiration date time of the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Last modification date time associated with the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>Possible sync statuses associated with an Apple Volume Purchase Program token.</summary>
        public VppTokenSyncStatus? LastSyncStatus { get; set; }
        /// <summary>Token location returned from Apple VPP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationName { get; set; }
#nullable restore
#else
        public string LocationName { get; set; }
#endif
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName { get; set; }
#nullable restore
#else
        public string OrganizationName { get; set; }
#endif
        /// <summary>Role Scope Tags IDs assigned to this entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>Possible states associated with an Apple Volume Purchase Program token.</summary>
        public VppTokenState? State { get; set; }
        /// <summary>The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The collection of statuses of the actions performed on the Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VppTokenActionResult>? TokenActionResults { get; set; }
#nullable restore
#else
        public List<VppTokenActionResult> TokenActionResults { get; set; }
#endif
        /// <summary>Possible types of an Apple Volume Purchase Program token.</summary>
        public ApiSdk.Models.VppTokenAccountType? VppTokenAccountType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VppToken"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VppToken CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppToken();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appleId", n => { AppleId = n.GetStringValue(); } },
                { "automaticallyUpdateApps", n => { AutomaticallyUpdateApps = n.GetBoolValue(); } },
                { "claimTokenManagementFromExternalMdm", n => { ClaimTokenManagementFromExternalMdm = n.GetBoolValue(); } },
                { "countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                { "dataSharingConsentGranted", n => { DataSharingConsentGranted = n.GetBoolValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSyncStatus", n => { LastSyncStatus = n.GetEnumValue<VppTokenSyncStatus>(); } },
                { "locationName", n => { LocationName = n.GetStringValue(); } },
                { "organizationName", n => { OrganizationName = n.GetStringValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "state", n => { State = n.GetEnumValue<VppTokenState>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "tokenActionResults", n => { TokenActionResults = n.GetCollectionOfObjectValues<VppTokenActionResult>(VppTokenActionResult.CreateFromDiscriminatorValue)?.ToList(); } },
                { "vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
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
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteBoolValue("automaticallyUpdateApps", AutomaticallyUpdateApps);
            writer.WriteBoolValue("claimTokenManagementFromExternalMdm", ClaimTokenManagementFromExternalMdm);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteBoolValue("dataSharingConsentGranted", DataSharingConsentGranted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<VppTokenSyncStatus>("lastSyncStatus", LastSyncStatus);
            writer.WriteStringValue("locationName", LocationName);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteEnumValue<VppTokenState>("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteCollectionOfObjectValues<VppTokenActionResult>("tokenActionResults", TokenActionResults);
            writer.WriteEnumValue<VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
        }
    }
}
