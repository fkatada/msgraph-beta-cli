// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// The base class for a type of apps
    /// </summary>
    public class WindowsKioskUWPApp : WindowsKioskAppBase, IParsable
    {
        /// <summary>This references an Intune App that will be target to the same assignments as Kiosk configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>This is the only Application User Model ID (AUMID) that will be available to launch use while in Kiosk Mode</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppUserModelId { get; set; }
#nullable restore
#else
        public string AppUserModelId { get; set; }
#endif
        /// <summary>This references an contained App from an Intune App</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainedAppId { get; set; }
#nullable restore
#else
        public string ContainedAppId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WindowsKioskUWPApp"/> and sets the default values.
        /// </summary>
        public WindowsKioskUWPApp() : base()
        {
            OdataType = "#microsoft.graph.windowsKioskUWPApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsKioskUWPApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsKioskUWPApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskUWPApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "appUserModelId", n => { AppUserModelId = n.GetStringValue(); } },
                { "containedAppId", n => { ContainedAppId = n.GetStringValue(); } },
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
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("appUserModelId", AppUserModelId);
            writer.WriteStringValue("containedAppId", ContainedAppId);
        }
    }
}
