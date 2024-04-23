// <auto-generated/>
using ApiSdk.DeviceManagement.Templates.Item.MigratableTo.Item.Categories.Item.RecommendedSettings;
using ApiSdk.DeviceManagement.Templates.Item.MigratableTo.Item.Categories.Item.SettingDefinitions;
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
namespace ApiSdk.DeviceManagement.Templates.Item.MigratableTo.Item.Categories.Item {
    /// <summary>
    /// Provides operations to manage the categories property of the microsoft.graph.deviceManagementTemplate entity.
    /// </summary>
    public class DeviceManagementTemplateSettingCategoryItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Delete navigation property categories for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property categories for deviceManagement";
            var deviceManagementTemplateIdOption = new Option<string>("--device-management-template-id", description: "The unique identifier of deviceManagementTemplate") {
            };
            deviceManagementTemplateIdOption.IsRequired = true;
            command.AddOption(deviceManagementTemplateIdOption);
            var deviceManagementTemplateId1Option = new Option<string>("--device-management-template-id1", description: "The unique identifier of deviceManagementTemplate") {
            };
            deviceManagementTemplateId1Option.IsRequired = true;
            command.AddOption(deviceManagementTemplateId1Option);
            var deviceManagementTemplateSettingCategoryIdOption = new Option<string>("--device-management-template-setting-category-id", description: "The unique identifier of deviceManagementTemplateSettingCategory") {
            };
            deviceManagementTemplateSettingCategoryIdOption.IsRequired = true;
            command.AddOption(deviceManagementTemplateSettingCategoryIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var deviceManagementTemplateId = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateIdOption);
                var deviceManagementTemplateId1 = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateId1Option);
                var deviceManagementTemplateSettingCategoryId = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateSettingCategoryIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (deviceManagementTemplateId is not null) requestInfo.PathParameters.Add("deviceManagementTemplate%2Did", deviceManagementTemplateId);
                if (deviceManagementTemplateId1 is not null) requestInfo.PathParameters.Add("deviceManagementTemplate%2Did1", deviceManagementTemplateId1);
                if (deviceManagementTemplateSettingCategoryId is not null) requestInfo.PathParameters.Add("deviceManagementTemplateSettingCategory%2Did", deviceManagementTemplateSettingCategoryId);
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
        /// Collection of setting categories within the template
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Collection of setting categories within the template";
            var deviceManagementTemplateIdOption = new Option<string>("--device-management-template-id", description: "The unique identifier of deviceManagementTemplate") {
            };
            deviceManagementTemplateIdOption.IsRequired = true;
            command.AddOption(deviceManagementTemplateIdOption);
            var deviceManagementTemplateId1Option = new Option<string>("--device-management-template-id1", description: "The unique identifier of deviceManagementTemplate") {
            };
            deviceManagementTemplateId1Option.IsRequired = true;
            command.AddOption(deviceManagementTemplateId1Option);
            var deviceManagementTemplateSettingCategoryIdOption = new Option<string>("--device-management-template-setting-category-id", description: "The unique identifier of deviceManagementTemplateSettingCategory") {
            };
            deviceManagementTemplateSettingCategoryIdOption.IsRequired = true;
            command.AddOption(deviceManagementTemplateSettingCategoryIdOption);
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
                var deviceManagementTemplateId = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateIdOption);
                var deviceManagementTemplateId1 = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateId1Option);
                var deviceManagementTemplateSettingCategoryId = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateSettingCategoryIdOption);
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
                if (deviceManagementTemplateId is not null) requestInfo.PathParameters.Add("deviceManagementTemplate%2Did", deviceManagementTemplateId);
                if (deviceManagementTemplateId1 is not null) requestInfo.PathParameters.Add("deviceManagementTemplate%2Did1", deviceManagementTemplateId1);
                if (deviceManagementTemplateSettingCategoryId is not null) requestInfo.PathParameters.Add("deviceManagementTemplateSettingCategory%2Did", deviceManagementTemplateSettingCategoryId);
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
        /// Update the navigation property categories in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property categories in deviceManagement";
            var deviceManagementTemplateIdOption = new Option<string>("--device-management-template-id", description: "The unique identifier of deviceManagementTemplate") {
            };
            deviceManagementTemplateIdOption.IsRequired = true;
            command.AddOption(deviceManagementTemplateIdOption);
            var deviceManagementTemplateId1Option = new Option<string>("--device-management-template-id1", description: "The unique identifier of deviceManagementTemplate") {
            };
            deviceManagementTemplateId1Option.IsRequired = true;
            command.AddOption(deviceManagementTemplateId1Option);
            var deviceManagementTemplateSettingCategoryIdOption = new Option<string>("--device-management-template-setting-category-id", description: "The unique identifier of deviceManagementTemplateSettingCategory") {
            };
            deviceManagementTemplateSettingCategoryIdOption.IsRequired = true;
            command.AddOption(deviceManagementTemplateSettingCategoryIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var deviceManagementTemplateId = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateIdOption);
                var deviceManagementTemplateId1 = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateId1Option);
                var deviceManagementTemplateSettingCategoryId = invocationContext.ParseResult.GetValueForOption(deviceManagementTemplateSettingCategoryIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceManagementTemplateSettingCategory>(DeviceManagementTemplateSettingCategory.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (deviceManagementTemplateId is not null) requestInfo.PathParameters.Add("deviceManagementTemplate%2Did", deviceManagementTemplateId);
                if (deviceManagementTemplateId1 is not null) requestInfo.PathParameters.Add("deviceManagementTemplate%2Did1", deviceManagementTemplateId1);
                if (deviceManagementTemplateSettingCategoryId is not null) requestInfo.PathParameters.Add("deviceManagementTemplateSettingCategory%2Did", deviceManagementTemplateSettingCategoryId);
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
        /// Provides operations to manage the recommendedSettings property of the microsoft.graph.deviceManagementTemplateSettingCategory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRecommendedSettingsNavCommand()
        {
            var command = new Command("recommended-settings");
            command.Description = "Provides operations to manage the recommendedSettings property of the microsoft.graph.deviceManagementTemplateSettingCategory entity.";
            var builder = new RecommendedSettingsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the settingDefinitions property of the microsoft.graph.deviceManagementSettingCategory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSettingDefinitionsNavCommand()
        {
            var command = new Command("setting-definitions");
            command.Description = "Provides operations to manage the settingDefinitions property of the microsoft.graph.deviceManagementSettingCategory entity.";
            var builder = new SettingDefinitionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementTemplateSettingCategoryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DeviceManagementTemplateSettingCategoryItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/templates/{deviceManagementTemplate%2Did}/migratableTo/{deviceManagementTemplate%2Did1}/categories/{deviceManagementTemplateSettingCategory%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementTemplateSettingCategoryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeviceManagementTemplateSettingCategoryItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/templates/{deviceManagementTemplate%2Did}/migratableTo/{deviceManagementTemplate%2Did1}/categories/{deviceManagementTemplateSettingCategory%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property categories for deviceManagement
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/deviceManagement/templates/{deviceManagementTemplate%2Did}/migratableTo/{deviceManagementTemplate%2Did1}/categories/{deviceManagementTemplateSettingCategory%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Collection of setting categories within the template
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeviceManagementTemplateSettingCategoryItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeviceManagementTemplateSettingCategoryItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property categories in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DeviceManagementTemplateSettingCategory body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DeviceManagementTemplateSettingCategory body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/deviceManagement/templates/{deviceManagementTemplate%2Did}/migratableTo/{deviceManagementTemplate%2Did1}/categories/{deviceManagementTemplateSettingCategory%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Collection of setting categories within the template
        /// </summary>
        public class DeviceManagementTemplateSettingCategoryItemRequestBuilderGetQueryParameters 
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
