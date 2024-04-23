// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PrivilegedAccessGroupEligibilityScheduleInstance : PrivilegedAccessScheduleInstance, IParsable 
    {
        /// <summary>The identifier of the membership or ownership eligibility relationship to the group. Required. The possible values are: owner, member. Supports $filter (eq).</summary>
        public PrivilegedAccessGroupRelationships? AccessId { get; set; }
        /// <summary>The identifier of the privilegedAccessGroupEligibilitySchedule from which this instance was created. Required. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EligibilityScheduleId { get; set; }
#nullable restore
#else
        public string EligibilityScheduleId { get; set; }
#endif
        /// <summary>References the group that is the scope of the membership or ownership eligibility through PIM for groups. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Group? Group { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Group Group { get; set; }
#endif
        /// <summary>The identifier of the group representing the scope of the membership or ownership eligibility through PIM for groups. Required. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId { get; set; }
#nullable restore
#else
        public string GroupId { get; set; }
#endif
        /// <summary>Indicates whether the assignment is derived from a group assignment. It can further imply whether the calling principal can manage the assignment schedule. Required. The possible values are: direct, group, unknownFutureValue. Supports $filter (eq).</summary>
        public PrivilegedAccessGroupMemberType? MemberType { get; set; }
        /// <summary>References the principal that&apos;s in the scope of the membership or ownership eligibility request through the group that&apos;s governed by PIM. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Principal { get; set; }
#nullable restore
#else
        public DirectoryObject Principal { get; set; }
#endif
        /// <summary>The identifier of the principal whose membership or ownership eligibility to the group is managed through PIM for groups. Required. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId { get; set; }
#nullable restore
#else
        public string PrincipalId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PrivilegedAccessGroupEligibilityScheduleInstance"/> and sets the default values.
        /// </summary>
        public PrivilegedAccessGroupEligibilityScheduleInstance() : base()
        {
            OdataType = "#microsoft.graph.privilegedAccessGroupEligibilityScheduleInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivilegedAccessGroupEligibilityScheduleInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccessGroupEligibilityScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccessGroupEligibilityScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"accessId", n => { AccessId = n.GetEnumValue<PrivilegedAccessGroupRelationships>(); } },
                {"eligibilityScheduleId", n => { EligibilityScheduleId = n.GetStringValue(); } },
                {"group", n => { Group = n.GetObjectValue<ApiSdk.Models.Group>(ApiSdk.Models.Group.CreateFromDiscriminatorValue); } },
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"memberType", n => { MemberType = n.GetEnumValue<PrivilegedAccessGroupMemberType>(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<PrivilegedAccessGroupRelationships>("accessId", AccessId);
            writer.WriteStringValue("eligibilityScheduleId", EligibilityScheduleId);
            writer.WriteObjectValue<ApiSdk.Models.Group>("group", Group);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteEnumValue<PrivilegedAccessGroupMemberType>("memberType", MemberType);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
        }
    }
}
