// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class TranslationPreferences : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Translation override behavior for languages, if any.Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TranslationLanguageOverride>? LanguageOverrides { get; set; }
#nullable restore
#else
        public List<TranslationLanguageOverride> LanguageOverrides { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The user&apos;s preferred translation behavior.Returned by default. Not nullable.</summary>
        public ApiSdk.Models.TranslationBehavior? TranslationBehavior { get; set; }
        /// <summary>The list of languages the user does not need translated. This is computed from the authoringLanguages collection in regionalAndLanguageSettings, and the languageOverrides collection in translationPreferences. The list specifies neutral culture values that include the language code without any country or region association. For example, it would specify &apos;fr&apos; for the neutral French culture, but not &apos;fr-FR&apos; for the French culture in France. Returned by default. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UntranslatedLanguages { get; set; }
#nullable restore
#else
        public List<string> UntranslatedLanguages { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TranslationPreferences"/> and sets the default values.
        /// </summary>
        public TranslationPreferences()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TranslationPreferences"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TranslationPreferences CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranslationPreferences();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"languageOverrides", n => { LanguageOverrides = n.GetCollectionOfObjectValues<TranslationLanguageOverride>(TranslationLanguageOverride.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"translationBehavior", n => { TranslationBehavior = n.GetEnumValue<TranslationBehavior>(); } },
                {"untranslatedLanguages", n => { UntranslatedLanguages = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TranslationLanguageOverride>("languageOverrides", LanguageOverrides);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<TranslationBehavior>("translationBehavior", TranslationBehavior);
            writer.WriteCollectionOfPrimitiveValues<string>("untranslatedLanguages", UntranslatedLanguages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
