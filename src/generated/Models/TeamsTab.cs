// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class TeamsTab : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Container for custom settings applied to a tab. The tab is considered configured only once this property is set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamsTabConfiguration? Configuration { get; set; }
#nullable restore
#else
        public TeamsTabConfiguration Configuration { get; set; }
#endif
        /// <summary>Name of the tab.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The messageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageId { get; set; }
#nullable restore
#else
        public string MessageId { get; set; }
#endif
        /// <summary>Index of the order used for sorting tabs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SortOrderIndex { get; set; }
#nullable restore
#else
        public string SortOrderIndex { get; set; }
#endif
        /// <summary>The application that is linked to the tab.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.TeamsApp? TeamsApp { get; set; }
#nullable restore
#else
        public ApiSdk.Models.TeamsApp TeamsApp { get; set; }
#endif
        /// <summary>The teamsAppId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsAppId { get; set; }
#nullable restore
#else
        public string TeamsAppId { get; set; }
#endif
        /// <summary>Deep link URL of the tab instance. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamsTab"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamsTab CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsTab();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"configuration", n => { Configuration = n.GetObjectValue<TeamsTabConfiguration>(TeamsTabConfiguration.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"messageId", n => { MessageId = n.GetStringValue(); } },
                {"sortOrderIndex", n => { SortOrderIndex = n.GetStringValue(); } },
                {"teamsApp", n => { TeamsApp = n.GetObjectValue<ApiSdk.Models.TeamsApp>(ApiSdk.Models.TeamsApp.CreateFromDiscriminatorValue); } },
                {"teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteObjectValue<TeamsTabConfiguration>("configuration", Configuration);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteStringValue("sortOrderIndex", SortOrderIndex);
            writer.WriteObjectValue<ApiSdk.Models.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
