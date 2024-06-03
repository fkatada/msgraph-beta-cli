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
namespace ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.AssociateWithHubSites
{
    /// <summary>
    /// Provides operations to call the associateWithHubSites method.
    /// </summary>
    public class AssociateWithHubSitesRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action associateWithHubSites
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/contenttype-associatewithhubsites?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action associateWithHubSites\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/contenttype-associatewithhubsites?view=graph-rest-beta";
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var listIdOption = new Option<string>("--list-id", description: "The unique identifier of list") {
            };
            listIdOption.IsRequired = true;
            command.AddOption(listIdOption);
            var contentTypeIdOption = new Option<string>("--content-type-id", description: "The unique identifier of contentType") {
            };
            contentTypeIdOption.IsRequired = true;
            command.AddOption(contentTypeIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var listId = invocationContext.ParseResult.GetValueForOption(listIdOption);
                var contentTypeId = invocationContext.ParseResult.GetValueForOption(contentTypeIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AssociateWithHubSitesPostRequestBody>(AssociateWithHubSitesPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (listId is not null) requestInfo.PathParameters.Add("list%2Did", listId);
                if (contentTypeId is not null) requestInfo.PathParameters.Add("contentType%2Did", contentTypeId);
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
        /// Instantiates a new <see cref="AssociateWithHubSitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AssociateWithHubSitesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/sites/{site%2Did}/lists/{list%2Did}/contentTypes/{contentType%2Did}/associateWithHubSites", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AssociateWithHubSitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AssociateWithHubSitesRequestBuilder(string rawUrl) : base("{+baseurl}/sites/{site%2Did}/lists/{list%2Did}/contentTypes/{contentType%2Did}/associateWithHubSites", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action associateWithHubSites
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AssociateWithHubSitesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AssociateWithHubSitesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
