// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Organization.Item.Branding.Localizations.Item.BackgroundImage;
using ApiSdk.Organization.Item.Branding.Localizations.Item.BannerLogo;
using ApiSdk.Organization.Item.Branding.Localizations.Item.CustomCSS;
using ApiSdk.Organization.Item.Branding.Localizations.Item.Favicon;
using ApiSdk.Organization.Item.Branding.Localizations.Item.HeaderLogo;
using ApiSdk.Organization.Item.Branding.Localizations.Item.SquareLogo;
using ApiSdk.Organization.Item.Branding.Localizations.Item.SquareLogoDark;
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
namespace ApiSdk.Organization.Item.Branding.Localizations.Item
{
    /// <summary>
    /// Provides operations to manage the localizations property of the microsoft.graph.organizationalBranding entity.
    /// </summary>
    public class OrganizationalBrandingLocalizationItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildBackgroundImageNavCommand()
        {
            var command = new Command("background-image");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new BackgroundImageRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildBannerLogoNavCommand()
        {
            var command = new Command("banner-logo");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new BannerLogoRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCustomCSSNavCommand()
        {
            var command = new Command("custom-c-s-s");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new CustomCSSRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete a localized branding object. To delete the organizationalBrandingLocalization object, all images (Stream types) must first be removed from the object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-delete?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete a localized branding object. To delete the organizationalBrandingLocalization object, all images (Stream types) must first be removed from the object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-delete?view=graph-rest-beta";
            var organizationIdOption = new Option<string>("--organization-id", description: "The unique identifier of organization") {
            };
            organizationIdOption.IsRequired = true;
            command.AddOption(organizationIdOption);
            var organizationalBrandingLocalizationIdOption = new Option<string>("--organizational-branding-localization-id", description: "The unique identifier of organizationalBrandingLocalization") {
            };
            organizationalBrandingLocalizationIdOption.IsRequired = true;
            command.AddOption(organizationalBrandingLocalizationIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var organizationId = invocationContext.ParseResult.GetValueForOption(organizationIdOption);
                var organizationalBrandingLocalizationId = invocationContext.ParseResult.GetValueForOption(organizationalBrandingLocalizationIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (organizationId is not null) requestInfo.PathParameters.Add("organization%2Did", organizationId);
                if (organizationalBrandingLocalizationId is not null) requestInfo.PathParameters.Add("organizationalBrandingLocalization%2Did", organizationalBrandingLocalizationId);
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
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildFaviconNavCommand()
        {
            var command = new Command("favicon");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new FaviconRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Read the properties and relationships of an organizationalBrandingLocalization object. To retrieve a localization branding object, specify the value of id in the URL.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Read the properties and relationships of an organizationalBrandingLocalization object. To retrieve a localization branding object, specify the value of id in the URL.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-get?view=graph-rest-beta";
            var organizationIdOption = new Option<string>("--organization-id", description: "The unique identifier of organization") {
            };
            organizationIdOption.IsRequired = true;
            command.AddOption(organizationIdOption);
            var organizationalBrandingLocalizationIdOption = new Option<string>("--organizational-branding-localization-id", description: "The unique identifier of organizationalBrandingLocalization") {
            };
            organizationalBrandingLocalizationIdOption.IsRequired = true;
            command.AddOption(organizationalBrandingLocalizationIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var organizationId = invocationContext.ParseResult.GetValueForOption(organizationIdOption);
                var organizationalBrandingLocalizationId = invocationContext.ParseResult.GetValueForOption(organizationalBrandingLocalizationIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (organizationId is not null) requestInfo.PathParameters.Add("organization%2Did", organizationId);
                if (organizationalBrandingLocalizationId is not null) requestInfo.PathParameters.Add("organizationalBrandingLocalization%2Did", organizationalBrandingLocalizationId);
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
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildHeaderLogoNavCommand()
        {
            var command = new Command("header-logo");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new HeaderLogoRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the properties of an organizationalBrandingLocalization object for a specific localization.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the properties of an organizationalBrandingLocalization object for a specific localization.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-update?view=graph-rest-beta";
            var organizationIdOption = new Option<string>("--organization-id", description: "The unique identifier of organization") {
            };
            organizationIdOption.IsRequired = true;
            command.AddOption(organizationIdOption);
            var organizationalBrandingLocalizationIdOption = new Option<string>("--organizational-branding-localization-id", description: "The unique identifier of organizationalBrandingLocalization") {
            };
            organizationalBrandingLocalizationIdOption.IsRequired = true;
            command.AddOption(organizationalBrandingLocalizationIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var organizationId = invocationContext.ParseResult.GetValueForOption(organizationIdOption);
                var organizationalBrandingLocalizationId = invocationContext.ParseResult.GetValueForOption(organizationalBrandingLocalizationIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<OrganizationalBrandingLocalization>(OrganizationalBrandingLocalization.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (organizationId is not null) requestInfo.PathParameters.Add("organization%2Did", organizationId);
                if (organizationalBrandingLocalizationId is not null) requestInfo.PathParameters.Add("organizationalBrandingLocalization%2Did", organizationalBrandingLocalizationId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSquareLogoDarkNavCommand()
        {
            var command = new Command("square-logo-dark");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new SquareLogoDarkRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSquareLogoNavCommand()
        {
            var command = new Command("square-logo");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new SquareLogoRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="OrganizationalBrandingLocalizationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public OrganizationalBrandingLocalizationItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/organization/{organization%2Did}/branding/localizations/{organizationalBrandingLocalization%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="OrganizationalBrandingLocalizationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OrganizationalBrandingLocalizationItemRequestBuilder(string rawUrl) : base("{+baseurl}/organization/{organization%2Did}/branding/localizations/{organizationalBrandingLocalization%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a localized branding object. To delete the organizationalBrandingLocalization object, all images (Stream types) must first be removed from the object.
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
        /// <summary>
        /// Read the properties and relationships of an organizationalBrandingLocalization object. To retrieve a localization branding object, specify the value of id in the URL.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of an organizationalBrandingLocalization object for a specific localization.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(OrganizationalBrandingLocalization body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(OrganizationalBrandingLocalization body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of an organizationalBrandingLocalization object. To retrieve a localization branding object, specify the value of id in the URL.
        /// </summary>
        public class OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
