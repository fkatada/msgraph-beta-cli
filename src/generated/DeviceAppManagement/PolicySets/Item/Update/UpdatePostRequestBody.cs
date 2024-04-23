// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceAppManagement.PolicySets.Item.Update {
    public class UpdatePostRequestBody : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The addedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PolicySetItem>? AddedPolicySetItems { get; set; }
#nullable restore
#else
        public List<PolicySetItem> AddedPolicySetItems { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The assignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PolicySetAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<PolicySetAssignment> Assignments { get; set; }
#endif
        /// <summary>The deletedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DeletedPolicySetItems { get; set; }
#nullable restore
#else
        public List<string> DeletedPolicySetItems { get; set; }
#endif
        /// <summary>The updatedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PolicySetItem>? UpdatedPolicySetItems { get; set; }
#nullable restore
#else
        public List<PolicySetItem> UpdatedPolicySetItems { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="UpdatePostRequestBody"/> and sets the default values.
        /// </summary>
        public UpdatePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UpdatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"addedPolicySetItems", n => { AddedPolicySetItems = n.GetCollectionOfObjectValues<PolicySetItem>(PolicySetItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<PolicySetAssignment>(PolicySetAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deletedPolicySetItems", n => { DeletedPolicySetItems = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"updatedPolicySetItems", n => { UpdatedPolicySetItems = n.GetCollectionOfObjectValues<PolicySetItem>(PolicySetItem.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PolicySetItem>("addedPolicySetItems", AddedPolicySetItems);
            writer.WriteCollectionOfObjectValues<PolicySetAssignment>("assignments", Assignments);
            writer.WriteCollectionOfPrimitiveValues<string>("deletedPolicySetItems", DeletedPolicySetItems);
            writer.WriteCollectionOfObjectValues<PolicySetItem>("updatedPolicySetItems", UpdatedPolicySetItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
