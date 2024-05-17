// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class EducationGradingScheme : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The name of the grading scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The grades that make up the scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationGradingSchemeGrade>? Grades { get; set; }
#nullable restore
#else
        public List<EducationGradingSchemeGrade> Grades { get; set; }
#endif
        /// <summary>The display setting for the UI. Indicates whether teachers can grade with points in addition to letter grades.</summary>
        public bool? HidePointsDuringGrading { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EducationGradingScheme"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationGradingScheme CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationGradingScheme();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"grades", n => { Grades = n.GetCollectionOfObjectValues<EducationGradingSchemeGrade>(EducationGradingSchemeGrade.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hidePointsDuringGrading", n => { HidePointsDuringGrading = n.GetBoolValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<EducationGradingSchemeGrade>("grades", Grades);
            writer.WriteBoolValue("hidePointsDuringGrading", HidePointsDuringGrading);
        }
    }
}
