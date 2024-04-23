// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Represents a Kerberos-type Single Sign-On extension profile for iOS devices.
    /// </summary>
    public class IosKerberosSingleSignOnExtension : IosSingleSignOnExtension, IParsable 
    {
        /// <summary>Gets or sets the Active Directory site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActiveDirectorySiteCode { get; set; }
#nullable restore
#else
        public string ActiveDirectorySiteCode { get; set; }
#endif
        /// <summary>Enables or disables whether the Kerberos extension can automatically determine its site name.</summary>
        public bool? BlockActiveDirectorySiteAutoDiscovery { get; set; }
        /// <summary>Enables or disables Keychain usage.</summary>
        public bool? BlockAutomaticLogin { get; set; }
        /// <summary>Gets or sets the Generic Security Services name of the Kerberos cache to use for this profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CacheName { get; set; }
#nullable restore
#else
        public string CacheName { get; set; }
#endif
        /// <summary>Gets or sets a list of app Bundle IDs allowed to access the Kerberos Ticket Granting Ticket.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CredentialBundleIdAccessControlList { get; set; }
#nullable restore
#else
        public List<string> CredentialBundleIdAccessControlList { get; set; }
#endif
        /// <summary>Gets or sets a list of realms for custom domain-realm mapping. Realms are case sensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DomainRealms { get; set; }
#nullable restore
#else
        public List<string> DomainRealms { get; set; }
#endif
        /// <summary>Gets or sets a list of hosts or domain names for which the app extension performs SSO.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Domains { get; set; }
#nullable restore
#else
        public List<string> Domains { get; set; }
#endif
        /// <summary>When true, this profile&apos;s realm will be selected as the default. Necessary if multiple Kerberos-type profiles are configured.</summary>
        public bool? IsDefaultRealm { get; set; }
        /// <summary>When set to True, the Kerberos extension allows managed apps, and any apps entered with the app bundle ID to access the credential. When set to False, the Kerberos extension allows all apps to access the credential. Available for devices running iOS and iPadOS versions 14 and later.</summary>
        public bool? ManagedAppsInBundleIdACLIncluded { get; set; }
        /// <summary>Enables or disables password changes.</summary>
        public bool? PasswordBlockModification { get; set; }
        /// <summary>Gets or sets the URL that the user will be sent to when they initiate a password change.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PasswordChangeUrl { get; set; }
#nullable restore
#else
        public string PasswordChangeUrl { get; set; }
#endif
        /// <summary>Enables or disables password syncing. This won&apos;t affect users logged in with a mobile account on macOS.</summary>
        public bool? PasswordEnableLocalSync { get; set; }
        /// <summary>Overrides the default password expiration in days. For most domains, this value is calculated automatically.</summary>
        public int? PasswordExpirationDays { get; set; }
        /// <summary>Gets or sets the number of days until the user is notified that their password will expire (default is 15).</summary>
        public int? PasswordExpirationNotificationDays { get; set; }
        /// <summary>Gets or sets the minimum number of days until a user can change their password again.</summary>
        public int? PasswordMinimumAgeDays { get; set; }
        /// <summary>Gets or sets the minimum length of a password.</summary>
        public int? PasswordMinimumLength { get; set; }
        /// <summary>Gets or sets the number of previous passwords to block.</summary>
        public int? PasswordPreviousPasswordBlockCount { get; set; }
        /// <summary>Enables or disables whether passwords must meet Active Directory&apos;s complexity requirements.</summary>
        public bool? PasswordRequireActiveDirectoryComplexity { get; set; }
        /// <summary>Gets or sets a description of the password complexity requirements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PasswordRequirementsDescription { get; set; }
#nullable restore
#else
        public string PasswordRequirementsDescription { get; set; }
#endif
        /// <summary>Gets or sets the case-sensitive realm name for this profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Realm { get; set; }
#nullable restore
#else
        public string Realm { get; set; }
#endif
        /// <summary>Gets or sets whether to require authentication via Touch ID, Face ID, or a passcode to access the keychain entry.</summary>
        public bool? RequireUserPresence { get; set; }
        /// <summary>Text displayed to the user at the Kerberos sign in window. Available for devices running iOS and iPadOS versions 14 and later.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignInHelpText { get; set; }
#nullable restore
#else
        public string SignInHelpText { get; set; }
#endif
        /// <summary>Gets or sets the principle user name to use for this profile. The realm name does not need to be included.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IosKerberosSingleSignOnExtension"/> and sets the default values.
        /// </summary>
        public IosKerberosSingleSignOnExtension() : base()
        {
            OdataType = "#microsoft.graph.iosKerberosSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IosKerberosSingleSignOnExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosKerberosSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosKerberosSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"activeDirectorySiteCode", n => { ActiveDirectorySiteCode = n.GetStringValue(); } },
                {"blockActiveDirectorySiteAutoDiscovery", n => { BlockActiveDirectorySiteAutoDiscovery = n.GetBoolValue(); } },
                {"blockAutomaticLogin", n => { BlockAutomaticLogin = n.GetBoolValue(); } },
                {"cacheName", n => { CacheName = n.GetStringValue(); } },
                {"credentialBundleIdAccessControlList", n => { CredentialBundleIdAccessControlList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"domainRealms", n => { DomainRealms = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"isDefaultRealm", n => { IsDefaultRealm = n.GetBoolValue(); } },
                {"managedAppsInBundleIdACLIncluded", n => { ManagedAppsInBundleIdACLIncluded = n.GetBoolValue(); } },
                {"passwordBlockModification", n => { PasswordBlockModification = n.GetBoolValue(); } },
                {"passwordChangeUrl", n => { PasswordChangeUrl = n.GetStringValue(); } },
                {"passwordEnableLocalSync", n => { PasswordEnableLocalSync = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordExpirationNotificationDays", n => { PasswordExpirationNotificationDays = n.GetIntValue(); } },
                {"passwordMinimumAgeDays", n => { PasswordMinimumAgeDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequireActiveDirectoryComplexity", n => { PasswordRequireActiveDirectoryComplexity = n.GetBoolValue(); } },
                {"passwordRequirementsDescription", n => { PasswordRequirementsDescription = n.GetStringValue(); } },
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"requireUserPresence", n => { RequireUserPresence = n.GetBoolValue(); } },
                {"signInHelpText", n => { SignInHelpText = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("activeDirectorySiteCode", ActiveDirectorySiteCode);
            writer.WriteBoolValue("blockActiveDirectorySiteAutoDiscovery", BlockActiveDirectorySiteAutoDiscovery);
            writer.WriteBoolValue("blockAutomaticLogin", BlockAutomaticLogin);
            writer.WriteStringValue("cacheName", CacheName);
            writer.WriteCollectionOfPrimitiveValues<string>("credentialBundleIdAccessControlList", CredentialBundleIdAccessControlList);
            writer.WriteCollectionOfPrimitiveValues<string>("domainRealms", DomainRealms);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteBoolValue("isDefaultRealm", IsDefaultRealm);
            writer.WriteBoolValue("managedAppsInBundleIdACLIncluded", ManagedAppsInBundleIdACLIncluded);
            writer.WriteBoolValue("passwordBlockModification", PasswordBlockModification);
            writer.WriteStringValue("passwordChangeUrl", PasswordChangeUrl);
            writer.WriteBoolValue("passwordEnableLocalSync", PasswordEnableLocalSync);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordExpirationNotificationDays", PasswordExpirationNotificationDays);
            writer.WriteIntValue("passwordMinimumAgeDays", PasswordMinimumAgeDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequireActiveDirectoryComplexity", PasswordRequireActiveDirectoryComplexity);
            writer.WriteStringValue("passwordRequirementsDescription", PasswordRequirementsDescription);
            writer.WriteStringValue("realm", Realm);
            writer.WriteBoolValue("requireUserPresence", RequireUserPresence);
            writer.WriteStringValue("signInHelpText", SignInHelpText);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
