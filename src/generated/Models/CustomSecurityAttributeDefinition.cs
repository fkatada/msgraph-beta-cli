using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class CustomSecurityAttributeDefinition : Entity, IParsable {
        /// <summary>Values that are predefined for this custom security attribute. This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions?$expand=allowedValues.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AllowedValue>? AllowedValues { get; set; }
#nullable restore
#else
        public List<AllowedValue> AllowedValues { get; set; }
#endif
        /// <summary>Name of the attribute set. Case insensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttributeSet { get; set; }
#nullable restore
#else
        public string AttributeSet { get; set; }
#endif
        /// <summary>Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Can be changed later.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If type is set to Boolean, isCollection cannot be set to true.</summary>
        public bool? IsCollection { get; set; }
        /// <summary>Indicates whether custom security attribute values are indexed for searching on objects that are assigned attribute values. Cannot be changed later.</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Specifies whether the custom security attribute is active or deactivated. Acceptable values are: Available and Deprecated. Can be changed later.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>Data type for the custom security attribute values. Supported types are: Boolean, Integer, and String. Cannot be changed later.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.</summary>
        public bool? UsePreDefinedValuesOnly { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomSecurityAttributeDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomSecurityAttributeDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedValues", n => { AllowedValues = n.GetCollectionOfObjectValues<AllowedValue>(AllowedValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attributeSet", n => { AttributeSet = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isCollection", n => { IsCollection = n.GetBoolValue(); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"usePreDefinedValuesOnly", n => { UsePreDefinedValuesOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AllowedValue>("allowedValues", AllowedValues);
            writer.WriteStringValue("attributeSet", AttributeSet);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isCollection", IsCollection);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("type", Type);
            writer.WriteBoolValue("usePreDefinedValuesOnly", UsePreDefinedValuesOnly);
        }
    }
}
