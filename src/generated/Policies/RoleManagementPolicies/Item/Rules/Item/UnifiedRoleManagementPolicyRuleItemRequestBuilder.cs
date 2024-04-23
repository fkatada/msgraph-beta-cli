// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.Policies.RoleManagementPolicies.Item.Rules.Item {
    /// <summary>
    /// Provides operations to manage the rules property of the microsoft.graph.unifiedRoleManagementPolicy entity.
    /// </summary>
    public class UnifiedRoleManagementPolicyRuleItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Delete navigation property rules for policies
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property rules for policies";
            var unifiedRoleManagementPolicyIdOption = new Option<string>("--unified-role-management-policy-id", description: "The unique identifier of unifiedRoleManagementPolicy") {
            };
            unifiedRoleManagementPolicyIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementPolicyIdOption);
            var unifiedRoleManagementPolicyRuleIdOption = new Option<string>("--unified-role-management-policy-rule-id", description: "The unique identifier of unifiedRoleManagementPolicyRule") {
            };
            unifiedRoleManagementPolicyRuleIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementPolicyRuleIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRoleManagementPolicyId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementPolicyIdOption);
                var unifiedRoleManagementPolicyRuleId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementPolicyRuleIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (unifiedRoleManagementPolicyId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementPolicy%2Did", unifiedRoleManagementPolicyId);
                if (unifiedRoleManagementPolicyRuleId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementPolicyRule%2Did", unifiedRoleManagementPolicyRuleId);
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
        /// Retrieve a rule defined for a role management policy. The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object:
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/unifiedrolemanagementpolicyrule-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Retrieve a rule defined for a role management policy. The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object:\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/unifiedrolemanagementpolicyrule-get?view=graph-rest-1.0";
            var unifiedRoleManagementPolicyIdOption = new Option<string>("--unified-role-management-policy-id", description: "The unique identifier of unifiedRoleManagementPolicy") {
            };
            unifiedRoleManagementPolicyIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementPolicyIdOption);
            var unifiedRoleManagementPolicyRuleIdOption = new Option<string>("--unified-role-management-policy-rule-id", description: "The unique identifier of unifiedRoleManagementPolicyRule") {
            };
            unifiedRoleManagementPolicyRuleIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementPolicyRuleIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRoleManagementPolicyId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementPolicyIdOption);
                var unifiedRoleManagementPolicyRuleId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementPolicyRuleIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (unifiedRoleManagementPolicyId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementPolicy%2Did", unifiedRoleManagementPolicyId);
                if (unifiedRoleManagementPolicyRuleId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementPolicyRule%2Did", unifiedRoleManagementPolicyRuleId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Update a rule defined for a role management policy. The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object: For more information about rules for Microsoft Entra roles and examples of updating rules, see the following articles:+ Overview of rules for Microsoft Entra roles in PIM APIs in Microsoft Graph+ Use PIM APIs in Microsoft Graph to update Microsoft Entra ID rules
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/unifiedrolemanagementpolicyrule-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update a rule defined for a role management policy. The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object: For more information about rules for Microsoft Entra roles and examples of updating rules, see the following articles:+ Overview of rules for Microsoft Entra roles in PIM APIs in Microsoft Graph+ Use PIM APIs in Microsoft Graph to update Microsoft Entra ID rules\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/unifiedrolemanagementpolicyrule-update?view=graph-rest-1.0";
            var unifiedRoleManagementPolicyIdOption = new Option<string>("--unified-role-management-policy-id", description: "The unique identifier of unifiedRoleManagementPolicy") {
            };
            unifiedRoleManagementPolicyIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementPolicyIdOption);
            var unifiedRoleManagementPolicyRuleIdOption = new Option<string>("--unified-role-management-policy-rule-id", description: "The unique identifier of unifiedRoleManagementPolicyRule") {
            };
            unifiedRoleManagementPolicyRuleIdOption.IsRequired = true;
            command.AddOption(unifiedRoleManagementPolicyRuleIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var unifiedRoleManagementPolicyId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementPolicyIdOption);
                var unifiedRoleManagementPolicyRuleId = invocationContext.ParseResult.GetValueForOption(unifiedRoleManagementPolicyRuleIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<UnifiedRoleManagementPolicyRule>(UnifiedRoleManagementPolicyRule.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (unifiedRoleManagementPolicyId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementPolicy%2Did", unifiedRoleManagementPolicyId);
                if (unifiedRoleManagementPolicyRuleId is not null) requestInfo.PathParameters.Add("unifiedRoleManagementPolicyRule%2Did", unifiedRoleManagementPolicyRuleId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="UnifiedRoleManagementPolicyRuleItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UnifiedRoleManagementPolicyRuleItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/policies/roleManagementPolicies/{unifiedRoleManagementPolicy%2Did}/rules/{unifiedRoleManagementPolicyRule%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="UnifiedRoleManagementPolicyRuleItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UnifiedRoleManagementPolicyRuleItemRequestBuilder(string rawUrl) : base("{+baseurl}/policies/roleManagementPolicies/{unifiedRoleManagementPolicy%2Did}/rules/{unifiedRoleManagementPolicyRule%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property rules for policies
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/policies/roleManagementPolicies/{unifiedRoleManagementPolicy%2Did}/rules/{unifiedRoleManagementPolicyRule%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve a rule defined for a role management policy. The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object:
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UnifiedRoleManagementPolicyRuleItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UnifiedRoleManagementPolicyRuleItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update a rule defined for a role management policy. The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object: For more information about rules for Microsoft Entra roles and examples of updating rules, see the following articles:+ Overview of rules for Microsoft Entra roles in PIM APIs in Microsoft Graph+ Use PIM APIs in Microsoft Graph to update Microsoft Entra ID rules
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(UnifiedRoleManagementPolicyRule body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(UnifiedRoleManagementPolicyRule body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/policies/roleManagementPolicies/{unifiedRoleManagementPolicy%2Did}/rules/{unifiedRoleManagementPolicyRule%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve a rule defined for a role management policy. The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object:
        /// </summary>
        public class UnifiedRoleManagementPolicyRuleItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
