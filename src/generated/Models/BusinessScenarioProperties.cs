// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class BusinessScenarioProperties : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier for the bucketDefinition configured in the plannerPlanConfiguration for the scenario. The task will be placed in the corresponding plannerBucket in the target plan. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalBucketId { get; set; }
#nullable restore
#else
        public string ExternalBucketId { get; set; }
#endif
        /// <summary>The identifier for the context of the task. Context is an application controlled value, and tasks can be queried by their externalContextId. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalContextId { get; set; }
#nullable restore
#else
        public string ExternalContextId { get; set; }
#endif
        /// <summary>Application-specific identifier for the task. Every task for the same scenario must have a unique identifier specified for this property. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalObjectId { get; set; }
#nullable restore
#else
        public string ExternalObjectId { get; set; }
#endif
        /// <summary>Application-specific version of the task. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalObjectVersion { get; set; }
#nullable restore
#else
        public string ExternalObjectVersion { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The URL to the application-specific experience for this task. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BusinessScenarioProperties"/> and sets the default values.
        /// </summary>
        public BusinessScenarioProperties()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BusinessScenarioProperties"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BusinessScenarioProperties CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BusinessScenarioProperties();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"externalBucketId", n => { ExternalBucketId = n.GetStringValue(); } },
                {"externalContextId", n => { ExternalContextId = n.GetStringValue(); } },
                {"externalObjectId", n => { ExternalObjectId = n.GetStringValue(); } },
                {"externalObjectVersion", n => { ExternalObjectVersion = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("externalBucketId", ExternalBucketId);
            writer.WriteStringValue("externalContextId", ExternalContextId);
            writer.WriteStringValue("externalObjectId", ExternalObjectId);
            writer.WriteStringValue("externalObjectVersion", ExternalObjectVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
