// <auto-generated/>
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.ExportJobs;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetActionStatusReports;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetCloudPcPerformanceReport;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetCloudPcRecommendationReports;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetConnectionQualityReports;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetDailyAggregatedRemoteConnectionReports;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetFrontlineReport;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetInaccessibleCloudPcReports;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetRawRemoteConnectionReports;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionLatencyWithCloudPcId;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetRemoteConnectionHistoricalReports;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetSharedUseLicenseUsageReport;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.GetTotalAggregatedRemoteConnectionReports;
using ApiSdk.DeviceManagement.VirtualEndpoint.Reports.RetrieveCrossRegionDisasterRecoveryReport;
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
namespace ApiSdk.DeviceManagement.VirtualEndpoint.Reports {
    /// <summary>
    /// Provides operations to manage the reports property of the microsoft.graph.virtualEndpoint entity.
    /// </summary>
    public class ReportsRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Delete navigation property reports for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property reports for deviceManagement";
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
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
        /// Provides operations to manage the exportJobs property of the microsoft.graph.cloudPcReports entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildExportJobsNavCommand()
        {
            var command = new Command("export-jobs");
            command.Description = "Provides operations to manage the exportJobs property of the microsoft.graph.cloudPcReports entity.";
            var builder = new ExportJobsRequestBuilder(PathParameters);
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
        /// Provides operations to call the getActionStatusReports method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetActionStatusReportsNavCommand()
        {
            var command = new Command("get-action-status-reports");
            command.Description = "Provides operations to call the getActionStatusReports method.";
            var builder = new GetActionStatusReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getCloudPcPerformanceReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCloudPcPerformanceReportNavCommand()
        {
            var command = new Command("get-cloud-pc-performance-report");
            command.Description = "Provides operations to call the getCloudPcPerformanceReport method.";
            var builder = new GetCloudPcPerformanceReportRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getCloudPcRecommendationReports method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCloudPcRecommendationReportsNavCommand()
        {
            var command = new Command("get-cloud-pc-recommendation-reports");
            command.Description = "Provides operations to call the getCloudPcRecommendationReports method.";
            var builder = new GetCloudPcRecommendationReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Cloud PC related reports.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Cloud PC related reports.";
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
        /// Provides operations to call the getConnectionQualityReports method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetConnectionQualityReportsNavCommand()
        {
            var command = new Command("get-connection-quality-reports");
            command.Description = "Provides operations to call the getConnectionQualityReports method.";
            var builder = new GetConnectionQualityReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getDailyAggregatedRemoteConnectionReports method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetDailyAggregatedRemoteConnectionReportsNavCommand()
        {
            var command = new Command("get-daily-aggregated-remote-connection-reports");
            command.Description = "Provides operations to call the getDailyAggregatedRemoteConnectionReports method.";
            var builder = new GetDailyAggregatedRemoteConnectionReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getFrontlineReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetFrontlineReportNavCommand()
        {
            var command = new Command("get-frontline-report");
            command.Description = "Provides operations to call the getFrontlineReport method.";
            var builder = new GetFrontlineReportRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getInaccessibleCloudPcReports method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetInaccessibleCloudPcReportsNavCommand()
        {
            var command = new Command("get-inaccessible-cloud-pc-reports");
            command.Description = "Provides operations to call the getInaccessibleCloudPcReports method.";
            var builder = new GetInaccessibleCloudPcReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getRawRemoteConnectionReports method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetRawRemoteConnectionReportsNavCommand()
        {
            var command = new Command("get-raw-remote-connection-reports");
            command.Description = "Provides operations to call the getRawRemoteConnectionReports method.";
            var builder = new GetRawRemoteConnectionReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getRealTimeRemoteConnectionLatency method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetRealTimeRemoteConnectionLatencyWithCloudPcIdRbCommand()
        {
            var command = new Command("get-real-time-remote-connection-latency-with-cloud-pc-id");
            command.Description = "Provides operations to call the getRealTimeRemoteConnectionLatency method.";
            var builder = new GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getRealTimeRemoteConnectionStatus method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetRealTimeRemoteConnectionStatusWithCloudPcIdRbCommand()
        {
            var command = new Command("get-real-time-remote-connection-status-with-cloud-pc-id");
            command.Description = "Provides operations to call the getRealTimeRemoteConnectionStatus method.";
            var builder = new GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getRemoteConnectionHistoricalReports method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetRemoteConnectionHistoricalReportsNavCommand()
        {
            var command = new Command("get-remote-connection-historical-reports");
            command.Description = "Provides operations to call the getRemoteConnectionHistoricalReports method.";
            var builder = new GetRemoteConnectionHistoricalReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharedUseLicenseUsageReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetSharedUseLicenseUsageReportNavCommand()
        {
            var command = new Command("get-shared-use-license-usage-report");
            command.Description = "Provides operations to call the getSharedUseLicenseUsageReport method.";
            var builder = new GetSharedUseLicenseUsageReportRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTotalAggregatedRemoteConnectionReports method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetTotalAggregatedRemoteConnectionReportsNavCommand()
        {
            var command = new Command("get-total-aggregated-remote-connection-reports");
            command.Description = "Provides operations to call the getTotalAggregatedRemoteConnectionReports method.";
            var builder = new GetTotalAggregatedRemoteConnectionReportsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property reports in deviceManagement";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<CloudPcReports>(CloudPcReports.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
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
        /// Provides operations to call the retrieveCrossRegionDisasterRecoveryReport method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRetrieveCrossRegionDisasterRecoveryReportNavCommand()
        {
            var command = new Command("retrieve-cross-region-disaster-recovery-report");
            command.Description = "Provides operations to call the retrieveCrossRegionDisasterRecoveryReport method.";
            var builder = new RetrieveCrossRegionDisasterRecoveryReportRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/virtualEndpoint/reports{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ReportsRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/virtualEndpoint/reports{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/deviceManagement/virtualEndpoint/reports", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Cloud PC related reports.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(CloudPcReports body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(CloudPcReports body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/deviceManagement/virtualEndpoint/reports", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Cloud PC related reports.
        /// </summary>
        public class ReportsRequestBuilderGetQueryParameters 
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
