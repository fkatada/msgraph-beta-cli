// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class EncryptWithUserDefinedRights : EncryptContent, IParsable 
    {
        /// <summary>The allowAdHocPermissions property</summary>
        public bool? AllowAdHocPermissions { get; set; }
        /// <summary>The allowMailForwarding property</summary>
        public bool? AllowMailForwarding { get; set; }
        /// <summary>The decryptionRightsManagementTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DecryptionRightsManagementTemplateId { get; set; }
#nullable restore
#else
        public string DecryptionRightsManagementTemplateId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EncryptWithUserDefinedRights"/> and sets the default values.
        /// </summary>
        public EncryptWithUserDefinedRights() : base()
        {
            OdataType = "#microsoft.graph.encryptWithUserDefinedRights";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EncryptWithUserDefinedRights"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EncryptWithUserDefinedRights CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EncryptWithUserDefinedRights();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"allowAdHocPermissions", n => { AllowAdHocPermissions = n.GetBoolValue(); } },
                {"allowMailForwarding", n => { AllowMailForwarding = n.GetBoolValue(); } },
                {"decryptionRightsManagementTemplateId", n => { DecryptionRightsManagementTemplateId = n.GetStringValue(); } },
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
            writer.WriteBoolValue("allowAdHocPermissions", AllowAdHocPermissions);
            writer.WriteBoolValue("allowMailForwarding", AllowMailForwarding);
            writer.WriteStringValue("decryptionRightsManagementTemplateId", DecryptionRightsManagementTemplateId);
        }
    }
}
