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
namespace ApiSdk.Users.Item.PendingAccessReviewInstances.Item.Stages.Item.Stop
{
    /// <summary>
    /// Provides operations to call the stop method.
    /// </summary>
    public class StopRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Stop an access review stage that is inProgress. After the access review stage stops, the stage status will be Completed and the reviewers can no longer give input. If there are subsequent stages that depend on the completed stage, the next stage will be created.  The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewstage-stop?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Stop an access review stage that is inProgress. After the access review stage stops, the stage status will be Completed and the reviewers can no longer give input. If there are subsequent stages that depend on the completed stage, the next stage will be created.  The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accessreviewstage-stop?view=graph-rest-beta";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--access-review-instance-id", description: "The unique identifier of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
            var accessReviewStageIdOption = new Option<string>("--access-review-stage-id", description: "The unique identifier of accessReviewStage") {
            };
            accessReviewStageIdOption.IsRequired = true;
            command.AddOption(accessReviewStageIdOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var accessReviewInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceIdOption);
                var accessReviewStageId = invocationContext.ParseResult.GetValueForOption(accessReviewStageIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (accessReviewInstanceId is not null) requestInfo.PathParameters.Add("accessReviewInstance%2Did", accessReviewInstanceId);
                if (accessReviewStageId is not null) requestInfo.PathParameters.Add("accessReviewStage%2Did", accessReviewStageId);
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
        /// Instantiates a new <see cref="StopRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public StopRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/pendingAccessReviewInstances/{accessReviewInstance%2Did}/stages/{accessReviewStage%2Did}/stop", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StopRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StopRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/pendingAccessReviewInstances/{accessReviewInstance%2Did}/stages/{accessReviewStage%2Did}/stop", rawUrl)
        {
        }
        /// <summary>
        /// Stop an access review stage that is inProgress. After the access review stage stops, the stage status will be Completed and the reviewers can no longer give input. If there are subsequent stages that depend on the completed stage, the next stage will be created.  The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.
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
