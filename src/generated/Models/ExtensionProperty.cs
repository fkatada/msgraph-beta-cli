// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class ExtensionProperty : DirectoryObject, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Display name of the application object on which this extension property is defined. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName { get; set; }
#nullable restore
#else
        public string AppDisplayName { get; set; }
#endif
        /// <summary>Specifies the data type of the value the extension property can hold. Following values are supported. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximumNot nullable. For multivalued directory extensions, these limits apply per value in the collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataType { get; set; }
#nullable restore
#else
        public string DataType { get; set; }
#endif
        /// <summary>Defines the directory extension as a multi-valued property. When true, the directory extension property can store a collection of objects of the dataType; for example, a collection of string types such as &apos;extensionb7b1c57b532f40b8b5ed4b7a7ba67401jobGroupTracker&apos;: [&apos;String 1&apos;, &apos;String 2&apos;]. The default value is false. Supports $filter (eq).</summary>
        public bool? IsMultiValued { get; set; }
        /// <summary>Indicates if this extension property was synced from on-premises active directory using Microsoft Entra Connect. Read-only.</summary>
        public bool? IsSyncedFromOnPremises { get; set; }
        /// <summary>Name of the extension property. Not nullable. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Following values are supported. Not nullable. UserGroupAdministrativeUnitApplicationDeviceOrganization</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TargetObjects { get; set; }
#nullable restore
#else
        public List<string> TargetObjects { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ExtensionProperty"/> and sets the default values.
        /// </summary>
        public ExtensionProperty() : base()
        {
            OdataType = "#microsoft.graph.extensionProperty";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExtensionProperty"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExtensionProperty CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExtensionProperty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"dataType", n => { DataType = n.GetStringValue(); } },
                {"isMultiValued", n => { IsMultiValued = n.GetBoolValue(); } },
                {"isSyncedFromOnPremises", n => { IsSyncedFromOnPremises = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"targetObjects", n => { TargetObjects = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("dataType", DataType);
            writer.WriteBoolValue("isMultiValued", IsMultiValued);
            writer.WriteBoolValue("isSyncedFromOnPremises", IsSyncedFromOnPremises);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("targetObjects", TargetObjects);
        }
    }
}
