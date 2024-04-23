// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Represents a booked appointment of a service by a customer in a business.
    /// </summary>
    public class BookingAppointment : Entity, IParsable 
    {
        /// <summary>Additional information that is sent to the customer when an appointment is confirmed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation { get; set; }
#nullable restore
#else
        public string AdditionalInformation { get; set; }
#endif
        /// <summary>The URL of the meeting to join anonymously.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnonymousJoinWebUrl { get; set; }
#nullable restore
#else
        public string AnonymousJoinWebUrl { get; set; }
#endif
        /// <summary>The user can stamp a custom label on the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppointmentLabel { get; set; }
#nullable restore
#else
        public string AppointmentLabel { get; set; }
#endif
        /// <summary>The date, time, and timezone when the appointment was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The SMTP address of the bookingCustomer who is booking the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerEmailAddress { get; set; }
#nullable restore
#else
        public string CustomerEmailAddress { get; set; }
#endif
        /// <summary>The ID of the bookingCustomer for this appointment. If no ID is specified when an appointment is created, then a new bookingCustomer object is created. Once set, you should consider the customerId immutable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId { get; set; }
#nullable restore
#else
        public string CustomerId { get; set; }
#endif
        /// <summary>Represents location information for the bookingCustomer who is booking the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Location? CustomerLocation { get; set; }
#nullable restore
#else
        public Location CustomerLocation { get; set; }
#endif
        /// <summary>The customer&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerName { get; set; }
#nullable restore
#else
        public string CustomerName { get; set; }
#endif
        /// <summary>Notes from the customer associated with this appointment. You can get the value only when reading this bookingAppointment by its ID.  You can set this property only when initially creating an appointment with a new customer. After that point, the value is computed from the customer represented by customerId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNotes { get; set; }
#nullable restore
#else
        public string CustomerNotes { get; set; }
#endif
        /// <summary>The customer&apos;s phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerPhone { get; set; }
#nullable restore
#else
        public string CustomerPhone { get; set; }
#endif
        /// <summary>A collection of the customer properties for an appointment. An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingCustomerInformationBase>? Customers { get; set; }
#nullable restore
#else
        public List<BookingCustomerInformationBase> Customers { get; set; }
#endif
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerTimeZone { get; set; }
#nullable restore
#else
        public string CustomerTimeZone { get; set; }
#endif
        /// <summary>The length of the appointment, denoted in ISO8601 format.</summary>
        public TimeSpan? Duration { get; private set; }
        /// <summary>The end property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? End { get; set; }
#nullable restore
#else
        public DateTimeTimeZone End { get; set; }
#endif
        /// <summary>The current number of customers in the appointment.</summary>
        public int? FilledAttendeesCount { get; private set; }
        /// <summary>The billed amount on the invoice.</summary>
        public double? InvoiceAmount { get; set; }
        /// <summary>The date, time, and time zone of the invoice for this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? InvoiceDate { get; set; }
#nullable restore
#else
        public DateTimeTimeZone InvoiceDate { get; set; }
#endif
        /// <summary>The ID of the invoice.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceId { get; set; }
#nullable restore
#else
        public string InvoiceId { get; set; }
#endif
        /// <summary>The invoiceStatus property</summary>
        public BookingInvoiceStatus? InvoiceStatus { get; set; }
        /// <summary>The URL of the invoice in Microsoft Bookings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceUrl { get; set; }
#nullable restore
#else
        public string InvoiceUrl { get; set; }
#endif
        /// <summary>Indicates that the customer can manage bookings created by the staff. The default value is false.</summary>
        public bool? IsCustomerAllowedToManageBooking { get; set; }
        /// <summary>Indicates that the appointment is held online. The default value is false.</summary>
        public bool? IsLocationOnline { get; set; }
        /// <summary>The URL of the online meeting for the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl { get; set; }
#nullable restore
#else
        public string JoinWebUrl { get; set; }
#endif
        /// <summary>The date, time and timezone when the booking business was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The maximum number of customers allowed in an appointment. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.</summary>
        public int? MaximumAttendeesCount { get; set; }
        /// <summary>The onlineMeetingUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineMeetingUrl { get; set; }
#nullable restore
#else
        public string OnlineMeetingUrl { get; set; }
#endif
        /// <summary>True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.</summary>
        public bool? OptOutOfCustomerEmail { get; set; }
        /// <summary>The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PostBuffer { get; set; }
        /// <summary>The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PreBuffer { get; set; }
        /// <summary>The regular price for an appointment for the specified bookingService.</summary>
        public double? Price { get; set; }
        /// <summary>Represents the type of pricing of a booking service.</summary>
        public BookingPriceType? PriceType { get; set; }
        /// <summary>The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingReminder>? Reminders { get; set; }
#nullable restore
#else
        public List<BookingReminder> Reminders { get; set; }
#endif
        /// <summary>Another tracking ID for the appointment, if the appointment was created directly by the customer on the scheduling page, as opposed to by a staff member on behalf of customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelfServiceAppointmentId { get; set; }
#nullable restore
#else
        public string SelfServiceAppointmentId { get; set; }
#endif
        /// <summary>The ID of the bookingService associated with this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceId { get; set; }
#nullable restore
#else
        public string ServiceId { get; set; }
#endif
        /// <summary>The location where the service is delivered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Location? ServiceLocation { get; set; }
#nullable restore
#else
        public Location ServiceLocation { get; set; }
#endif
        /// <summary>The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceName { get; set; }
#nullable restore
#else
        public string ServiceName { get; set; }
#endif
        /// <summary>Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceNotes { get; set; }
#nullable restore
#else
        public string ServiceNotes { get; set; }
#endif
        /// <summary>True indicates SMS notifications will be sent to the customers for the appointment. Default value is false.</summary>
        public bool? SmsNotificationsEnabled { get; set; }
        /// <summary>The ID of each bookingStaffMember who is scheduled in this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StaffMemberIds { get; set; }
#nullable restore
#else
        public List<string> StaffMemberIds { get; set; }
#endif
        /// <summary>The start property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? Start { get; set; }
#nullable restore
#else
        public DateTimeTimeZone Start { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BookingAppointment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BookingAppointment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingAppointment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"anonymousJoinWebUrl", n => { AnonymousJoinWebUrl = n.GetStringValue(); } },
                {"appointmentLabel", n => { AppointmentLabel = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customerEmailAddress", n => { CustomerEmailAddress = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerLocation", n => { CustomerLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"customerName", n => { CustomerName = n.GetStringValue(); } },
                {"customerNotes", n => { CustomerNotes = n.GetStringValue(); } },
                {"customerPhone", n => { CustomerPhone = n.GetStringValue(); } },
                {"customerTimeZone", n => { CustomerTimeZone = n.GetStringValue(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<BookingCustomerInformationBase>(BookingCustomerInformationBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"end", n => { End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"filledAttendeesCount", n => { FilledAttendeesCount = n.GetIntValue(); } },
                {"invoiceAmount", n => { InvoiceAmount = n.GetDoubleValue(); } },
                {"invoiceDate", n => { InvoiceDate = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"invoiceId", n => { InvoiceId = n.GetStringValue(); } },
                {"invoiceStatus", n => { InvoiceStatus = n.GetEnumValue<BookingInvoiceStatus>(); } },
                {"invoiceUrl", n => { InvoiceUrl = n.GetStringValue(); } },
                {"isCustomerAllowedToManageBooking", n => { IsCustomerAllowedToManageBooking = n.GetBoolValue(); } },
                {"isLocationOnline", n => { IsLocationOnline = n.GetBoolValue(); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"maximumAttendeesCount", n => { MaximumAttendeesCount = n.GetIntValue(); } },
                {"onlineMeetingUrl", n => { OnlineMeetingUrl = n.GetStringValue(); } },
                {"optOutOfCustomerEmail", n => { OptOutOfCustomerEmail = n.GetBoolValue(); } },
                {"postBuffer", n => { PostBuffer = n.GetTimeSpanValue(); } },
                {"preBuffer", n => { PreBuffer = n.GetTimeSpanValue(); } },
                {"price", n => { Price = n.GetDoubleValue(); } },
                {"priceType", n => { PriceType = n.GetEnumValue<BookingPriceType>(); } },
                {"reminders", n => { Reminders = n.GetCollectionOfObjectValues<BookingReminder>(BookingReminder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"selfServiceAppointmentId", n => { SelfServiceAppointmentId = n.GetStringValue(); } },
                {"serviceId", n => { ServiceId = n.GetStringValue(); } },
                {"serviceLocation", n => { ServiceLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
                {"serviceNotes", n => { ServiceNotes = n.GetStringValue(); } },
                {"smsNotificationsEnabled", n => { SmsNotificationsEnabled = n.GetBoolValue(); } },
                {"staffMemberIds", n => { StaffMemberIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"start", n => { Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("anonymousJoinWebUrl", AnonymousJoinWebUrl);
            writer.WriteStringValue("appointmentLabel", AppointmentLabel);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("customerEmailAddress", CustomerEmailAddress);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteObjectValue<Location>("customerLocation", CustomerLocation);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNotes", CustomerNotes);
            writer.WriteStringValue("customerPhone", CustomerPhone);
            writer.WriteCollectionOfObjectValues<BookingCustomerInformationBase>("customers", Customers);
            writer.WriteStringValue("customerTimeZone", CustomerTimeZone);
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteDoubleValue("invoiceAmount", InvoiceAmount);
            writer.WriteObjectValue<DateTimeTimeZone>("invoiceDate", InvoiceDate);
            writer.WriteStringValue("invoiceId", InvoiceId);
            writer.WriteEnumValue<BookingInvoiceStatus>("invoiceStatus", InvoiceStatus);
            writer.WriteStringValue("invoiceUrl", InvoiceUrl);
            writer.WriteBoolValue("isCustomerAllowedToManageBooking", IsCustomerAllowedToManageBooking);
            writer.WriteBoolValue("isLocationOnline", IsLocationOnline);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteIntValue("maximumAttendeesCount", MaximumAttendeesCount);
            writer.WriteStringValue("onlineMeetingUrl", OnlineMeetingUrl);
            writer.WriteBoolValue("optOutOfCustomerEmail", OptOutOfCustomerEmail);
            writer.WriteTimeSpanValue("postBuffer", PostBuffer);
            writer.WriteTimeSpanValue("preBuffer", PreBuffer);
            writer.WriteDoubleValue("price", Price);
            writer.WriteEnumValue<BookingPriceType>("priceType", PriceType);
            writer.WriteCollectionOfObjectValues<BookingReminder>("reminders", Reminders);
            writer.WriteStringValue("selfServiceAppointmentId", SelfServiceAppointmentId);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteObjectValue<Location>("serviceLocation", ServiceLocation);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteStringValue("serviceNotes", ServiceNotes);
            writer.WriteBoolValue("smsNotificationsEnabled", SmsNotificationsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("staffMemberIds", StaffMemberIds);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
        }
    }
}
