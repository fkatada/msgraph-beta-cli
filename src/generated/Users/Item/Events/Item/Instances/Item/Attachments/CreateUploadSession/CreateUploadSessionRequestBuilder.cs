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
namespace ApiSdk.Users.Item.Events.Item.Instances.Item.Attachments.CreateUploadSession {
    /// <summary>
    /// Provides operations to call the createUploadSession method.
    /// </summary>
    public class CreateUploadSessionRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item. The item can be a message or event. Use this approach to attach a file if the file size is between 3 MB and 150 MB. To attach a file that&apos;s smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.  As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries. Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded. This allows transfer to be resumed, in case the network connection is dropped during upload.  The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/attachment-createuploadsession?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item. The item can be a message or event. Use this approach to attach a file if the file size is between 3 MB and 150 MB. To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.  As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries. Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded. This allows transfer to be resumed, in case the network connection is dropped during upload.  The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/attachment-createuploadsession?view=graph-rest-1.0";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var eventIdOption = new Option<string>("--event-id", description: "The unique identifier of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var eventId1Option = new Option<string>("--event-id1", description: "The unique identifier of event") {
            };
            eventId1Option.IsRequired = true;
            command.AddOption(eventId1Option);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var eventId = invocationContext.ParseResult.GetValueForOption(eventIdOption);
                var eventId1 = invocationContext.ParseResult.GetValueForOption(eventId1Option);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<CreateUploadSessionPostRequestBody>(CreateUploadSessionPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (eventId is not null) requestInfo.PathParameters.Add("event%2Did", eventId);
                if (eventId1 is not null) requestInfo.PathParameters.Add("event%2Did1", eventId1);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new CreateUploadSessionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CreateUploadSessionRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/events/{event%2Did}/instances/{event%2Did1}/attachments/createUploadSession", pathParameters) {
        }
        /// <summary>
        /// Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item. The item can be a message or event. Use this approach to attach a file if the file size is between 3 MB and 150 MB. To attach a file that&apos;s smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.  As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries. Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded. This allows transfer to be resumed, in case the network connection is dropped during upload.  The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateUploadSessionPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateUploadSessionPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
    }
}
