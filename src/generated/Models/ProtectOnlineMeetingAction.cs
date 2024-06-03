// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class ProtectOnlineMeetingAction : LabelActionBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The allowedForwarders property</summary>
        public OnlineMeetingForwarders? AllowedForwarders { get; set; }
        /// <summary>The allowedPresenters property</summary>
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
        /// <summary>The isCopyToClipboardEnabled property</summary>
        public bool? IsCopyToClipboardEnabled { get; set; }
        /// <summary>The isLobbyEnabled property</summary>
        public bool? IsLobbyEnabled { get; set; }
        /// <summary>The lobbyBypassSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.LobbyBypassSettings? LobbyBypassSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.LobbyBypassSettings LobbyBypassSettings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ProtectOnlineMeetingAction"/> and sets the default values.
        /// </summary>
        public ProtectOnlineMeetingAction() : base()
        {
            OdataType = "#microsoft.graph.protectOnlineMeetingAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ProtectOnlineMeetingAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProtectOnlineMeetingAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectOnlineMeetingAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedForwarders", n => { AllowedForwarders = n.GetEnumValue<OnlineMeetingForwarders>(); } },
                { "allowedPresenters", n => { AllowedPresenters = n.GetEnumValue<OnlineMeetingPresenters>(); } },
                { "isCopyToClipboardEnabled", n => { IsCopyToClipboardEnabled = n.GetBoolValue(); } },
                { "isLobbyEnabled", n => { IsLobbyEnabled = n.GetBoolValue(); } },
                { "lobbyBypassSettings", n => { LobbyBypassSettings = n.GetObjectValue<ApiSdk.Models.LobbyBypassSettings>(ApiSdk.Models.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<OnlineMeetingForwarders>("allowedForwarders", AllowedForwarders);
            writer.WriteEnumValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteBoolValue("isCopyToClipboardEnabled", IsCopyToClipboardEnabled);
            writer.WriteBoolValue("isLobbyEnabled", IsLobbyEnabled);
            writer.WriteObjectValue<ApiSdk.Models.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
        }
    }
}
