// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Admin.Windows.Updates.DeploymentAudiences.Item.MicrosoftGraphWindowsUpdatesUpdateAudienceById {
    #pragma warning disable CS1591
    public class UpdateAudienceByIdPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The addExclusions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AddExclusions { get; set; }
#nullable restore
#else
        public List<string> AddExclusions { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The addMembers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AddMembers { get; set; }
#nullable restore
#else
        public List<string> AddMembers { get; set; }
#endif
        /// <summary>The memberEntityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberEntityType { get; set; }
#nullable restore
#else
        public string MemberEntityType { get; set; }
#endif
        /// <summary>The removeExclusions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RemoveExclusions { get; set; }
#nullable restore
#else
        public List<string> RemoveExclusions { get; set; }
#endif
        /// <summary>The removeMembers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RemoveMembers { get; set; }
#nullable restore
#else
        public List<string> RemoveMembers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="UpdateAudienceByIdPostRequestBody"/> and sets the default values.
        /// </summary>
        public UpdateAudienceByIdPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UpdateAudienceByIdPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateAudienceByIdPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAudienceByIdPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"addExclusions", n => { AddExclusions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"addMembers", n => { AddMembers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"memberEntityType", n => { MemberEntityType = n.GetStringValue(); } },
                {"removeExclusions", n => { RemoveExclusions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"removeMembers", n => { RemoveMembers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("addExclusions", AddExclusions);
            writer.WriteCollectionOfPrimitiveValues<string>("addMembers", AddMembers);
            writer.WriteStringValue("memberEntityType", MemberEntityType);
            writer.WriteCollectionOfPrimitiveValues<string>("removeExclusions", RemoveExclusions);
            writer.WriteCollectionOfPrimitiveValues<string>("removeMembers", RemoveMembers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
