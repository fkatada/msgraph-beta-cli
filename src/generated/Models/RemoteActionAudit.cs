// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Report of remote actions initiated on the devices belonging to a certain tenant.
    /// </summary>
    public class RemoteActionAudit : Entity, IParsable 
    {
        /// <summary>Remote actions Intune supports.</summary>
        public RemoteAction? Action { get; set; }
        /// <summary>The actionState property</summary>
        public ApiSdk.Models.ActionState? ActionState { get; set; }
        /// <summary>Intune device name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDisplayName { get; set; }
#nullable restore
#else
        public string DeviceDisplayName { get; set; }
#endif
        /// <summary>IMEI of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceIMEI { get; set; }
#nullable restore
#else
        public string DeviceIMEI { get; set; }
#endif
        /// <summary>Upn of the device owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceOwnerUserPrincipalName { get; set; }
#nullable restore
#else
        public string DeviceOwnerUserPrincipalName { get; set; }
#endif
        /// <summary>User who initiated the device action, format is UPN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedByUserPrincipalName { get; set; }
#nullable restore
#else
        public string InitiatedByUserPrincipalName { get; set; }
#endif
        /// <summary>Action target.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId { get; set; }
#nullable restore
#else
        public string ManagedDeviceId { get; set; }
#endif
        /// <summary>Time when the action was issued, given in UTC.</summary>
        public DateTimeOffset? RequestDateTime { get; set; }
        /// <summary>[deprecated] Please use InitiatedByUserPrincipalName instead.</summary>
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
        /// <returns>A <see cref="RemoteActionAudit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RemoteActionAudit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteActionAudit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"action", n => { Action = n.GetEnumValue<RemoteAction>(); } },
                {"actionState", n => { ActionState = n.GetEnumValue<ActionState>(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceIMEI", n => { DeviceIMEI = n.GetStringValue(); } },
                {"deviceOwnerUserPrincipalName", n => { DeviceOwnerUserPrincipalName = n.GetStringValue(); } },
                {"initiatedByUserPrincipalName", n => { InitiatedByUserPrincipalName = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"requestDateTime", n => { RequestDateTime = n.GetDateTimeOffsetValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
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
            writer.WriteEnumValue<RemoteAction>("action", Action);
            writer.WriteEnumValue<ActionState>("actionState", ActionState);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceIMEI", DeviceIMEI);
            writer.WriteStringValue("deviceOwnerUserPrincipalName", DeviceOwnerUserPrincipalName);
            writer.WriteStringValue("initiatedByUserPrincipalName", InitiatedByUserPrincipalName);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteDateTimeOffsetValue("requestDateTime", RequestDateTime);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
