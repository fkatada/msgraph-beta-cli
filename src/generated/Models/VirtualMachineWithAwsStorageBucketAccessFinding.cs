// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class VirtualMachineWithAwsStorageBucketAccessFinding : Finding, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The total number of storage buckets that the EC2 instance can access using the role.</summary>
        public int? AccessibleCount { get; set; }
        /// <summary>The total number of storage buckets in the authorization system that hosts the EC2 instance.</summary>
        public int? BucketCount { get; set; }
        /// <summary>The ec2Instance property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthorizationSystemResource? Ec2Instance { get; set; }
#nullable restore
#else
        public AuthorizationSystemResource Ec2Instance { get; set; }
#endif
        /// <summary>The permissionsCreepIndex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PermissionsCreepIndex? PermissionsCreepIndex { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PermissionsCreepIndex PermissionsCreepIndex { get; set; }
#endif
        /// <summary>The role property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AwsRole? Role { get; set; }
#nullable restore
#else
        public AwsRole Role { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VirtualMachineWithAwsStorageBucketAccessFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualMachineWithAwsStorageBucketAccessFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualMachineWithAwsStorageBucketAccessFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"accessibleCount", n => { AccessibleCount = n.GetIntValue(); } },
                {"bucketCount", n => { BucketCount = n.GetIntValue(); } },
                {"ec2Instance", n => { Ec2Instance = n.GetObjectValue<AuthorizationSystemResource>(AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
                {"permissionsCreepIndex", n => { PermissionsCreepIndex = n.GetObjectValue<ApiSdk.Models.PermissionsCreepIndex>(ApiSdk.Models.PermissionsCreepIndex.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetObjectValue<AwsRole>(AwsRole.CreateFromDiscriminatorValue); } },
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
            writer.WriteIntValue("accessibleCount", AccessibleCount);
            writer.WriteIntValue("bucketCount", BucketCount);
            writer.WriteObjectValue<AuthorizationSystemResource>("ec2Instance", Ec2Instance);
            writer.WriteObjectValue<ApiSdk.Models.PermissionsCreepIndex>("permissionsCreepIndex", PermissionsCreepIndex);
            writer.WriteObjectValue<AwsRole>("role", Role);
        }
    }
}
