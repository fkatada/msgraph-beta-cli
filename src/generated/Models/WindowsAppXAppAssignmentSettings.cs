// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Contains properties used when assigning a Windows AppX mobile app to a group.
    /// </summary>
    public class WindowsAppXAppAssignmentSettings : MobileAppAssignmentSettings, IParsable 
    {
        /// <summary>Whether or not to use device execution context for Windows AppX mobile app.</summary>
        public bool? UseDeviceContext { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WindowsAppXAppAssignmentSettings"/> and sets the default values.
        /// </summary>
        public WindowsAppXAppAssignmentSettings() : base()
        {
            OdataType = "#microsoft.graph.windowsAppXAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsAppXAppAssignmentSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsAppXAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAppXAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"useDeviceContext", n => { UseDeviceContext = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("useDeviceContext", UseDeviceContext);
        }
    }
}
