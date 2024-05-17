// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class TeamworkAccountConfiguration : IAdditionalDataHolder, IParsable 
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
        /// <summary>The account used to sync the calendar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkOnPremisesCalendarSyncConfiguration? OnPremisesCalendarSyncConfiguration { get; set; }
#nullable restore
#else
        public TeamworkOnPremisesCalendarSyncConfiguration OnPremisesCalendarSyncConfiguration { get; set; }
#endif
        /// <summary>The supported client for Teams Rooms devices. The possible values are: unknown, skypeDefaultAndTeams, teamsDefaultAndSkype, skypeOnly, teamsOnly, unknownFutureValue.</summary>
        public TeamworkSupportedClient? SupportedClient { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="TeamworkAccountConfiguration"/> and sets the default values.
        /// </summary>
        public TeamworkAccountConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamworkAccountConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkAccountConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkAccountConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onPremisesCalendarSyncConfiguration", n => { OnPremisesCalendarSyncConfiguration = n.GetObjectValue<TeamworkOnPremisesCalendarSyncConfiguration>(TeamworkOnPremisesCalendarSyncConfiguration.CreateFromDiscriminatorValue); } },
                {"supportedClient", n => { SupportedClient = n.GetEnumValue<TeamworkSupportedClient>(); } },
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
            writer.WriteObjectValue<TeamworkOnPremisesCalendarSyncConfiguration>("onPremisesCalendarSyncConfiguration", OnPremisesCalendarSyncConfiguration);
            writer.WriteEnumValue<TeamworkSupportedClient>("supportedClient", SupportedClient);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
