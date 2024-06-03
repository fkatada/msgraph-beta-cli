// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class SharingLinkVariants : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the most permissive role with which an address bar link can be created. The possible values are: none, view, edit, manageList, review, restrictedView, submitOnly, unknownFutureValue.</summary>
        public SharingRole? AddressBarLinkPermission { get; set; }
        /// <summary>Indicates whether a link can be embedded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? AllowEmbed { get; set; }
#nullable restore
#else
        public SharingOperationStatus AllowEmbed { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates whether a link can be password protected, meaning that link users would need to enter a password to access the item for which the sharing link is produced. Creating a passwordProtected link for the first time requires providing a password.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? PasswordProtected { get; set; }
#nullable restore
#else
        public SharingOperationStatus PasswordProtected { get; set; }
#endif
        /// <summary>Indicates whether a link requires identity authentication for recipients. Users can be verified through either an email address or identity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingOperationStatus? RequiresAuthentication { get; set; }
#nullable restore
#else
        public SharingOperationStatus RequiresAuthentication { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SharingLinkVariants"/> and sets the default values.
        /// </summary>
        public SharingLinkVariants()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SharingLinkVariants"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SharingLinkVariants CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharingLinkVariants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "addressBarLinkPermission", n => { AddressBarLinkPermission = n.GetEnumValue<SharingRole>(); } },
                { "allowEmbed", n => { AllowEmbed = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "passwordProtected", n => { PasswordProtected = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "requiresAuthentication", n => { RequiresAuthentication = n.GetObjectValue<SharingOperationStatus>(SharingOperationStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SharingRole>("addressBarLinkPermission", AddressBarLinkPermission);
            writer.WriteObjectValue<SharingOperationStatus>("allowEmbed", AllowEmbed);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<SharingOperationStatus>("passwordProtected", PasswordProtected);
            writer.WriteObjectValue<SharingOperationStatus>("requiresAuthentication", RequiresAuthentication);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
