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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackages.Item.IncompatibleAccessPackages.Item.Ref
{
    /// <summary>
    /// Provides operations to manage the collection of identityGovernance entities.
    /// </summary>
    public class RefRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Remove an access package from the list of access packages marked as incompatible on an accessPackage.  
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackage-delete-incompatibleaccesspackage?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Remove an access package from the list of access packages marked as incompatible on an accessPackage.  \n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accesspackage-delete-incompatibleaccesspackage?view=graph-rest-beta";
            var accessPackageIdOption = new Option<string>("--access-package-id", description: "The unique identifier of accessPackage") {
            };
            accessPackageIdOption.IsRequired = true;
            command.AddOption(accessPackageIdOption);
            var accessPackageId1Option = new Option<string>("--access-package-id1", description: "The unique identifier of accessPackage") {
            };
            accessPackageId1Option.IsRequired = true;
            command.AddOption(accessPackageId1Option);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageId = invocationContext.ParseResult.GetValueForOption(accessPackageIdOption);
                var accessPackageId1 = invocationContext.ParseResult.GetValueForOption(accessPackageId1Option);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (accessPackageId is not null) requestInfo.PathParameters.Add("accessPackage%2Did", accessPackageId);
                if (accessPackageId1 is not null) requestInfo.PathParameters.Add("accessPackage%2Did1", accessPackageId1);
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
        public RefRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackages/{accessPackage%2Did}/incompatibleAccessPackages/{accessPackage%2Did1}/$ref", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RefRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RefRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackages/{accessPackage%2Did}/incompatibleAccessPackages/{accessPackage%2Did1}/$ref", rawUrl)
        {
        }
        /// <summary>
        /// Remove an access package from the list of access packages marked as incompatible on an accessPackage.  
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
