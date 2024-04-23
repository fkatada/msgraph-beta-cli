// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.AssignJustInTimeConfiguration {
    public class AssignJustInTimeConfigurationPostRequestBody : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The justInTimeAssignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationJustInTimeAssignmentPolicy? JustInTimeAssignments { get; set; }
#nullable restore
#else
        public DeviceManagementConfigurationJustInTimeAssignmentPolicy JustInTimeAssignments { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AssignJustInTimeConfigurationPostRequestBody"/> and sets the default values.
        /// </summary>
        public AssignJustInTimeConfigurationPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AssignJustInTimeConfigurationPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignJustInTimeConfigurationPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignJustInTimeConfigurationPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"justInTimeAssignments", n => { JustInTimeAssignments = n.GetObjectValue<DeviceManagementConfigurationJustInTimeAssignmentPolicy>(DeviceManagementConfigurationJustInTimeAssignmentPolicy.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceManagementConfigurationJustInTimeAssignmentPolicy>("justInTimeAssignments", JustInTimeAssignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
