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
namespace ApiSdk.TeamTemplateDefinition.Item.TeamDefinition.PrimaryChannel.Messages.Item.UndoSoftDelete
{
    /// <summary>
    /// Provides operations to call the undoSoftDelete method.
    /// </summary>
    public class UndoSoftDeleteRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/chatmessage-undosoftdelete?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/chatmessage-undosoftdelete?view=graph-rest-beta";
            var teamTemplateDefinitionIdOption = new Option<string>("--team-template-definition-id", description: "The unique identifier of teamTemplateDefinition") {
            };
            teamTemplateDefinitionIdOption.IsRequired = true;
            command.AddOption(teamTemplateDefinitionIdOption);
            var chatMessageIdOption = new Option<string>("--chat-message-id", description: "The unique identifier of chatMessage") {
            };
            chatMessageIdOption.IsRequired = true;
            command.AddOption(chatMessageIdOption);
            command.SetHandler(async (invocationContext) => {
                var teamTemplateDefinitionId = invocationContext.ParseResult.GetValueForOption(teamTemplateDefinitionIdOption);
                var chatMessageId = invocationContext.ParseResult.GetValueForOption(chatMessageIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (teamTemplateDefinitionId is not null) requestInfo.PathParameters.Add("teamTemplateDefinition%2Did", teamTemplateDefinitionId);
                if (chatMessageId is not null) requestInfo.PathParameters.Add("chatMessage%2Did", chatMessageId);
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
        /// Instantiates a new <see cref="UndoSoftDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UndoSoftDeleteRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teamTemplateDefinition/{teamTemplateDefinition%2Did}/teamDefinition/primaryChannel/messages/{chatMessage%2Did}/undoSoftDelete", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="UndoSoftDeleteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UndoSoftDeleteRequestBuilder(string rawUrl) : base("{+baseurl}/teamTemplateDefinition/{teamTemplateDefinition%2Did}/teamDefinition/primaryChannel/messages/{chatMessage%2Did}/undoSoftDelete", rawUrl)
        {
        }
        /// <summary>
        /// Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.
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
