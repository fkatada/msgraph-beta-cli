// <auto-generated/>
using ApiSdk.Models.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Site : BaseItem, IParsable 
    {
        /// <summary>Analytics about the view activities that took place in this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? Analytics { get; set; }
#nullable restore
#else
        public ItemAnalytics Analytics { get; set; }
#endif
        /// <summary>The collection of column definitions reusable across lists under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? Columns { get; set; }
#nullable restore
#else
        public List<ColumnDefinition> Columns { get; set; }
#endif
        /// <summary>The collection of content types defined for this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentType>? ContentTypes { get; set; }
#nullable restore
#else
        public List<ContentType> ContentTypes { get; set; }
#endif
        /// <summary>The deleted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Deleted? Deleted { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Deleted Deleted { get; set; }
#endif
        /// <summary>The full title for the site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The default drive (document library) for this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Drive? Drive { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Drive Drive { get; set; }
#endif
        /// <summary>The collection of drives (document libraries) under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Drive>? Drives { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Drive> Drives { get; set; }
#endif
        /// <summary>The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? ExternalColumns { get; set; }
#nullable restore
#else
        public List<ColumnDefinition> ExternalColumns { get; set; }
#endif
        /// <summary>The informationProtection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.InformationProtection? InformationProtection { get; set; }
#nullable restore
#else
        public ApiSdk.Models.InformationProtection InformationProtection { get; set; }
#endif
        /// <summary>The isPersonalSite property</summary>
        public bool? IsPersonalSite { get; set; }
        /// <summary>Used to address any item contained in this site. This collection cannot be enumerated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BaseItem>? Items { get; set; }
#nullable restore
#else
        public List<BaseItem> Items { get; set; }
#endif
        /// <summary>The collection of lists under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<List>? Lists { get; set; }
#nullable restore
#else
        public List<List> Lists { get; set; }
#endif
        /// <summary>The onenote property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Onenote? Onenote { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Onenote Onenote { get; set; }
#endif
        /// <summary>The collection of long running operations for the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RichLongRunningOperation>? Operations { get; set; }
#nullable restore
#else
        public List<RichLongRunningOperation> Operations { get; set; }
#endif
        /// <summary>The collection of pages in the baseSitePages list in this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BaseSitePage>? Pages { get; set; }
#nullable restore
#else
        public List<BaseSitePage> Pages { get; set; }
#endif
        /// <summary>The permissions associated with the site. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Permission>? Permissions { get; set; }
#nullable restore
#else
        public List<Permission> Permissions { get; set; }
#endif
        /// <summary>A container for a collection of recycleBinItem resources in this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RecycleBin? RecycleBin { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RecycleBin RecycleBin { get; set; }
#endif
        /// <summary>If present, indicates that this is the root site in the site collection. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Root? Root { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Root Root { get; set; }
#endif
        /// <summary>The settings on this site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SiteSettings? Settings { get; set; }
#nullable restore
#else
        public SiteSettings Settings { get; set; }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>Provides details about the site&apos;s site collection. Available only on the root site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SiteCollection? SiteCollection { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SiteCollection SiteCollection { get; set; }
#endif
        /// <summary>The collection of the sub-sites under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Site>? Sites { get; set; }
#nullable restore
#else
        public List<Site> Sites { get; set; }
#endif
        /// <summary>The termStore under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Store? TermStore { get; set; }
#nullable restore
#else
        public Store TermStore { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Site"/> and sets the default values.
        /// </summary>
        public Site() : base()
        {
            OdataType = "#microsoft.graph.site";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Site"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Site CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Site();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deleted", n => { Deleted = n.GetObjectValue<ApiSdk.Models.Deleted>(ApiSdk.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<ApiSdk.Models.Drive>(ApiSdk.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<ApiSdk.Models.Drive>(ApiSdk.Models.Drive.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalColumns", n => { ExternalColumns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"informationProtection", n => { InformationProtection = n.GetObjectValue<ApiSdk.Models.InformationProtection>(ApiSdk.Models.InformationProtection.CreateFromDiscriminatorValue); } },
                {"isPersonalSite", n => { IsPersonalSite = n.GetBoolValue(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<BaseItem>(BaseItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lists", n => { Lists = n.GetCollectionOfObjectValues<List>(List.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onenote", n => { Onenote = n.GetObjectValue<ApiSdk.Models.Onenote>(ApiSdk.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<RichLongRunningOperation>(RichLongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pages", n => { Pages = n.GetCollectionOfObjectValues<BaseSitePage>(BaseSitePage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"recycleBin", n => { RecycleBin = n.GetObjectValue<ApiSdk.Models.RecycleBin>(ApiSdk.Models.RecycleBin.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<ApiSdk.Models.Root>(ApiSdk.Models.Root.CreateFromDiscriminatorValue); } },
                {"settings", n => { Settings = n.GetObjectValue<SiteSettings>(SiteSettings.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<ApiSdk.Models.SharepointIds>(ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"siteCollection", n => { SiteCollection = n.GetObjectValue<ApiSdk.Models.SiteCollection>(ApiSdk.Models.SiteCollection.CreateFromDiscriminatorValue); } },
                {"sites", n => { Sites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue)?.ToList(); } },
                {"termStore", n => { TermStore = n.GetObjectValue<Store>(Store.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<ContentType>("contentTypes", ContentTypes);
            writer.WriteObjectValue<ApiSdk.Models.Deleted>("deleted", Deleted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ApiSdk.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Drive>("drives", Drives);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("externalColumns", ExternalColumns);
            writer.WriteObjectValue<ApiSdk.Models.InformationProtection>("informationProtection", InformationProtection);
            writer.WriteBoolValue("isPersonalSite", IsPersonalSite);
            writer.WriteCollectionOfObjectValues<BaseItem>("items", Items);
            writer.WriteCollectionOfObjectValues<List>("lists", Lists);
            writer.WriteObjectValue<ApiSdk.Models.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<RichLongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<BaseSitePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<ApiSdk.Models.RecycleBin>("recycleBin", RecycleBin);
            writer.WriteObjectValue<ApiSdk.Models.Root>("root", Root);
            writer.WriteObjectValue<SiteSettings>("settings", Settings);
            writer.WriteObjectValue<ApiSdk.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteObjectValue<ApiSdk.Models.SiteCollection>("siteCollection", SiteCollection);
            writer.WriteCollectionOfObjectValues<Site>("sites", Sites);
            writer.WriteObjectValue<Store>("termStore", TermStore);
        }
    }
}
