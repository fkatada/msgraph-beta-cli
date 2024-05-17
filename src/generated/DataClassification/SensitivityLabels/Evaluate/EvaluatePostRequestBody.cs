// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DataClassification.SensitivityLabels.Evaluate {
    #pragma warning disable CS1591
    public class EvaluatePostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The currentLabel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.CurrentLabel? CurrentLabel { get; set; }
#nullable restore
#else
        public ApiSdk.Models.CurrentLabel CurrentLabel { get; set; }
#endif
        /// <summary>The discoveredSensitiveTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DiscoveredSensitiveType>? DiscoveredSensitiveTypes { get; set; }
#nullable restore
#else
        public List<DiscoveredSensitiveType> DiscoveredSensitiveTypes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EvaluatePostRequestBody"/> and sets the default values.
        /// </summary>
        public EvaluatePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EvaluatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EvaluatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"currentLabel", n => { CurrentLabel = n.GetObjectValue<ApiSdk.Models.CurrentLabel>(ApiSdk.Models.CurrentLabel.CreateFromDiscriminatorValue); } },
                {"discoveredSensitiveTypes", n => { DiscoveredSensitiveTypes = n.GetCollectionOfObjectValues<DiscoveredSensitiveType>(DiscoveredSensitiveType.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.CurrentLabel>("currentLabel", CurrentLabel);
            writer.WriteCollectionOfObjectValues<DiscoveredSensitiveType>("discoveredSensitiveTypes", DiscoveredSensitiveTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
