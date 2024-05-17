// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class MembershipRuleProcessingStatus : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Detailed error message if dynamic group processing ran into an error.  Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorMessage { get; set; }
#nullable restore
#else
        public string ErrorMessage { get; set; }
#endif
        /// <summary>Most recent date and time when membership of a dynamic group was updated.  Optional. Read-only.</summary>
        public DateTimeOffset? LastMembershipUpdated { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Current status of a dynamic group processing. Possible values are: NotStarted, Running, Succeeded, Failed, and UnknownFutureValue.  Required. Read-only.</summary>
        public MembershipRuleProcessingStatusDetails? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="MembershipRuleProcessingStatus"/> and sets the default values.
        /// </summary>
        public MembershipRuleProcessingStatus()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MembershipRuleProcessingStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MembershipRuleProcessingStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MembershipRuleProcessingStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"errorMessage", n => { ErrorMessage = n.GetStringValue(); } },
                {"lastMembershipUpdated", n => { LastMembershipUpdated = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<MembershipRuleProcessingStatusDetails>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("errorMessage", ErrorMessage);
            writer.WriteDateTimeOffsetValue("lastMembershipUpdated", LastMembershipUpdated);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<MembershipRuleProcessingStatusDetails>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
