// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class TrainingCampaignReportOverview : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
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
        /// <summary>Aggregate data of training completion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TrainingEventsContent? TrainingModuleCompletion { get; set; }
#nullable restore
#else
        public TrainingEventsContent TrainingModuleCompletion { get; set; }
#endif
        /// <summary>Aggregate data of training mail delivery over the course of the training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TrainingNotificationDelivery? TrainingNotificationDeliveryStatus { get; set; }
#nullable restore
#else
        public TrainingNotificationDelivery TrainingNotificationDeliveryStatus { get; set; }
#endif
        /// <summary>Aggregate data of users training progress.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserTrainingCompletionSummary? UserCompletionStatus { get; set; }
#nullable restore
#else
        public UserTrainingCompletionSummary UserCompletionStatus { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TrainingCampaignReportOverview"/> and sets the default values.
        /// </summary>
        public TrainingCampaignReportOverview()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TrainingCampaignReportOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TrainingCampaignReportOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrainingCampaignReportOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "trainingModuleCompletion", n => { TrainingModuleCompletion = n.GetObjectValue<TrainingEventsContent>(TrainingEventsContent.CreateFromDiscriminatorValue); } },
                { "trainingNotificationDeliveryStatus", n => { TrainingNotificationDeliveryStatus = n.GetObjectValue<TrainingNotificationDelivery>(TrainingNotificationDelivery.CreateFromDiscriminatorValue); } },
                { "userCompletionStatus", n => { UserCompletionStatus = n.GetObjectValue<UserTrainingCompletionSummary>(UserTrainingCompletionSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TrainingEventsContent>("trainingModuleCompletion", TrainingModuleCompletion);
            writer.WriteObjectValue<TrainingNotificationDelivery>("trainingNotificationDeliveryStatus", TrainingNotificationDeliveryStatus);
            writer.WriteObjectValue<UserTrainingCompletionSummary>("userCompletionStatus", UserCompletionStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
