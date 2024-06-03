// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class DestinationSummary : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of the destinationSummary objects, aggregated by Global Secure Access service.</summary>
        public long? Count { get; set; }
        /// <summary>The IP address or FQDN of the destination.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Destination { get; set; }
#nullable restore
#else
        public string Destination { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The traffic classification. The allowed values are internet, private, microsoft365, all, and unknownFutureValue.</summary>
        public ApiSdk.Models.Networkaccess.TrafficType? TrafficType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DestinationSummary"/> and sets the default values.
        /// </summary>
        public DestinationSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DestinationSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DestinationSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DestinationSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "count", n => { Count = n.GetLongValue(); } },
                { "destination", n => { Destination = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "trafficType", n => { TrafficType = n.GetEnumValue<TrafficType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("count", Count);
            writer.WriteStringValue("destination", Destination);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<TrafficType>("trafficType", TrafficType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
