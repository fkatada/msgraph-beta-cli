// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Users.Item.Outlook.MasterCategories;
using ApiSdk.Users.Item.Outlook.SupportedLanguages;
using ApiSdk.Users.Item.Outlook.SupportedTimeZones;
using ApiSdk.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard;
using ApiSdk.Users.Item.Outlook.TaskFolders;
using ApiSdk.Users.Item.Outlook.TaskGroups;
using ApiSdk.Users.Item.Outlook.Tasks;
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
namespace ApiSdk.Users.Item.Outlook {
    /// <summary>
    /// Provides operations to manage the outlook property of the microsoft.graph.user entity.
    /// </summary>
    public class OutlookRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Selective Outlook services available to the user. Read-only. Nullable.";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
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
        /// Provides operations to manage the masterCategories property of the microsoft.graph.outlookUser entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMasterCategoriesNavCommand()
        {
            var command = new Command("master-categories");
            command.Description = "Provides operations to manage the masterCategories property of the microsoft.graph.outlookUser entity.";
            var builder = new MasterCategoriesRequestBuilder(PathParameters);
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
        /// Provides operations to call the supportedLanguages method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSupportedLanguagesNavCommand()
        {
            var command = new Command("supported-languages");
            command.Description = "Provides operations to call the supportedLanguages method.";
            var builder = new SupportedLanguagesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the supportedTimeZones method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSupportedTimeZonesNavCommand()
        {
            var command = new Command("supported-time-zones");
            command.Description = "Provides operations to call the supportedTimeZones method.";
            var builder = new SupportedTimeZonesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the supportedTimeZones method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSupportedTimeZonesWithTimeZoneStandardRbCommand()
        {
            var command = new Command("supported-time-zones-with-time-zone-standard");
            command.Description = "Provides operations to call the supportedTimeZones method.";
            var builder = new SupportedTimeZonesWithTimeZoneStandardRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the taskFolders property of the microsoft.graph.outlookUser entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTaskFoldersNavCommand()
        {
            var command = new Command("task-folders");
            command.Description = "Provides operations to manage the taskFolders property of the microsoft.graph.outlookUser entity.";
            var builder = new TaskFoldersRequestBuilder(PathParameters);
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
        /// Provides operations to manage the taskGroups property of the microsoft.graph.outlookUser entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTaskGroupsNavCommand()
        {
            var command = new Command("task-groups");
            command.Description = "Provides operations to manage the taskGroups property of the microsoft.graph.outlookUser entity.";
            var builder = new TaskGroupsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the tasks property of the microsoft.graph.outlookUser entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTasksNavCommand()
        {
            var command = new Command("tasks");
            command.Description = "Provides operations to manage the tasks property of the microsoft.graph.outlookUser entity.";
            var builder = new TasksRequestBuilder(PathParameters);
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
        /// Instantiates a new <see cref="OutlookRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public OutlookRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/outlook{?%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="OutlookRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OutlookRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/outlook{?%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OutlookRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OutlookRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        public class OutlookRequestBuilderGetQueryParameters 
        {
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
