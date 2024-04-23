// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Contains properties for the installation state of a mobile app for a device. This will be deprecated starting May, 2023 (Intune Release 2305).
    /// </summary>
    public class MobileAppInstallStatus : Entity, IParsable 
    {
        /// <summary>The navigation link to the mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MobileApp? App { get; set; }
#nullable restore
#else
        public MobileApp App { get; set; }
#endif
        /// <summary>Device ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>Device name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>Human readable version of the application</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayVersion { get; set; }
#nullable restore
#else
        public string DisplayVersion { get; set; }
#endif
        /// <summary>The error code for install or uninstall failures.</summary>
        public int? ErrorCode { get; set; }
        /// <summary>A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.</summary>
        public ResultantAppState? InstallState { get; set; }
        /// <summary>Enum indicating additional details regarding why an application has a particular install state.</summary>
        public ResultantAppStateDetail? InstallStateDetail { get; set; }
        /// <summary>Last sync date time</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.</summary>
        public ResultantAppState? MobileAppInstallStatusValue { get; set; }
        /// <summary>OS Description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsDescription { get; set; }
#nullable restore
#else
        public string OsDescription { get; set; }
#endif
        /// <summary>OS Version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; set; }
#nullable restore
#else
        public string OsVersion { get; set; }
#endif
        /// <summary>Device User Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>User Principal Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MobileAppInstallStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppInstallStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppInstallStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"app", n => { App = n.GetObjectValue<MobileApp>(MobileApp.CreateFromDiscriminatorValue); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"displayVersion", n => { DisplayVersion = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"installState", n => { InstallState = n.GetEnumValue<ResultantAppState>(); } },
                {"installStateDetail", n => { InstallStateDetail = n.GetEnumValue<ResultantAppStateDetail>(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"mobileAppInstallStatusValue", n => { MobileAppInstallStatusValue = n.GetEnumValue<ResultantAppState>(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteObjectValue<MobileApp>("app", App);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("displayVersion", DisplayVersion);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteEnumValue<ResultantAppState>("installState", InstallState);
            writer.WriteEnumValue<ResultantAppStateDetail>("installStateDetail", InstallStateDetail);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<ResultantAppState>("mobileAppInstallStatusValue", MobileAppInstallStatusValue);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
