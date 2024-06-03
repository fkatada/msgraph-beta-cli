// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AgedAccountsPayable : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The agedAsOfDate property</summary>
        public Date? AgedAsOfDate { get; set; }
        /// <summary>The balanceDue property</summary>
        public decimal? BalanceDue { get; set; }
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>The currentAmount property</summary>
        public decimal? CurrentAmount { get; set; }
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The period1Amount property</summary>
        public decimal? Period1Amount { get; set; }
        /// <summary>The period2Amount property</summary>
        public decimal? Period2Amount { get; set; }
        /// <summary>The period3Amount property</summary>
        public decimal? Period3Amount { get; set; }
        /// <summary>The periodLengthFilter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PeriodLengthFilter { get; set; }
#nullable restore
#else
        public string PeriodLengthFilter { get; set; }
#endif
        /// <summary>The vendorId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VendorId { get; set; }
#nullable restore
#else
        public string VendorId { get; set; }
#endif
        /// <summary>The vendorNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VendorNumber { get; set; }
#nullable restore
#else
        public string VendorNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AgedAccountsPayable"/> and sets the default values.
        /// </summary>
        public AgedAccountsPayable()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AgedAccountsPayable"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AgedAccountsPayable CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AgedAccountsPayable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "agedAsOfDate", n => { AgedAsOfDate = n.GetDateValue(); } },
                { "balanceDue", n => { BalanceDue = n.GetDecimalValue(); } },
                { "currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                { "currentAmount", n => { CurrentAmount = n.GetDecimalValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "period1Amount", n => { Period1Amount = n.GetDecimalValue(); } },
                { "period2Amount", n => { Period2Amount = n.GetDecimalValue(); } },
                { "period3Amount", n => { Period3Amount = n.GetDecimalValue(); } },
                { "periodLengthFilter", n => { PeriodLengthFilter = n.GetStringValue(); } },
                { "vendorId", n => { VendorId = n.GetStringValue(); } },
                { "vendorNumber", n => { VendorNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("agedAsOfDate", AgedAsOfDate);
            writer.WriteDecimalValue("balanceDue", BalanceDue);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteDecimalValue("currentAmount", CurrentAmount);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDecimalValue("period1Amount", Period1Amount);
            writer.WriteDecimalValue("period2Amount", Period2Amount);
            writer.WriteDecimalValue("period3Amount", Period3Amount);
            writer.WriteStringValue("periodLengthFilter", PeriodLengthFilter);
            writer.WriteStringValue("vendorId", VendorId);
            writer.WriteStringValue("vendorNumber", VendorNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
