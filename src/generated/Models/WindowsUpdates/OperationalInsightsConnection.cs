// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.WindowsUpdates {
    #pragma warning disable CS1591
    public class OperationalInsightsConnection : ResourceConnection, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The name of the Azure resource group that contains the Log Analytics workspace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureResourceGroupName { get; set; }
#nullable restore
#else
        public string AzureResourceGroupName { get; set; }
#endif
        /// <summary>The Azure subscription ID that contains the Log Analytics workspace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureSubscriptionId { get; set; }
#nullable restore
#else
        public string AzureSubscriptionId { get; set; }
#endif
        /// <summary>The name of the Log Analytics workspace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkspaceName { get; set; }
#nullable restore
#else
        public string WorkspaceName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="OperationalInsightsConnection"/> and sets the default values.
        /// </summary>
        public OperationalInsightsConnection() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.operationalInsightsConnection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OperationalInsightsConnection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OperationalInsightsConnection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OperationalInsightsConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"azureResourceGroupName", n => { AzureResourceGroupName = n.GetStringValue(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"workspaceName", n => { WorkspaceName = n.GetStringValue(); } },
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
            writer.WriteStringValue("azureResourceGroupName", AzureResourceGroupName);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("workspaceName", WorkspaceName);
        }
    }
}
