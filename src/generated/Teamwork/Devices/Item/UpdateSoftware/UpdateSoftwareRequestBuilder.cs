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
namespace ApiSdk.Teamwork.Devices.Item.UpdateSoftware {
    /// <summary>
    /// Provides operations to call the updateSoftware method.
    /// </summary>
    public class UpdateSoftwareRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Update the software for a Microsoft Teams-enabled device. This API triggers a long-running operation.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/teamworkdevice-updatesoftware?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Update the software for a Microsoft Teams-enabled device. This API triggers a long-running operation.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/teamworkdevice-updatesoftware?view=graph-rest-beta";
            var teamworkDeviceIdOption = new Option<string>("--teamwork-device-id", description: "The unique identifier of teamworkDevice") {
            };
            teamworkDeviceIdOption.IsRequired = true;
            command.AddOption(teamworkDeviceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var teamworkDeviceId = invocationContext.ParseResult.GetValueForOption(teamworkDeviceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<UpdateSoftwarePostRequestBody>(UpdateSoftwarePostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (teamworkDeviceId is not null) requestInfo.PathParameters.Add("teamworkDevice%2Did", teamworkDeviceId);
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
        /// Instantiates a new <see cref="UpdateSoftwareRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UpdateSoftwareRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teamwork/devices/{teamworkDevice%2Did}/updateSoftware", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="UpdateSoftwareRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UpdateSoftwareRequestBuilder(string rawUrl) : base("{+baseurl}/teamwork/devices/{teamworkDevice%2Did}/updateSoftware", rawUrl)
        {
        }
        /// <summary>
        /// Update the software for a Microsoft Teams-enabled device. This API triggers a long-running operation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(UpdateSoftwarePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(UpdateSoftwarePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
