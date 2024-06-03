// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Ediscovery
{
    #pragma warning disable CS1591
    public class TopicModelingSettings : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>To learn more, see Adjust maximum number of themes dynamically.</summary>
        public bool? DynamicallyAdjustTopicCount { get; set; }
        /// <summary>To learn more, see Include numbers in themes.</summary>
        public bool? IgnoreNumbers { get; set; }
        /// <summary>Indicates whether themes are enabled for the case.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>To learn more, see Maximum number of themes.</summary>
        public int? TopicCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="TopicModelingSettings"/> and sets the default values.
        /// </summary>
        public TopicModelingSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TopicModelingSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TopicModelingSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TopicModelingSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dynamicallyAdjustTopicCount", n => { DynamicallyAdjustTopicCount = n.GetBoolValue(); } },
                { "ignoreNumbers", n => { IgnoreNumbers = n.GetBoolValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "topicCount", n => { TopicCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("dynamicallyAdjustTopicCount", DynamicallyAdjustTopicCount);
            writer.WriteBoolValue("ignoreNumbers", IgnoreNumbers);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("topicCount", TopicCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
