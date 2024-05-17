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
namespace ApiSdk.Print.Printers.Item.GetCapabilities {
    /// <summary>
    /// Provides operations to call the getCapabilities method.
    /// </summary>
    public class GetCapabilitiesRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Get a list of capabilities for the printer.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/printer-getcapabilities?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        [Obsolete("The getCapabilities API is deprecated and will stop returning data on July 31, 2023. Please use the capabilities property instead of this. as of 2023-06/Tasks_And_Plans")]
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get a list of capabilities for the printer.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/printer-getcapabilities?view=graph-rest-beta";
            var printerIdOption = new Option<string>("--printer-id", description: "The unique identifier of printer") {
            };
            printerIdOption.IsRequired = true;
            command.AddOption(printerIdOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var printerId = invocationContext.ParseResult.GetValueForOption(printerIdOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (printerId is not null) requestInfo.PathParameters.Add("printer%2Did", printerId);
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
        /// Instantiates a new <see cref="GetCapabilitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GetCapabilitiesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/printers/{printer%2Did}/getCapabilities()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GetCapabilitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetCapabilitiesRequestBuilder(string rawUrl) : base("{+baseurl}/print/printers/{printer%2Did}/getCapabilities()", rawUrl)
        {
        }
        /// <summary>
        /// Get a list of capabilities for the printer.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The getCapabilities API is deprecated and will stop returning data on July 31, 2023. Please use the capabilities property instead of this. as of 2023-06/Tasks_And_Plans")]
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
