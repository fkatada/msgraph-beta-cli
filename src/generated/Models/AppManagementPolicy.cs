// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class AppManagementPolicy : PolicyBase, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Collection of application and service principals to which a policy is applied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? AppliesTo { get; set; }
#nullable restore
#else
        public List<DirectoryObject> AppliesTo { get; set; }
#endif
        /// <summary>Denotes whether the policy is enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Restrictions that apply to an application or service principal object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AppManagementConfiguration? Restrictions { get; set; }
#nullable restore
#else
        public AppManagementConfiguration Restrictions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AppManagementPolicy"/> and sets the default values.
        /// </summary>
        public AppManagementPolicy() : base()
        {
            OdataType = "#microsoft.graph.appManagementPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AppManagementPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AppManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"appliesTo", n => { AppliesTo = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"restrictions", n => { Restrictions = n.GetObjectValue<AppManagementConfiguration>(AppManagementConfiguration.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<AppManagementConfiguration>("restrictions", Restrictions);
        }
    }
}
