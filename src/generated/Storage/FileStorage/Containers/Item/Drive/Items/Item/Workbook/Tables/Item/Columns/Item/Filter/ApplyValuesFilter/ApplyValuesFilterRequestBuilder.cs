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
namespace ApiSdk.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyValuesFilter
{
    /// <summary>
    /// Provides operations to call the applyValuesFilter method.
    /// </summary>
    public class ApplyValuesFilterRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke action applyValuesFilter
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Invoke action applyValuesFilter";
            var fileStorageContainerIdOption = new Option<string>("--file-storage-container-id", description: "The unique identifier of fileStorageContainer") {
            };
            fileStorageContainerIdOption.IsRequired = true;
            command.AddOption(fileStorageContainerIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var workbookTableIdOption = new Option<string>("--workbook-table-id", description: "The unique identifier of workbookTable") {
            };
            workbookTableIdOption.IsRequired = true;
            command.AddOption(workbookTableIdOption);
            var workbookTableColumnIdOption = new Option<string>("--workbook-table-column-id", description: "The unique identifier of workbookTableColumn") {
            };
            workbookTableColumnIdOption.IsRequired = true;
            command.AddOption(workbookTableColumnIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var fileStorageContainerId = invocationContext.ParseResult.GetValueForOption(fileStorageContainerIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var workbookTableId = invocationContext.ParseResult.GetValueForOption(workbookTableIdOption);
                var workbookTableColumnId = invocationContext.ParseResult.GetValueForOption(workbookTableColumnIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApplyValuesFilterPostRequestBody>(ApplyValuesFilterPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (fileStorageContainerId is not null) requestInfo.PathParameters.Add("fileStorageContainer%2Did", fileStorageContainerId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
                if (workbookTableId is not null) requestInfo.PathParameters.Add("workbookTable%2Did", workbookTableId);
                if (workbookTableColumnId is not null) requestInfo.PathParameters.Add("workbookTableColumn%2Did", workbookTableColumnId);
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
        /// Instantiates a new <see cref="ApplyValuesFilterRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ApplyValuesFilterRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/filter/applyValuesFilter", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ApplyValuesFilterRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ApplyValuesFilterRequestBuilder(string rawUrl) : base("{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/tables/{workbookTable%2Did}/columns/{workbookTableColumn%2Did}/filter/applyValuesFilter", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action applyValuesFilter
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ApplyValuesFilterPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ApplyValuesFilterPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
