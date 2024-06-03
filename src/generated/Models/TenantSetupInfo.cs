// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class TenantSetupInfo : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The defaultRolesSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedRoleSettings? DefaultRolesSettings { get; set; }
#nullable restore
#else
        public PrivilegedRoleSettings DefaultRolesSettings { get; set; }
#endif
        /// <summary>The firstTimeSetup property</summary>
        public bool? FirstTimeSetup { get; set; }
        /// <summary>The relevantRolesSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RelevantRolesSettings { get; set; }
#nullable restore
#else
        public List<string> RelevantRolesSettings { get; set; }
#endif
        /// <summary>The setupStatus property</summary>
        public ApiSdk.Models.SetupStatus? SetupStatus { get; set; }
        /// <summary>The skipSetup property</summary>
        public bool? SkipSetup { get; set; }
        /// <summary>The userRolesActions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserRolesActions { get; set; }
#nullable restore
#else
        public string UserRolesActions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TenantSetupInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TenantSetupInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantSetupInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "defaultRolesSettings", n => { DefaultRolesSettings = n.GetObjectValue<PrivilegedRoleSettings>(PrivilegedRoleSettings.CreateFromDiscriminatorValue); } },
                { "firstTimeSetup", n => { FirstTimeSetup = n.GetBoolValue(); } },
                { "relevantRolesSettings", n => { RelevantRolesSettings = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "setupStatus", n => { SetupStatus = n.GetEnumValue<SetupStatus>(); } },
                { "skipSetup", n => { SkipSetup = n.GetBoolValue(); } },
                { "userRolesActions", n => { UserRolesActions = n.GetStringValue(); } },
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
            writer.WriteObjectValue<PrivilegedRoleSettings>("defaultRolesSettings", DefaultRolesSettings);
            writer.WriteBoolValue("firstTimeSetup", FirstTimeSetup);
            writer.WriteCollectionOfPrimitiveValues<string>("relevantRolesSettings", RelevantRolesSettings);
            writer.WriteEnumValue<SetupStatus>("setupStatus", SetupStatus);
            writer.WriteBoolValue("skipSetup", SkipSetup);
            writer.WriteStringValue("userRolesActions", UserRolesActions);
        }
    }
}
