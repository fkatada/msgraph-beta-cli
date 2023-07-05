using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Location : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The street address of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PhysicalAddress? Address { get; set; }
#nullable restore
#else
        public PhysicalAddress Address { get; set; }
#endif
        /// <summary>The geographic coordinates and elevation of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OutlookGeoCoordinates? Coordinates { get; set; }
#nullable restore
#else
        public OutlookGeoCoordinates Coordinates { get; set; }
#endif
        /// <summary>The name associated with the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The street address of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PhysicalAddress? LocationAddress { get; set; }
#nullable restore
#else
        public PhysicalAddress LocationAddress { get; set; }
#endif
        /// <summary>The geographic coordinates and elevation of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OutlookGeoCoordinates? LocationCoordinates { get; set; }
#nullable restore
#else
        public OutlookGeoCoordinates LocationCoordinates { get; set; }
#endif
        /// <summary>The name associated with the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationDisplayName { get; set; }
#nullable restore
#else
        public string LocationDisplayName { get; set; }
#endif
        /// <summary>Optional email address of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationEmailAddress { get; set; }
#nullable restore
#else
        public string LocationEmailAddress { get; set; }
#endif
        /// <summary>Optional email address of the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationLocationEmailAddress { get; set; }
#nullable restore
#else
        public string LocationLocationEmailAddress { get; set; }
#endif
        /// <summary>The type of location. The possible values are: default, conferenceRoom, homeAddress, businessAddress,geoCoordinates, streetAddress, hotel, restaurant, localBusiness, postalAddress. Read-only.</summary>
        public ApiSdk.Models.LocationType? LocationLocationType { get; set; }
        /// <summary>Optional URI representing the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationLocationUri { get; set; }
#nullable restore
#else
        public string LocationLocationUri { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationOdataType { get; set; }
#nullable restore
#else
        public string LocationOdataType { get; set; }
#endif
        /// <summary>The type of location. The possible values are: default, conferenceRoom, homeAddress, businessAddress,geoCoordinates, streetAddress, hotel, restaurant, localBusiness, postalAddress. Read-only.</summary>
        public ApiSdk.Models.LocationType? LocationType { get; set; }
        /// <summary>For internal use only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationUniqueId { get; set; }
#nullable restore
#else
        public string LocationUniqueId { get; set; }
#endif
        /// <summary>For internal use only.</summary>
        public ApiSdk.Models.LocationUniqueIdType? LocationUniqueIdType { get; set; }
        /// <summary>Optional URI representing the location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationUri { get; set; }
#nullable restore
#else
        public string LocationUri { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>For internal use only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniqueId { get; set; }
#nullable restore
#else
        public string UniqueId { get; set; }
#endif
        /// <summary>For internal use only.</summary>
        public ApiSdk.Models.LocationUniqueIdType? UniqueIdType { get; set; }
        /// <summary>
        /// Instantiates a new location and sets the default values.
        /// </summary>
        public Location() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Location CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.locationConstraintItem" => new LocationConstraintItem(),
                _ => new Location(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"coordinates", n => { Coordinates = n.GetObjectValue<OutlookGeoCoordinates>(OutlookGeoCoordinates.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"address", n => { LocationAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"coordinates", n => { LocationCoordinates = n.GetObjectValue<OutlookGeoCoordinates>(OutlookGeoCoordinates.CreateFromDiscriminatorValue); } },
                {"displayName", n => { LocationDisplayName = n.GetStringValue(); } },
                {"locationEmailAddress", n => { LocationEmailAddress = n.GetStringValue(); } },
                {"locationEmailAddress", n => { LocationLocationEmailAddress = n.GetStringValue(); } },
                {"locationType", n => { LocationLocationType = n.GetEnumValue<LocationType>(); } },
                {"locationUri", n => { LocationLocationUri = n.GetStringValue(); } },
                {"@odata.type", n => { LocationOdataType = n.GetStringValue(); } },
                {"locationType", n => { LocationType = n.GetEnumValue<LocationType>(); } },
                {"uniqueId", n => { LocationUniqueId = n.GetStringValue(); } },
                {"uniqueIdType", n => { LocationUniqueIdType = n.GetEnumValue<LocationUniqueIdType>(); } },
                {"locationUri", n => { LocationUri = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"uniqueId", n => { UniqueId = n.GetStringValue(); } },
                {"uniqueIdType", n => { UniqueIdType = n.GetEnumValue<LocationUniqueIdType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteObjectValue<OutlookGeoCoordinates>("coordinates", Coordinates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<PhysicalAddress>("address", LocationAddress);
            writer.WriteObjectValue<OutlookGeoCoordinates>("coordinates", LocationCoordinates);
            writer.WriteStringValue("displayName", LocationDisplayName);
            writer.WriteStringValue("locationEmailAddress", LocationEmailAddress);
            writer.WriteStringValue("locationEmailAddress", LocationLocationEmailAddress);
            writer.WriteEnumValue<LocationType>("locationType", LocationLocationType);
            writer.WriteStringValue("locationUri", LocationLocationUri);
            writer.WriteStringValue("@odata.type", LocationOdataType);
            writer.WriteEnumValue<LocationType>("locationType", LocationType);
            writer.WriteStringValue("uniqueId", LocationUniqueId);
            writer.WriteEnumValue<LocationUniqueIdType>("uniqueIdType", LocationUniqueIdType);
            writer.WriteStringValue("locationUri", LocationUri);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("uniqueId", UniqueId);
            writer.WriteEnumValue<LocationUniqueIdType>("uniqueIdType", UniqueIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
