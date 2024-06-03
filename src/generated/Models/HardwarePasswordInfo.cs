// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Intune will provide customer the ability to configure hardware/bios settings on the enrolled windows 10 Azure Active Directory joined devices.
    /// </summary>
    public class HardwarePasswordInfo : Entity, IParsable
    {
        /// <summary>Current device password</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentPassword { get; set; }
#nullable restore
#else
        public string CurrentPassword { get; set; }
#endif
        /// <summary>List of previous device passwords</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PreviousPasswords { get; set; }
#nullable restore
#else
        public List<string> PreviousPasswords { get; set; }
#endif
        /// <summary>Device serial number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HardwarePasswordInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new HardwarePasswordInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HardwarePasswordInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "currentPassword", n => { CurrentPassword = n.GetStringValue(); } },
                { "previousPasswords", n => { PreviousPasswords = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "serialNumber", n => { SerialNumber = n.GetStringValue(); } },
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
            writer.WriteStringValue("currentPassword", CurrentPassword);
            writer.WriteCollectionOfPrimitiveValues<string>("previousPasswords", PreviousPasswords);
            writer.WriteStringValue("serialNumber", SerialNumber);
        }
    }
}
