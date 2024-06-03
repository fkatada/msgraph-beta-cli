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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageResources.Item.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceScopes.Item.AccessPackageResource.Refresh
{
    /// <summary>
    /// Provides operations to call the refresh method.
    /// </summary>
    public class RefreshRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// In Microsoft Entra entitlement management, refresh the accessPackageResource object to fetch the latest details for displayName, description, and resourceType from the origin system. For the AadApplication originSystem, this operation also updates the displayName and description for the accessPackageResourceRole. 
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackageresource-refresh?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "In Microsoft Entra entitlement management, refresh the accessPackageResource object to fetch the latest details for displayName, description, and resourceType from the origin system. For the AadApplication originSystem, this operation also updates the displayName and description for the accessPackageResourceRole. \n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accesspackageresource-refresh?view=graph-rest-beta";
            var accessPackageResourceIdOption = new Option<string>("--access-package-resource-id", description: "The unique identifier of accessPackageResource") {
            };
            accessPackageResourceIdOption.IsRequired = true;
            command.AddOption(accessPackageResourceIdOption);
            var accessPackageResourceRoleIdOption = new Option<string>("--access-package-resource-role-id", description: "The unique identifier of accessPackageResourceRole") {
            };
            accessPackageResourceRoleIdOption.IsRequired = true;
            command.AddOption(accessPackageResourceRoleIdOption);
            var accessPackageResourceScopeIdOption = new Option<string>("--access-package-resource-scope-id", description: "The unique identifier of accessPackageResourceScope") {
            };
            accessPackageResourceScopeIdOption.IsRequired = true;
            command.AddOption(accessPackageResourceScopeIdOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageResourceId = invocationContext.ParseResult.GetValueForOption(accessPackageResourceIdOption);
                var accessPackageResourceRoleId = invocationContext.ParseResult.GetValueForOption(accessPackageResourceRoleIdOption);
                var accessPackageResourceScopeId = invocationContext.ParseResult.GetValueForOption(accessPackageResourceScopeIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (accessPackageResourceId is not null) requestInfo.PathParameters.Add("accessPackageResource%2Did", accessPackageResourceId);
                if (accessPackageResourceRoleId is not null) requestInfo.PathParameters.Add("accessPackageResourceRole%2Did", accessPackageResourceRoleId);
                if (accessPackageResourceScopeId is not null) requestInfo.PathParameters.Add("accessPackageResourceScope%2Did", accessPackageResourceScopeId);
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
        /// Instantiates a new <see cref="RefreshRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RefreshRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageResources/{accessPackageResource%2Did}/accessPackageResourceRoles/{accessPackageResourceRole%2Did}/accessPackageResource/accessPackageResourceScopes/{accessPackageResourceScope%2Did}/accessPackageResource/refresh", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RefreshRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefreshRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageResources/{accessPackageResource%2Did}/accessPackageResourceRoles/{accessPackageResourceRole%2Did}/accessPackageResource/accessPackageResourceScopes/{accessPackageResourceScope%2Did}/accessPackageResource/refresh", rawUrl)
        {
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, refresh the accessPackageResource object to fetch the latest details for displayName, description, and resourceType from the origin system. For the AadApplication originSystem, this operation also updates the displayName and description for the accessPackageResourceRole. 
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
