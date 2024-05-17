// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class CustomExtensionHandler : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Indicates which custom workflow extension is executed at this stage. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomAccessPackageWorkflowExtension? CustomExtension { get; set; }
#nullable restore
#else
        public CustomAccessPackageWorkflowExtension CustomExtension { get; set; }
#endif
        /// <summary>Indicates the stage of the access package assignment request workflow when the access package custom extension runs. The possible values are: assignmentRequestCreated, assignmentRequestApproved, assignmentRequestGranted, assignmentRequestRemoved, assignmentFourteenDaysBeforeExpiration, assignmentOneDayBeforeExpiration, unknownFutureValue.</summary>
        public AccessPackageCustomExtensionStage? Stage { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CustomExtensionHandler"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomExtensionHandler CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomExtensionHandler();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"customExtension", n => { CustomExtension = n.GetObjectValue<CustomAccessPackageWorkflowExtension>(CustomAccessPackageWorkflowExtension.CreateFromDiscriminatorValue); } },
                {"stage", n => { Stage = n.GetEnumValue<AccessPackageCustomExtensionStage>(); } },
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
            writer.WriteObjectValue<CustomAccessPackageWorkflowExtension>("customExtension", CustomExtension);
            writer.WriteEnumValue<AccessPackageCustomExtensionStage>("stage", Stage);
        }
    }
}
