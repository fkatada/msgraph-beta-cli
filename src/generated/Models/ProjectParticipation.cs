// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class ProjectParticipation : ItemFacet, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Contains categories a user has associated with the project (for example, digital transformation, oil rig).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories { get; set; }
#nullable restore
#else
        public List<string> Categories { get; set; }
#endif
        /// <summary>Contains detailed information about the client the project was for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CompanyDetail? Client { get; set; }
#nullable restore
#else
        public CompanyDetail Client { get; set; }
#endif
        /// <summary>Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CollaborationTags { get; set; }
#nullable restore
#else
        public List<string> CollaborationTags { get; set; }
#endif
        /// <summary>Lists people that also worked on the project.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RelatedPerson>? Colleagues { get; set; }
#nullable restore
#else
        public List<RelatedPerson> Colleagues { get; set; }
#endif
        /// <summary>Contains detail about the user&apos;s role on the project.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PositionDetail? Detail { get; set; }
#nullable restore
#else
        public PositionDetail Detail { get; set; }
#endif
        /// <summary>Contains a friendly name for the project.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The Person or people who sponsored the project.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RelatedPerson>? Sponsors { get; set; }
#nullable restore
#else
        public List<RelatedPerson> Sponsors { get; set; }
#endif
        /// <summary>The thumbnailUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailUrl { get; set; }
#nullable restore
#else
        public string ThumbnailUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ProjectParticipation"/> and sets the default values.
        /// </summary>
        public ProjectParticipation() : base()
        {
            OdataType = "#microsoft.graph.projectParticipation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ProjectParticipation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProjectParticipation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProjectParticipation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"client", n => { Client = n.GetObjectValue<CompanyDetail>(CompanyDetail.CreateFromDiscriminatorValue); } },
                {"collaborationTags", n => { CollaborationTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"colleagues", n => { Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue)?.ToList(); } },
                {"detail", n => { Detail = n.GetObjectValue<PositionDetail>(PositionDetail.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"sponsors", n => { Sponsors = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue)?.ToList(); } },
                {"thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteObjectValue<CompanyDetail>("client", Client);
            writer.WriteCollectionOfPrimitiveValues<string>("collaborationTags", CollaborationTags);
            writer.WriteCollectionOfObjectValues<RelatedPerson>("colleagues", Colleagues);
            writer.WriteObjectValue<PositionDetail>("detail", Detail);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<RelatedPerson>("sponsors", Sponsors);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
        }
    }
}
