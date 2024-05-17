// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceManagement.ManagedDevices.Item.TriggerConfigurationManagerAction {
    #pragma warning disable CS1591
    public class TriggerConfigurationManagerActionPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Parameter for action triggerConfigurationManagerAction</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ConfigurationManagerAction? ConfigurationManagerAction { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ConfigurationManagerAction ConfigurationManagerAction { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TriggerConfigurationManagerActionPostRequestBody"/> and sets the default values.
        /// </summary>
        public TriggerConfigurationManagerActionPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TriggerConfigurationManagerActionPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TriggerConfigurationManagerActionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TriggerConfigurationManagerActionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"configurationManagerAction", n => { ConfigurationManagerAction = n.GetObjectValue<ApiSdk.Models.ConfigurationManagerAction>(ApiSdk.Models.ConfigurationManagerAction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.ConfigurationManagerAction>("configurationManagerAction", ConfigurationManagerAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
