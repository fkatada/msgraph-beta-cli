// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class PrivilegedOperationEvent : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The additionalInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation { get; set; }
#nullable restore
#else
        public string AdditionalInformation { get; set; }
#endif
        /// <summary>The creationDateTime property</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The referenceKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceKey { get; set; }
#nullable restore
#else
        public string ReferenceKey { get; set; }
#endif
        /// <summary>The referenceSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferenceSystem { get; set; }
#nullable restore
#else
        public string ReferenceSystem { get; set; }
#endif
        /// <summary>The requestorId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestorId { get; set; }
#nullable restore
#else
        public string RequestorId { get; set; }
#endif
        /// <summary>The requestorName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestorName { get; set; }
#nullable restore
#else
        public string RequestorName { get; set; }
#endif
        /// <summary>The requestType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestType { get; set; }
#nullable restore
#else
        public string RequestType { get; set; }
#endif
        /// <summary>The roleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleId { get; set; }
#nullable restore
#else
        public string RoleId { get; set; }
#endif
        /// <summary>The roleName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleName { get; set; }
#nullable restore
#else
        public string RoleName { get; set; }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The userId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>The userMail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserMail { get; set; }
#nullable restore
#else
        public string UserMail { get; set; }
#endif
        /// <summary>The userName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivilegedOperationEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedOperationEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedOperationEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                { "creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "referenceKey", n => { ReferenceKey = n.GetStringValue(); } },
                { "referenceSystem", n => { ReferenceSystem = n.GetStringValue(); } },
                { "requestType", n => { RequestType = n.GetStringValue(); } },
                { "requestorId", n => { RequestorId = n.GetStringValue(); } },
                { "requestorName", n => { RequestorName = n.GetStringValue(); } },
                { "roleId", n => { RoleId = n.GetStringValue(); } },
                { "roleName", n => { RoleName = n.GetStringValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userMail", n => { UserMail = n.GetStringValue(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
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
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("referenceKey", ReferenceKey);
            writer.WriteStringValue("referenceSystem", ReferenceSystem);
            writer.WriteStringValue("requestorId", RequestorId);
            writer.WriteStringValue("requestorName", RequestorName);
            writer.WriteStringValue("requestType", RequestType);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteStringValue("roleName", RoleName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userMail", UserMail);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
