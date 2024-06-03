// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.IdentityGovernance.AccessReviews.Decisions.Item.Instance.Decisions.RecordAllDecisions
{
    #pragma warning disable CS1591
    public class RecordAllDecisionsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The decision property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Decision { get; set; }
#nullable restore
#else
        public string Decision { get; set; }
#endif
        /// <summary>The justification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification { get; set; }
#nullable restore
#else
        public string Justification { get; set; }
#endif
        /// <summary>The principalId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId { get; set; }
#nullable restore
#else
        public string PrincipalId { get; set; }
#endif
        /// <summary>The resourceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId { get; set; }
#nullable restore
#else
        public string ResourceId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RecordAllDecisionsPostRequestBody"/> and sets the default values.
        /// </summary>
        public RecordAllDecisionsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RecordAllDecisionsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RecordAllDecisionsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecordAllDecisionsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "decision", n => { Decision = n.GetStringValue(); } },
                { "justification", n => { Justification = n.GetStringValue(); } },
                { "principalId", n => { PrincipalId = n.GetStringValue(); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("decision", Decision);
            writer.WriteStringValue("justification", Justification);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
