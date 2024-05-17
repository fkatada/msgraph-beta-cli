// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class GroupMembershipGovernanceCriteria : GovernanceCriteria, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The groupId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId { get; set; }
#nullable restore
#else
        public string GroupId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GroupMembershipGovernanceCriteria"/> and sets the default values.
        /// </summary>
        public GroupMembershipGovernanceCriteria() : base()
        {
            OdataType = "#microsoft.graph.groupMembershipGovernanceCriteria";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GroupMembershipGovernanceCriteria"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupMembershipGovernanceCriteria CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupMembershipGovernanceCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"groupId", n => { GroupId = n.GetStringValue(); } },
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
            writer.WriteStringValue("groupId", GroupId);
        }
    }
}
