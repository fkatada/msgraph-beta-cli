// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class ContentCustomization : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the content options of External Identities to be customized throughout the authentication flow for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? AttributeCollection { get; set; }
#nullable restore
#else
        public List<KeyValue> AttributeCollection { get; set; }
#endif
        /// <summary>A relative URL for the content options of External Identities to be customized throughout the authentication flow for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttributeCollectionRelativeUrl { get; set; }
#nullable restore
#else
        public string AttributeCollectionRelativeUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The registrationCampaign property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? RegistrationCampaign { get; set; }
#nullable restore
#else
        public List<KeyValue> RegistrationCampaign { get; set; }
#endif
        /// <summary>The registrationCampaignRelativeUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistrationCampaignRelativeUrl { get; set; }
#nullable restore
#else
        public string RegistrationCampaignRelativeUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ContentCustomization"/> and sets the default values.
        /// </summary>
        public ContentCustomization()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ContentCustomization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ContentCustomization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentCustomization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attributeCollection", n => { AttributeCollection = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attributeCollectionRelativeUrl", n => { AttributeCollectionRelativeUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"registrationCampaign", n => { RegistrationCampaign = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"registrationCampaignRelativeUrl", n => { RegistrationCampaignRelativeUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<KeyValue>("attributeCollection", AttributeCollection);
            writer.WriteStringValue("attributeCollectionRelativeUrl", AttributeCollectionRelativeUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<KeyValue>("registrationCampaign", RegistrationCampaign);
            writer.WriteStringValue("registrationCampaignRelativeUrl", RegistrationCampaignRelativeUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
