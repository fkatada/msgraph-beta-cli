// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Employee : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? Address { get; set; }
#nullable restore
#else
        public PostalAddressType Address { get; set; }
#endif
        /// <summary>The birthDate property</summary>
        public Date? BirthDate { get; set; }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The employmentDate property</summary>
        public Date? EmploymentDate { get; set; }
        /// <summary>The givenName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName { get; set; }
#nullable restore
#else
        public string GivenName { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The jobTitle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle { get; set; }
#nullable restore
#else
        public string JobTitle { get; set; }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The middleName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MiddleName { get; set; }
#nullable restore
#else
        public string MiddleName { get; set; }
#endif
        /// <summary>The mobilePhone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MobilePhone { get; set; }
#nullable restore
#else
        public string MobilePhone { get; set; }
#endif
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number { get; set; }
#nullable restore
#else
        public string Number { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The personalEmail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonalEmail { get; set; }
#nullable restore
#else
        public string PersonalEmail { get; set; }
#endif
        /// <summary>The phoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The picture property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Picture>? Picture { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Picture> Picture { get; set; }
#endif
        /// <summary>The statisticsGroupCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatisticsGroupCode { get; set; }
#nullable restore
#else
        public string StatisticsGroupCode { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The surname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname { get; set; }
#nullable restore
#else
        public string Surname { get; set; }
#endif
        /// <summary>The terminationDate property</summary>
        public Date? TerminationDate { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Employee"/> and sets the default values.
        /// </summary>
        public Employee()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Employee"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Employee CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Employee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                { "birthDate", n => { BirthDate = n.GetDateValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "employmentDate", n => { EmploymentDate = n.GetDateValue(); } },
                { "givenName", n => { GivenName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "jobTitle", n => { JobTitle = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "middleName", n => { MiddleName = n.GetStringValue(); } },
                { "mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                { "number", n => { Number = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "personalEmail", n => { PersonalEmail = n.GetStringValue(); } },
                { "phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                { "picture", n => { Picture = n.GetCollectionOfObjectValues<ApiSdk.Models.Picture>(ApiSdk.Models.Picture.CreateFromDiscriminatorValue)?.ToList(); } },
                { "statisticsGroupCode", n => { StatisticsGroupCode = n.GetStringValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "surname", n => { Surname = n.GetStringValue(); } },
                { "terminationDate", n => { TerminationDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PostalAddressType>("address", Address);
            writer.WriteDateValue("birthDate", BirthDate);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteDateValue("employmentDate", EmploymentDate);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("personalEmail", PersonalEmail);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Picture>("picture", Picture);
            writer.WriteStringValue("statisticsGroupCode", StatisticsGroupCode);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("surname", Surname);
            writer.WriteDateValue("terminationDate", TerminationDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
