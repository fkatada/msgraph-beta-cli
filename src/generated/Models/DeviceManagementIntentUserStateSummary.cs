// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Entity that represents user state summary for an intent
    /// </summary>
    public class DeviceManagementIntentUserStateSummary : Entity, IParsable
    {
        /// <summary>Number of users in conflict</summary>
        public int? ConflictCount { get; set; }
        /// <summary>Number of error users</summary>
        public int? ErrorCount { get; set; }
        /// <summary>Number of failed users</summary>
        public int? FailedCount { get; set; }
        /// <summary>Number of not applicable users</summary>
        public int? NotApplicableCount { get; set; }
        /// <summary>Number of succeeded users</summary>
        public int? SuccessCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementIntentUserStateSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementIntentUserStateSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntentUserStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "conflictCount", n => { ConflictCount = n.GetIntValue(); } },
                { "errorCount", n => { ErrorCount = n.GetIntValue(); } },
                { "failedCount", n => { FailedCount = n.GetIntValue(); } },
                { "notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                { "successCount", n => { SuccessCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("conflictCount", ConflictCount);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
