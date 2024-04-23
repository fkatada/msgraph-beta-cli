// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Sites.Item.Analytics;
using ApiSdk.Sites.Item.Columns;
using ApiSdk.Sites.Item.ContentTypes;
using ApiSdk.Sites.Item.CreatedByUser;
using ApiSdk.Sites.Item.Drive;
using ApiSdk.Sites.Item.Drives;
using ApiSdk.Sites.Item.ExternalColumns;
using ApiSdk.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using ApiSdk.Sites.Item.GetApplicableContentTypesForListWithListId;
using ApiSdk.Sites.Item.GetByPathWithPath;
using ApiSdk.Sites.Item.InformationProtection;
using ApiSdk.Sites.Item.Items;
using ApiSdk.Sites.Item.LastModifiedByUser;
using ApiSdk.Sites.Item.Lists;
using ApiSdk.Sites.Item.Onenote;
using ApiSdk.Sites.Item.Operations;
using ApiSdk.Sites.Item.Pages;
using ApiSdk.Sites.Item.Permissions;
using ApiSdk.Sites.Item.RecycleBin;
using ApiSdk.Sites.Item.Sites;
using ApiSdk.Sites.Item.TermStore;
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
namespace ApiSdk.Sites.Item {
    /// <summary>
    /// Provides operations to manage the collection of site entities.
    /// </summary>
    public class SiteItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to manage the analytics property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAnalyticsNavCommand()
        {
            var command = new Command("analytics");
            command.Description = "Provides operations to manage the analytics property of the microsoft.graph.site entity.";
            var builder = new AnalyticsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAllTimeNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildItemActivityStatsNavCommand());
            nonExecCommands.Add(builder.BuildLastSevenDaysNavCommand());
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
        /// Provides operations to manage the columns property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildColumnsNavCommand()
        {
            var command = new Command("columns");
            command.Description = "Provides operations to manage the columns property of the microsoft.graph.site entity.";
            var builder = new ColumnsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the contentTypes property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildContentTypesNavCommand()
        {
            var command = new Command("content-types");
            command.Description = "Provides operations to manage the contentTypes property of the microsoft.graph.site entity.";
            var builder = new ContentTypesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAddCopyFromContentTypeHubNavCommand());
            nonExecCommands.Add(builder.BuildAddCopyNavCommand());
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildGetCompatibleHubContentTypesNavCommand());
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
        /// Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreatedByUserNavCommand()
        {
            var command = new Command("created-by-user");
            command.Description = "Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.";
            var builder = new CreatedByUserRequestBuilder(PathParameters);
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
        /// Provides operations to manage the drive property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDriveNavCommand()
        {
            var command = new Command("drive");
            command.Description = "Provides operations to manage the drive property of the microsoft.graph.site entity.";
            var builder = new DriveRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drives property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDrivesNavCommand()
        {
            var command = new Command("drives");
            command.Description = "Provides operations to manage the drives property of the microsoft.graph.site entity.";
            var builder = new DrivesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the externalColumns property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildExternalColumnsNavCommand()
        {
            var command = new Command("external-columns");
            command.Description = "Provides operations to manage the externalColumns property of the microsoft.graph.site entity.";
            var builder = new ExternalColumnsRequestBuilder(PathParameters);
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
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRbCommand()
        {
            var command = new Command("get-activities-by-interval-with-start-date-time-with-end-date-time-with-interval");
            command.Description = "Provides operations to call the getActivitiesByInterval method.";
            var builder = new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetApplicableContentTypesForListWithListIdRbCommand()
        {
            var command = new Command("get-applicable-content-types-for-list-with-list-id");
            command.Description = "Provides operations to call the getApplicableContentTypesForList method.";
            var builder = new GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getByPath method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetByPathWithPathRbCommand()
        {
            var command = new Command("get-by-path-with-path");
            command.Description = "Provides operations to call the getByPath method.";
            var builder = new GetByPathWithPathRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAnalyticsNavCommand());
            nonExecCommands.Add(builder.BuildColumnsNavCommand());
            nonExecCommands.Add(builder.BuildContentTypesNavCommand());
            nonExecCommands.Add(builder.BuildCreatedByUserNavCommand());
            nonExecCommands.Add(builder.BuildDriveNavCommand());
            nonExecCommands.Add(builder.BuildDrivesNavCommand());
            nonExecCommands.Add(builder.BuildExternalColumnsNavCommand());
            nonExecCommands.Add(builder.BuildGetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRbCommand());
            nonExecCommands.Add(builder.BuildGetApplicableContentTypesForListWithListIdRbCommand());
            nonExecCommands.Add(builder.BuildGetByPathWithPath1RbCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildInformationProtectionNavCommand());
            nonExecCommands.Add(builder.BuildItemsNavCommand());
            nonExecCommands.Add(builder.BuildLastModifiedByUserNavCommand());
            nonExecCommands.Add(builder.BuildListsNavCommand());
            nonExecCommands.Add(builder.BuildOnenoteNavCommand());
            nonExecCommands.Add(builder.BuildOperationsNavCommand());
            nonExecCommands.Add(builder.BuildPagesNavCommand());
            nonExecCommands.Add(builder.BuildPermissionsNavCommand());
            nonExecCommands.Add(builder.BuildRecycleBinNavCommand());
            nonExecCommands.Add(builder.BuildSitesNavCommand());
            nonExecCommands.Add(builder.BuildTermStoreNavCommand());
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
        /// Retrieve properties and relationships for a [site][] resource.A site resource represents a team site in SharePoint.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/site-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Retrieve properties and relationships for a [site][] resource.A site resource represents a team site in SharePoint.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/site-get?view=graph-rest-1.0";
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
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
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
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
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
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
        /// Provides operations to manage the informationProtection property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildInformationProtectionNavCommand()
        {
            var command = new Command("information-protection");
            command.Description = "Provides operations to manage the informationProtection property of the microsoft.graph.site entity.";
            var builder = new InformationProtectionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildBitlockerNavCommand());
            nonExecCommands.Add(builder.BuildDataLossPreventionPoliciesNavCommand());
            nonExecCommands.Add(builder.BuildDecryptBufferNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            nonExecCommands.Add(builder.BuildEncryptBufferNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPolicyNavCommand());
            nonExecCommands.Add(builder.BuildSensitivityLabelsNavCommand());
            nonExecCommands.Add(builder.BuildSensitivityPolicySettingsNavCommand());
            nonExecCommands.Add(builder.BuildSignDigestNavCommand());
            nonExecCommands.Add(builder.BuildThreatAssessmentRequestsNavCommand());
            nonExecCommands.Add(builder.BuildVerifySignatureNavCommand());
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
        /// Provides operations to manage the items property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildItemsNavCommand()
        {
            var command = new Command("items");
            command.Description = "Provides operations to manage the items property of the microsoft.graph.site entity.";
            var builder = new ItemsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildLastModifiedByUserNavCommand()
        {
            var command = new Command("last-modified-by-user");
            command.Description = "Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.";
            var builder = new LastModifiedByUserRequestBuilder(PathParameters);
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
        /// Provides operations to manage the lists property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildListsNavCommand()
        {
            var command = new Command("lists");
            command.Description = "Provides operations to manage the lists property of the microsoft.graph.site entity.";
            var builder = new ListsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the onenote property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildOnenoteNavCommand()
        {
            var command = new Command("onenote");
            command.Description = "Provides operations to manage the onenote property of the microsoft.graph.site entity.";
            var builder = new OnenoteRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildNotebooksNavCommand());
            nonExecCommands.Add(builder.BuildOperationsNavCommand());
            nonExecCommands.Add(builder.BuildPagesNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildResourcesNavCommand());
            nonExecCommands.Add(builder.BuildSectionGroupsNavCommand());
            nonExecCommands.Add(builder.BuildSectionsNavCommand());
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
        /// Provides operations to manage the operations property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildOperationsNavCommand()
        {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.site entity.";
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
        /// Provides operations to manage the pages property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPagesNavCommand()
        {
            var command = new Command("pages");
            command.Description = "Provides operations to manage the pages property of the microsoft.graph.site entity.";
            var builder = new PagesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildGraphSitePageNavCommand());
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
        /// Update entity in sites
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update entity in sites";
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Site>(ApiSdk.Models.Site.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
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
        /// Provides operations to manage the permissions property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPermissionsNavCommand()
        {
            var command = new Command("permissions");
            command.Description = "Provides operations to manage the permissions property of the microsoft.graph.site entity.";
            var builder = new PermissionsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the recycleBin property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRecycleBinNavCommand()
        {
            var command = new Command("recycle-bin");
            command.Description = "Provides operations to manage the recycleBin property of the microsoft.graph.site entity.";
            var builder = new RecycleBinRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCreatedByUserNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildItemsNavCommand());
            nonExecCommands.Add(builder.BuildLastModifiedByUserNavCommand());
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
        /// Provides operations to manage the sites property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSubSitesNavCommand()
        {
            var command = new Command("sub-sites");
            command.Description = "Provides operations to manage the sites property of the microsoft.graph.site entity.";
            var builder = new ApiSdk.Sites.Item.Sites.SitesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the termStore property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildTermStoreNavCommand()
        {
            var command = new Command("term-store");
            command.Description = "Provides operations to manage the termStore property of the microsoft.graph.site entity.";
            var builder = new TermStoreRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildGroupsNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildSetsNavCommand());
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
        /// Instantiates a new <see cref="SiteItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SiteItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/sites/{site%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SiteItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SiteItemRequestBuilder(string rawUrl) : base("{+baseurl}/sites/{site%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve properties and relationships for a [site][] resource.A site resource represents a team site in SharePoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SiteItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SiteItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update entity in sites
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/sites/{site%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve properties and relationships for a [site][] resource.A site resource represents a team site in SharePoint.
        /// </summary>
        public class SiteItemRequestBuilderGetQueryParameters 
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
