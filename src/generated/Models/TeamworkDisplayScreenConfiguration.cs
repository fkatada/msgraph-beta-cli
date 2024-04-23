// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class TeamworkDisplayScreenConfiguration : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The brightness level on the device (0-100). Not applicable for Microsoft Teams Rooms devices.</summary>
        public int? BacklightBrightness { get; set; }
        /// <summary>Timeout for backlight (30-3600 secs). Not applicable for Teams Rooms devices.</summary>
        public TimeSpan? BacklightTimeout { get; set; }
        /// <summary>True if high contrast mode is enabled. Not applicable for Teams Rooms devices.</summary>
        public bool? IsHighContrastEnabled { get; set; }
        /// <summary>True if screensaver is enabled. Not applicable for Teams Rooms devices.</summary>
        public bool? IsScreensaverEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Screensaver timeout from 30 to 3600 secs. Not applicable for Teams Rooms devices.</summary>
        public TimeSpan? ScreensaverTimeout { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="TeamworkDisplayScreenConfiguration"/> and sets the default values.
        /// </summary>
        public TeamworkDisplayScreenConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamworkDisplayScreenConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkDisplayScreenConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDisplayScreenConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"backlightBrightness", n => { BacklightBrightness = n.GetIntValue(); } },
                {"backlightTimeout", n => { BacklightTimeout = n.GetTimeSpanValue(); } },
                {"isHighContrastEnabled", n => { IsHighContrastEnabled = n.GetBoolValue(); } },
                {"isScreensaverEnabled", n => { IsScreensaverEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"screensaverTimeout", n => { ScreensaverTimeout = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("backlightBrightness", BacklightBrightness);
            writer.WriteTimeSpanValue("backlightTimeout", BacklightTimeout);
            writer.WriteBoolValue("isHighContrastEnabled", IsHighContrastEnabled);
            writer.WriteBoolValue("isScreensaverEnabled", IsScreensaverEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteTimeSpanValue("screensaverTimeout", ScreensaverTimeout);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
