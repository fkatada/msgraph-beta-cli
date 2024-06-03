// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class OnPremisesApplicationSegment : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If you&apos;re configuring a traffic manager in front of multiple App Proxy application segments, contains the user-friendly URL that will point to the traffic manager.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternateUrl { get; set; }
#nullable restore
#else
        public string AlternateUrl { get; set; }
#endif
        /// <summary>CORS Rule definition for a particular application segment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CorsConfiguration>? CorsConfigurations { get; set; }
#nullable restore
#else
        public List<CorsConfiguration> CorsConfigurations { get; set; }
#endif
        /// <summary>The published external URL for the application segment; for example, https://intranet.contoso.com./</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalUrl { get; set; }
#nullable restore
#else
        public string ExternalUrl { get; set; }
#endif
        /// <summary>The internal URL of the application segment; for example, https://intranet/.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalUrl { get; set; }
#nullable restore
#else
        public string InternalUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="OnPremisesApplicationSegment"/> and sets the default values.
        /// </summary>
        public OnPremisesApplicationSegment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OnPremisesApplicationSegment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesApplicationSegment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesApplicationSegment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alternateUrl", n => { AlternateUrl = n.GetStringValue(); } },
                { "corsConfigurations", n => { CorsConfigurations = n.GetCollectionOfObjectValues<CorsConfiguration>(CorsConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                { "externalUrl", n => { ExternalUrl = n.GetStringValue(); } },
                { "internalUrl", n => { InternalUrl = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alternateUrl", AlternateUrl);
            writer.WriteCollectionOfObjectValues<CorsConfiguration>("corsConfigurations", CorsConfigurations);
            writer.WriteStringValue("externalUrl", ExternalUrl);
            writer.WriteStringValue("internalUrl", InternalUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
