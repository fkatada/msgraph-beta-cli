// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Solutions.BookingBusinesses.Item.Appointments.Item.Cancel {
    /// <summary>
    /// Provides operations to call the cancel method.
    /// </summary>
    public class CancelRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/bookingappointment-cancel?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/bookingappointment-cancel?view=graph-rest-1.0";
            var bookingBusinessIdOption = new Option<string>("--booking-business-id", description: "The unique identifier of bookingBusiness") {
            };
            bookingBusinessIdOption.IsRequired = true;
            command.AddOption(bookingBusinessIdOption);
            var bookingAppointmentIdOption = new Option<string>("--booking-appointment-id", description: "The unique identifier of bookingAppointment") {
            };
            bookingAppointmentIdOption.IsRequired = true;
            command.AddOption(bookingAppointmentIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var bookingBusinessId = invocationContext.ParseResult.GetValueForOption(bookingBusinessIdOption);
                var bookingAppointmentId = invocationContext.ParseResult.GetValueForOption(bookingAppointmentIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<CancelPostRequestBody>(CancelPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (bookingBusinessId is not null) requestInfo.PathParameters.Add("bookingBusiness%2Did", bookingBusinessId);
                if (bookingAppointmentId is not null) requestInfo.PathParameters.Add("bookingAppointment%2Did", bookingAppointmentId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="CancelRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CancelRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}/appointments/{bookingAppointment%2Did}/cancel", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CancelRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CancelRequestBuilder(string rawUrl) : base("{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}/appointments/{bookingAppointment%2Did}/cancel", rawUrl)
        {
        }
        /// <summary>
        /// Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CancelPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CancelPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
