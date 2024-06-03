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
namespace ApiSdk.Applications.Item.Synchronization.Jobs.Item.Start
{
    /// <summary>
    /// Provides operations to call the start method.
    /// </summary>
    public class StartRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Start an existing synchronization job. If the job is in a paused state, it continues processing changes from the point where it was paused. If the job is in quarantine, the quarantine status is cleared. Don&apos;t create scripts to call the start job continuously while it&apos;s running because that can cause the service to stop running. Use the start job only when the job is currently paused or in quarantine. 
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/synchronization-synchronizationjob-start?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Start an existing synchronization job. If the job is in a paused state, it continues processing changes from the point where it was paused. If the job is in quarantine, the quarantine status is cleared. Don't create scripts to call the start job continuously while it's running because that can cause the service to stop running. Use the start job only when the job is currently paused or in quarantine. \n\nFind more info here:\n  https://learn.microsoft.com/graph/api/synchronization-synchronizationjob-start?view=graph-rest-beta";
            var applicationIdOption = new Option<string>("--application-id", description: "The unique identifier of application") {
            };
            applicationIdOption.IsRequired = true;
            command.AddOption(applicationIdOption);
            var synchronizationJobIdOption = new Option<string>("--synchronization-job-id", description: "The unique identifier of synchronizationJob") {
            };
            synchronizationJobIdOption.IsRequired = true;
            command.AddOption(synchronizationJobIdOption);
            command.SetHandler(async (invocationContext) => {
                var applicationId = invocationContext.ParseResult.GetValueForOption(applicationIdOption);
                var synchronizationJobId = invocationContext.ParseResult.GetValueForOption(synchronizationJobIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (applicationId is not null) requestInfo.PathParameters.Add("application%2Did", applicationId);
                if (synchronizationJobId is not null) requestInfo.PathParameters.Add("synchronizationJob%2Did", synchronizationJobId);
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
        /// Instantiates a new <see cref="StartRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public StartRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/applications/{application%2Did}/synchronization/jobs/{synchronizationJob%2Did}/start", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="StartRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public StartRequestBuilder(string rawUrl) : base("{+baseurl}/applications/{application%2Did}/synchronization/jobs/{synchronizationJob%2Did}/start", rawUrl)
        {
        }
        /// <summary>
        /// Start an existing synchronization job. If the job is in a paused state, it continues processing changes from the point where it was paused. If the job is in quarantine, the quarantine status is cleared. Don&apos;t create scripts to call the start job continuously while it&apos;s running because that can cause the service to stop running. Use the start job only when the job is currently paused or in quarantine. 
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
