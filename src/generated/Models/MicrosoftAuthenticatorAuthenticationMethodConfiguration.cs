// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class MicrosoftAuthenticatorAuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of Microsoft Authenticator settings such as number matching and location context, and whether they are enabled for all users or specific users only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MicrosoftAuthenticatorFeatureSettings? FeatureSettings { get; set; }
#nullable restore
#else
        public MicrosoftAuthenticatorFeatureSettings FeatureSettings { get; set; }
#endif
        /// <summary>A collection of groups that are enabled to use the authentication method. Expanded by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MicrosoftAuthenticatorAuthenticationMethodTarget>? IncludeTargets { get; set; }
#nullable restore
#else
        public List<MicrosoftAuthenticatorAuthenticationMethodTarget> IncludeTargets { get; set; }
#endif
        /// <summary>true if users can use the OTP code generated by the Microsoft Authenticator app, false otherwise.</summary>
        public bool? IsSoftwareOathEnabled { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftAuthenticatorAuthenticationMethodConfiguration"/> and sets the default values.
        /// </summary>
        public MicrosoftAuthenticatorAuthenticationMethodConfiguration() : base()
        {
            OdataType = "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MicrosoftAuthenticatorAuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftAuthenticatorAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftAuthenticatorAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "featureSettings", n => { FeatureSettings = n.GetObjectValue<MicrosoftAuthenticatorFeatureSettings>(MicrosoftAuthenticatorFeatureSettings.CreateFromDiscriminatorValue); } },
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethodTarget>(MicrosoftAuthenticatorAuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isSoftwareOathEnabled", n => { IsSoftwareOathEnabled = n.GetBoolValue(); } },
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
            writer.WriteObjectValue<MicrosoftAuthenticatorFeatureSettings>("featureSettings", FeatureSettings);
            writer.WriteCollectionOfObjectValues<MicrosoftAuthenticatorAuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteBoolValue("isSoftwareOathEnabled", IsSoftwareOathEnabled);
        }
    }
}
