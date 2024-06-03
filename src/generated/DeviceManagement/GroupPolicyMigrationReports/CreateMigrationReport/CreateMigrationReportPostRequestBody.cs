// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceManagement.GroupPolicyMigrationReports.CreateMigrationReport
{
    #pragma warning disable CS1591
    public class CreateMigrationReportPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The groupPolicyObjectFile property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.GroupPolicyObjectFile? GroupPolicyObjectFile { get; set; }
#nullable restore
#else
        public ApiSdk.Models.GroupPolicyObjectFile GroupPolicyObjectFile { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CreateMigrationReportPostRequestBody"/> and sets the default values.
        /// </summary>
        public CreateMigrationReportPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CreateMigrationReportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateMigrationReportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateMigrationReportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "groupPolicyObjectFile", n => { GroupPolicyObjectFile = n.GetObjectValue<ApiSdk.Models.GroupPolicyObjectFile>(ApiSdk.Models.GroupPolicyObjectFile.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.GroupPolicyObjectFile>("groupPolicyObjectFile", GroupPolicyObjectFile);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
