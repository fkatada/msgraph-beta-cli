// <auto-generated/>
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
namespace ApiSdk.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Archive {
    /// <summary>
    /// Provides operations to call the archive method.
    /// </summary>
    public class ArchiveRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Archive the specified team. When a team is archived, users can no longer make most changes to the team. For example, users can no longer: send or like messages on any channel in the team; edit the team&apos;s name or description; nor edit other settings. However, membership changes to the team continue to be allowed. Archiving is an async operation. A team is archived once the async operation completes successfully, which can occur subsequent to a response from this API. To archive a team, the team and group must have an owner. To restore a team from its archived state, use the API to unarchive.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/team-archive?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Archive the specified team. When a team is archived, users can no longer make most changes to the team. For example, users can no longer: send or like messages on any channel in the team; edit the team's name or description; nor edit other settings. However, membership changes to the team continue to be allowed. Archiving is an async operation. A team is archived once the async operation completes successfully, which can occur subsequent to a response from this API. To archive a team, the team and group must have an owner. To restore a team from its archived state, use the API to unarchive.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/team-archive?view=graph-rest-beta";
            var teamTemplateIdOption = new Option<string>("--team-template-id", description: "The unique identifier of teamTemplate") {
            };
            teamTemplateIdOption.IsRequired = true;
            command.AddOption(teamTemplateIdOption);
            var teamTemplateDefinitionIdOption = new Option<string>("--team-template-definition-id", description: "The unique identifier of teamTemplateDefinition") {
            };
            teamTemplateDefinitionIdOption.IsRequired = true;
            command.AddOption(teamTemplateDefinitionIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var teamTemplateId = invocationContext.ParseResult.GetValueForOption(teamTemplateIdOption);
                var teamTemplateDefinitionId = invocationContext.ParseResult.GetValueForOption(teamTemplateDefinitionIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ArchivePostRequestBody>(ArchivePostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (teamTemplateId is not null) requestInfo.PathParameters.Add("teamTemplate%2Did", teamTemplateId);
                if (teamTemplateDefinitionId is not null) requestInfo.PathParameters.Add("teamTemplateDefinition%2Did", teamTemplateDefinitionId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="ArchiveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ArchiveRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/archive", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ArchiveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ArchiveRequestBuilder(string rawUrl) : base("{+baseurl}/teamwork/teamTemplates/{teamTemplate%2Did}/definitions/{teamTemplateDefinition%2Did}/teamDefinition/archive", rawUrl)
        {
        }
        /// <summary>
        /// Archive the specified team. When a team is archived, users can no longer make most changes to the team. For example, users can no longer: send or like messages on any channel in the team; edit the team&apos;s name or description; nor edit other settings. However, membership changes to the team continue to be allowed. Archiving is an async operation. A team is archived once the async operation completes successfully, which can occur subsequent to a response from this API. To archive a team, the team and group must have an owner. To restore a team from its archived state, use the API to unarchive.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ArchivePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ArchivePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
