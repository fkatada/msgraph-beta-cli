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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceRole.AccessPackageResource.AccessPackageResourceScopes.Item.AccessPackageResource.AccessPackageResourceRoles.Count
{
    /// <summary>
    /// Provides operations to count the resources in the collection.
    /// </summary>
    public class CountRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the number of the resource";
            var accessPackageAssignmentIdOption = new Option<string>("--access-package-assignment-id", description: "The unique identifier of accessPackageAssignment") {
            };
            accessPackageAssignmentIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentIdOption);
            var accessPackageResourceRoleScopeIdOption = new Option<string>("--access-package-resource-role-scope-id", description: "The unique identifier of accessPackageResourceRoleScope") {
            };
            accessPackageResourceRoleScopeIdOption.IsRequired = true;
            command.AddOption(accessPackageResourceRoleScopeIdOption);
            var accessPackageResourceScopeIdOption = new Option<string>("--access-package-resource-scope-id", description: "The unique identifier of accessPackageResourceScope") {
            };
            accessPackageResourceScopeIdOption.IsRequired = true;
            command.AddOption(accessPackageResourceScopeIdOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageAssignmentId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentIdOption);
                var accessPackageResourceRoleScopeId = invocationContext.ParseResult.GetValueForOption(accessPackageResourceRoleScopeIdOption);
                var accessPackageResourceScopeId = invocationContext.ParseResult.GetValueForOption(accessPackageResourceScopeIdOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                });
                if (accessPackageAssignmentId is not null) requestInfo.PathParameters.Add("accessPackageAssignment%2Did", accessPackageAssignmentId);
                if (accessPackageResourceRoleScopeId is not null) requestInfo.PathParameters.Add("accessPackageResourceRoleScope%2Did", accessPackageResourceRoleScopeId);
                if (accessPackageResourceScopeId is not null) requestInfo.PathParameters.Add("accessPackageResourceScope%2Did", accessPackageResourceScopeId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                var formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CountRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackage/accessPackageResourceRoleScopes/{accessPackageResourceRoleScope%2Did}/accessPackageResourceRole/accessPackageResource/accessPackageResourceScopes/{accessPackageResourceScope%2Did}/accessPackageResource/accessPackageResourceRoles/$count{?%24filter,%24search}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CountRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackage/accessPackageResourceRoleScopes/{accessPackageResourceRoleScope%2Did}/accessPackageResourceRole/accessPackageResource/accessPackageResourceScopes/{accessPackageResourceScope%2Did}/accessPackageResource/accessPackageResourceRoles/$count{?%24filter,%24search}", rawUrl)
        {
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CountRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CountRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "text/plain;q=0.9");
            return requestInfo;
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        public class CountRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
        }
    }
}
