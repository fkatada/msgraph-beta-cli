// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class EnumeratedDeviceRegistrationMembership : DeviceRegistrationMembership, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>List of groups that this policy applies to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Groups { get; set; }
#nullable restore
#else
        public List<string> Groups { get; set; }
#endif
        /// <summary>List of users that this policy applies to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Users { get; set; }
#nullable restore
#else
        public List<string> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EnumeratedDeviceRegistrationMembership"/> and sets the default values.
        /// </summary>
        public EnumeratedDeviceRegistrationMembership() : base()
        {
            OdataType = "#microsoft.graph.enumeratedDeviceRegistrationMembership";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EnumeratedDeviceRegistrationMembership"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EnumeratedDeviceRegistrationMembership CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnumeratedDeviceRegistrationMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"groups", n => { Groups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"users", n => { Users = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("groups", Groups);
            writer.WriteCollectionOfPrimitiveValues<string>("users", Users);
        }
    }
}
