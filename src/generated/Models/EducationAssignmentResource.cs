// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class EducationAssignmentResource : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The dependentResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationAssignmentResource>? DependentResources { get; set; }
#nullable restore
#else
        public List<EducationAssignmentResource> DependentResources { get; set; }
#endif
        /// <summary>Indicates whether this resource should be copied to each student submission for modification and submission. Required</summary>
        public bool? DistributeForStudentWork { get; set; }
        /// <summary>Resource object that has been associated with this assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationResource? Resource { get; set; }
#nullable restore
#else
        public EducationResource Resource { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EducationAssignmentResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationAssignmentResource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignmentResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "dependentResources", n => { DependentResources = n.GetCollectionOfObjectValues<EducationAssignmentResource>(EducationAssignmentResource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "distributeForStudentWork", n => { DistributeForStudentWork = n.GetBoolValue(); } },
                { "resource", n => { Resource = n.GetObjectValue<EducationResource>(EducationResource.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<EducationAssignmentResource>("dependentResources", DependentResources);
            writer.WriteBoolValue("distributeForStudentWork", DistributeForStudentWork);
            writer.WriteObjectValue<EducationResource>("resource", Resource);
        }
    }
}
