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
namespace ApiSdk.Reports.GetM365AppUserCountsWithPeriod
{
    /// <summary>
    /// Provides operations to call the getM365AppUserCounts method.
    /// </summary>
    public class GetM365AppUserCountsWithPeriodRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Get a report that provides the trend in the number of active users for each app (Outlook, Word, Excel, PowerPoint, OneNote, and Teams) in your organization.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/reportroot-getm365appusercounts?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get a report that provides the trend in the number of active users for each app (Outlook, Word, Excel, PowerPoint, OneNote, and Teams) in your organization.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/reportroot-getm365appusercounts?view=graph-rest-beta";
            var periodOption = new Option<string>("--period", description: "Usage: period='{period}'") {
            };
            periodOption.IsRequired = true;
            command.AddOption(periodOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var period = invocationContext.ParseResult.GetValueForOption(periodOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (period is not null) requestInfo.PathParameters.Add("period", period);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="GetM365AppUserCountsWithPeriodRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GetM365AppUserCountsWithPeriodRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/reports/getM365AppUserCounts(period='{period}')", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GetM365AppUserCountsWithPeriodRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetM365AppUserCountsWithPeriodRequestBuilder(string rawUrl) : base("{+baseurl}/reports/getM365AppUserCounts(period='{period}')", rawUrl)
        {
        }
        /// <summary>
        /// Get a report that provides the trend in the number of active users for each app (Outlook, Word, Excel, PowerPoint, OneNote, and Teams) in your organization.
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
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream, application/json");
            return requestInfo;
        }
    }
}
