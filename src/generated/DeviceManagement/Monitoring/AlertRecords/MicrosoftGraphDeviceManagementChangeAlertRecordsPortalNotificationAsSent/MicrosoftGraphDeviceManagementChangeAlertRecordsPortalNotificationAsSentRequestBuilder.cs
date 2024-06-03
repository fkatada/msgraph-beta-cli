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
namespace ApiSdk.DeviceManagement.Monitoring.AlertRecords.MicrosoftGraphDeviceManagementChangeAlertRecordsPortalNotificationAsSent
{
    /// <summary>
    /// Provides operations to call the changeAlertRecordsPortalNotificationAsSent method.
    /// </summary>
    public class MicrosoftGraphDeviceManagementChangeAlertRecordsPortalNotificationAsSentRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Set the isPortalNotificationSent property of all portal notification resources associated with the specified alertRecord to true, marking them as sent. A maximum of 100 alertRecord IDs can be received at one time, and a maximum of 100 portal notification resources can be changed in the isPortalNotificationSent property status.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Set the isPortalNotificationSent property of all portal notification resources associated with the specified alertRecord to true, marking them as sent. A maximum of 100 alertRecord IDs can be received at one time, and a maximum of 100 portal notification resources can be changed in the isPortalNotificationSent property status.";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ChangeAlertRecordsPortalNotificationAsSentPostRequestBody>(ChangeAlertRecordsPortalNotificationAsSentPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
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
        /// Instantiates a new <see cref="MicrosoftGraphDeviceManagementChangeAlertRecordsPortalNotificationAsSentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphDeviceManagementChangeAlertRecordsPortalNotificationAsSentRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/monitoring/alertRecords/microsoft.graph.deviceManagement.changeAlertRecordsPortalNotificationAsSent", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphDeviceManagementChangeAlertRecordsPortalNotificationAsSentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphDeviceManagementChangeAlertRecordsPortalNotificationAsSentRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/monitoring/alertRecords/microsoft.graph.deviceManagement.changeAlertRecordsPortalNotificationAsSent", rawUrl)
        {
        }
        /// <summary>
        /// Set the isPortalNotificationSent property of all portal notification resources associated with the specified alertRecord to true, marking them as sent. A maximum of 100 alertRecord IDs can be received at one time, and a maximum of 100 portal notification resources can be changed in the isPortalNotificationSent property status.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ChangeAlertRecordsPortalNotificationAsSentPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ChangeAlertRecordsPortalNotificationAsSentPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
