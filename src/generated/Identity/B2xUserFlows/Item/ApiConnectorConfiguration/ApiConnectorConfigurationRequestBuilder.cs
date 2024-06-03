// <auto-generated/>
using ApiSdk.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PostAttributeCollection;
using ApiSdk.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PostFederationSignup;
using ApiSdk.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PreTokenIssuance;
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
namespace ApiSdk.Identity.B2xUserFlows.Item.ApiConnectorConfiguration
{
    /// <summary>
    /// Builds and executes requests for operations under \identity\b2xUserFlows\{b2xIdentityUserFlow-id}\apiConnectorConfiguration
    /// </summary>
    public class ApiConnectorConfigurationRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Get the apiConnectorConfiguration property in a b2xIdentityUserFlow to detail the API connectors enabled for the user flow.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/b2xidentityuserflow-get-apiconnectorconfiguration?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the apiConnectorConfiguration property in a b2xIdentityUserFlow to detail the API connectors enabled for the user flow.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/b2xidentityuserflow-get-apiconnectorconfiguration?view=graph-rest-beta";
            var b2xIdentityUserFlowIdOption = new Option<string>("--b2x-identity-user-flow-id", description: "The unique identifier of b2xIdentityUserFlow") {
            };
            b2xIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2xIdentityUserFlowIdOption);
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
                var b2xIdentityUserFlowId = invocationContext.ParseResult.GetValueForOption(b2xIdentityUserFlowIdOption);
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
                if (b2xIdentityUserFlowId is not null) requestInfo.PathParameters.Add("b2xIdentityUserFlow%2Did", b2xIdentityUserFlowId);
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
        /// Provides operations to manage the postAttributeCollection property of the microsoft.graph.userFlowApiConnectorConfiguration entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostAttributeCollectionNavCommand()
        {
            var command = new Command("post-attribute-collection");
            command.Description = "Provides operations to manage the postAttributeCollection property of the microsoft.graph.userFlowApiConnectorConfiguration entity.";
            var builder = new PostAttributeCollectionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildRefNavCommand());
            nonExecCommands.Add(builder.BuildUploadClientCertificateNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the postFederationSignup property of the microsoft.graph.userFlowApiConnectorConfiguration entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostFederationSignupNavCommand()
        {
            var command = new Command("post-federation-signup");
            command.Description = "Provides operations to manage the postFederationSignup property of the microsoft.graph.userFlowApiConnectorConfiguration entity.";
            var builder = new PostFederationSignupRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildRefNavCommand());
            nonExecCommands.Add(builder.BuildUploadClientCertificateNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the preTokenIssuance property of the microsoft.graph.userFlowApiConnectorConfiguration entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPreTokenIssuanceNavCommand()
        {
            var command = new Command("pre-token-issuance");
            command.Description = "Provides operations to manage the preTokenIssuance property of the microsoft.graph.userFlowApiConnectorConfiguration entity.";
            var builder = new PreTokenIssuanceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildUploadClientCertificateNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="ApiConnectorConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ApiConnectorConfigurationRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}/apiConnectorConfiguration{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ApiConnectorConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ApiConnectorConfigurationRequestBuilder(string rawUrl) : base("{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}/apiConnectorConfiguration{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get the apiConnectorConfiguration property in a b2xIdentityUserFlow to detail the API connectors enabled for the user flow.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ApiConnectorConfigurationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ApiConnectorConfigurationRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get the apiConnectorConfiguration property in a b2xIdentityUserFlow to detail the API connectors enabled for the user flow.
        /// </summary>
        public class ApiConnectorConfigurationRequestBuilderGetQueryParameters 
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
