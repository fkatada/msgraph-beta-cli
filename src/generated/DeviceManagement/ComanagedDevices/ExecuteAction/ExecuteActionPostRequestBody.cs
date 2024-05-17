// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceManagement.ComanagedDevices.ExecuteAction {
    #pragma warning disable CS1591
    public class ExecuteActionPostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The actionName property</summary>
        public ManagedDeviceRemoteAction? ActionName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The carrierUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CarrierUrl { get; set; }
#nullable restore
#else
        public string CarrierUrl { get; set; }
#endif
        /// <summary>The deprovisionReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeprovisionReason { get; set; }
#nullable restore
#else
        public string DeprovisionReason { get; set; }
#endif
        /// <summary>The deviceIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DeviceIds { get; set; }
#nullable restore
#else
        public List<string> DeviceIds { get; set; }
#endif
        /// <summary>The deviceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>The keepEnrollmentData property</summary>
        public bool? KeepEnrollmentData { get; set; }
        /// <summary>The keepUserData property</summary>
        public bool? KeepUserData { get; set; }
        /// <summary>The notificationBody property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationBody { get; set; }
#nullable restore
#else
        public string NotificationBody { get; set; }
#endif
        /// <summary>The notificationTitle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationTitle { get; set; }
#nullable restore
#else
        public string NotificationTitle { get; set; }
#endif
        /// <summary>The organizationalUnitPath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationalUnitPath { get; set; }
#nullable restore
#else
        public string OrganizationalUnitPath { get; set; }
#endif
        /// <summary>The persistEsimDataPlan property</summary>
        public bool? PersistEsimDataPlan { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ExecuteActionPostRequestBody"/> and sets the default values.
        /// </summary>
        public ExecuteActionPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExecuteActionPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExecuteActionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExecuteActionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"actionName", n => { ActionName = n.GetEnumValue<ManagedDeviceRemoteAction>(); } },
                {"carrierUrl", n => { CarrierUrl = n.GetStringValue(); } },
                {"deprovisionReason", n => { DeprovisionReason = n.GetStringValue(); } },
                {"deviceIds", n => { DeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"keepEnrollmentData", n => { KeepEnrollmentData = n.GetBoolValue(); } },
                {"keepUserData", n => { KeepUserData = n.GetBoolValue(); } },
                {"notificationBody", n => { NotificationBody = n.GetStringValue(); } },
                {"notificationTitle", n => { NotificationTitle = n.GetStringValue(); } },
                {"organizationalUnitPath", n => { OrganizationalUnitPath = n.GetStringValue(); } },
                {"persistEsimDataPlan", n => { PersistEsimDataPlan = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ManagedDeviceRemoteAction>("actionName", ActionName);
            writer.WriteStringValue("carrierUrl", CarrierUrl);
            writer.WriteStringValue("deprovisionReason", DeprovisionReason);
            writer.WriteCollectionOfPrimitiveValues<string>("deviceIds", DeviceIds);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteBoolValue("keepEnrollmentData", KeepEnrollmentData);
            writer.WriteBoolValue("keepUserData", KeepUserData);
            writer.WriteStringValue("notificationBody", NotificationBody);
            writer.WriteStringValue("notificationTitle", NotificationTitle);
            writer.WriteStringValue("organizationalUnitPath", OrganizationalUnitPath);
            writer.WriteBoolValue("persistEsimDataPlan", PersistEsimDataPlan);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
