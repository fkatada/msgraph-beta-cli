// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AzureAssociatedIdentities : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The all property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AzureIdentity>? All { get; set; }
#nullable restore
#else
        public List<AzureIdentity> All { get; set; }
#endif
        /// <summary>The managedIdentities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AzureManagedIdentity>? ManagedIdentities { get; set; }
#nullable restore
#else
        public List<AzureManagedIdentity> ManagedIdentities { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The servicePrincipals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AzureServicePrincipal>? ServicePrincipals { get; set; }
#nullable restore
#else
        public List<AzureServicePrincipal> ServicePrincipals { get; set; }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AzureUser>? Users { get; set; }
#nullable restore
#else
        public List<AzureUser> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AzureAssociatedIdentities"/> and sets the default values.
        /// </summary>
        public AzureAssociatedIdentities()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AzureAssociatedIdentities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AzureAssociatedIdentities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureAssociatedIdentities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"all", n => { All = n.GetCollectionOfObjectValues<AzureIdentity>(AzureIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedIdentities", n => { ManagedIdentities = n.GetCollectionOfObjectValues<AzureManagedIdentity>(AzureManagedIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"servicePrincipals", n => { ServicePrincipals = n.GetCollectionOfObjectValues<AzureServicePrincipal>(AzureServicePrincipal.CreateFromDiscriminatorValue)?.ToList(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<AzureUser>(AzureUser.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AzureIdentity>("all", All);
            writer.WriteCollectionOfObjectValues<AzureManagedIdentity>("managedIdentities", ManagedIdentities);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<AzureServicePrincipal>("servicePrincipals", ServicePrincipals);
            writer.WriteCollectionOfObjectValues<AzureUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
