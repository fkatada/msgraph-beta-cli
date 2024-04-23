// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// A class containing the properties used for mobile app PolicySetItem.
    /// </summary>
    public class MobileAppPolicySetItem : PolicySetItem, IParsable 
    {
        /// <summary>Possible values for the install intent chosen by the admin.</summary>
        public InstallIntent? Intent { get; set; }
        /// <summary>Settings of the MobileAppPolicySetItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MobileAppAssignmentSettings? Settings { get; set; }
#nullable restore
#else
        public MobileAppAssignmentSettings Settings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MobileAppPolicySetItem"/> and sets the default values.
        /// </summary>
        public MobileAppPolicySetItem() : base()
        {
            OdataType = "#microsoft.graph.mobileAppPolicySetItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MobileAppPolicySetItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppPolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppPolicySetItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"intent", n => { Intent = n.GetEnumValue<InstallIntent>(); } },
                {"settings", n => { Settings = n.GetObjectValue<MobileAppAssignmentSettings>(MobileAppAssignmentSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<InstallIntent>("intent", Intent);
            writer.WriteObjectValue<MobileAppAssignmentSettings>("settings", Settings);
        }
    }
}
