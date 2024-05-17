// <auto-generated/>
using ApiSdk.Models.IdentityGovernance;
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
namespace ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceRestore {
    /// <summary>
    /// Provides operations to call the restore method.
    /// </summary>
    public class MicrosoftGraphIdentityGovernanceRestoreRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Restore a workflow that has been deleted. You can only restore a workflow that was deleted within the last 30 days before Microsoft Entra ID automatically permanently deletes it.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/identitygovernance-workflow-restore?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Restore a workflow that has been deleted. You can only restore a workflow that was deleted within the last 30 days before Microsoft Entra ID automatically permanently deletes it.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/identitygovernance-workflow-restore?view=graph-rest-beta";
            var workflowIdOption = new Option<string>("--workflow-id", description: "The unique identifier of workflow") {
            };
            workflowIdOption.IsRequired = true;
            command.AddOption(workflowIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var workflowId = invocationContext.ParseResult.GetValueForOption(workflowIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (workflowId is not null) requestInfo.PathParameters.Add("workflow%2Did", workflowId);
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
        /// Instantiates a new <see cref="MicrosoftGraphIdentityGovernanceRestoreRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphIdentityGovernanceRestoreRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/microsoft.graph.identityGovernance.restore", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphIdentityGovernanceRestoreRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphIdentityGovernanceRestoreRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/microsoft.graph.identityGovernance.restore", rawUrl)
        {
        }
        /// <summary>
        /// Restore a workflow that has been deleted. You can only restore a workflow that was deleted within the last 30 days before Microsoft Entra ID automatically permanently deletes it.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
