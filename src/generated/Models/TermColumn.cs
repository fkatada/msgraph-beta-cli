using ApiSdk.Models.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class TermColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether the column will allow more than one value.</summary>
        public bool? AllowMultipleValues { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The parentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Term? ParentTerm { get; set; }
#nullable restore
#else
        public Term ParentTerm { get; set; }
#endif
        /// <summary>Specifies whether to display the entire term path or only the term label.</summary>
        public bool? ShowFullyQualifiedName { get; set; }
        /// <summary>The termSet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.TermStore.Set? TermSet { get; set; }
#nullable restore
#else
        public ApiSdk.Models.TermStore.Set TermSet { get; set; }
#endif
        /// <summary>
        /// Instantiates a new termColumn and sets the default values.
        /// </summary>
        public TermColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TermColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowMultipleValues", n => { AllowMultipleValues = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parentTerm", n => { ParentTerm = n.GetObjectValue<Term>(Term.CreateFromDiscriminatorValue); } },
                {"showFullyQualifiedName", n => { ShowFullyQualifiedName = n.GetBoolValue(); } },
                {"termSet", n => { TermSet = n.GetObjectValue<ApiSdk.Models.TermStore.Set>(ApiSdk.Models.TermStore.Set.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleValues", AllowMultipleValues);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Term>("parentTerm", ParentTerm);
            writer.WriteBoolValue("showFullyQualifiedName", ShowFullyQualifiedName);
            writer.WriteObjectValue<ApiSdk.Models.TermStore.Set>("termSet", TermSet);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
