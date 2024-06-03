// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class RiskUserActivity : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The possible values are none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue.</summary>
        public RiskDetail? Detail { get; set; }
        /// <summary>List of risk event types. Deprecated. Use riskEventType instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskEventType?>? EventTypes { get; set; }
#nullable restore
#else
        public List<RiskEventType?> EventTypes { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The type of risk event detected. The possible values are: anonymizedIPAddress, investigationsThreatIntelligence, investigationsThreatIntelligenceSigninLinked,leakedCredentials, maliciousIPAddress, maliciousIPAddressValidCredentialsBlockedIP, malwareInfectedIPAddress, mcasImpossibleTravel, mcasSuspiciousInboxManipulationRules, suspiciousAPITraffic, suspiciousIPAddress,   unfamiliarFeatures, unlikelyTravel. For more information about each value, see Risk types and detection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RiskEventTypes { get; set; }
#nullable restore
#else
        public List<string> RiskEventTypes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RiskUserActivity"/> and sets the default values.
        /// </summary>
        public RiskUserActivity()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RiskUserActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RiskUserActivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RiskUserActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detail", n => { Detail = n.GetEnumValue<RiskDetail>(); } },
                { "eventTypes", n => { EventTypes = n.GetCollectionOfEnumValues<RiskEventType>()?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "riskEventTypes", n => { RiskEventTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RiskDetail>("detail", Detail);
            writer.WriteCollectionOfEnumValues<RiskEventType>("eventTypes", EventTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("riskEventTypes", RiskEventTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
