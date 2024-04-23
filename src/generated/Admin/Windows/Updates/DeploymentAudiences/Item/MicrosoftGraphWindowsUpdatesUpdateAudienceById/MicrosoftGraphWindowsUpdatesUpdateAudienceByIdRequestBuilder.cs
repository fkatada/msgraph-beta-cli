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
namespace ApiSdk.Admin.Windows.Updates.DeploymentAudiences.Item.MicrosoftGraphWindowsUpdatesUpdateAudienceById {
    /// <summary>
    /// Provides operations to call the updateAudienceById method.
    /// </summary>
    public class MicrosoftGraphWindowsUpdatesUpdateAudienceByIdRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Update the members and exclusions collections of a deploymentAudience with updatableAsset resources of the same type. Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates a Microsoft Entra device object if it does not already exist. If the same updatableAsset gets included in the exclusions and members collections of a deploymentAudience, deployment will not apply to that asset. You can also use the method updateAudience to update the deploymentAudience.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/windowsupdates-deploymentaudience-updateaudiencebyid?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Update the members and exclusions collections of a deploymentAudience with updatableAsset resources of the same type. Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates a Microsoft Entra device object if it does not already exist. If the same updatableAsset gets included in the exclusions and members collections of a deploymentAudience, deployment will not apply to that asset. You can also use the method updateAudience to update the deploymentAudience.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/windowsupdates-deploymentaudience-updateaudiencebyid?view=graph-rest-1.0";
            var deploymentAudienceIdOption = new Option<string>("--deployment-audience-id", description: "The unique identifier of deploymentAudience") {
            };
            deploymentAudienceIdOption.IsRequired = true;
            command.AddOption(deploymentAudienceIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var deploymentAudienceId = invocationContext.ParseResult.GetValueForOption(deploymentAudienceIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<UpdateAudienceByIdPostRequestBody>(UpdateAudienceByIdPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (deploymentAudienceId is not null) requestInfo.PathParameters.Add("deploymentAudience%2Did", deploymentAudienceId);
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
        /// Instantiates a new <see cref="MicrosoftGraphWindowsUpdatesUpdateAudienceByIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphWindowsUpdatesUpdateAudienceByIdRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/admin/windows/updates/deploymentAudiences/{deploymentAudience%2Did}/microsoft.graph.windowsUpdates.updateAudienceById", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphWindowsUpdatesUpdateAudienceByIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphWindowsUpdatesUpdateAudienceByIdRequestBuilder(string rawUrl) : base("{+baseurl}/admin/windows/updates/deploymentAudiences/{deploymentAudience%2Did}/microsoft.graph.windowsUpdates.updateAudienceById", rawUrl)
        {
        }
        /// <summary>
        /// Update the members and exclusions collections of a deploymentAudience with updatableAsset resources of the same type. Adding an azureADDevice to the members or exclusions collections of a deployment audience automatically creates a Microsoft Entra device object if it does not already exist. If the same updatableAsset gets included in the exclusions and members collections of a deploymentAudience, deployment will not apply to that asset. You can also use the method updateAudience to update the deploymentAudience.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(UpdateAudienceByIdPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(UpdateAudienceByIdPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
