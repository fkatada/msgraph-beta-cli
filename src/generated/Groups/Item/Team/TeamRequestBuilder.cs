// <auto-generated/>
using ApiSdk.Groups.Item.Team.AllChannels;
using ApiSdk.Groups.Item.Team.Archive;
using ApiSdk.Groups.Item.Team.Channels;
using ApiSdk.Groups.Item.Team.Clone;
using ApiSdk.Groups.Item.Team.CompleteMigration;
using ApiSdk.Groups.Item.Team.Group;
using ApiSdk.Groups.Item.Team.IncomingChannels;
using ApiSdk.Groups.Item.Team.InstalledApps;
using ApiSdk.Groups.Item.Team.Members;
using ApiSdk.Groups.Item.Team.Operations;
using ApiSdk.Groups.Item.Team.Owners;
using ApiSdk.Groups.Item.Team.PermissionGrants;
using ApiSdk.Groups.Item.Team.Photo;
using ApiSdk.Groups.Item.Team.PrimaryChannel;
using ApiSdk.Groups.Item.Team.Schedule;
using ApiSdk.Groups.Item.Team.SendActivityNotification;
using ApiSdk.Groups.Item.Team.Tags;
using ApiSdk.Groups.Item.Team.Template;
using ApiSdk.Groups.Item.Team.TemplateDefinition;
using ApiSdk.Groups.Item.Team.Unarchive;
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
namespace ApiSdk.Groups.Item.Team {
    /// <summary>
    /// Provides operations to manage the team property of the microsoft.graph.group entity.
    /// </summary>
    public class TeamRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to manage the allChannels property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAllChannelsNavCommand()
        {
            var command = new Command("all-channels");
            command.Description = "Provides operations to manage the allChannels property of the microsoft.graph.team entity.";
            var builder = new AllChannelsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
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
        /// Provides operations to call the archive method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildArchiveNavCommand()
        {
            var command = new Command("archive");
            command.Description = "Provides operations to call the archive method.";
            var builder = new ArchiveRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the channels property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildChannelsNavCommand()
        {
            var command = new Command("channels");
            command.Description = "Provides operations to manage the channels property of the microsoft.graph.team entity.";
            var builder = new ChannelsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAllMessagesNavCommand());
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildGetAllMessagesNavCommand());
            nonExecCommands.Add(builder.BuildGetAllRetainedMessagesNavCommand());
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
        /// Provides operations to call the clone method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCloneNavCommand()
        {
            var command = new Command("clone");
            command.Description = "Provides operations to call the clone method.";
            var builder = new CloneRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the completeMigration method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCompleteMigrationNavCommand()
        {
            var command = new Command("complete-migration");
            command.Description = "Provides operations to call the completeMigration method.";
            var builder = new CompleteMigrationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property team for groups
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property team for groups";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
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
        /// The team associated with this group.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The team associated with this group.";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
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
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
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
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
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
        /// Provides operations to manage the group property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGroupNavCommand()
        {
            var command = new Command("group");
            command.Description = "Provides operations to manage the group property of the microsoft.graph.team entity.";
            var builder = new GroupRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
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
        /// Provides operations to manage the incomingChannels property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildIncomingChannelsNavCommand()
        {
            var command = new Command("incoming-channels");
            command.Description = "Provides operations to manage the incomingChannels property of the microsoft.graph.team entity.";
            var builder = new IncomingChannelsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
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
        /// Provides operations to manage the installedApps property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildInstalledAppsNavCommand()
        {
            var command = new Command("installed-apps");
            command.Description = "Provides operations to manage the installedApps property of the microsoft.graph.team entity.";
            var builder = new InstalledAppsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the members property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMembersNavCommand()
        {
            var command = new Command("members");
            command.Description = "Provides operations to manage the members property of the microsoft.graph.team entity.";
            var builder = new MembersRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAddNavCommand());
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
        /// Provides operations to manage the operations property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildOperationsNavCommand()
        {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.team entity.";
            var builder = new OperationsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the owners property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildOwnersNavCommand()
        {
            var command = new Command("owners");
            command.Description = "Provides operations to manage the owners property of the microsoft.graph.team entity.";
            var builder = new OwnersRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
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
        /// Provides operations to manage the permissionGrants property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPermissionGrantsNavCommand()
        {
            var command = new Command("permission-grants");
            command.Description = "Provides operations to manage the permissionGrants property of the microsoft.graph.team entity.";
            var builder = new PermissionGrantsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the photo property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPhotoNavCommand()
        {
            var command = new Command("photo");
            command.Description = "Provides operations to manage the photo property of the microsoft.graph.team entity.";
            var builder = new PhotoRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildContentNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
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
        /// Provides operations to manage the primaryChannel property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPrimaryChannelNavCommand()
        {
            var command = new Command("primary-channel");
            command.Description = "Provides operations to manage the primaryChannel property of the microsoft.graph.team entity.";
            var builder = new PrimaryChannelRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildArchiveNavCommand());
            nonExecCommands.Add(builder.BuildCompleteMigrationNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            nonExecCommands.Add(builder.BuildDoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameNavCommand());
            nonExecCommands.Add(builder.BuildFilesFolderNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildMembersNavCommand());
            nonExecCommands.Add(builder.BuildMessagesNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildProvisionEmailNavCommand());
            nonExecCommands.Add(builder.BuildRemoveEmailNavCommand());
            nonExecCommands.Add(builder.BuildSharedWithTeamsNavCommand());
            nonExecCommands.Add(builder.BuildTabsNavCommand());
            nonExecCommands.Add(builder.BuildUnarchiveNavCommand());
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
        /// Update the navigation property team in groups
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPutCommand()
        {
            var command = new Command("put");
            command.Description = "Update the navigation property team in groups";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Team>(ApiSdk.Models.Team.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPutRequestInformation(model, q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
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
        /// Provides operations to manage the schedule property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildScheduleNavCommand()
        {
            var command = new Command("schedule");
            command.Description = "Provides operations to manage the schedule property of the microsoft.graph.team entity.";
            var builder = new ScheduleRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildDayNotesNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildOfferShiftRequestsNavCommand());
            nonExecCommands.Add(builder.BuildOpenShiftChangeRequestsNavCommand());
            nonExecCommands.Add(builder.BuildOpenShiftsNavCommand());
            execCommands.Add(builder.BuildPutCommand());
            nonExecCommands.Add(builder.BuildSchedulingGroupsNavCommand());
            nonExecCommands.Add(builder.BuildShareNavCommand());
            nonExecCommands.Add(builder.BuildShiftsNavCommand());
            nonExecCommands.Add(builder.BuildShiftsRoleDefinitionsNavCommand());
            nonExecCommands.Add(builder.BuildSwapShiftsChangeRequestsNavCommand());
            nonExecCommands.Add(builder.BuildTimeCardsNavCommand());
            nonExecCommands.Add(builder.BuildTimeOffReasonsNavCommand());
            nonExecCommands.Add(builder.BuildTimeOffRequestsNavCommand());
            nonExecCommands.Add(builder.BuildTimesOffNavCommand());
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
        /// Provides operations to call the sendActivityNotification method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSendActivityNotificationNavCommand()
        {
            var command = new Command("send-activity-notification");
            command.Description = "Provides operations to call the sendActivityNotification method.";
            var builder = new SendActivityNotificationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tags property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTagsNavCommand()
        {
            var command = new Command("tags");
            command.Description = "Provides operations to manage the tags property of the microsoft.graph.team entity.";
            var builder = new TagsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the templateDefinition property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTemplateDefinitionNavCommand()
        {
            var command = new Command("template-definition");
            command.Description = "Provides operations to manage the templateDefinition property of the microsoft.graph.team entity.";
            var builder = new TemplateDefinitionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the template property of the microsoft.graph.team entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTemplateNavCommand()
        {
            var command = new Command("template");
            command.Description = "Provides operations to manage the template property of the microsoft.graph.team entity.";
            var builder = new TemplateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the unarchive method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUnarchiveNavCommand()
        {
            var command = new Command("unarchive");
            command.Description = "Provides operations to call the unarchive method.";
            var builder = new UnarchiveRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="TeamRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public TeamRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/groups/{group%2Did}/team{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="TeamRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TeamRequestBuilder(string rawUrl) : base("{+baseurl}/groups/{group%2Did}/team{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property team for groups
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
        /// The team associated with this group.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TeamRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TeamRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property team in groups
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(ApiSdk.Models.Team body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(ApiSdk.Models.Team body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The team associated with this group.
        /// </summary>
        public class TeamRequestBuilderGetQueryParameters 
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
