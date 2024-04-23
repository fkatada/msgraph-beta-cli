// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.WindowsUpdates {
    public class ContentApproval : ComplianceChange, IParsable 
    {
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeployableContent? Content { get; set; }
#nullable restore
#else
        public DeployableContent Content { get; set; }
#endif
        /// <summary>Deployments created as a result of applying the approval.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Deployment>? Deployments { get; set; }
#nullable restore
#else
        public List<Deployment> Deployments { get; set; }
#endif
        /// <summary>Settings for governing how to deploy content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.WindowsUpdates.DeploymentSettings? DeploymentSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.WindowsUpdates.DeploymentSettings DeploymentSettings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ContentApproval"/> and sets the default values.
        /// </summary>
        public ContentApproval() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.contentApproval";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ContentApproval"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ContentApproval CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentApproval();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"content", n => { Content = n.GetObjectValue<DeployableContent>(DeployableContent.CreateFromDiscriminatorValue); } },
                {"deploymentSettings", n => { DeploymentSettings = n.GetObjectValue<ApiSdk.Models.WindowsUpdates.DeploymentSettings>(ApiSdk.Models.WindowsUpdates.DeploymentSettings.CreateFromDiscriminatorValue); } },
                {"deployments", n => { Deployments = n.GetCollectionOfObjectValues<Deployment>(Deployment.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<DeployableContent>("content", Content);
            writer.WriteCollectionOfObjectValues<Deployment>("deployments", Deployments);
            writer.WriteObjectValue<ApiSdk.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings", DeploymentSettings);
        }
    }
}
