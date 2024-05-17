// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ManagedTenants {
    #pragma warning disable CS1591
    public class Tenant : ApiSdk.Models.Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The relationship details for the tenant with the managing entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TenantContract? Contract { get; set; }
#nullable restore
#else
        public TenantContract Contract { get; set; }
#endif
        /// <summary>The date and time the tenant was created in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name for the tenant. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The date and time the tenant was last updated within the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The onboarding status information for the tenant. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ManagedTenants.TenantStatusInformation? TenantStatusInformation { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ManagedTenants.TenantStatusInformation TenantStatusInformation { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Tenant"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Tenant CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Tenant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"contract", n => { Contract = n.GetObjectValue<TenantContract>(TenantContract.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"tenantStatusInformation", n => { TenantStatusInformation = n.GetObjectValue<ApiSdk.Models.ManagedTenants.TenantStatusInformation>(ApiSdk.Models.ManagedTenants.TenantStatusInformation.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<TenantContract>("contract", Contract);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<ApiSdk.Models.ManagedTenants.TenantStatusInformation>("tenantStatusInformation", TenantStatusInformation);
        }
    }
}
