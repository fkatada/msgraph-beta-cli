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
namespace ApiSdk.OnPremisesPublishingProfiles.Item.AgentGroups.Item.PublishedResources.Item.AgentGroups.Ref {
    /// <summary>
    /// Provides operations to manage the collection of onPremisesPublishingProfile entities.
    /// </summary>
    public class RefRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Delete ref of navigation property agentGroups for onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete ref of navigation property agentGroups for onPremisesPublishingProfiles";
            var onPremisesPublishingProfileIdOption = new Option<string>("--on-premises-publishing-profile-id", description: "The unique identifier of onPremisesPublishingProfile") {
            };
            onPremisesPublishingProfileIdOption.IsRequired = true;
            command.AddOption(onPremisesPublishingProfileIdOption);
            var onPremisesAgentGroupIdOption = new Option<string>("--on-premises-agent-group-id", description: "The unique identifier of onPremisesAgentGroup") {
            };
            onPremisesAgentGroupIdOption.IsRequired = true;
            command.AddOption(onPremisesAgentGroupIdOption);
            var publishedResourceIdOption = new Option<string>("--published-resource-id", description: "The unique identifier of publishedResource") {
            };
            publishedResourceIdOption.IsRequired = true;
            command.AddOption(publishedResourceIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            var idOption = new Option<string>("--id", description: "The delete Uri") {
            };
            idOption.IsRequired = true;
            command.AddOption(idOption);
            command.SetHandler(async (invocationContext) => {
                var onPremisesPublishingProfileId = invocationContext.ParseResult.GetValueForOption(onPremisesPublishingProfileIdOption);
                var onPremisesAgentGroupId = invocationContext.ParseResult.GetValueForOption(onPremisesAgentGroupIdOption);
                var publishedResourceId = invocationContext.ParseResult.GetValueForOption(publishedResourceIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                    if (!string.IsNullOrEmpty(id)) q.QueryParameters.Id = id;
                });
                if (onPremisesPublishingProfileId is not null) requestInfo.PathParameters.Add("onPremisesPublishingProfile%2Did", onPremisesPublishingProfileId);
                if (onPremisesAgentGroupId is not null) requestInfo.PathParameters.Add("onPremisesAgentGroup%2Did", onPremisesAgentGroupId);
                if (publishedResourceId is not null) requestInfo.PathParameters.Add("publishedResource%2Did", publishedResourceId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
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
        /// List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.";
            var onPremisesPublishingProfileIdOption = new Option<string>("--on-premises-publishing-profile-id", description: "The unique identifier of onPremisesPublishingProfile") {
            };
            onPremisesPublishingProfileIdOption.IsRequired = true;
            command.AddOption(onPremisesPublishingProfileIdOption);
            var onPremisesAgentGroupIdOption = new Option<string>("--on-premises-agent-group-id", description: "The unique identifier of onPremisesAgentGroup") {
            };
            onPremisesAgentGroupIdOption.IsRequired = true;
            command.AddOption(onPremisesAgentGroupIdOption);
            var publishedResourceIdOption = new Option<string>("--published-resource-id", description: "The unique identifier of publishedResource") {
            };
            publishedResourceIdOption.IsRequired = true;
            command.AddOption(publishedResourceIdOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items") {
            };
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var skipOption = new Option<int?>("--skip", description: "Skip the first n items") {
            };
            skipOption.IsRequired = false;
            command.AddOption(skipOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            var countOption = new Option<bool?>("--count", description: "Include count of items") {
            };
            countOption.IsRequired = false;
            command.AddOption(countOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values") {
                Arity = ArgumentArity.ZeroOrMore
            };
            orderbyOption.IsRequired = false;
            command.AddOption(orderbyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var onPremisesPublishingProfileId = invocationContext.ParseResult.GetValueForOption(onPremisesPublishingProfileIdOption);
                var onPremisesAgentGroupId = invocationContext.ParseResult.GetValueForOption(onPremisesAgentGroupIdOption);
                var publishedResourceId = invocationContext.ParseResult.GetValueForOption(publishedResourceIdOption);
                var top = invocationContext.ParseResult.GetValueForOption(topOption);
                var skip = invocationContext.ParseResult.GetValueForOption(skipOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                var count = invocationContext.ParseResult.GetValueForOption(countOption);
                var orderby = invocationContext.ParseResult.GetValueForOption(orderbyOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var all = invocationContext.ParseResult.GetValueForOption(allOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                IPagingService pagingService = invocationContext.BindingContext.GetService(typeof(IPagingService)) as IPagingService ?? throw new ArgumentNullException("pagingService");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Top = top;
                    q.QueryParameters.Skip = skip;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                    q.QueryParameters.Count = count;
                    q.QueryParameters.Orderby = orderby;
                });
                if (onPremisesPublishingProfileId is not null) requestInfo.PathParameters.Add("onPremisesPublishingProfile%2Did", onPremisesPublishingProfileId);
                if (onPremisesAgentGroupId is not null) requestInfo.PathParameters.Add("onPremisesAgentGroup%2Did", onPremisesAgentGroupId);
                if (publishedResourceId is not null) requestInfo.PathParameters.Add("publishedResource%2Did", publishedResourceId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, token) => reqAdapter.SendNoContentAsync(info, cancellationToken: token), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
                IOutputFormatter? formatter = null;
                if (pageResponse?.StatusCode >= 200 && pageResponse?.StatusCode < 300) {
                    formatter = outputFormatterFactory.GetFormatter(output);
                    response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                } else {
                    formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                }
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Create new navigation property ref to agentGroups for onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Create new navigation property ref to agentGroups for onPremisesPublishingProfiles";
            var onPremisesPublishingProfileIdOption = new Option<string>("--on-premises-publishing-profile-id", description: "The unique identifier of onPremisesPublishingProfile") {
            };
            onPremisesPublishingProfileIdOption.IsRequired = true;
            command.AddOption(onPremisesPublishingProfileIdOption);
            var onPremisesAgentGroupIdOption = new Option<string>("--on-premises-agent-group-id", description: "The unique identifier of onPremisesAgentGroup") {
            };
            onPremisesAgentGroupIdOption.IsRequired = true;
            command.AddOption(onPremisesAgentGroupIdOption);
            var publishedResourceIdOption = new Option<string>("--published-resource-id", description: "The unique identifier of publishedResource") {
            };
            publishedResourceIdOption.IsRequired = true;
            command.AddOption(publishedResourceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var onPremisesPublishingProfileId = invocationContext.ParseResult.GetValueForOption(onPremisesPublishingProfileIdOption);
                var onPremisesAgentGroupId = invocationContext.ParseResult.GetValueForOption(onPremisesAgentGroupIdOption);
                var publishedResourceId = invocationContext.ParseResult.GetValueForOption(publishedResourceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ReferenceCreate>(ReferenceCreate.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (onPremisesPublishingProfileId is not null) requestInfo.PathParameters.Add("onPremisesPublishingProfile%2Did", onPremisesPublishingProfileId);
                if (onPremisesAgentGroupId is not null) requestInfo.PathParameters.Add("onPremisesAgentGroup%2Did", onPremisesAgentGroupId);
                if (publishedResourceId is not null) requestInfo.PathParameters.Add("publishedResource%2Did", publishedResourceId);
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
        /// Instantiates a new <see cref="RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RefRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agentGroups/{onPremisesAgentGroup%2Did}/publishedResources/{publishedResource%2Did}/agentGroups/$ref{?%24count,%24filter,%24orderby,%24search,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefRequestBuilder(string rawUrl) : base("{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agentGroups/{onPremisesAgentGroup%2Did}/publishedResources/{publishedResource%2Did}/agentGroups/$ref{?%24count,%24filter,%24orderby,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Delete ref of navigation property agentGroups for onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<RefRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<RefRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agentGroups/{onPremisesAgentGroup%2Did}/publishedResources/{publishedResource%2Did}/agentGroups/$ref?@id={%40id}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RefRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RefRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property ref to agentGroups for onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ReferenceCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ReferenceCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/agentGroups/{onPremisesAgentGroup%2Did}/publishedResources/{publishedResource%2Did}/agentGroups/$ref", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Delete ref of navigation property agentGroups for onPremisesPublishingProfiles
        /// </summary>
        public class RefRequestBuilderDeleteQueryParameters 
        {
            /// <summary>The delete Uri</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%40id")]
            public string? Id { get; set; }
#nullable restore
#else
            [QueryParameter("%40id")]
            public string Id { get; set; }
#endif
        }
        /// <summary>
        /// List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
        /// </summary>
        public class RefRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
    }
}
