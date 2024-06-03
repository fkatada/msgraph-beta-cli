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
namespace ApiSdk.Policies.MobileAppManagementPolicies.Item.IncludedGroups.Item.Ref
{
    /// <summary>
    /// Provides operations to manage the collection of policyRoot entities.
    /// </summary>
    public class RefRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete a group from the list of groups included in a mobile app management policy.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/mobileappmanagementpolicies-delete-includedgroups?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete a group from the list of groups included in a mobile app management policy.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/mobileappmanagementpolicies-delete-includedgroups?view=graph-rest-beta";
            var mobilityManagementPolicyIdOption = new Option<string>("--mobility-management-policy-id", description: "The unique identifier of mobilityManagementPolicy") {
            };
            mobilityManagementPolicyIdOption.IsRequired = true;
            command.AddOption(mobilityManagementPolicyIdOption);
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var mobilityManagementPolicyId = invocationContext.ParseResult.GetValueForOption(mobilityManagementPolicyIdOption);
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (mobilityManagementPolicyId is not null) requestInfo.PathParameters.Add("mobilityManagementPolicy%2Did", mobilityManagementPolicyId);
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
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
        /// Instantiates a new <see cref="RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RefRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/policies/mobileAppManagementPolicies/{mobilityManagementPolicy%2Did}/includedGroups/{group%2Did}/$ref", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefRequestBuilder(string rawUrl) : base("{+baseurl}/policies/mobileAppManagementPolicies/{mobilityManagementPolicy%2Did}/includedGroups/{group%2Did}/$ref", rawUrl)
        {
        }
        /// <summary>
        /// Delete a group from the list of groups included in a mobile app management policy.
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
    }
}
