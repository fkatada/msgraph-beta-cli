// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IndustryData
{
    #pragma warning disable CS1591
    public class EnrollmentMappings : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The enrollmentMappings member for the class group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SectionRoleReferenceValue>? MemberEnrollmentMappings { get; set; }
#nullable restore
#else
        public List<SectionRoleReferenceValue> MemberEnrollmentMappings { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The enrollmentMappings owner for the class group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SectionRoleReferenceValue>? OwnerEnrollmentMappings { get; set; }
#nullable restore
#else
        public List<SectionRoleReferenceValue> OwnerEnrollmentMappings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EnrollmentMappings"/> and sets the default values.
        /// </summary>
        public EnrollmentMappings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EnrollmentMappings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EnrollmentMappings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnrollmentMappings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "memberEnrollmentMappings", n => { MemberEnrollmentMappings = n.GetCollectionOfObjectValues<SectionRoleReferenceValue>(SectionRoleReferenceValue.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "ownerEnrollmentMappings", n => { OwnerEnrollmentMappings = n.GetCollectionOfObjectValues<SectionRoleReferenceValue>(SectionRoleReferenceValue.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SectionRoleReferenceValue>("memberEnrollmentMappings", MemberEnrollmentMappings);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<SectionRoleReferenceValue>("ownerEnrollmentMappings", OwnerEnrollmentMappings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
