// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// A pool represents a group of embedded SIM activation codes.
    /// </summary>
    public class EmbeddedSIMActivationCodePool : Entity, IParsable 
    {
        /// <summary>The total count of activation codes which belong to this pool.</summary>
        public int? ActivationCodeCount { get; set; }
        /// <summary>The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EmbeddedSIMActivationCode>? ActivationCodes { get; set; }
#nullable restore
#else
        public List<EmbeddedSIMActivationCode> ActivationCodes { get; set; }
#endif
        /// <summary>Navigational property to a list of targets to which this pool is assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EmbeddedSIMActivationCodePoolAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<EmbeddedSIMActivationCodePoolAssignment> Assignments { get; set; }
#endif
        /// <summary>The time the embedded SIM activation code pool was created. Generated service side.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Navigational property to a list of device states for this pool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EmbeddedSIMDeviceState>? DeviceStates { get; set; }
#nullable restore
#else
        public List<EmbeddedSIMDeviceState> DeviceStates { get; set; }
#endif
        /// <summary>The admin defined name of the embedded SIM activation code pool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The time the embedded SIM activation code pool was last modified. Updated service side.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EmbeddedSIMActivationCodePool"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmbeddedSIMActivationCodePool CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmbeddedSIMActivationCodePool();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"activationCodeCount", n => { ActivationCodeCount = n.GetIntValue(); } },
                {"activationCodes", n => { ActivationCodes = n.GetCollectionOfObjectValues<EmbeddedSIMActivationCode>(EmbeddedSIMActivationCode.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<EmbeddedSIMActivationCodePoolAssignment>(EmbeddedSIMActivationCodePoolAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<EmbeddedSIMDeviceState>(EmbeddedSIMDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteIntValue("activationCodeCount", ActivationCodeCount);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMActivationCode>("activationCodes", ActivationCodes);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMActivationCodePoolAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMDeviceState>("deviceStates", DeviceStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
