// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models.Security;
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
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item
{
    /// <summary>
    /// Provides operations to manage the childTags property of the microsoft.graph.security.ediscoveryReviewTag entity.
    /// </summary>
    public class EdiscoveryReviewTagItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Returns the tags that are a child of a tag.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Returns the tags that are a child of a tag.";
            var ediscoveryCaseIdOption = new Option<string>("--ediscovery-case-id", description: "The unique identifier of ediscoveryCase") {
            };
            ediscoveryCaseIdOption.IsRequired = true;
            command.AddOption(ediscoveryCaseIdOption);
            var ediscoveryReviewTagIdOption = new Option<string>("--ediscovery-review-tag-id", description: "The unique identifier of ediscoveryReviewTag") {
            };
            ediscoveryReviewTagIdOption.IsRequired = true;
            command.AddOption(ediscoveryReviewTagIdOption);
            var ediscoveryReviewTagId1Option = new Option<string>("--ediscovery-review-tag-id1", description: "The unique identifier of ediscoveryReviewTag") {
            };
            ediscoveryReviewTagId1Option.IsRequired = true;
            command.AddOption(ediscoveryReviewTagId1Option);
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
                var ediscoveryCaseId = invocationContext.ParseResult.GetValueForOption(ediscoveryCaseIdOption);
                var ediscoveryReviewTagId = invocationContext.ParseResult.GetValueForOption(ediscoveryReviewTagIdOption);
                var ediscoveryReviewTagId1 = invocationContext.ParseResult.GetValueForOption(ediscoveryReviewTagId1Option);
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
                if (ediscoveryCaseId is not null) requestInfo.PathParameters.Add("ediscoveryCase%2Did", ediscoveryCaseId);
                if (ediscoveryReviewTagId is not null) requestInfo.PathParameters.Add("ediscoveryReviewTag%2Did", ediscoveryReviewTagId);
                if (ediscoveryReviewTagId1 is not null) requestInfo.PathParameters.Add("ediscoveryReviewTag%2Did1", ediscoveryReviewTagId1);
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
        /// Instantiates a new <see cref="EdiscoveryReviewTagItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EdiscoveryReviewTagItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/tags/{ediscoveryReviewTag%2Did}/childTags/{ediscoveryReviewTag%2Did1}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="EdiscoveryReviewTagItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EdiscoveryReviewTagItemRequestBuilder(string rawUrl) : base("{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/tags/{ediscoveryReviewTag%2Did}/childTags/{ediscoveryReviewTag%2Did1}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the tags that are a child of a tag.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EdiscoveryReviewTagItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EdiscoveryReviewTagItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns the tags that are a child of a tag.
        /// </summary>
        public class EdiscoveryReviewTagItemRequestBuilderGetQueryParameters 
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
