// <auto-generated/>
using ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.TaskReports.Item.TaskProcessingResults.Item.MicrosoftGraphIdentityGovernanceResume;
using ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.TaskReports.Item.TaskProcessingResults.Item.Subject;
using ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.TaskReports.Item.TaskProcessingResults.Item.TaskNamespace;
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
namespace ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.TaskReports.Item.TaskProcessingResults.Item {
    /// <summary>
    /// Provides operations to manage the taskProcessingResults property of the microsoft.graph.identityGovernance.taskReport entity.
    /// </summary>
    public class TaskProcessingResultItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// The related lifecycle workflow taskProcessingResults.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The related lifecycle workflow taskProcessingResults.";
            var workflowIdOption = new Option<string>("--workflow-id", description: "The unique identifier of workflow") {
            };
            workflowIdOption.IsRequired = true;
            command.AddOption(workflowIdOption);
            var taskReportIdOption = new Option<string>("--task-report-id", description: "The unique identifier of taskReport") {
            };
            taskReportIdOption.IsRequired = true;
            command.AddOption(taskReportIdOption);
            var taskProcessingResultIdOption = new Option<string>("--task-processing-result-id", description: "The unique identifier of taskProcessingResult") {
            };
            taskProcessingResultIdOption.IsRequired = true;
            command.AddOption(taskProcessingResultIdOption);
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
                var workflowId = invocationContext.ParseResult.GetValueForOption(workflowIdOption);
                var taskReportId = invocationContext.ParseResult.GetValueForOption(taskReportIdOption);
                var taskProcessingResultId = invocationContext.ParseResult.GetValueForOption(taskProcessingResultIdOption);
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
                if (workflowId is not null) requestInfo.PathParameters.Add("workflow%2Did", workflowId);
                if (taskReportId is not null) requestInfo.PathParameters.Add("taskReport%2Did", taskReportId);
                if (taskProcessingResultId is not null) requestInfo.PathParameters.Add("taskProcessingResult%2Did", taskProcessingResultId);
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
        /// Provides operations to call the resume method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMicrosoftGraphIdentityGovernanceResumeNavCommand()
        {
            var command = new Command("microsoft-graph-identity-governance-resume");
            command.Description = "Provides operations to call the resume method.";
            var builder = new MicrosoftGraphIdentityGovernanceResumeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the subject property of the microsoft.graph.identityGovernance.taskProcessingResult entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSubjectNavCommand()
        {
            var command = new Command("subject");
            command.Description = "Provides operations to manage the subject property of the microsoft.graph.identityGovernance.taskProcessingResult entity.";
            var builder = new SubjectRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildMailboxSettingsNavCommand());
            nonExecCommands.Add(builder.BuildServiceProvisioningErrorsNavCommand());
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
        /// Provides operations to manage the task property of the microsoft.graph.identityGovernance.taskProcessingResult entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTaskNavCommand()
        {
            var command = new Command("task");
            command.Description = "Provides operations to manage the task property of the microsoft.graph.identityGovernance.taskProcessingResult entity.";
            var builder = new TaskRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="TaskProcessingResultItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public TaskProcessingResultItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/taskReports/{taskReport%2Did}/taskProcessingResults/{taskProcessingResult%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="TaskProcessingResultItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TaskProcessingResultItemRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/taskReports/{taskReport%2Did}/taskProcessingResults/{taskProcessingResult%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The related lifecycle workflow taskProcessingResults.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TaskProcessingResultItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TaskProcessingResultItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The related lifecycle workflow taskProcessingResults.
        /// </summary>
        public class TaskProcessingResultItemRequestBuilderGetQueryParameters 
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
