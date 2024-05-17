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
namespace ApiSdk.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Members.Item.MicrosoftGraphWindowsUpdatesAddMembers {
    /// <summary>
    /// Provides operations to call the addMembers method.
    /// </summary>
    public class MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Add members to an updatableAssetGroup. You can add azureADDevice resources as members, but may not add updatableAssetGroup resources as members. Adding a Microsoft Entra device as a member of an updatable asset group automatically creates an azureADDevice object, if it does not already exist. You can also use the method addMembersById to add members.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/windowsupdates-updatableassetgroup-addmembers?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Add members to an updatableAssetGroup. You can add azureADDevice resources as members, but may not add updatableAssetGroup resources as members. Adding a Microsoft Entra device as a member of an updatable asset group automatically creates an azureADDevice object, if it does not already exist. You can also use the method addMembersById to add members.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/windowsupdates-updatableassetgroup-addmembers?view=graph-rest-beta";
            var updatePolicyIdOption = new Option<string>("--update-policy-id", description: "The unique identifier of updatePolicy") {
            };
            updatePolicyIdOption.IsRequired = true;
            command.AddOption(updatePolicyIdOption);
            var updatableAssetIdOption = new Option<string>("--updatable-asset-id", description: "The unique identifier of updatableAsset") {
            };
            updatableAssetIdOption.IsRequired = true;
            command.AddOption(updatableAssetIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var updatePolicyId = invocationContext.ParseResult.GetValueForOption(updatePolicyIdOption);
                var updatableAssetId = invocationContext.ParseResult.GetValueForOption(updatableAssetIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AddMembersPostRequestBody>(AddMembersPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (updatePolicyId is not null) requestInfo.PathParameters.Add("updatePolicy%2Did", updatePolicyId);
                if (updatableAssetId is not null) requestInfo.PathParameters.Add("updatableAsset%2Did", updatableAssetId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new <see cref="MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/admin/windows/updates/updatePolicies/{updatePolicy%2Did}/audience/members/{updatableAsset%2Did}/microsoft.graph.windowsUpdates.addMembers", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder(string rawUrl) : base("{+baseurl}/admin/windows/updates/updatePolicies/{updatePolicy%2Did}/audience/members/{updatableAsset%2Did}/microsoft.graph.windowsUpdates.addMembers", rawUrl)
        {
        }
        /// <summary>
        /// Add members to an updatableAssetGroup. You can add azureADDevice resources as members, but may not add updatableAssetGroup resources as members. Adding a Microsoft Entra device as a member of an updatable asset group automatically creates an azureADDevice object, if it does not already exist. You can also use the method addMembersById to add members.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AddMembersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AddMembersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
