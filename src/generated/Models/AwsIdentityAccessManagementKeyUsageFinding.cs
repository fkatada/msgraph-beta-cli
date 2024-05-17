// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class AwsIdentityAccessManagementKeyUsageFinding : Finding, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The accessKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AwsAccessKey? AccessKey { get; set; }
#nullable restore
#else
        public AwsAccessKey AccessKey { get; set; }
#endif
        /// <summary>The actionSummary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ActionSummary? ActionSummary { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ActionSummary ActionSummary { get; set; }
#endif
        /// <summary>The awsAccessKeyDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AwsAccessKeyDetails? AwsAccessKeyDetails { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AwsAccessKeyDetails AwsAccessKeyDetails { get; set; }
#endif
        /// <summary>The permissionsCreepIndex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PermissionsCreepIndex? PermissionsCreepIndex { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PermissionsCreepIndex PermissionsCreepIndex { get; set; }
#endif
        /// <summary>The status property</summary>
        public IamStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AwsIdentityAccessManagementKeyUsageFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AwsIdentityAccessManagementKeyUsageFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AwsIdentityAccessManagementKeyUsageFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"accessKey", n => { AccessKey = n.GetObjectValue<AwsAccessKey>(AwsAccessKey.CreateFromDiscriminatorValue); } },
                {"actionSummary", n => { ActionSummary = n.GetObjectValue<ApiSdk.Models.ActionSummary>(ApiSdk.Models.ActionSummary.CreateFromDiscriminatorValue); } },
                {"awsAccessKeyDetails", n => { AwsAccessKeyDetails = n.GetObjectValue<ApiSdk.Models.AwsAccessKeyDetails>(ApiSdk.Models.AwsAccessKeyDetails.CreateFromDiscriminatorValue); } },
                {"permissionsCreepIndex", n => { PermissionsCreepIndex = n.GetObjectValue<ApiSdk.Models.PermissionsCreepIndex>(ApiSdk.Models.PermissionsCreepIndex.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<IamStatus>(); } },
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
            writer.WriteObjectValue<AwsAccessKey>("accessKey", AccessKey);
            writer.WriteObjectValue<ApiSdk.Models.ActionSummary>("actionSummary", ActionSummary);
            writer.WriteObjectValue<ApiSdk.Models.AwsAccessKeyDetails>("awsAccessKeyDetails", AwsAccessKeyDetails);
            writer.WriteObjectValue<ApiSdk.Models.PermissionsCreepIndex>("permissionsCreepIndex", PermissionsCreepIndex);
            writer.WriteEnumValue<IamStatus>("status", Status);
        }
    }
}
