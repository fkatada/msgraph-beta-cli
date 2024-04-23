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
namespace ApiSdk.IdentityGovernance.AccessReviews.Decisions.Item.Instance.StopApplyDecisions {
    /// <summary>
    /// Provides operations to call the stopApplyDecisions method.
    /// </summary>
    public class StopApplyDecisionsRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Invoke action stopApplyDecisions
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action stopApplyDecisions";
            var accessReviewInstanceDecisionItemIdOption = new Option<string>("--access-review-instance-decision-item-id", description: "The unique identifier of accessReviewInstanceDecisionItem") {
            };
            accessReviewInstanceDecisionItemIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceDecisionItemIdOption);
            command.SetHandler(async (invocationContext) => {
                var accessReviewInstanceDecisionItemId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceDecisionItemIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (accessReviewInstanceDecisionItemId is not null) requestInfo.PathParameters.Add("accessReviewInstanceDecisionItem%2Did", accessReviewInstanceDecisionItemId);
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
        /// Instantiates a new <see cref="StopApplyDecisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public StopApplyDecisionsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/accessReviews/decisions/{accessReviewInstanceDecisionItem%2Did}/instance/stopApplyDecisions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StopApplyDecisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StopApplyDecisionsRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/accessReviews/decisions/{accessReviewInstanceDecisionItem%2Did}/instance/stopApplyDecisions", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action stopApplyDecisions
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
