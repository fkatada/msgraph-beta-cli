// <auto-generated/>
using ApiSdk.Groups.Item.Threads.Item.Posts.Item.InReplyTo.Attachments;
using ApiSdk.Groups.Item.Threads.Item.Posts.Item.InReplyTo.Extensions;
using ApiSdk.Groups.Item.Threads.Item.Posts.Item.InReplyTo.Forward;
using ApiSdk.Groups.Item.Threads.Item.Posts.Item.InReplyTo.Mentions;
using ApiSdk.Groups.Item.Threads.Item.Posts.Item.InReplyTo.Reply;
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
namespace ApiSdk.Groups.Item.Threads.Item.Posts.Item.InReplyTo
{
    /// <summary>
    /// Provides operations to manage the inReplyTo property of the microsoft.graph.post entity.
    /// </summary>
    public class InReplyToRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the attachments property of the microsoft.graph.post entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAttachmentsNavCommand()
        {
            var command = new Command("attachments");
            command.Description = "Provides operations to manage the attachments property of the microsoft.graph.post entity.";
            var builder = new AttachmentsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildCreateUploadSessionNavCommand());
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
        /// Provides operations to manage the extensions property of the microsoft.graph.post entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildExtensionsNavCommand()
        {
            var command = new Command("extensions");
            command.Description = "Provides operations to manage the extensions property of the microsoft.graph.post entity.";
            var builder = new ExtensionsRequestBuilder(PathParameters);
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
        /// Provides operations to call the forward method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildForwardNavCommand()
        {
            var command = new Command("forward");
            command.Description = "Provides operations to call the forward method.";
            var builder = new ForwardRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The earlier post that this post is replying to in the conversationThread. Read-only. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The earlier post that this post is replying to in the conversationThread. Read-only. Supports $expand.";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var conversationThreadIdOption = new Option<string>("--conversation-thread-id", description: "The unique identifier of conversationThread") {
            };
            conversationThreadIdOption.IsRequired = true;
            command.AddOption(conversationThreadIdOption);
            var postIdOption = new Option<string>("--post-id", description: "The unique identifier of post") {
            };
            postIdOption.IsRequired = true;
            command.AddOption(postIdOption);
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
                var conversationThreadId = invocationContext.ParseResult.GetValueForOption(conversationThreadIdOption);
                var postId = invocationContext.ParseResult.GetValueForOption(postIdOption);
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
                if (conversationThreadId is not null) requestInfo.PathParameters.Add("conversationThread%2Did", conversationThreadId);
                if (postId is not null) requestInfo.PathParameters.Add("post%2Did", postId);
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
        /// Provides operations to manage the mentions property of the microsoft.graph.post entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildMentionsNavCommand()
        {
            var command = new Command("mentions");
            command.Description = "Provides operations to manage the mentions property of the microsoft.graph.post entity.";
            var builder = new MentionsRequestBuilder(PathParameters);
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
        /// Provides operations to call the reply method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildReplyNavCommand()
        {
            var command = new Command("reply");
            command.Description = "Provides operations to call the reply method.";
            var builder = new ReplyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="InReplyToRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public InReplyToRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/groups/{group%2Did}/threads/{conversationThread%2Did}/posts/{post%2Did}/inReplyTo{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="InReplyToRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public InReplyToRequestBuilder(string rawUrl) : base("{+baseurl}/groups/{group%2Did}/threads/{conversationThread%2Did}/posts/{post%2Did}/inReplyTo{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The earlier post that this post is replying to in the conversationThread. Read-only. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<InReplyToRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<InReplyToRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The earlier post that this post is replying to in the conversationThread. Read-only. Supports $expand.
        /// </summary>
        public class InReplyToRequestBuilderGetQueryParameters 
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
