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
namespace ApiSdk.AccessReviews.Item.SendReminder
{
    /// <summary>
    /// Provides operations to call the sendReminder method.
    /// </summary>
    public class SendReminderRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// In the Microsoft Entra access reviews feature, send a reminder to the reviewers of a currently active accessReview.  The target object can be either a one-time access review, or an instance of a recurring access review. 
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreview-sendreminder?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "In the Microsoft Entra access reviews feature, send a reminder to the reviewers of a currently active accessReview.  The target object can be either a one-time access review, or an instance of a recurring access review. \n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accessreview-sendreminder?view=graph-rest-beta";
            var accessReviewIdOption = new Option<string>("--access-review-id", description: "The unique identifier of accessReview") {
            };
            accessReviewIdOption.IsRequired = true;
            command.AddOption(accessReviewIdOption);
            command.SetHandler(async (invocationContext) => {
                var accessReviewId = invocationContext.ParseResult.GetValueForOption(accessReviewIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (accessReviewId is not null) requestInfo.PathParameters.Add("accessReview%2Did", accessReviewId);
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
        /// Instantiates a new <see cref="SendReminderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SendReminderRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/accessReviews/{accessReview%2Did}/sendReminder", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SendReminderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SendReminderRequestBuilder(string rawUrl) : base("{+baseurl}/accessReviews/{accessReview%2Did}/sendReminder", rawUrl)
        {
        }
        /// <summary>
        /// In the Microsoft Entra access reviews feature, send a reminder to the reviewers of a currently active accessReview.  The target object can be either a one-time access review, or an instance of a recurring access review. 
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
