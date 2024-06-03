// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IndustryData
{
    #pragma warning disable CS1591
    public class UserMatchingSetting : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The RefUserMatchTarget for matching a user from the source with a Microsoft Entra user object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserMatchTargetReferenceValue? MatchTarget { get; set; }
#nullable restore
#else
        public UserMatchTargetReferenceValue MatchTarget { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The priority order to apply when a user has multiple RefRole codes assigned.</summary>
        public int? PriorityOrder { get; set; }
        /// <summary>The roleGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IndustryData.RoleGroup? RoleGroup { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IndustryData.RoleGroup RoleGroup { get; set; }
#endif
        /// <summary>The sourceIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentifierTypeReferenceValue? SourceIdentifier { get; set; }
#nullable restore
#else
        public IdentifierTypeReferenceValue SourceIdentifier { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="UserMatchingSetting"/> and sets the default values.
        /// </summary>
        public UserMatchingSetting()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserMatchingSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserMatchingSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserMatchingSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "matchTarget", n => { MatchTarget = n.GetObjectValue<UserMatchTargetReferenceValue>(UserMatchTargetReferenceValue.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "priorityOrder", n => { PriorityOrder = n.GetIntValue(); } },
                { "roleGroup", n => { RoleGroup = n.GetObjectValue<ApiSdk.Models.IndustryData.RoleGroup>(ApiSdk.Models.IndustryData.RoleGroup.CreateFromDiscriminatorValue); } },
                { "sourceIdentifier", n => { SourceIdentifier = n.GetObjectValue<IdentifierTypeReferenceValue>(IdentifierTypeReferenceValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UserMatchTargetReferenceValue>("matchTarget", MatchTarget);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("priorityOrder", PriorityOrder);
            writer.WriteObjectValue<ApiSdk.Models.IndustryData.RoleGroup>("roleGroup", RoleGroup);
            writer.WriteObjectValue<IdentifierTypeReferenceValue>("sourceIdentifier", SourceIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
