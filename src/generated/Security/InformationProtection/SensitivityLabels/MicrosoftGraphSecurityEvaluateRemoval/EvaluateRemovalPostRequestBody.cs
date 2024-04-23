// <auto-generated/>
using ApiSdk.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateRemoval {
    public class EvaluateRemovalPostRequestBody : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contentInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.ContentInfo? ContentInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.ContentInfo ContentInfo { get; set; }
#endif
        /// <summary>The downgradeJustification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.DowngradeJustification? DowngradeJustification { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.DowngradeJustification DowngradeJustification { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EvaluateRemovalPostRequestBody"/> and sets the default values.
        /// </summary>
        public EvaluateRemovalPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EvaluateRemovalPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EvaluateRemovalPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateRemovalPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"contentInfo", n => { ContentInfo = n.GetObjectValue<ApiSdk.Models.Security.ContentInfo>(ApiSdk.Models.Security.ContentInfo.CreateFromDiscriminatorValue); } },
                {"downgradeJustification", n => { DowngradeJustification = n.GetObjectValue<ApiSdk.Models.Security.DowngradeJustification>(ApiSdk.Models.Security.DowngradeJustification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Security.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteObjectValue<ApiSdk.Models.Security.DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
