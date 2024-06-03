// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Ediscovery
{
    #pragma warning disable CS1591
    public class NoncustodialDataSource : DataSourceContainer, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates if hold is applied to noncustodial data source (such as mailbox or site).</summary>
        public bool? ApplyHoldToSource { get; set; }
        /// <summary>User source or SharePoint site data source as noncustodial data source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Ediscovery.DataSource? DataSource { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Ediscovery.DataSource DataSource { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="NoncustodialDataSource"/> and sets the default values.
        /// </summary>
        public NoncustodialDataSource() : base()
        {
            OdataType = "#microsoft.graph.ediscovery.noncustodialDataSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="NoncustodialDataSource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new NoncustodialDataSource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NoncustodialDataSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applyHoldToSource", n => { ApplyHoldToSource = n.GetBoolValue(); } },
                { "dataSource", n => { DataSource = n.GetObjectValue<ApiSdk.Models.Ediscovery.DataSource>(ApiSdk.Models.Ediscovery.DataSource.CreateFromDiscriminatorValue); } },
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
            writer.WriteBoolValue("applyHoldToSource", ApplyHoldToSource);
            writer.WriteObjectValue<ApiSdk.Models.Ediscovery.DataSource>("dataSource", DataSource);
        }
    }
}
