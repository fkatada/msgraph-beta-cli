// <auto-generated/>
using ApiSdk.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Exclusions.MicrosoftGraphWindowsUpdatesUnenrollAssetsById {
    #pragma warning disable CS1591
    public class UnenrollAssetsByIdPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ids property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Ids { get; set; }
#nullable restore
#else
        public List<string> Ids { get; set; }
#endif
        /// <summary>The memberEntityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberEntityType { get; set; }
#nullable restore
#else
        public string MemberEntityType { get; set; }
#endif
        /// <summary>The updateCategory property</summary>
        public ApiSdk.Models.WindowsUpdates.UpdateCategory? UpdateCategory { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="UnenrollAssetsByIdPostRequestBody"/> and sets the default values.
        /// </summary>
        public UnenrollAssetsByIdPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UnenrollAssetsByIdPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UnenrollAssetsByIdPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnenrollAssetsByIdPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"ids", n => { Ids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"memberEntityType", n => { MemberEntityType = n.GetStringValue(); } },
                {"updateCategory", n => { UpdateCategory = n.GetEnumValue<UpdateCategory>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("ids", Ids);
            writer.WriteStringValue("memberEntityType", MemberEntityType);
            writer.WriteEnumValue<UpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
