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
namespace ApiSdk.Organization.Item.Branding.Localizations.Item.HeaderLogo {
    /// <summary>
    /// Provides operations to manage the media for the organization entity.
    /// </summary>
    public class HeaderLogoRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Get headerLogo for the navigation property localizations from organization
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/organizationalbranding-list-localizations?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Get headerLogo for the navigation property localizations from organization\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/organizationalbranding-list-localizations?view=graph-rest-1.0";
            var organizationIdOption = new Option<string>("--organization-id", description: "The unique identifier of organization") {
            };
            organizationIdOption.IsRequired = true;
            command.AddOption(organizationIdOption);
            var organizationalBrandingLocalizationIdOption = new Option<string>("--organizational-branding-localization-id", description: "The unique identifier of organizationalBrandingLocalization") {
            };
            organizationalBrandingLocalizationIdOption.IsRequired = true;
            command.AddOption(organizationalBrandingLocalizationIdOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var organizationId = invocationContext.ParseResult.GetValueForOption(organizationIdOption);
                var organizationalBrandingLocalizationId = invocationContext.ParseResult.GetValueForOption(organizationalBrandingLocalizationIdOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (organizationId is not null) requestInfo.PathParameters.Add("organization%2Did", organizationId);
                if (organizationalBrandingLocalizationId is not null) requestInfo.PathParameters.Add("organizationalBrandingLocalization%2Did", organizationalBrandingLocalizationId);
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
        /// Update headerLogo for the navigation property localizations in organization
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "Update headerLogo for the navigation property localizations in organization";
            var organizationIdOption = new Option<string>("--organization-id", description: "The unique identifier of organization") {
            };
            organizationIdOption.IsRequired = true;
            command.AddOption(organizationIdOption);
            var organizationalBrandingLocalizationIdOption = new Option<string>("--organizational-branding-localization-id", description: "The unique identifier of organizationalBrandingLocalization") {
            };
            organizationalBrandingLocalizationIdOption.IsRequired = true;
            command.AddOption(organizationalBrandingLocalizationIdOption);
            var inputFileOption = new Option<FileInfo>("--input-file", description: "Binary request body") {
            };
            inputFileOption.IsRequired = true;
            command.AddOption(inputFileOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var organizationId = invocationContext.ParseResult.GetValueForOption(organizationIdOption);
                var organizationalBrandingLocalizationId = invocationContext.ParseResult.GetValueForOption(organizationalBrandingLocalizationIdOption);
                var inputFile = invocationContext.ParseResult.GetValueForOption(inputFileOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                if (inputFile is null || !inputFile.Exists) return;
                using var stream = inputFile.OpenRead();
                var requestInfo = ToPutRequestInformation(stream, q => {
                });
                if (organizationId is not null) requestInfo.PathParameters.Add("organization%2Did", organizationId);
                if (organizationalBrandingLocalizationId is not null) requestInfo.PathParameters.Add("organizationalBrandingLocalization%2Did", organizationalBrandingLocalizationId);
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
        /// Instantiates a new HeaderLogoRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public HeaderLogoRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/organization/{organization%2Did}/branding/localizations/{organizationalBrandingLocalization%2Did}/headerLogo", pathParameters) {
        }
        /// <summary>
        /// Get headerLogo for the navigation property localizations from organization
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update headerLogo for the navigation property localizations in organization
        /// </summary>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetStreamContent(body);
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
