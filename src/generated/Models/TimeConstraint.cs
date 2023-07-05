using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class TimeConstraint : IAdditionalDataHolder, IParsable {
        /// <summary>The nature of the activity, optional. The possible values are: work, personal, unrestricted, or unknown.</summary>
        public ApiSdk.Models.ActivityDomain? ActivityDomain { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The timeSlots property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeSlot>? TimeSlots { get; set; }
#nullable restore
#else
        public List<TimeSlot> TimeSlots { get; set; }
#endif
        /// <summary>
        /// Instantiates a new timeConstraint and sets the default values.
        /// </summary>
        public TimeConstraint() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityDomain", n => { ActivityDomain = n.GetEnumValue<ActivityDomain>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"timeSlots", n => { TimeSlots = n.GetCollectionOfObjectValues<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ActivityDomain>("activityDomain", ActivityDomain);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<TimeSlot>("timeSlots", TimeSlots);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
