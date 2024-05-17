// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class PermissionsAnalyticsAggregation : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The aws property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PermissionsAnalytics? Aws { get; set; }
#nullable restore
#else
        public PermissionsAnalytics Aws { get; set; }
#endif
        /// <summary>The azure property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PermissionsAnalytics? Azure { get; set; }
#nullable restore
#else
        public PermissionsAnalytics Azure { get; set; }
#endif
        /// <summary>The gcp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PermissionsAnalytics? Gcp { get; set; }
#nullable restore
#else
        public PermissionsAnalytics Gcp { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PermissionsAnalyticsAggregation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PermissionsAnalyticsAggregation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermissionsAnalyticsAggregation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"aws", n => { Aws = n.GetObjectValue<PermissionsAnalytics>(PermissionsAnalytics.CreateFromDiscriminatorValue); } },
                {"azure", n => { Azure = n.GetObjectValue<PermissionsAnalytics>(PermissionsAnalytics.CreateFromDiscriminatorValue); } },
                {"gcp", n => { Gcp = n.GetObjectValue<PermissionsAnalytics>(PermissionsAnalytics.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<PermissionsAnalytics>("aws", Aws);
            writer.WriteObjectValue<PermissionsAnalytics>("azure", Azure);
            writer.WriteObjectValue<PermissionsAnalytics>("gcp", Gcp);
        }
    }
}
