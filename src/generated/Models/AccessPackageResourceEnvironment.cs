// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AccessPackageResourceEnvironment : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResource>? AccessPackageResources { get; set; }
#nullable restore
#else
        public List<AccessPackageResource> AccessPackageResources { get; set; }
#endif
        /// <summary>Connection information of an environment used to connect to a resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ConnectionInfo? ConnectionInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ConnectionInfo ConnectionInfo { get; set; }
#endif
        /// <summary>The display name of the user that created this object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of this object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of this object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Determines whether this is default environment or not. It is set to true for all static origin systems, such as Microsoft Entra groups and Microsoft Entra Applications.</summary>
        public bool? IsDefaultEnvironment { get; set; }
        /// <summary>The display name of the entity that last modified this object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModifiedBy { get; set; }
#nullable restore
#else
        public string ModifiedBy { get; set; }
#endif
        /// <summary>The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>The unique identifier of this environment in the origin system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginId { get; set; }
#nullable restore
#else
        public string OriginId { get; set; }
#endif
        /// <summary>The type of the resource in the origin system, that is, SharePointOnline. Requires $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginSystem { get; set; }
#nullable restore
#else
        public string OriginSystem { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccessPackageResourceEnvironment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageResourceEnvironment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceEnvironment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackageResources", n => { AccessPackageResources = n.GetCollectionOfObjectValues<AccessPackageResource>(AccessPackageResource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "connectionInfo", n => { ConnectionInfo = n.GetObjectValue<ApiSdk.Models.ConnectionInfo>(ApiSdk.Models.ConnectionInfo.CreateFromDiscriminatorValue); } },
                { "createdBy", n => { CreatedBy = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isDefaultEnvironment", n => { IsDefaultEnvironment = n.GetBoolValue(); } },
                { "modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "originId", n => { OriginId = n.GetStringValue(); } },
                { "originSystem", n => { OriginSystem = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteObjectValue<ApiSdk.Models.ConnectionInfo>("connectionInfo", ConnectionInfo);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isDefaultEnvironment", IsDefaultEnvironment);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
        }
    }
}
