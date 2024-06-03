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
namespace ApiSdk.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn
{
    /// <summary>
    /// Provides operations to call the cell method.
    /// </summary>
    public class CellWithRowWithColumnRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Gets the range object containing the single cell based on row and column numbers. The cell can be outside the bounds of its parent range, so long as it&apos;s stays within the worksheet grid.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/worksheet-cell?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Gets the range object containing the single cell based on row and column numbers. The cell can be outside the bounds of its parent range, so long as it's stays within the worksheet grid.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/worksheet-cell?view=graph-rest-beta";
            var fileStorageContainerIdOption = new Option<string>("--file-storage-container-id", description: "The unique identifier of fileStorageContainer") {
            };
            fileStorageContainerIdOption.IsRequired = true;
            command.AddOption(fileStorageContainerIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookWorksheetIdOption = new Option<string>("--workbook-worksheet-id", description: "The unique identifier of workbookWorksheet") {
            };
            workbookWorksheetIdOption.IsRequired = true;
            command.AddOption(workbookWorksheetIdOption);
            var rowOption = new Option<int?>("--row", description: "Usage: row={row}") {
            };
            rowOption.IsRequired = true;
            command.AddOption(rowOption);
            var columnOption = new Option<int?>("--column", description: "Usage: column={column}") {
            };
            columnOption.IsRequired = true;
            command.AddOption(columnOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var fileStorageContainerId = invocationContext.ParseResult.GetValueForOption(fileStorageContainerIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var workbookWorksheetId = invocationContext.ParseResult.GetValueForOption(workbookWorksheetIdOption);
                var row = invocationContext.ParseResult.GetValueForOption(rowOption);
                var column = invocationContext.ParseResult.GetValueForOption(columnOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (fileStorageContainerId is not null) requestInfo.PathParameters.Add("fileStorageContainer%2Did", fileStorageContainerId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                if (workbookWorksheetId is not null) requestInfo.PathParameters.Add("workbookWorksheet%2Did", workbookWorksheetId);
                if (row is not null) requestInfo.PathParameters.Add("row", row);
                if (column is not null) requestInfo.PathParameters.Add("column", column);
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
        /// Instantiates a new <see cref="CellWithRowWithColumnRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CellWithRowWithColumnRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/cell(row={row},column={column})", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CellWithRowWithColumnRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CellWithRowWithColumnRequestBuilder(string rawUrl) : base("{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/cell(row={row},column={column})", rawUrl)
        {
        }
        /// <summary>
        /// Gets the range object containing the single cell based on row and column numbers. The cell can be outside the bounds of its parent range, so long as it&apos;s stays within the worksheet grid.
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
