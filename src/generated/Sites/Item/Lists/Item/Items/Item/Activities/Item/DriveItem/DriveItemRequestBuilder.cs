// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Sites.Item.Lists.Item.Items.Item.Activities.Item.DriveItem.Content;
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
namespace ApiSdk.Sites.Item.Lists.Item.Items.Item.Activities.Item.DriveItem {
    /// <summary>
    /// Provides operations to manage the driveItem property of the microsoft.graph.itemActivityOLD entity.
    /// </summary>
    public class DriveItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to manage the media for the site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildContentNavCommand()
        {
            var command = new Command("content");
            command.Description = "Provides operations to manage the media for the site entity.";
            var builder = new ContentRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Get driveItem from sites
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get driveItem from sites";
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var listIdOption = new Option<string>("--list-id", description: "The unique identifier of list") {
            };
            listIdOption.IsRequired = true;
            command.AddOption(listIdOption);
            var listItemIdOption = new Option<string>("--list-item-id", description: "The unique identifier of listItem") {
            };
            listItemIdOption.IsRequired = true;
            command.AddOption(listItemIdOption);
            var itemActivityOLDIdOption = new Option<string>("--item-activity-oldid", description: "The unique identifier of itemActivityOLD") {
            };
            itemActivityOLDIdOption.IsRequired = true;
            command.AddOption(itemActivityOLDIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var listId = invocationContext.ParseResult.GetValueForOption(listIdOption);
                var listItemId = invocationContext.ParseResult.GetValueForOption(listItemIdOption);
                var itemActivityOLDId = invocationContext.ParseResult.GetValueForOption(itemActivityOLDIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (listId is not null) requestInfo.PathParameters.Add("list%2Did", listId);
                if (listItemId is not null) requestInfo.PathParameters.Add("listItem%2Did", listItemId);
                if (itemActivityOLDId is not null) requestInfo.PathParameters.Add("itemActivityOLD%2Did", itemActivityOLDId);
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
        /// Instantiates a new <see cref="DriveItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DriveItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/sites/{site%2Did}/lists/{list%2Did}/items/{listItem%2Did}/activities/{itemActivityOLD%2Did}/driveItem{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DriveItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DriveItemRequestBuilder(string rawUrl) : base("{+baseurl}/sites/{site%2Did}/lists/{list%2Did}/items/{listItem%2Did}/activities/{itemActivityOLD%2Did}/driveItem{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get driveItem from sites
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DriveItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DriveItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get driveItem from sites
        /// </summary>
        public class DriveItemRequestBuilderGetQueryParameters 
        {
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
        }
    }
}
