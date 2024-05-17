// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class UserSettings : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The user&apos;s settings for the visibility of merge suggestion for the duplicate contacts in the user&apos;s contact list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ContactMergeSuggestions? ContactMergeSuggestions { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ContactMergeSuggestions ContactMergeSuggestions { get; set; }
#endif
        /// <summary>Reflects the Office Delve organization level setting. When set to true, the organization doesn&apos;t have access to Office Delve. This setting is read-only and can only be changed by administrators in the SharePoint admin center.</summary>
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }
        /// <summary>When set to true, documents in the user&apos;s Office Delve are disabled. Users can control this setting in Office Delve.</summary>
        public bool? ContributionToContentDiscoveryDisabled { get; set; }
        /// <summary>The user&apos;s settings for the visibility of meeting hour insights, and insights derived between a user and other items in Microsoft 365, such as documents or sites. Get userInsightsSettings through this navigation property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserInsightsSettings? ItemInsights { get; set; }
#nullable restore
#else
        public UserInsightsSettings ItemInsights { get; set; }
#endif
        /// <summary>The user&apos;s preferences for languages, regional locale and date/time formatting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RegionalAndLanguageSettings? RegionalAndLanguageSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RegionalAndLanguageSettings RegionalAndLanguageSettings { get; set; }
#endif
        /// <summary>The shift preferences for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ShiftPreferences? ShiftPreferences { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ShiftPreferences ShiftPreferences { get; set; }
#endif
        /// <summary>The storage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserStorage? Storage { get; set; }
#nullable restore
#else
        public UserStorage Storage { get; set; }
#endif
        /// <summary>The Windows settings of the user stored in the cloud.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsSetting>? Windows { get; set; }
#nullable restore
#else
        public List<WindowsSetting> Windows { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"contactMergeSuggestions", n => { ContactMergeSuggestions = n.GetObjectValue<ApiSdk.Models.ContactMergeSuggestions>(ApiSdk.Models.ContactMergeSuggestions.CreateFromDiscriminatorValue); } },
                {"contributionToContentDiscoveryAsOrganizationDisabled", n => { ContributionToContentDiscoveryAsOrganizationDisabled = n.GetBoolValue(); } },
                {"contributionToContentDiscoveryDisabled", n => { ContributionToContentDiscoveryDisabled = n.GetBoolValue(); } },
                {"itemInsights", n => { ItemInsights = n.GetObjectValue<UserInsightsSettings>(UserInsightsSettings.CreateFromDiscriminatorValue); } },
                {"regionalAndLanguageSettings", n => { RegionalAndLanguageSettings = n.GetObjectValue<ApiSdk.Models.RegionalAndLanguageSettings>(ApiSdk.Models.RegionalAndLanguageSettings.CreateFromDiscriminatorValue); } },
                {"shiftPreferences", n => { ShiftPreferences = n.GetObjectValue<ApiSdk.Models.ShiftPreferences>(ApiSdk.Models.ShiftPreferences.CreateFromDiscriminatorValue); } },
                {"storage", n => { Storage = n.GetObjectValue<UserStorage>(UserStorage.CreateFromDiscriminatorValue); } },
                {"windows", n => { Windows = n.GetCollectionOfObjectValues<WindowsSetting>(WindowsSetting.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.ContactMergeSuggestions>("contactMergeSuggestions", ContactMergeSuggestions);
            writer.WriteBoolValue("contributionToContentDiscoveryAsOrganizationDisabled", ContributionToContentDiscoveryAsOrganizationDisabled);
            writer.WriteBoolValue("contributionToContentDiscoveryDisabled", ContributionToContentDiscoveryDisabled);
            writer.WriteObjectValue<UserInsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<ApiSdk.Models.RegionalAndLanguageSettings>("regionalAndLanguageSettings", RegionalAndLanguageSettings);
            writer.WriteObjectValue<ApiSdk.Models.ShiftPreferences>("shiftPreferences", ShiftPreferences);
            writer.WriteObjectValue<UserStorage>("storage", Storage);
            writer.WriteCollectionOfObjectValues<WindowsSetting>("windows", Windows);
        }
    }
}
