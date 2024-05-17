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
namespace ApiSdk.Identity.B2cUserFlows.Item.UserAttributeAssignments.SetOrder {
    /// <summary>
    /// Provides operations to call the setOrder method.
    /// </summary>
    public class SetOrderRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Set the order of identityUserFlowAttributeAssignments being collected within a user flow.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/identityuserflowattributeassignment-setorder?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Set the order of identityUserFlowAttributeAssignments being collected within a user flow.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/identityuserflowattributeassignment-setorder?view=graph-rest-beta";
            var b2cIdentityUserFlowIdOption = new Option<string>("--b2c-identity-user-flow-id", description: "The unique identifier of b2cIdentityUserFlow") {
            };
            b2cIdentityUserFlowIdOption.IsRequired = true;
            command.AddOption(b2cIdentityUserFlowIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var b2cIdentityUserFlowId = invocationContext.ParseResult.GetValueForOption(b2cIdentityUserFlowIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<SetOrderPostRequestBody>(SetOrderPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (b2cIdentityUserFlowId is not null) requestInfo.PathParameters.Add("b2cIdentityUserFlow%2Did", b2cIdentityUserFlowId);
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
        /// Instantiates a new <see cref="SetOrderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SetOrderRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identity/b2cUserFlows/{b2cIdentityUserFlow%2Did}/userAttributeAssignments/setOrder", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SetOrderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SetOrderRequestBuilder(string rawUrl) : base("{+baseurl}/identity/b2cUserFlows/{b2cIdentityUserFlow%2Did}/userAttributeAssignments/setOrder", rawUrl)
        {
        }
        /// <summary>
        /// Set the order of identityUserFlowAttributeAssignments being collected within a user flow.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(SetOrderPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(SetOrderPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
