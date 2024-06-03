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
namespace ApiSdk.Users.Item.PendingAccessReviewInstances.Item.ApplyDecisions
{
    /// <summary>
    /// Provides operations to call the applyDecisions method.
    /// </summary>
    public class ApplyDecisionsRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is false in the review&apos;s accessReviewScheduleSettings. The status of the accessReviewInstance must be Completed to call this method.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewinstance-applydecisions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is false in the review's accessReviewScheduleSettings. The status of the accessReviewInstance must be Completed to call this method.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accessreviewinstance-applydecisions?view=graph-rest-beta";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user. Use 'me' for the currently signed in user.") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--access-review-instance-id", description: "The unique identifier of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var accessReviewInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (accessReviewInstanceId is not null) requestInfo.PathParameters.Add("accessReviewInstance%2Did", accessReviewInstanceId);
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
        /// Instantiates a new <see cref="ApplyDecisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ApplyDecisionsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/pendingAccessReviewInstances/{accessReviewInstance%2Did}/applyDecisions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ApplyDecisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ApplyDecisionsRequestBuilder(string rawUrl) : base("{+baseurl}/users/{user%2Did}/pendingAccessReviewInstances/{accessReviewInstance%2Did}/applyDecisions", rawUrl)
        {
        }
        /// <summary>
        /// Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is false in the review&apos;s accessReviewScheduleSettings. The status of the accessReviewInstance must be Completed to call this method.
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
