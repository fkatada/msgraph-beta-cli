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
namespace ApiSdk.DeviceManagement.ReusablePolicySettings.Item.ReferencingConfigurationPolicies.Item.Reorder
{
    /// <summary>
    /// Provides operations to call the reorder method.
    /// </summary>
    public class ReorderRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action reorder
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action reorder";
            var deviceManagementReusablePolicySettingIdOption = new Option<string>("--device-management-reusable-policy-setting-id", description: "The unique identifier of deviceManagementReusablePolicySetting") {
            };
            deviceManagementReusablePolicySettingIdOption.IsRequired = true;
            command.AddOption(deviceManagementReusablePolicySettingIdOption);
            var deviceManagementConfigurationPolicyIdOption = new Option<string>("--device-management-configuration-policy-id", description: "The unique identifier of deviceManagementConfigurationPolicy") {
            };
            deviceManagementConfigurationPolicyIdOption.IsRequired = true;
            command.AddOption(deviceManagementConfigurationPolicyIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var deviceManagementReusablePolicySettingId = invocationContext.ParseResult.GetValueForOption(deviceManagementReusablePolicySettingIdOption);
                var deviceManagementConfigurationPolicyId = invocationContext.ParseResult.GetValueForOption(deviceManagementConfigurationPolicyIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ReorderPostRequestBody>(ReorderPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (deviceManagementReusablePolicySettingId is not null) requestInfo.PathParameters.Add("deviceManagementReusablePolicySetting%2Did", deviceManagementReusablePolicySettingId);
                if (deviceManagementConfigurationPolicyId is not null) requestInfo.PathParameters.Add("deviceManagementConfigurationPolicy%2Did", deviceManagementConfigurationPolicyId);
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
        /// Instantiates a new <see cref="ReorderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ReorderRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/reusablePolicySettings/{deviceManagementReusablePolicySetting%2Did}/referencingConfigurationPolicies/{deviceManagementConfigurationPolicy%2Did}/reorder", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ReorderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ReorderRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/reusablePolicySettings/{deviceManagementReusablePolicySetting%2Did}/referencingConfigurationPolicies/{deviceManagementConfigurationPolicy%2Did}/reorder", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action reorder
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ReorderPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ReorderPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
