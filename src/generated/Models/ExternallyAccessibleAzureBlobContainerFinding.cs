// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class ExternallyAccessibleAzureBlobContainerFinding : Finding, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The accessibility property</summary>
        public AzureAccessType? Accessibility { get; set; }
        /// <summary>The encryptionManagedBy property</summary>
        public AzureEncryption? EncryptionManagedBy { get; set; }
        /// <summary>The storageAccount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthorizationSystemResource? StorageAccount { get; set; }
#nullable restore
#else
        public AuthorizationSystemResource StorageAccount { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternallyAccessibleAzureBlobContainerFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternallyAccessibleAzureBlobContainerFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternallyAccessibleAzureBlobContainerFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"accessibility", n => { Accessibility = n.GetEnumValue<AzureAccessType>(); } },
                {"encryptionManagedBy", n => { EncryptionManagedBy = n.GetEnumValue<AzureEncryption>(); } },
                {"storageAccount", n => { StorageAccount = n.GetObjectValue<AuthorizationSystemResource>(AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<AzureAccessType>("accessibility", Accessibility);
            writer.WriteEnumValue<AzureEncryption>("encryptionManagedBy", EncryptionManagedBy);
            writer.WriteObjectValue<AuthorizationSystemResource>("storageAccount", StorageAccount);
        }
    }
}
