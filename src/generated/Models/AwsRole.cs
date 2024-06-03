// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AwsRole : AwsIdentity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The roleType property</summary>
        public AwsRoleType? RoleType { get; set; }
        /// <summary>The trustEntityType property</summary>
        public AwsRoleTrustEntityType? TrustEntityType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AwsRole"/> and sets the default values.
        /// </summary>
        public AwsRole() : base()
        {
            OdataType = "#microsoft.graph.awsRole";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AwsRole"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AwsRole CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AwsRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "roleType", n => { RoleType = n.GetEnumValue<AwsRoleType>(); } },
                { "trustEntityType", n => { TrustEntityType = n.GetEnumValue<AwsRoleTrustEntityType>(); } },
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
            writer.WriteEnumValue<AwsRoleType>("roleType", RoleType);
            writer.WriteEnumValue<AwsRoleTrustEntityType>("trustEntityType", TrustEntityType);
        }
    }
}
