// <auto-generated/>
using ApiSdk.Models.Partners.Billing;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Reports.Partners.Billing.Usage.Unbilled.MicrosoftGraphPartnersBillingExport {
    #pragma warning disable CS1591
    public class ExportPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributeSet property</summary>
        public ApiSdk.Models.Partners.Billing.AttributeSet? AttributeSet { get; set; }
        /// <summary>The billingPeriod property</summary>
        public ApiSdk.Models.Partners.Billing.BillingPeriod? BillingPeriod { get; set; }
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ExportPostRequestBody"/> and sets the default values.
        /// </summary>
        public ExportPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attributeSet", n => { AttributeSet = n.GetEnumValue<AttributeSet>(); } },
                {"billingPeriod", n => { BillingPeriod = n.GetEnumValue<BillingPeriod>(); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AttributeSet>("attributeSet", AttributeSet);
            writer.WriteEnumValue<BillingPeriod>("billingPeriod", BillingPeriod);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
