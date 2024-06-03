// <auto-generated/>
using ApiSdk.Models.Networkaccess;
using ApiSdk.Models.ODataErrors;
using ApiSdk.NetworkAccess.Connectivity.Branches.Item.ConnectivityConfiguration.Links;
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
namespace ApiSdk.NetworkAccess.Connectivity.Branches.Item.ConnectivityConfiguration
{
    /// <summary>
    /// Provides operations to manage the connectivityConfiguration property of the microsoft.graph.networkaccess.branchSite entity.
    /// </summary>
    public class ConnectivityConfigurationRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property connectivityConfiguration for networkAccess
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property connectivityConfiguration for networkAccess";
            var branchSiteIdOption = new Option<string>("--branch-site-id", description: "The unique identifier of branchSite") {
            };
            branchSiteIdOption.IsRequired = true;
            command.AddOption(branchSiteIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var branchSiteId = invocationContext.ParseResult.GetValueForOption(branchSiteIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (branchSiteId is not null) requestInfo.PathParameters.Add("branchSite%2Did", branchSiteId);
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
        /// Retrieve the IPSec tunnel configuration required to establish a bidirectional communication link between your organization&apos;s router and the Microsoft gateway. This information is vital for configuring your router (customer premise equipment) after creating a deviceLink.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/networkaccess-branchconnectivityconfiguration-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Retrieve the IPSec tunnel configuration required to establish a bidirectional communication link between your organization's router and the Microsoft gateway. This information is vital for configuring your router (customer premise equipment) after creating a deviceLink.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/networkaccess-branchconnectivityconfiguration-get?view=graph-rest-beta";
            var branchSiteIdOption = new Option<string>("--branch-site-id", description: "The unique identifier of branchSite") {
            };
            branchSiteIdOption.IsRequired = true;
            command.AddOption(branchSiteIdOption);
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
                var branchSiteId = invocationContext.ParseResult.GetValueForOption(branchSiteIdOption);
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
                if (branchSiteId is not null) requestInfo.PathParameters.Add("branchSite%2Did", branchSiteId);
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
        /// Provides operations to manage the links property of the microsoft.graph.networkaccess.branchConnectivityConfiguration entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLinksNavCommand()
        {
            var command = new Command("links");
            command.Description = "Provides operations to manage the links property of the microsoft.graph.networkaccess.branchConnectivityConfiguration entity.";
            var builder = new LinksRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the navigation property connectivityConfiguration in networkAccess
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property connectivityConfiguration in networkAccess";
            var branchSiteIdOption = new Option<string>("--branch-site-id", description: "The unique identifier of branchSite") {
            };
            branchSiteIdOption.IsRequired = true;
            command.AddOption(branchSiteIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var branchSiteId = invocationContext.ParseResult.GetValueForOption(branchSiteIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<BranchConnectivityConfiguration>(BranchConnectivityConfiguration.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (branchSiteId is not null) requestInfo.PathParameters.Add("branchSite%2Did", branchSiteId);
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
        /// Instantiates a new <see cref="ConnectivityConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ConnectivityConfigurationRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/networkAccess/connectivity/branches/{branchSite%2Did}/connectivityConfiguration{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConnectivityConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ConnectivityConfigurationRequestBuilder(string rawUrl) : base("{+baseurl}/networkAccess/connectivity/branches/{branchSite%2Did}/connectivityConfiguration{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property connectivityConfiguration for networkAccess
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
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
        /// Retrieve the IPSec tunnel configuration required to establish a bidirectional communication link between your organization&apos;s router and the Microsoft gateway. This information is vital for configuring your router (customer premise equipment) after creating a deviceLink.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ConnectivityConfigurationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ConnectivityConfigurationRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property connectivityConfiguration in networkAccess
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(BranchConnectivityConfiguration body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(BranchConnectivityConfiguration body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the IPSec tunnel configuration required to establish a bidirectional communication link between your organization&apos;s router and the Microsoft gateway. This information is vital for configuring your router (customer premise equipment) after creating a deviceLink.
        /// </summary>
        public class ConnectivityConfigurationRequestBuilderGetQueryParameters 
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
