// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants {
    #pragma warning disable CS1591
    public class ManagementTemplateStepVersion : ApiSdk.Models.Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The acceptedFor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagementTemplateStep? AcceptedFor { get; set; }
#nullable restore
#else
        public ManagementTemplateStep AcceptedFor { get; set; }
#endif
        /// <summary>The contentMarkdown property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentMarkdown { get; set; }
#nullable restore
#else
        public string ContentMarkdown { get; set; }
#endif
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId { get; set; }
#nullable restore
#else
        public string CreatedByUserId { get; set; }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The deployments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateStepDeployment>? Deployments { get; set; }
#nullable restore
#else
        public List<ManagementTemplateStepDeployment> Deployments { get; set; }
#endif
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId { get; set; }
#nullable restore
#else
        public string LastActionByUserId { get; set; }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The templateStep property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagementTemplateStep? TemplateStep { get; set; }
#nullable restore
#else
        public ManagementTemplateStep TemplateStep { get; set; }
#endif
        /// <summary>The version property</summary>
        public int? Version { get; set; }
        /// <summary>The versionInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionInformation { get; set; }
#nullable restore
#else
        public string VersionInformation { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ManagementTemplateStepVersion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementTemplateStepVersion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStepVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"acceptedFor", n => { AcceptedFor = n.GetObjectValue<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue); } },
                {"contentMarkdown", n => { ContentMarkdown = n.GetStringValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deployments", n => { Deployments = n.GetCollectionOfObjectValues<ManagementTemplateStepDeployment>(ManagementTemplateStepDeployment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"templateStep", n => { TemplateStep = n.GetObjectValue<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetIntValue(); } },
                {"versionInformation", n => { VersionInformation = n.GetStringValue(); } },
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
            writer.WriteObjectValue<ManagementTemplateStep>("acceptedFor", AcceptedFor);
            writer.WriteStringValue("contentMarkdown", ContentMarkdown);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepDeployment>("deployments", Deployments);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ManagementTemplateStep>("templateStep", TemplateStep);
            writer.WriteIntValue("version", Version);
            writer.WriteStringValue("versionInformation", VersionInformation);
        }
    }
}
