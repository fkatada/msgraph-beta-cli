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
namespace ApiSdk.Teams.Item.PrimaryChannel.Messages.Delta
{
    /// <summary>
    /// Provides operations to call the delta method.
    /// </summary>
    public class DeltaRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Retrieve the list of messages (without the replies) in a channel of a team. By using delta query, you can get new or updated messages in a channel. Delta query supports both full synchronization that retrieves all the messages in the specified channel, and incremental synchronization that retrieves those messages that have been added or changed in the channel since the last synchronization. Typically, you would do an initial full synchronization, and then get incremental changes to that messages view periodically. To get the replies for a message, use the list message replies or the get message reply operation. A GET request with the delta function returns either: State tokens are opaque to the client. To proceed with a round of change tracking, copy and apply the @odata.nextLink or @odata.deltaLink URL returned from the last GET request to the next delta function call for that same calendar view. A @odata.deltaLink returned in a response signifies that the current round of change tracking is complete. You can save and use the @odata.deltaLink URL when you begin the to retrieve additional changes (messages changed or posted after acquiring @odata.deltaLink). For more information, see the delta query documentation.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/chatmessage-delta?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Retrieve the list of messages (without the replies) in a channel of a team. By using delta query, you can get new or updated messages in a channel. Delta query supports both full synchronization that retrieves all the messages in the specified channel, and incremental synchronization that retrieves those messages that have been added or changed in the channel since the last synchronization. Typically, you would do an initial full synchronization, and then get incremental changes to that messages view periodically. To get the replies for a message, use the list message replies or the get message reply operation. A GET request with the delta function returns either: State tokens are opaque to the client. To proceed with a round of change tracking, copy and apply the @odata.nextLink or @odata.deltaLink URL returned from the last GET request to the next delta function call for that same calendar view. A @odata.deltaLink returned in a response signifies that the current round of change tracking is complete. You can save and use the @odata.deltaLink URL when you begin the to retrieve additional changes (messages changed or posted after acquiring @odata.deltaLink). For more information, see the delta query documentation.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/chatmessage-delta?view=graph-rest-beta";
            var teamIdOption = new Option<string>("--team-id", description: "The unique identifier of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
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
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values") {
                Arity = ArgumentArity.ZeroOrMore
            };
            orderbyOption.IsRequired = false;
            command.AddOption(orderbyOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var top = invocationContext.ParseResult.GetValueForOption(topOption);
                var skip = invocationContext.ParseResult.GetValueForOption(skipOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                var count = invocationContext.ParseResult.GetValueForOption(countOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var orderby = invocationContext.ParseResult.GetValueForOption(orderbyOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
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
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Orderby = orderby;
                    q.QueryParameters.Expand = expand;
                });
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, token) => reqAdapter.SendNoContentAsync(info, cancellationToken: token), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
#nullable enable
                IOutputFormatter? formatter = null;
#nullable restore
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
        /// Instantiates a new <see cref="DeltaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DeltaRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teams/{team%2Did}/primaryChannel/messages/delta(){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DeltaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeltaRequestBuilder(string rawUrl) : base("{+baseurl}/teams/{team%2Did}/primaryChannel/messages/delta(){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve the list of messages (without the replies) in a channel of a team. By using delta query, you can get new or updated messages in a channel. Delta query supports both full synchronization that retrieves all the messages in the specified channel, and incremental synchronization that retrieves those messages that have been added or changed in the channel since the last synchronization. Typically, you would do an initial full synchronization, and then get incremental changes to that messages view periodically. To get the replies for a message, use the list message replies or the get message reply operation. A GET request with the delta function returns either: State tokens are opaque to the client. To proceed with a round of change tracking, copy and apply the @odata.nextLink or @odata.deltaLink URL returned from the last GET request to the next delta function call for that same calendar view. A @odata.deltaLink returned in a response signifies that the current round of change tracking is complete. You can save and use the @odata.deltaLink URL when you begin the to retrieve additional changes (messages changed or posted after acquiring @odata.deltaLink). For more information, see the delta query documentation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeltaRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeltaRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the list of messages (without the replies) in a channel of a team. By using delta query, you can get new or updated messages in a channel. Delta query supports both full synchronization that retrieves all the messages in the specified channel, and incremental synchronization that retrieves those messages that have been added or changed in the channel since the last synchronization. Typically, you would do an initial full synchronization, and then get incremental changes to that messages view periodically. To get the replies for a message, use the list message replies or the get message reply operation. A GET request with the delta function returns either: State tokens are opaque to the client. To proceed with a round of change tracking, copy and apply the @odata.nextLink or @odata.deltaLink URL returned from the last GET request to the next delta function call for that same calendar view. A @odata.deltaLink returned in a response signifies that the current round of change tracking is complete. You can save and use the @odata.deltaLink URL when you begin the to retrieve additional changes (messages changed or posted after acquiring @odata.deltaLink). For more information, see the delta query documentation.
        /// </summary>
        public class DeltaRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
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
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
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
