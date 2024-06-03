// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class ListItem : BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of recent activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ItemActivityOLD>? Activities { get; set; }
#nullable restore
#else
        public List<ItemActivityOLD> Activities { get; set; }
#endif
        /// <summary>Analytics about the view activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? Analytics { get; set; }
#nullable restore
#else
        public ItemAnalytics Analytics { get; set; }
#endif
        /// <summary>The content type of this list item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentTypeInfo? ContentType { get; set; }
#nullable restore
#else
        public ContentTypeInfo ContentType { get; set; }
#endif
        /// <summary>The deleted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Deleted? Deleted { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Deleted Deleted { get; set; }
#endif
        /// <summary>Version information for a document set version created by a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DocumentSetVersion>? DocumentSetVersions { get; set; }
#nullable restore
#else
        public List<DocumentSetVersion> DocumentSetVersions { get; set; }
#endif
        /// <summary>For document libraries, the driveItem relationship exposes the listItem as a driveItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DriveItem? DriveItem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DriveItem DriveItem { get; set; }
#endif
        /// <summary>The values of the columns set on this list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FieldValueSet? Fields { get; set; }
#nullable restore
#else
        public FieldValueSet Fields { get; set; }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>The list of previous versions of the list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ListItemVersion>? Versions { get; set; }
#nullable restore
#else
        public List<ListItemVersion> Versions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ListItem"/> and sets the default values.
        /// </summary>
        public ListItem() : base()
        {
            OdataType = "#microsoft.graph.listItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ListItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ListItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activities", n => { Activities = n.GetCollectionOfObjectValues<ItemActivityOLD>(ItemActivityOLD.CreateFromDiscriminatorValue)?.ToList(); } },
                { "analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                { "contentType", n => { ContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                { "deleted", n => { Deleted = n.GetObjectValue<ApiSdk.Models.Deleted>(ApiSdk.Models.Deleted.CreateFromDiscriminatorValue); } },
                { "documentSetVersions", n => { DocumentSetVersions = n.GetCollectionOfObjectValues<DocumentSetVersion>(DocumentSetVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                { "driveItem", n => { DriveItem = n.GetObjectValue<ApiSdk.Models.DriveItem>(ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "fields", n => { Fields = n.GetObjectValue<FieldValueSet>(FieldValueSet.CreateFromDiscriminatorValue); } },
                { "sharepointIds", n => { SharepointIds = n.GetObjectValue<ApiSdk.Models.SharepointIds>(ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "versions", n => { Versions = n.GetCollectionOfObjectValues<ListItemVersion>(ListItemVersion.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ItemActivityOLD>("activities", Activities);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<ContentTypeInfo>("contentType", ContentType);
            writer.WriteObjectValue<ApiSdk.Models.Deleted>("deleted", Deleted);
            writer.WriteCollectionOfObjectValues<DocumentSetVersion>("documentSetVersions", DocumentSetVersions);
            writer.WriteObjectValue<ApiSdk.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<FieldValueSet>("fields", Fields);
            writer.WriteObjectValue<ApiSdk.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<ListItemVersion>("versions", Versions);
        }
    }
}
