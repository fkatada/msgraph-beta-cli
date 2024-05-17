// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class PlannerTaskRoleBasedRule : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Default rule that applies when a property or action-specific rule is not provided. Possible values are: Allow, Block</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultRule { get; set; }
#nullable restore
#else
        public string DefaultRule { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Rules for specific properties and actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerTaskPropertyRule? PropertyRule { get; set; }
#nullable restore
#else
        public PlannerTaskPropertyRule PropertyRule { get; set; }
#endif
        /// <summary>The role these rules apply to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerTaskConfigurationRoleBase? Role { get; set; }
#nullable restore
#else
        public PlannerTaskConfigurationRoleBase Role { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PlannerTaskRoleBasedRule"/> and sets the default values.
        /// </summary>
        public PlannerTaskRoleBasedRule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PlannerTaskRoleBasedRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlannerTaskRoleBasedRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskRoleBasedRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"defaultRule", n => { DefaultRule = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"propertyRule", n => { PropertyRule = n.GetObjectValue<PlannerTaskPropertyRule>(PlannerTaskPropertyRule.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetObjectValue<PlannerTaskConfigurationRoleBase>(PlannerTaskConfigurationRoleBase.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultRule", DefaultRule);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<PlannerTaskPropertyRule>("propertyRule", PropertyRule);
            writer.WriteObjectValue<PlannerTaskConfigurationRoleBase>("role", Role);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
