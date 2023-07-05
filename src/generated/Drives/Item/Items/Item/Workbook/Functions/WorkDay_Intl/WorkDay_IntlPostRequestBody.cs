using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.WorkDay_Intl {
    public class WorkDay_IntlPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The days property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Days { get; set; }
#nullable restore
#else
        public Json Days { get; set; }
#endif
        /// <summary>The holidays property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Holidays { get; set; }
#nullable restore
#else
        public Json Holidays { get; set; }
#endif
        /// <summary>The startDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartDate { get; set; }
#nullable restore
#else
        public Json StartDate { get; set; }
#endif
        /// <summary>The weekend property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Weekend { get; set; }
#nullable restore
#else
        public Json Weekend { get; set; }
#endif
        /// <summary>
        /// Instantiates a new workDay_IntlPostRequestBody and sets the default values.
        /// </summary>
        public WorkDay_IntlPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkDay_IntlPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkDay_IntlPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"days", n => { Days = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"holidays", n => { Holidays = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startDate", n => { StartDate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"weekend", n => { Weekend = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("days", Days);
            writer.WriteObjectValue<Json>("holidays", Holidays);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteObjectValue<Json>("weekend", Weekend);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
