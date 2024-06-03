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
namespace ApiSdk.Compliance.Ediscovery.Cases.Item.Custodians.Item.MicrosoftGraphEdiscoveryApplyHold
{
    /// <summary>
    /// Provides operations to call the applyHold method.
    /// </summary>
    public class MicrosoftGraphEdiscoveryApplyHoldRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action applyHold
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action applyHold";
            var caseIdOption = new Option<string>("--case-id", description: "The unique identifier of case") {
            };
            caseIdOption.IsRequired = true;
            command.AddOption(caseIdOption);
            var custodianIdOption = new Option<string>("--custodian-id", description: "The unique identifier of custodian") {
            };
            custodianIdOption.IsRequired = true;
            command.AddOption(custodianIdOption);
            command.SetHandler(async (invocationContext) => {
                var caseId = invocationContext.ParseResult.GetValueForOption(caseIdOption);
                var custodianId = invocationContext.ParseResult.GetValueForOption(custodianIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (caseId is not null) requestInfo.PathParameters.Add("case%2Did", caseId);
                if (custodianId is not null) requestInfo.PathParameters.Add("custodian%2Did", custodianId);
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
        /// Instantiates a new <see cref="MicrosoftGraphEdiscoveryApplyHoldRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphEdiscoveryApplyHoldRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/compliance/ediscovery/cases/{case%2Did}/custodians/{custodian%2Did}/microsoft.graph.ediscovery.applyHold", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphEdiscoveryApplyHoldRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphEdiscoveryApplyHoldRequestBuilder(string rawUrl) : base("{+baseurl}/compliance/ediscovery/cases/{case%2Did}/custodians/{custodian%2Did}/microsoft.graph.ediscovery.applyHold", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action applyHold
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
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
