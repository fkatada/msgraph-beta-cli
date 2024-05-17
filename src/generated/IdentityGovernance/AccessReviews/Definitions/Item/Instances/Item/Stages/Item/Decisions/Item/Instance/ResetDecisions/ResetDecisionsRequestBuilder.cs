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
namespace ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.ResetDecisions {
    /// <summary>
    /// Provides operations to call the resetDecisions method.
    /// </summary>
    public class ResetDecisionsRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Resets decisions of all accessReviewInstanceDecisionItem objects on an accessReviewInstance to notReviewed.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewinstance-resetdecisions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Resets decisions of all accessReviewInstanceDecisionItem objects on an accessReviewInstance to notReviewed.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accessreviewinstance-resetdecisions?view=graph-rest-beta";
            var accessReviewScheduleDefinitionIdOption = new Option<string>("--access-review-schedule-definition-id", description: "The unique identifier of accessReviewScheduleDefinition") {
            };
            accessReviewScheduleDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewScheduleDefinitionIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--access-review-instance-id", description: "The unique identifier of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
            var accessReviewStageIdOption = new Option<string>("--access-review-stage-id", description: "The unique identifier of accessReviewStage") {
            };
            accessReviewStageIdOption.IsRequired = true;
            command.AddOption(accessReviewStageIdOption);
            var accessReviewInstanceDecisionItemIdOption = new Option<string>("--access-review-instance-decision-item-id", description: "The unique identifier of accessReviewInstanceDecisionItem") {
            };
            accessReviewInstanceDecisionItemIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceDecisionItemIdOption);
            command.SetHandler(async (invocationContext) => {
                var accessReviewScheduleDefinitionId = invocationContext.ParseResult.GetValueForOption(accessReviewScheduleDefinitionIdOption);
                var accessReviewInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceIdOption);
                var accessReviewStageId = invocationContext.ParseResult.GetValueForOption(accessReviewStageIdOption);
                var accessReviewInstanceDecisionItemId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceDecisionItemIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (accessReviewScheduleDefinitionId is not null) requestInfo.PathParameters.Add("accessReviewScheduleDefinition%2Did", accessReviewScheduleDefinitionId);
                if (accessReviewInstanceId is not null) requestInfo.PathParameters.Add("accessReviewInstance%2Did", accessReviewInstanceId);
                if (accessReviewStageId is not null) requestInfo.PathParameters.Add("accessReviewStage%2Did", accessReviewStageId);
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
        /// Instantiates a new <see cref="ResetDecisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ResetDecisionsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}/stages/{accessReviewStage%2Did}/decisions/{accessReviewInstanceDecisionItem%2Did}/instance/resetDecisions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ResetDecisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ResetDecisionsRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}/stages/{accessReviewStage%2Did}/decisions/{accessReviewInstanceDecisionItem%2Did}/instance/resetDecisions", rawUrl)
        {
        }
        /// <summary>
        /// Resets decisions of all accessReviewInstanceDecisionItem objects on an accessReviewInstance to notReviewed.
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
