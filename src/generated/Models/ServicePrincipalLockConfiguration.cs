// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class ServicePrincipalLockConfiguration : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Enables locking all sensitive properties. The sensitive properties are keyCredentials, passwordCredentials, and tokenEncryptionKeyId.</summary>
        public bool? AllProperties { get; set; }
        /// <summary>Locks the keyCredentials and passwordCredentials properties for modification where credential usage type is Sign.</summary>
        public bool? CredentialsWithUsageSign { get; set; }
        /// <summary>Locks the keyCredentials and passwordCredentials properties for modification where credential usage type is Verify. This locks OAuth service principals.</summary>
        public bool? CredentialsWithUsageVerify { get; set; }
        /// <summary>Enables or disables service principal lock configuration. To allow the sensitive properties to be updated, update this property to false to disable the lock on the service principal.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Locks the tokenEncryptionKeyId property for modification on the service principal.</summary>
        public bool? TokenEncryptionKeyId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ServicePrincipalLockConfiguration"/> and sets the default values.
        /// </summary>
        public ServicePrincipalLockConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ServicePrincipalLockConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ServicePrincipalLockConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalLockConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"allProperties", n => { AllProperties = n.GetBoolValue(); } },
                {"credentialsWithUsageSign", n => { CredentialsWithUsageSign = n.GetBoolValue(); } },
                {"credentialsWithUsageVerify", n => { CredentialsWithUsageVerify = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tokenEncryptionKeyId", n => { TokenEncryptionKeyId = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allProperties", AllProperties);
            writer.WriteBoolValue("credentialsWithUsageSign", CredentialsWithUsageSign);
            writer.WriteBoolValue("credentialsWithUsageVerify", CredentialsWithUsageVerify);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
