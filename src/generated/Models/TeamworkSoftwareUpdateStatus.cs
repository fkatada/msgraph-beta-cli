// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class TeamworkSoftwareUpdateStatus : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The available software version to update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvailableVersion { get; set; }
#nullable restore
#else
        public string AvailableVersion { get; set; }
#endif
        /// <summary>The current software version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentVersion { get; set; }
#nullable restore
#else
        public string CurrentVersion { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The update status of the software. The possible values are: unknown, latest, updateAvailable, unknownFutureValue.</summary>
        public TeamworkSoftwareFreshness? SoftwareFreshness { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="TeamworkSoftwareUpdateStatus"/> and sets the default values.
        /// </summary>
        public TeamworkSoftwareUpdateStatus()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamworkSoftwareUpdateStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkSoftwareUpdateStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkSoftwareUpdateStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "availableVersion", n => { AvailableVersion = n.GetStringValue(); } },
                { "currentVersion", n => { CurrentVersion = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "softwareFreshness", n => { SoftwareFreshness = n.GetEnumValue<TeamworkSoftwareFreshness>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("availableVersion", AvailableVersion);
            writer.WriteStringValue("currentVersion", CurrentVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<TeamworkSoftwareFreshness>("softwareFreshness", SoftwareFreshness);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
