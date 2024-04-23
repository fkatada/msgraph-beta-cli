// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.Drives.Item.Items.Item.CreateLink {
    /// <summary>
    /// Provides operations to call the createLink method.
    /// </summary>
    public class CreateLinkRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Create a link to share a driveItem driveItem.The createLink action creates a new sharing link if the specified link type doesn&apos;t already exist for the calling application.If a sharing link of the specified type already exists for the app, the existing sharing link is returned. DriveItem resources inherit sharing permissions from their ancestors.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/driveitem-createlink?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Create a link to share a driveItem driveItem.The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.If a sharing link of the specified type already exists for the app, the existing sharing link is returned. DriveItem resources inherit sharing permissions from their ancestors.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/driveitem-createlink?view=graph-rest-1.0";
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<CreateLinkPostRequestBody>(CreateLinkPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="CreateLinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CreateLinkRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/createLink", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CreateLinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CreateLinkRequestBuilder(string rawUrl) : base("{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/createLink", rawUrl)
        {
        }
        /// <summary>
        /// Create a link to share a driveItem driveItem.The createLink action creates a new sharing link if the specified link type doesn&apos;t already exist for the calling application.If a sharing link of the specified type already exists for the app, the existing sharing link is returned. DriveItem resources inherit sharing permissions from their ancestors.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateLinkPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateLinkPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
