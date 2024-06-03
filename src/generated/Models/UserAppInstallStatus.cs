// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Contains properties for the installation status for a user. This will be deprecated starting May, 2023 (Intune Release 2305).
    /// </summary>
    public class UserAppInstallStatus : Entity, IParsable
    {
        /// <summary>The navigation link to the mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MobileApp? App { get; set; }
#nullable restore
#else
        public MobileApp App { get; set; }
#endif
        /// <summary>The install state of the app on devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileAppInstallStatus>? DeviceStatuses { get; set; }
#nullable restore
#else
        public List<MobileAppInstallStatus> DeviceStatuses { get; set; }
#endif
        /// <summary>Failed Device Count.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>Installed Device Count.</summary>
        public int? InstalledDeviceCount { get; set; }
        /// <summary>Not installed device count.</summary>
        public int? NotInstalledDeviceCount { get; set; }
        /// <summary>User name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>User Principal Name.</summary>
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
        /// <returns>A <see cref="UserAppInstallStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserAppInstallStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAppInstallStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "app", n => { App = n.GetObjectValue<MobileApp>(MobileApp.CreateFromDiscriminatorValue); } },
                { "deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<MobileAppInstallStatus>(MobileAppInstallStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                { "failedDeviceCount", n => { FailedDeviceCount = n.GetIntValue(); } },
                { "installedDeviceCount", n => { InstalledDeviceCount = n.GetIntValue(); } },
                { "notInstalledDeviceCount", n => { NotInstalledDeviceCount = n.GetIntValue(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<MobileAppInstallStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteIntValue("installedDeviceCount", InstalledDeviceCount);
            writer.WriteIntValue("notInstalledDeviceCount", NotInstalledDeviceCount);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
