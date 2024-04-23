// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class WorkPosition : ItemFacet, IParsable 
    {
        /// <summary>Categories that the user has associated with this position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories { get; set; }
#nullable restore
#else
        public List<string> Categories { get; set; }
#endif
        /// <summary>Colleagues that are associated with this position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RelatedPerson>? Colleagues { get; set; }
#nullable restore
#else
        public List<RelatedPerson> Colleagues { get; set; }
#endif
        /// <summary>The detail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PositionDetail? Detail { get; set; }
#nullable restore
#else
        public PositionDetail Detail { get; set; }
#endif
        /// <summary>Denotes whether or not the position is current.</summary>
        public bool? IsCurrent { get; set; }
        /// <summary>Contains detail of the user&apos;s manager in this position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RelatedPerson? Manager { get; set; }
#nullable restore
#else
        public RelatedPerson Manager { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WorkPosition"/> and sets the default values.
        /// </summary>
        public WorkPosition() : base()
        {
            OdataType = "#microsoft.graph.workPosition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WorkPosition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkPosition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkPosition();
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
                {"colleagues", n => { Colleagues = n.GetCollectionOfObjectValues<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue)?.ToList(); } },
                {"detail", n => { Detail = n.GetObjectValue<PositionDetail>(PositionDetail.CreateFromDiscriminatorValue); } },
                {"isCurrent", n => { IsCurrent = n.GetBoolValue(); } },
                {"manager", n => { Manager = n.GetObjectValue<RelatedPerson>(RelatedPerson.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<RelatedPerson>("colleagues", Colleagues);
            writer.WriteObjectValue<PositionDetail>("detail", Detail);
            writer.WriteBoolValue("isCurrent", IsCurrent);
            writer.WriteObjectValue<RelatedPerson>("manager", Manager);
        }
    }
}
