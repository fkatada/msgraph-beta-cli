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
namespace ApiSdk.DirectoryNamespace.InboundSharedUserProfiles.Item.RemovePersonalData
{
    /// <summary>
    /// Provides operations to call the removePersonalData method.
    /// </summary>
    public class RemovePersonalDataRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Create a request to remove the personal data for an inboundSharedUserProfile. 
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/inboundshareduserprofile-removepersonaldata?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Create a request to remove the personal data for an inboundSharedUserProfile. \n\nFind more info here:\n  https://learn.microsoft.com/graph/api/inboundshareduserprofile-removepersonaldata?view=graph-rest-beta";
            var inboundSharedUserProfileUserIdOption = new Option<string>("--inbound-shared-user-profile-user-id", description: "The unique identifier of inboundSharedUserProfile") {
            };
            inboundSharedUserProfileUserIdOption.IsRequired = true;
            command.AddOption(inboundSharedUserProfileUserIdOption);
            command.SetHandler(async (invocationContext) => {
                var inboundSharedUserProfileUserId = invocationContext.ParseResult.GetValueForOption(inboundSharedUserProfileUserIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (inboundSharedUserProfileUserId is not null) requestInfo.PathParameters.Add("inboundSharedUserProfile%2DuserId", inboundSharedUserProfileUserId);
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
        /// Instantiates a new <see cref="RemovePersonalDataRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RemovePersonalDataRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/directory/inboundSharedUserProfiles/{inboundSharedUserProfile%2DuserId}/removePersonalData", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RemovePersonalDataRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RemovePersonalDataRequestBuilder(string rawUrl) : base("{+baseurl}/directory/inboundSharedUserProfiles/{inboundSharedUserProfile%2DuserId}/removePersonalData", rawUrl)
        {
        }
        /// <summary>
        /// Create a request to remove the personal data for an inboundSharedUserProfile. 
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
