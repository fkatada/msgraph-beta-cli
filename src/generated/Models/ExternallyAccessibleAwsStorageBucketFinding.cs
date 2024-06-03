// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class ExternallyAccessibleAwsStorageBucketFinding : Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessibility property</summary>
        public AwsAccessType? Accessibility { get; set; }
        /// <summary>The accountsWithAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AccountsWithAccess? AccountsWithAccess { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AccountsWithAccess AccountsWithAccess { get; set; }
#endif
        /// <summary>The storageBucket property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthorizationSystemResource? StorageBucket { get; set; }
#nullable restore
#else
        public AuthorizationSystemResource StorageBucket { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternallyAccessibleAwsStorageBucketFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternallyAccessibleAwsStorageBucketFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternallyAccessibleAwsStorageBucketFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessibility", n => { Accessibility = n.GetEnumValue<AwsAccessType>(); } },
                { "accountsWithAccess", n => { AccountsWithAccess = n.GetObjectValue<ApiSdk.Models.AccountsWithAccess>(ApiSdk.Models.AccountsWithAccess.CreateFromDiscriminatorValue); } },
                { "storageBucket", n => { StorageBucket = n.GetObjectValue<AuthorizationSystemResource>(AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<AwsAccessType>("accessibility", Accessibility);
            writer.WriteObjectValue<ApiSdk.Models.AccountsWithAccess>("accountsWithAccess", AccountsWithAccess);
            writer.WriteObjectValue<AuthorizationSystemResource>("storageBucket", StorageBucket);
        }
    }
}
