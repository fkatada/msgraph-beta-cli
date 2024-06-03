// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Revoke Apple Vpp licenses action result
    /// </summary>
    public class RevokeAppleVppLicensesActionResult : DeviceActionResult, IParsable
    {
        /// <summary>Total number of Apple Vpp licenses that failed to revoke</summary>
        public int? FailedLicensesCount { get; set; }
        /// <summary>Total number of Apple Vpp licenses associated</summary>
        public int? TotalLicensesCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RevokeAppleVppLicensesActionResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RevokeAppleVppLicensesActionResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RevokeAppleVppLicensesActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "failedLicensesCount", n => { FailedLicensesCount = n.GetIntValue(); } },
                { "totalLicensesCount", n => { TotalLicensesCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("failedLicensesCount", FailedLicensesCount);
            writer.WriteIntValue("totalLicensesCount", TotalLicensesCount);
        }
    }
}
