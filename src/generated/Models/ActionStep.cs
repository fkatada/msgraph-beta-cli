// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class ActionStep : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>A link to the documentation or Microsoft Entra admin center page that is associated with the action step.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ActionUrl? ActionUrl { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ActionUrl ActionUrl { get; set; }
#endif
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
        /// <summary>Indicates the position for this action in the order of the collection of actions to be taken.</summary>
        public long? StepNumber { get; set; }
        /// <summary>Friendly description of the action to take.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ActionStep"/> and sets the default values.
        /// </summary>
        public ActionStep()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ActionStep"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ActionStep CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActionStep();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"actionUrl", n => { ActionUrl = n.GetObjectValue<ApiSdk.Models.ActionUrl>(ApiSdk.Models.ActionUrl.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"stepNumber", n => { StepNumber = n.GetLongValue(); } },
                {"text", n => { Text = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.ActionUrl>("actionUrl", ActionUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("stepNumber", StepNumber);
            writer.WriteStringValue("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
