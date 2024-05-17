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
namespace ApiSdk.DeviceAppManagement.IosLobAppProvisioningConfigurations.Item.Assignments.Item {
    /// <summary>
    /// Provides operations to manage the assignments property of the microsoft.graph.iosLobAppProvisioningConfiguration entity.
    /// </summary>
    public class IosLobAppProvisioningConfigurationAssignmentItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Delete navigation property assignments for deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property assignments for deviceAppManagement";
            var iosLobAppProvisioningConfigurationIdOption = new Option<string>("--ios-lob-app-provisioning-configuration-id", description: "The unique identifier of iosLobAppProvisioningConfiguration") {
            };
            iosLobAppProvisioningConfigurationIdOption.IsRequired = true;
            command.AddOption(iosLobAppProvisioningConfigurationIdOption);
            var iosLobAppProvisioningConfigurationAssignmentIdOption = new Option<string>("--ios-lob-app-provisioning-configuration-assignment-id", description: "The unique identifier of iosLobAppProvisioningConfigurationAssignment") {
            };
            iosLobAppProvisioningConfigurationAssignmentIdOption.IsRequired = true;
            command.AddOption(iosLobAppProvisioningConfigurationAssignmentIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var iosLobAppProvisioningConfigurationId = invocationContext.ParseResult.GetValueForOption(iosLobAppProvisioningConfigurationIdOption);
                var iosLobAppProvisioningConfigurationAssignmentId = invocationContext.ParseResult.GetValueForOption(iosLobAppProvisioningConfigurationAssignmentIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (iosLobAppProvisioningConfigurationId is not null) requestInfo.PathParameters.Add("iosLobAppProvisioningConfiguration%2Did", iosLobAppProvisioningConfigurationId);
                if (iosLobAppProvisioningConfigurationAssignmentId is not null) requestInfo.PathParameters.Add("iosLobAppProvisioningConfigurationAssignment%2Did", iosLobAppProvisioningConfigurationAssignmentId);
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
        /// The associated group assignments for IosLobAppProvisioningConfiguration.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The associated group assignments for IosLobAppProvisioningConfiguration.";
            var iosLobAppProvisioningConfigurationIdOption = new Option<string>("--ios-lob-app-provisioning-configuration-id", description: "The unique identifier of iosLobAppProvisioningConfiguration") {
            };
            iosLobAppProvisioningConfigurationIdOption.IsRequired = true;
            command.AddOption(iosLobAppProvisioningConfigurationIdOption);
            var iosLobAppProvisioningConfigurationAssignmentIdOption = new Option<string>("--ios-lob-app-provisioning-configuration-assignment-id", description: "The unique identifier of iosLobAppProvisioningConfigurationAssignment") {
            };
            iosLobAppProvisioningConfigurationAssignmentIdOption.IsRequired = true;
            command.AddOption(iosLobAppProvisioningConfigurationAssignmentIdOption);
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
                var iosLobAppProvisioningConfigurationId = invocationContext.ParseResult.GetValueForOption(iosLobAppProvisioningConfigurationIdOption);
                var iosLobAppProvisioningConfigurationAssignmentId = invocationContext.ParseResult.GetValueForOption(iosLobAppProvisioningConfigurationAssignmentIdOption);
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
                if (iosLobAppProvisioningConfigurationId is not null) requestInfo.PathParameters.Add("iosLobAppProvisioningConfiguration%2Did", iosLobAppProvisioningConfigurationId);
                if (iosLobAppProvisioningConfigurationAssignmentId is not null) requestInfo.PathParameters.Add("iosLobAppProvisioningConfigurationAssignment%2Did", iosLobAppProvisioningConfigurationAssignmentId);
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
        /// Update the navigation property assignments in deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property assignments in deviceAppManagement";
            var iosLobAppProvisioningConfigurationIdOption = new Option<string>("--ios-lob-app-provisioning-configuration-id", description: "The unique identifier of iosLobAppProvisioningConfiguration") {
            };
            iosLobAppProvisioningConfigurationIdOption.IsRequired = true;
            command.AddOption(iosLobAppProvisioningConfigurationIdOption);
            var iosLobAppProvisioningConfigurationAssignmentIdOption = new Option<string>("--ios-lob-app-provisioning-configuration-assignment-id", description: "The unique identifier of iosLobAppProvisioningConfigurationAssignment") {
            };
            iosLobAppProvisioningConfigurationAssignmentIdOption.IsRequired = true;
            command.AddOption(iosLobAppProvisioningConfigurationAssignmentIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var iosLobAppProvisioningConfigurationId = invocationContext.ParseResult.GetValueForOption(iosLobAppProvisioningConfigurationIdOption);
                var iosLobAppProvisioningConfigurationAssignmentId = invocationContext.ParseResult.GetValueForOption(iosLobAppProvisioningConfigurationAssignmentIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<IosLobAppProvisioningConfigurationAssignment>(IosLobAppProvisioningConfigurationAssignment.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (iosLobAppProvisioningConfigurationId is not null) requestInfo.PathParameters.Add("iosLobAppProvisioningConfiguration%2Did", iosLobAppProvisioningConfigurationId);
                if (iosLobAppProvisioningConfigurationAssignmentId is not null) requestInfo.PathParameters.Add("iosLobAppProvisioningConfigurationAssignment%2Did", iosLobAppProvisioningConfigurationAssignmentId);
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
        /// Instantiates a new <see cref="IosLobAppProvisioningConfigurationAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public IosLobAppProvisioningConfigurationAssignmentItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceAppManagement/iosLobAppProvisioningConfigurations/{iosLobAppProvisioningConfiguration%2Did}/assignments/{iosLobAppProvisioningConfigurationAssignment%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="IosLobAppProvisioningConfigurationAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public IosLobAppProvisioningConfigurationAssignmentItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceAppManagement/iosLobAppProvisioningConfigurations/{iosLobAppProvisioningConfiguration%2Did}/assignments/{iosLobAppProvisioningConfigurationAssignment%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property assignments for deviceAppManagement
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
        /// The associated group assignments for IosLobAppProvisioningConfiguration.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IosLobAppProvisioningConfigurationAssignmentItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IosLobAppProvisioningConfigurationAssignmentItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property assignments in deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(IosLobAppProvisioningConfigurationAssignment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(IosLobAppProvisioningConfigurationAssignment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The associated group assignments for IosLobAppProvisioningConfiguration.
        /// </summary>
        public class IosLobAppProvisioningConfigurationAssignmentItemRequestBuilderGetQueryParameters 
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
