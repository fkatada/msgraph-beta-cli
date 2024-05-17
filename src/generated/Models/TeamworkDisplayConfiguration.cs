// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class TeamworkDisplayConfiguration : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of configured displays. Applicable only for Microsoft Teams Rooms devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkConfiguredPeripheral>? ConfiguredDisplays { get; set; }
#nullable restore
#else
        public List<TeamworkConfiguredPeripheral> ConfiguredDisplays { get; set; }
#endif
        /// <summary>Total number of connected displays, including the inbuilt display. Applicable only for Teams Rooms devices.</summary>
        public int? DisplayCount { get; set; }
        /// <summary>Configuration for the inbuilt display. Not applicable for Teams Rooms devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkDisplayScreenConfiguration? InBuiltDisplayScreenConfiguration { get; set; }
#nullable restore
#else
        public TeamworkDisplayScreenConfiguration InBuiltDisplayScreenConfiguration { get; set; }
#endif
        /// <summary>True if content duplication is allowed. Applicable only for Teams Rooms devices.</summary>
        public bool? IsContentDuplicationAllowed { get; set; }
        /// <summary>True if dual display mode is enabled. If isDualDisplayModeEnabled is true, then the content will be displayed on both front of room screens instead of just the one screen, when it is shared via the HDMI ingest module on the Microsoft Teams Rooms device. Applicable only for Teams Rooms devices.</summary>
        public bool? IsDualDisplayModeEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TeamworkDisplayConfiguration"/> and sets the default values.
        /// </summary>
        public TeamworkDisplayConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamworkDisplayConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkDisplayConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDisplayConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"configuredDisplays", n => { ConfiguredDisplays = n.GetCollectionOfObjectValues<TeamworkConfiguredPeripheral>(TeamworkConfiguredPeripheral.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayCount", n => { DisplayCount = n.GetIntValue(); } },
                {"inBuiltDisplayScreenConfiguration", n => { InBuiltDisplayScreenConfiguration = n.GetObjectValue<TeamworkDisplayScreenConfiguration>(TeamworkDisplayScreenConfiguration.CreateFromDiscriminatorValue); } },
                {"isContentDuplicationAllowed", n => { IsContentDuplicationAllowed = n.GetBoolValue(); } },
                {"isDualDisplayModeEnabled", n => { IsDualDisplayModeEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TeamworkConfiguredPeripheral>("configuredDisplays", ConfiguredDisplays);
            writer.WriteIntValue("displayCount", DisplayCount);
            writer.WriteObjectValue<TeamworkDisplayScreenConfiguration>("inBuiltDisplayScreenConfiguration", InBuiltDisplayScreenConfiguration);
            writer.WriteBoolValue("isContentDuplicationAllowed", IsContentDuplicationAllowed);
            writer.WriteBoolValue("isDualDisplayModeEnabled", IsDualDisplayModeEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
