// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class ItemActivityOLD : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActionSet? Action { get; set; }
#nullable restore
#else
        public ItemActionSet Action { get; set; }
#endif
        /// <summary>The actor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Actor { get; set; }
#nullable restore
#else
        public IdentitySet Actor { get; set; }
#endif
        /// <summary>The driveItem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DriveItem? DriveItem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DriveItem DriveItem { get; set; }
#endif
        /// <summary>The listItem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ListItem? ListItem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ListItem ListItem { get; set; }
#endif
        /// <summary>The times property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActivityTimeSet? Times { get; set; }
#nullable restore
#else
        public ItemActivityTimeSet Times { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ItemActivityOLD"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemActivityOLD CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivityOLD();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "action", n => { Action = n.GetObjectValue<ItemActionSet>(ItemActionSet.CreateFromDiscriminatorValue); } },
                { "actor", n => { Actor = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                { "driveItem", n => { DriveItem = n.GetObjectValue<ApiSdk.Models.DriveItem>(ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "listItem", n => { ListItem = n.GetObjectValue<ApiSdk.Models.ListItem>(ApiSdk.Models.ListItem.CreateFromDiscriminatorValue); } },
                { "times", n => { Times = n.GetObjectValue<ItemActivityTimeSet>(ItemActivityTimeSet.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ItemActionSet>("action", Action);
            writer.WriteObjectValue<IdentitySet>("actor", Actor);
            writer.WriteObjectValue<ApiSdk.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<ApiSdk.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<ItemActivityTimeSet>("times", Times);
        }
    }
}
