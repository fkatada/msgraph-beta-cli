// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class EducationIdentityMatchingOptions : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The appliesTo property</summary>
        public EducationUserRole? AppliesTo { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The name of the source property, which should be a field name in the source data. This property is case-sensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourcePropertyName { get; set; }
#nullable restore
#else
        public string SourcePropertyName { get; set; }
#endif
        /// <summary>The domain to suffix with the source property to match on the target. If provided as null, the source property will be used to match with the target property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetDomain { get; set; }
#nullable restore
#else
        public string TargetDomain { get; set; }
#endif
        /// <summary>The name of the target property, which should be a valid property in Microsoft Entra ID. This property is case-sensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetPropertyName { get; set; }
#nullable restore
#else
        public string TargetPropertyName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EducationIdentityMatchingOptions"/> and sets the default values.
        /// </summary>
        public EducationIdentityMatchingOptions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EducationIdentityMatchingOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EducationIdentityMatchingOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationIdentityMatchingOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appliesTo", n => { AppliesTo = n.GetEnumValue<EducationUserRole>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sourcePropertyName", n => { SourcePropertyName = n.GetStringValue(); } },
                { "targetDomain", n => { TargetDomain = n.GetStringValue(); } },
                { "targetPropertyName", n => { TargetPropertyName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<EducationUserRole>("appliesTo", AppliesTo);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sourcePropertyName", SourcePropertyName);
            writer.WriteStringValue("targetDomain", TargetDomain);
            writer.WriteStringValue("targetPropertyName", TargetPropertyName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
