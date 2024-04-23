// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class CorsConfiguration : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The request headers that the origin domain may specify on the CORS request. The wildcard character * indicates that any header beginning with the specified prefix is allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedHeaders { get; set; }
#nullable restore
#else
        public List<string> AllowedHeaders { get; set; }
#endif
        /// <summary>The HTTP request methods that the origin domain may use for a CORS request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedMethods { get; set; }
#nullable restore
#else
        public List<string> AllowedMethods { get; set; }
#endif
        /// <summary>The origin domains that are permitted to make a request against the service via CORS. The origin domain is the domain from which the request originates. The origin must be an exact case-sensitive match with the origin that the user age sends to the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedOrigins { get; set; }
#nullable restore
#else
        public List<string> AllowedOrigins { get; set; }
#endif
        /// <summary>The maximum amount of time that a browser should cache the response to the preflight OPTIONS request.</summary>
        public int? MaxAgeInSeconds { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Resource within the application segment for which CORS permissions are granted. / grants permission for whole app segment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Resource { get; set; }
#nullable restore
#else
        public string Resource { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CorsConfiguration"/> and sets the default values.
        /// </summary>
        public CorsConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CorsConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CorsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CorsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"allowedHeaders", n => { AllowedHeaders = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"allowedMethods", n => { AllowedMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"allowedOrigins", n => { AllowedOrigins = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"maxAgeInSeconds", n => { MaxAgeInSeconds = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedHeaders", AllowedHeaders);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedMethods", AllowedMethods);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedOrigins", AllowedOrigins);
            writer.WriteIntValue("maxAgeInSeconds", MaxAgeInSeconds);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("resource", Resource);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
