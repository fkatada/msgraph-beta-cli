// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ItemFacet : Entity, IParsable 
    {
        /// <summary>The audiences that are able to see the values contained within the associated entity. Possible values are: me, family, contacts, groupMembers, organization, federatedOrganizations, everyone, unknownFutureValue.</summary>
        public ApiSdk.Models.AllowedAudiences? AllowedAudiences { get; set; }
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Contains inference detail if the entity is inferred by the creating or modifying application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InferenceData? Inference { get; set; }
#nullable restore
#else
        public InferenceData Inference { get; set; }
#endif
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>The lastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>Provides the dateTimeOffset for when the entity was created.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Where the values within an entity originated if synced from another service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PersonDataSources? Source { get; set; }
#nullable restore
#else
        public PersonDataSources Source { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ItemFacet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemFacet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.educationalActivity" => new EducationalActivity(),
                "#microsoft.graph.itemAddress" => new ItemAddress(),
                "#microsoft.graph.itemEmail" => new ItemEmail(),
                "#microsoft.graph.itemPatent" => new ItemPatent(),
                "#microsoft.graph.itemPhone" => new ItemPhone(),
                "#microsoft.graph.itemPublication" => new ItemPublication(),
                "#microsoft.graph.languageProficiency" => new LanguageProficiency(),
                "#microsoft.graph.personAnnotation" => new PersonAnnotation(),
                "#microsoft.graph.personAnnualEvent" => new PersonAnnualEvent(),
                "#microsoft.graph.personAward" => new PersonAward(),
                "#microsoft.graph.personCertification" => new PersonCertification(),
                "#microsoft.graph.personInterest" => new PersonInterest(),
                "#microsoft.graph.personName" => new PersonName(),
                "#microsoft.graph.personResponsibility" => new PersonResponsibility(),
                "#microsoft.graph.personWebsite" => new PersonWebsite(),
                "#microsoft.graph.projectParticipation" => new ProjectParticipation(),
                "#microsoft.graph.skillProficiency" => new SkillProficiency(),
                "#microsoft.graph.userAccountInformation" => new UserAccountInformation(),
                "#microsoft.graph.webAccount" => new WebAccount(),
                "#microsoft.graph.workPosition" => new WorkPosition(),
                _ => new ItemFacet(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"allowedAudiences", n => { AllowedAudiences = n.GetEnumValue<AllowedAudiences>(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"inference", n => { Inference = n.GetObjectValue<InferenceData>(InferenceData.CreateFromDiscriminatorValue); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"source", n => { Source = n.GetObjectValue<PersonDataSources>(PersonDataSources.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AllowedAudiences>("allowedAudiences", AllowedAudiences);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<InferenceData>("inference", Inference);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<PersonDataSources>("source", Source);
        }
    }
}
