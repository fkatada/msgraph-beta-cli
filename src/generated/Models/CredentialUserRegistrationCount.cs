// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class CredentialUserRegistrationCount : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Provides the count of users with accountEnabled set to true in the tenant.</summary>
        public long? TotalUserCount { get; set; }
        /// <summary>A collection of registration count and status information for users in your tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserRegistrationCount>? UserRegistrationCounts { get; set; }
#nullable restore
#else
        public List<UserRegistrationCount> UserRegistrationCounts { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CredentialUserRegistrationCount"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CredentialUserRegistrationCount CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CredentialUserRegistrationCount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"totalUserCount", n => { TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationCounts", n => { UserRegistrationCounts = n.GetCollectionOfObjectValues<UserRegistrationCount>(UserRegistrationCount.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<UserRegistrationCount>("userRegistrationCounts", UserRegistrationCounts);
        }
    }
}
