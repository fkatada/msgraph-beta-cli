// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class DayNote : ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date of the day note.</summary>
        public Date? DayNoteDate { get; set; }
        /// <summary>The draft version of this day note that is viewable by managers. Only contentType text is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? DraftDayNote { get; set; }
#nullable restore
#else
        public ItemBody DraftDayNote { get; set; }
#endif
        /// <summary>The shared version of this day note that is viewable by both employees and managers. Only contentType text is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? SharedDayNote { get; set; }
#nullable restore
#else
        public ItemBody SharedDayNote { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DayNote"/> and sets the default values.
        /// </summary>
        public DayNote() : base()
        {
            OdataType = "#microsoft.graph.dayNote";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DayNote"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DayNote CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DayNote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "dayNoteDate", n => { DayNoteDate = n.GetDateValue(); } },
                { "draftDayNote", n => { DraftDayNote = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                { "sharedDayNote", n => { SharedDayNote = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateValue("dayNoteDate", DayNoteDate);
            writer.WriteObjectValue<ItemBody>("draftDayNote", DraftDayNote);
            writer.WriteObjectValue<ItemBody>("sharedDayNote", SharedDayNote);
        }
    }
}
