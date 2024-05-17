// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class LicenseAssignmentState : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the license is directly-assigned or inherited from a group. If directly-assigned, this field is null; if inherited through a group membership, this field contains the ID of the group. Read-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedByGroup { get; set; }
#nullable restore
#else
        public string AssignedByGroup { get; set; }
#endif
        /// <summary>The service plans that are disabled in this assignment. Read-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? DisabledPlans { get; set; }
#nullable restore
#else
        public List<Guid?> DisabledPlans { get; set; }
#endif
        /// <summary>License assignment failure error. If the license is assigned successfully, this field will be Null. Read-Only. The possible values are CountViolation, MutuallyExclusiveViolation, DependencyViolation, ProhibitedInUsageLocationViolation, UniquenessViolation, and Other. For more information on how to identify and resolve license assignment errors, see here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Error { get; set; }
#nullable restore
#else
        public string Error { get; set; }
#endif
        /// <summary>The timestamp when the state of the license assignment was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The unique identifier for the SKU. Read-Only.</summary>
        public Guid? SkuId { get; set; }
        /// <summary>Indicate the current state of this assignment. Read-Only. The possible values are Active, ActiveWithError, Disabled, and Error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="LicenseAssignmentState"/> and sets the default values.
        /// </summary>
        public LicenseAssignmentState()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="LicenseAssignmentState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LicenseAssignmentState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LicenseAssignmentState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"assignedByGroup", n => { AssignedByGroup = n.GetStringValue(); } },
                {"disabledPlans", n => { DisabledPlans = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"error", n => { Error = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"skuId", n => { SkuId = n.GetGuidValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignedByGroup", AssignedByGroup);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("disabledPlans", DisabledPlans);
            writer.WriteStringValue("error", Error);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteGuidValue("skuId", SkuId);
            writer.WriteStringValue("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
