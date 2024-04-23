// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PersonName : ItemFacet, IParsable 
    {
        /// <summary>Provides an ordered rendering of firstName and lastName depending on the locale of the user or their device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>First name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? First { get; set; }
#nullable restore
#else
        public string First { get; set; }
#endif
        /// <summary>Initials of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Initials { get; set; }
#nullable restore
#else
        public string Initials { get; set; }
#endif
        /// <summary>Contains the name for the language (en-US, no-NB, en-AU) following IETF BCP47 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag { get; set; }
#nullable restore
#else
        public string LanguageTag { get; set; }
#endif
        /// <summary>Last name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Last { get; set; }
#nullable restore
#else
        public string Last { get; set; }
#endif
        /// <summary>Maiden name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Maiden { get; set; }
#nullable restore
#else
        public string Maiden { get; set; }
#endif
        /// <summary>Middle name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Middle { get; set; }
#nullable restore
#else
        public string Middle { get; set; }
#endif
        /// <summary>Nickname of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nickname { get; set; }
#nullable restore
#else
        public string Nickname { get; set; }
#endif
        /// <summary>Guidance on how to pronounce the users name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PersonNamePronounciation? Pronunciation { get; set; }
#nullable restore
#else
        public PersonNamePronounciation Pronunciation { get; set; }
#endif
        /// <summary>Designators used after the users name (eg: PhD.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Suffix { get; set; }
#nullable restore
#else
        public string Suffix { get; set; }
#endif
        /// <summary>Honorifics used to prefix a users name (eg: Dr, Sir, Madam, Mrs.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PersonName"/> and sets the default values.
        /// </summary>
        public PersonName() : base()
        {
            OdataType = "#microsoft.graph.personName";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PersonName"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PersonName CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonName();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"first", n => { First = n.GetStringValue(); } },
                {"initials", n => { Initials = n.GetStringValue(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"last", n => { Last = n.GetStringValue(); } },
                {"maiden", n => { Maiden = n.GetStringValue(); } },
                {"middle", n => { Middle = n.GetStringValue(); } },
                {"nickname", n => { Nickname = n.GetStringValue(); } },
                {"pronunciation", n => { Pronunciation = n.GetObjectValue<PersonNamePronounciation>(PersonNamePronounciation.CreateFromDiscriminatorValue); } },
                {"suffix", n => { Suffix = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("first", First);
            writer.WriteStringValue("initials", Initials);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("last", Last);
            writer.WriteStringValue("maiden", Maiden);
            writer.WriteStringValue("middle", Middle);
            writer.WriteStringValue("nickname", Nickname);
            writer.WriteObjectValue<PersonNamePronounciation>("pronunciation", Pronunciation);
            writer.WriteStringValue("suffix", Suffix);
            writer.WriteStringValue("title", Title);
        }
    }
}
