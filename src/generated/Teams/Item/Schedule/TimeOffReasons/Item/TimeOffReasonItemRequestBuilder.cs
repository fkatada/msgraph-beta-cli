// <auto-generated/>
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
namespace ApiSdk.Teams.Item.Schedule.TimeOffReasons.Item {
    /// <summary>
    /// Provides operations to manage the timeOffReasons property of the microsoft.graph.schedule entity.
    /// </summary>
    public class TimeOffReasonItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Mark a timeOffReason as inactive by setting the isActive property. Every team must include at least one timeOffReason. This method does not remove the specified timeOffReason instance. timeOffItem instances that have been assigned this reason remain assigned to this reason.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/timeoffreason-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Mark a timeOffReason as inactive by setting the isActive property. Every team must include at least one timeOffReason. This method does not remove the specified timeOffReason instance. timeOffItem instances that have been assigned this reason remain assigned to this reason.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/timeoffreason-delete?view=graph-rest-1.0";
            var teamIdOption = new Option<string>("--team-id", description: "The unique identifier of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var timeOffReasonIdOption = new Option<string>("--time-off-reason-id", description: "The unique identifier of timeOffReason") {
            };
            timeOffReasonIdOption.IsRequired = true;
            command.AddOption(timeOffReasonIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var timeOffReasonId = invocationContext.ParseResult.GetValueForOption(timeOffReasonIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                if (timeOffReasonId is not null) requestInfo.PathParameters.Add("timeOffReason%2Did", timeOffReasonId);
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
        /// Retrieve the properties and relationships of a timeOffReason object by ID.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/timeoffreason-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Retrieve the properties and relationships of a timeOffReason object by ID.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/timeoffreason-get?view=graph-rest-1.0";
            var teamIdOption = new Option<string>("--team-id", description: "The unique identifier of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var timeOffReasonIdOption = new Option<string>("--time-off-reason-id", description: "The unique identifier of timeOffReason") {
            };
            timeOffReasonIdOption.IsRequired = true;
            command.AddOption(timeOffReasonIdOption);
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
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var timeOffReasonId = invocationContext.ParseResult.GetValueForOption(timeOffReasonIdOption);
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
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                if (timeOffReasonId is not null) requestInfo.PathParameters.Add("timeOffReason%2Did", timeOffReasonId);
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
        /// Replace an existing timeOffReason. If the specified timeOffReason doesn&apos;t exist, this method returns 404 Not found.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/timeoffreason-put?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Replace an existing timeOffReason. If the specified timeOffReason doesn't exist, this method returns 404 Not found.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/timeoffreason-put?view=graph-rest-1.0";
            var teamIdOption = new Option<string>("--team-id", description: "The unique identifier of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var timeOffReasonIdOption = new Option<string>("--time-off-reason-id", description: "The unique identifier of timeOffReason") {
            };
            timeOffReasonIdOption.IsRequired = true;
            command.AddOption(timeOffReasonIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var timeOffReasonId = invocationContext.ParseResult.GetValueForOption(timeOffReasonIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<TimeOffReason>(TimeOffReason.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                if (timeOffReasonId is not null) requestInfo.PathParameters.Add("timeOffReason%2Did", timeOffReasonId);
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
        /// Instantiates a new <see cref="TimeOffReasonItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public TimeOffReasonItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/teams/{team%2Did}/schedule/timeOffReasons/{timeOffReason%2Did}{?%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="TimeOffReasonItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TimeOffReasonItemRequestBuilder(string rawUrl) : base("{+baseurl}/teams/{team%2Did}/schedule/timeOffReasons/{timeOffReason%2Did}{?%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Mark a timeOffReason as inactive by setting the isActive property. Every team must include at least one timeOffReason. This method does not remove the specified timeOffReason instance. timeOffItem instances that have been assigned this reason remain assigned to this reason.
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/teams/{team%2Did}/schedule/timeOffReasons/{timeOffReason%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of a timeOffReason object by ID.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimeOffReasonItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimeOffReasonItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Replace an existing timeOffReason. If the specified timeOffReason doesn&apos;t exist, this method returns 404 Not found.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(TimeOffReason body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(TimeOffReason body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/teams/{team%2Did}/schedule/timeOffReasons/{timeOffReason%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of a timeOffReason object by ID.
        /// </summary>
        public class TimeOffReasonItemRequestBuilderGetQueryParameters 
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
