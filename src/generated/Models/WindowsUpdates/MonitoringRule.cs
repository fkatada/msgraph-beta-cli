// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.WindowsUpdates {
    #pragma warning disable CS1591
    public class MonitoringRule : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The action triggered when the threshold for the given signal is reached. Possible values are: alertError, pauseDeployment, offerFallback, unknownFutureValue. The offerFallback member is only supported on feature update deployments of Windows 11 and must be paired with the ineligible signal. The fallback version offered is the version 22H2 of Windows 10.</summary>
        public MonitoringAction? Action { get; set; }
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
        /// <summary>The signal to monitor. Possible values are: rollback, ineligible, unknownFutureValue. The ineligible member is only supported on feature update deployments of Windows 11 and must be paired with the offerFallback action.</summary>
        public MonitoringSignal? Signal { get; set; }
        /// <summary>The threshold for a signal at which to trigger the action. An integer from 1 to 100 (inclusive). This value is ignored when the signal is ineligible and the action is offerFallback.</summary>
        public int? Threshold { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="MonitoringRule"/> and sets the default values.
        /// </summary>
        public MonitoringRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MonitoringRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MonitoringRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MonitoringRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"action", n => { Action = n.GetEnumValue<MonitoringAction>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"signal", n => { Signal = n.GetEnumValue<MonitoringSignal>(); } },
                {"threshold", n => { Threshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MonitoringAction>("action", Action);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<MonitoringSignal>("signal", Signal);
            writer.WriteIntValue("threshold", Threshold);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
