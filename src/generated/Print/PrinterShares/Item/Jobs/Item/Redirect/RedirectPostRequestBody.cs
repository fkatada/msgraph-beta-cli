// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Print.PrinterShares.Item.Jobs.Item.Redirect {
    #pragma warning disable CS1591
    public class RedirectPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The configuration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrintJobConfiguration? Configuration { get; set; }
#nullable restore
#else
        public PrintJobConfiguration Configuration { get; set; }
#endif
        /// <summary>The destinationPrinterId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationPrinterId { get; set; }
#nullable restore
#else
        public string DestinationPrinterId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RedirectPostRequestBody"/> and sets the default values.
        /// </summary>
        public RedirectPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RedirectPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RedirectPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RedirectPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"configuration", n => { Configuration = n.GetObjectValue<PrintJobConfiguration>(PrintJobConfiguration.CreateFromDiscriminatorValue); } },
                {"destinationPrinterId", n => { DestinationPrinterId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PrintJobConfiguration>("configuration", Configuration);
            writer.WriteStringValue("destinationPrinterId", DestinationPrinterId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
