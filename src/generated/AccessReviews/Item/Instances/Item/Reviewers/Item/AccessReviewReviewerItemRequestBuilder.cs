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
namespace ApiSdk.AccessReviews.Item.Instances.Item.Reviewers.Item
{
    /// <summary>
    /// Provides operations to manage the reviewers property of the microsoft.graph.accessReview entity.
    /// </summary>
    public class AccessReviewReviewerItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete navigation property reviewers for accessReviews
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property reviewers for accessReviews";
            var accessReviewIdOption = new Option<string>("--access-review-id", description: "The unique identifier of accessReview") {
            };
            accessReviewIdOption.IsRequired = true;
            command.AddOption(accessReviewIdOption);
            var accessReviewId1Option = new Option<string>("--access-review-id1", description: "The unique identifier of accessReview") {
            };
            accessReviewId1Option.IsRequired = true;
            command.AddOption(accessReviewId1Option);
            var accessReviewReviewerIdOption = new Option<string>("--access-review-reviewer-id", description: "The unique identifier of accessReviewReviewer") {
            };
            accessReviewReviewerIdOption.IsRequired = true;
            command.AddOption(accessReviewReviewerIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var accessReviewId = invocationContext.ParseResult.GetValueForOption(accessReviewIdOption);
                var accessReviewId1 = invocationContext.ParseResult.GetValueForOption(accessReviewId1Option);
                var accessReviewReviewerId = invocationContext.ParseResult.GetValueForOption(accessReviewReviewerIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (accessReviewId is not null) requestInfo.PathParameters.Add("accessReview%2Did", accessReviewId);
                if (accessReviewId1 is not null) requestInfo.PathParameters.Add("accessReview%2Did1", accessReviewId1);
                if (accessReviewReviewerId is not null) requestInfo.PathParameters.Add("accessReviewReviewer%2Did", accessReviewReviewerId);
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
        /// The collection of reviewers for an access review, if access review reviewerType is of type delegated.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "The collection of reviewers for an access review, if access review reviewerType is of type delegated.";
            var accessReviewIdOption = new Option<string>("--access-review-id", description: "The unique identifier of accessReview") {
            };
            accessReviewIdOption.IsRequired = true;
            command.AddOption(accessReviewIdOption);
            var accessReviewId1Option = new Option<string>("--access-review-id1", description: "The unique identifier of accessReview") {
            };
            accessReviewId1Option.IsRequired = true;
            command.AddOption(accessReviewId1Option);
            var accessReviewReviewerIdOption = new Option<string>("--access-review-reviewer-id", description: "The unique identifier of accessReviewReviewer") {
            };
            accessReviewReviewerIdOption.IsRequired = true;
            command.AddOption(accessReviewReviewerIdOption);
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
                var accessReviewId = invocationContext.ParseResult.GetValueForOption(accessReviewIdOption);
                var accessReviewId1 = invocationContext.ParseResult.GetValueForOption(accessReviewId1Option);
                var accessReviewReviewerId = invocationContext.ParseResult.GetValueForOption(accessReviewReviewerIdOption);
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
                if (accessReviewId is not null) requestInfo.PathParameters.Add("accessReview%2Did", accessReviewId);
                if (accessReviewId1 is not null) requestInfo.PathParameters.Add("accessReview%2Did1", accessReviewId1);
                if (accessReviewReviewerId is not null) requestInfo.PathParameters.Add("accessReviewReviewer%2Did", accessReviewReviewerId);
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
        /// Update the navigation property reviewers in accessReviews
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property reviewers in accessReviews";
            var accessReviewIdOption = new Option<string>("--access-review-id", description: "The unique identifier of accessReview") {
            };
            accessReviewIdOption.IsRequired = true;
            command.AddOption(accessReviewIdOption);
            var accessReviewId1Option = new Option<string>("--access-review-id1", description: "The unique identifier of accessReview") {
            };
            accessReviewId1Option.IsRequired = true;
            command.AddOption(accessReviewId1Option);
            var accessReviewReviewerIdOption = new Option<string>("--access-review-reviewer-id", description: "The unique identifier of accessReviewReviewer") {
            };
            accessReviewReviewerIdOption.IsRequired = true;
            command.AddOption(accessReviewReviewerIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var accessReviewId = invocationContext.ParseResult.GetValueForOption(accessReviewIdOption);
                var accessReviewId1 = invocationContext.ParseResult.GetValueForOption(accessReviewId1Option);
                var accessReviewReviewerId = invocationContext.ParseResult.GetValueForOption(accessReviewReviewerIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AccessReviewReviewer>(AccessReviewReviewer.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (accessReviewId is not null) requestInfo.PathParameters.Add("accessReview%2Did", accessReviewId);
                if (accessReviewId1 is not null) requestInfo.PathParameters.Add("accessReview%2Did1", accessReviewId1);
                if (accessReviewReviewerId is not null) requestInfo.PathParameters.Add("accessReviewReviewer%2Did", accessReviewReviewerId);
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
        /// Instantiates a new <see cref="AccessReviewReviewerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AccessReviewReviewerItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/accessReviews/{accessReview%2Did}/instances/{accessReview%2Did1}/reviewers/{accessReviewReviewer%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AccessReviewReviewerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AccessReviewReviewerItemRequestBuilder(string rawUrl) : base("{+baseurl}/accessReviews/{accessReview%2Did}/instances/{accessReview%2Did1}/reviewers/{accessReviewReviewer%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property reviewers for accessReviews
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
        /// The collection of reviewers for an access review, if access review reviewerType is of type delegated.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AccessReviewReviewerItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AccessReviewReviewerItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property reviewers in accessReviews
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(AccessReviewReviewer body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(AccessReviewReviewer body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The collection of reviewers for an access review, if access review reviewerType is of type delegated.
        /// </summary>
        public class AccessReviewReviewerItemRequestBuilderGetQueryParameters 
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
