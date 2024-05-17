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
namespace ApiSdk.TenantRelationships.FindTenantInformationByDomainNameWithDomainName {
    /// <summary>
    /// Provides operations to call the findTenantInformationByDomainName method.
    /// </summary>
    public class FindTenantInformationByDomainNameWithDomainNameRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Given a domain name, search for a tenant and read its tenantInformation. You can use this API to validate tenant information and use their tenantId to configure cross-tenant access settings between you and the tenant.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/tenantrelationship-findtenantinformationbydomainname?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Given a domain name, search for a tenant and read its tenantInformation. You can use this API to validate tenant information and use their tenantId to configure cross-tenant access settings between you and the tenant.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/tenantrelationship-findtenantinformationbydomainname?view=graph-rest-beta";
            var domainNameOption = new Option<string>("--domain-name", description: "Usage: domainName='{domainName}'") {
            };
            domainNameOption.IsRequired = true;
            command.AddOption(domainNameOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var domainName = invocationContext.ParseResult.GetValueForOption(domainNameOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (domainName is not null) requestInfo.PathParameters.Add("domainName", domainName);
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
        /// Instantiates a new <see cref="FindTenantInformationByDomainNameWithDomainNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public FindTenantInformationByDomainNameWithDomainNameRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/tenantRelationships/findTenantInformationByDomainName(domainName='{domainName}')", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="FindTenantInformationByDomainNameWithDomainNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public FindTenantInformationByDomainNameWithDomainNameRequestBuilder(string rawUrl) : base("{+baseurl}/tenantRelationships/findTenantInformationByDomainName(domainName='{domainName}')", rawUrl)
        {
        }
        /// <summary>
        /// Given a domain name, search for a tenant and read its tenantInformation. You can use this API to validate tenant information and use their tenantId to configure cross-tenant access settings between you and the tenant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
