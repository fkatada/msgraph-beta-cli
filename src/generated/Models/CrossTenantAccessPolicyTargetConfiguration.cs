// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CrossTenantAccessPolicyTargetConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines whether access is allowed or blocked. The possible values are: allowed, blocked, unknownFutureValue.</summary>
        public CrossTenantAccessPolicyTargetConfigurationAccessType? AccessType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specifies whether to target users, groups, or applications with this rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CrossTenantAccessPolicyTarget>? Targets { get; set; }
#nullable restore
#else
        public List<CrossTenantAccessPolicyTarget> Targets { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CrossTenantAccessPolicyTargetConfiguration"/> and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyTargetConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CrossTenantAccessPolicyTargetConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CrossTenantAccessPolicyTargetConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyTargetConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessType", n => { AccessType = n.GetEnumValue<CrossTenantAccessPolicyTargetConfigurationAccessType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "targets", n => { Targets = n.GetCollectionOfObjectValues<CrossTenantAccessPolicyTarget>(CrossTenantAccessPolicyTarget.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CrossTenantAccessPolicyTargetConfigurationAccessType>("accessType", AccessType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<CrossTenantAccessPolicyTarget>("targets", Targets);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
