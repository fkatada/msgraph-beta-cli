// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Users.Item.CloudPCs.Item.ChangeUserAccountType;
using ApiSdk.Users.Item.CloudPCs.Item.CreateSnapshot;
using ApiSdk.Users.Item.CloudPCs.Item.EndGracePeriod;
using ApiSdk.Users.Item.CloudPCs.Item.GetCloudPcConnectivityHistory;
using ApiSdk.Users.Item.CloudPCs.Item.GetCloudPcLaunchInfo;
using ApiSdk.Users.Item.CloudPCs.Item.GetFrontlineCloudPcAccessState;
using ApiSdk.Users.Item.CloudPCs.Item.GetShiftWorkCloudPcAccessState;
using ApiSdk.Users.Item.CloudPCs.Item.GetSupportedCloudPcRemoteActions;
using ApiSdk.Users.Item.CloudPCs.Item.PowerOff;
using ApiSdk.Users.Item.CloudPCs.Item.PowerOn;
using ApiSdk.Users.Item.CloudPCs.Item.Reboot;
using ApiSdk.Users.Item.CloudPCs.Item.Rename;
using ApiSdk.Users.Item.CloudPCs.Item.Reprovision;
using ApiSdk.Users.Item.CloudPCs.Item.Resize;
using ApiSdk.Users.Item.CloudPCs.Item.Restore;
using ApiSdk.Users.Item.CloudPCs.Item.RetryPartnerAgentInstallation;
using ApiSdk.Users.Item.CloudPCs.Item.Start;
using ApiSdk.Users.Item.CloudPCs.Item.Stop;
using ApiSdk.Users.Item.CloudPCs.Item.Troubleshoot;
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
namespace ApiSdk.Users.Item.CloudPCs.Item {
    /// <summary>
    /// Provides operations to manage the cloudPCs property of the microsoft.graph.user entity.
    /// </summary>
    public class CloudPCItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to call the changeUserAccountType method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildChangeUserAccountTypeNavCommand()
        {
            var command = new Command("change-user-account-type");
            command.Description = "Provides operations to call the changeUserAccountType method.";
            var builder = new ChangeUserAccountTypeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the createSnapshot method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateSnapshotNavCommand()
        {
            var command = new Command("create-snapshot");
            command.Description = "Provides operations to call the createSnapshot method.";
            var builder = new CreateSnapshotRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property cloudPCs for users
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property cloudPCs for users";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var cloudPCIdOption = new Option<string>("--cloud-pcid", description: "The unique identifier of cloudPC") {
            };
            cloudPCIdOption.IsRequired = true;
            command.AddOption(cloudPCIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var cloudPCId = invocationContext.ParseResult.GetValueForOption(cloudPCIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (cloudPCId is not null) requestInfo.PathParameters.Add("cloudPC%2Did", cloudPCId);
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
        /// Provides operations to call the endGracePeriod method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildEndGracePeriodNavCommand()
        {
            var command = new Command("end-grace-period");
            command.Description = "Provides operations to call the endGracePeriod method.";
            var builder = new EndGracePeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getCloudPcConnectivityHistory method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCloudPcConnectivityHistoryNavCommand()
        {
            var command = new Command("get-cloud-pc-connectivity-history");
            command.Description = "Provides operations to call the getCloudPcConnectivityHistory method.";
            var builder = new GetCloudPcConnectivityHistoryRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getCloudPcLaunchInfo method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCloudPcLaunchInfoNavCommand()
        {
            var command = new Command("get-cloud-pc-launch-info");
            command.Description = "Provides operations to call the getCloudPcLaunchInfo method.";
            var builder = new GetCloudPcLaunchInfoRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Read the properties and relationships of a specific cloudPC object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Read the properties and relationships of a specific cloudPC object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/cloudpc-get?view=graph-rest-1.0";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var cloudPCIdOption = new Option<string>("--cloud-pcid", description: "The unique identifier of cloudPC") {
            };
            cloudPCIdOption.IsRequired = true;
            command.AddOption(cloudPCIdOption);
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
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var cloudPCId = invocationContext.ParseResult.GetValueForOption(cloudPCIdOption);
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
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (cloudPCId is not null) requestInfo.PathParameters.Add("cloudPC%2Did", cloudPCId);
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
        /// Provides operations to call the getFrontlineCloudPcAccessState method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetFrontlineCloudPcAccessStateNavCommand()
        {
            var command = new Command("get-frontline-cloud-pc-access-state");
            command.Description = "Provides operations to call the getFrontlineCloudPcAccessState method.";
            var builder = new GetFrontlineCloudPcAccessStateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getShiftWorkCloudPcAccessState method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetShiftWorkCloudPcAccessStateNavCommand()
        {
            var command = new Command("get-shift-work-cloud-pc-access-state");
            command.Description = "Provides operations to call the getShiftWorkCloudPcAccessState method.";
            var builder = new GetShiftWorkCloudPcAccessStateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSupportedCloudPcRemoteActions method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetSupportedCloudPcRemoteActionsNavCommand()
        {
            var command = new Command("get-supported-cloud-pc-remote-actions");
            command.Description = "Provides operations to call the getSupportedCloudPcRemoteActions method.";
            var builder = new GetSupportedCloudPcRemoteActionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the navigation property cloudPCs in users
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property cloudPCs in users";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var cloudPCIdOption = new Option<string>("--cloud-pcid", description: "The unique identifier of cloudPC") {
            };
            cloudPCIdOption.IsRequired = true;
            command.AddOption(cloudPCIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var cloudPCId = invocationContext.ParseResult.GetValueForOption(cloudPCIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.CloudPC>(ApiSdk.Models.CloudPC.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (cloudPCId is not null) requestInfo.PathParameters.Add("cloudPC%2Did", cloudPCId);
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
        /// Provides operations to call the powerOff method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPowerOffNavCommand()
        {
            var command = new Command("power-off");
            command.Description = "Provides operations to call the powerOff method.";
            var builder = new PowerOffRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the powerOn method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPowerOnNavCommand()
        {
            var command = new Command("power-on");
            command.Description = "Provides operations to call the powerOn method.";
            var builder = new PowerOnRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the reboot method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRebootNavCommand()
        {
            var command = new Command("reboot");
            command.Description = "Provides operations to call the reboot method.";
            var builder = new RebootRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the rename method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRenameNavCommand()
        {
            var command = new Command("rename");
            command.Description = "Provides operations to call the rename method.";
            var builder = new RenameRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the reprovision method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildReprovisionNavCommand()
        {
            var command = new Command("reprovision");
            command.Description = "Provides operations to call the reprovision method.";
            var builder = new ReprovisionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the resize method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResizeNavCommand()
        {
            var command = new Command("resize");
            command.Description = "Provides operations to call the resize method.";
            var builder = new ResizeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the restore method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRestoreNavCommand()
        {
            var command = new Command("restore");
            command.Description = "Provides operations to call the restore method.";
            var builder = new RestoreRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the retryPartnerAgentInstallation method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRetryPartnerAgentInstallationNavCommand()
        {
            var command = new Command("retry-partner-agent-installation");
            command.Description = "Provides operations to call the retryPartnerAgentInstallation method.";
            var builder = new RetryPartnerAgentInstallationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the start method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildStartNavCommand()
        {
            var command = new Command("start");
            command.Description = "Provides operations to call the start method.";
            var builder = new StartRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the stop method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildStopNavCommand()
        {
            var command = new Command("stop");
            command.Description = "Provides operations to call the stop method.";
            var builder = new StopRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the troubleshoot method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTroubleshootNavCommand()
        {
            var command = new Command("troubleshoot");
            command.Description = "Provides operations to call the troubleshoot method.";
            var builder = new TroubleshootRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="CloudPCItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CloudPCItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/cloudPCs/{cloudPC%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CloudPCItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CloudPCItemRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/cloudPCs/{cloudPC%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property cloudPCs for users
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/users/{user%2Did}/cloudPCs/{cloudPC%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a specific cloudPC object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CloudPCItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CloudPCItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property cloudPCs in users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/users/{user%2Did}/cloudPCs/{cloudPC%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a specific cloudPC object.
        /// </summary>
        public class CloudPCItemRequestBuilderGetQueryParameters 
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
