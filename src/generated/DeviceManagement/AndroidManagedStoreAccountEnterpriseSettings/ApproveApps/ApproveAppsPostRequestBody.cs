// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.ApproveApps {
    public class ApproveAppsPostRequestBody : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The approveAllPermissions property</summary>
        public bool? ApproveAllPermissions { get; set; }
        /// <summary>The packageIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PackageIds { get; set; }
#nullable restore
#else
        public List<string> PackageIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ApproveAppsPostRequestBody"/> and sets the default values.
        /// </summary>
        public ApproveAppsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ApproveAppsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApproveAppsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApproveAppsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"approveAllPermissions", n => { ApproveAllPermissions = n.GetBoolValue(); } },
                {"packageIds", n => { PackageIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("approveAllPermissions", ApproveAllPermissions);
            writer.WriteCollectionOfPrimitiveValues<string>("packageIds", PackageIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
