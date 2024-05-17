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
namespace ApiSdk.DeviceManagement.MacOSSoftwareUpdateAccountSummaries.Item.CategorySummaries.Item.UpdateStateSummaries.Item {
    /// <summary>
    /// Provides operations to manage the updateStateSummaries property of the microsoft.graph.macOSSoftwareUpdateCategorySummary entity.
    /// </summary>
    public class MacOSSoftwareUpdateStateSummaryItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Delete navigation property updateStateSummaries for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property updateStateSummaries for deviceManagement";
            var macOSSoftwareUpdateAccountSummaryIdOption = new Option<string>("--mac-ossoftware-update-account-summary-id", description: "The unique identifier of macOSSoftwareUpdateAccountSummary") {
            };
            macOSSoftwareUpdateAccountSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateAccountSummaryIdOption);
            var macOSSoftwareUpdateCategorySummaryIdOption = new Option<string>("--mac-ossoftware-update-category-summary-id", description: "The unique identifier of macOSSoftwareUpdateCategorySummary") {
            };
            macOSSoftwareUpdateCategorySummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateCategorySummaryIdOption);
            var macOSSoftwareUpdateStateSummaryIdOption = new Option<string>("--mac-ossoftware-update-state-summary-id", description: "The unique identifier of macOSSoftwareUpdateStateSummary") {
            };
            macOSSoftwareUpdateStateSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateStateSummaryIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var macOSSoftwareUpdateAccountSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateAccountSummaryIdOption);
                var macOSSoftwareUpdateCategorySummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateCategorySummaryIdOption);
                var macOSSoftwareUpdateStateSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateStateSummaryIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (macOSSoftwareUpdateAccountSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateAccountSummary%2Did", macOSSoftwareUpdateAccountSummaryId);
                if (macOSSoftwareUpdateCategorySummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateCategorySummary%2Did", macOSSoftwareUpdateCategorySummaryId);
                if (macOSSoftwareUpdateStateSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateStateSummary%2Did", macOSSoftwareUpdateStateSummaryId);
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
        /// Summary of the update states.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Summary of the update states.";
            var macOSSoftwareUpdateAccountSummaryIdOption = new Option<string>("--mac-ossoftware-update-account-summary-id", description: "The unique identifier of macOSSoftwareUpdateAccountSummary") {
            };
            macOSSoftwareUpdateAccountSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateAccountSummaryIdOption);
            var macOSSoftwareUpdateCategorySummaryIdOption = new Option<string>("--mac-ossoftware-update-category-summary-id", description: "The unique identifier of macOSSoftwareUpdateCategorySummary") {
            };
            macOSSoftwareUpdateCategorySummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateCategorySummaryIdOption);
            var macOSSoftwareUpdateStateSummaryIdOption = new Option<string>("--mac-ossoftware-update-state-summary-id", description: "The unique identifier of macOSSoftwareUpdateStateSummary") {
            };
            macOSSoftwareUpdateStateSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateStateSummaryIdOption);
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
                var macOSSoftwareUpdateAccountSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateAccountSummaryIdOption);
                var macOSSoftwareUpdateCategorySummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateCategorySummaryIdOption);
                var macOSSoftwareUpdateStateSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateStateSummaryIdOption);
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
                if (macOSSoftwareUpdateAccountSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateAccountSummary%2Did", macOSSoftwareUpdateAccountSummaryId);
                if (macOSSoftwareUpdateCategorySummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateCategorySummary%2Did", macOSSoftwareUpdateCategorySummaryId);
                if (macOSSoftwareUpdateStateSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateStateSummary%2Did", macOSSoftwareUpdateStateSummaryId);
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
        /// Update the navigation property updateStateSummaries in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property updateStateSummaries in deviceManagement";
            var macOSSoftwareUpdateAccountSummaryIdOption = new Option<string>("--mac-ossoftware-update-account-summary-id", description: "The unique identifier of macOSSoftwareUpdateAccountSummary") {
            };
            macOSSoftwareUpdateAccountSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateAccountSummaryIdOption);
            var macOSSoftwareUpdateCategorySummaryIdOption = new Option<string>("--mac-ossoftware-update-category-summary-id", description: "The unique identifier of macOSSoftwareUpdateCategorySummary") {
            };
            macOSSoftwareUpdateCategorySummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateCategorySummaryIdOption);
            var macOSSoftwareUpdateStateSummaryIdOption = new Option<string>("--mac-ossoftware-update-state-summary-id", description: "The unique identifier of macOSSoftwareUpdateStateSummary") {
            };
            macOSSoftwareUpdateStateSummaryIdOption.IsRequired = true;
            command.AddOption(macOSSoftwareUpdateStateSummaryIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var macOSSoftwareUpdateAccountSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateAccountSummaryIdOption);
                var macOSSoftwareUpdateCategorySummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateCategorySummaryIdOption);
                var macOSSoftwareUpdateStateSummaryId = invocationContext.ParseResult.GetValueForOption(macOSSoftwareUpdateStateSummaryIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<MacOSSoftwareUpdateStateSummary>(MacOSSoftwareUpdateStateSummary.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (macOSSoftwareUpdateAccountSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateAccountSummary%2Did", macOSSoftwareUpdateAccountSummaryId);
                if (macOSSoftwareUpdateCategorySummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateCategorySummary%2Did", macOSSoftwareUpdateCategorySummaryId);
                if (macOSSoftwareUpdateStateSummaryId is not null) requestInfo.PathParameters.Add("macOSSoftwareUpdateStateSummary%2Did", macOSSoftwareUpdateStateSummaryId);
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
        /// Instantiates a new <see cref="MacOSSoftwareUpdateStateSummaryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MacOSSoftwareUpdateStateSummaryItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/macOSSoftwareUpdateAccountSummaries/{macOSSoftwareUpdateAccountSummary%2Did}/categorySummaries/{macOSSoftwareUpdateCategorySummary%2Did}/updateStateSummaries/{macOSSoftwareUpdateStateSummary%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MacOSSoftwareUpdateStateSummaryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MacOSSoftwareUpdateStateSummaryItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/macOSSoftwareUpdateAccountSummaries/{macOSSoftwareUpdateAccountSummary%2Did}/categorySummaries/{macOSSoftwareUpdateCategorySummary%2Did}/updateStateSummaries/{macOSSoftwareUpdateStateSummary%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property updateStateSummaries for deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Summary of the update states.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MacOSSoftwareUpdateStateSummaryItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MacOSSoftwareUpdateStateSummaryItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property updateStateSummaries in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(MacOSSoftwareUpdateStateSummary body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(MacOSSoftwareUpdateStateSummary body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Summary of the update states.
        /// </summary>
        public class MacOSSoftwareUpdateStateSummaryItemRequestBuilderGetQueryParameters 
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
