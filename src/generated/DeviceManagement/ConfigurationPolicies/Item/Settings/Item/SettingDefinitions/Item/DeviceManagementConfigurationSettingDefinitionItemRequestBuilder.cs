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
namespace ApiSdk.DeviceManagement.ConfigurationPolicies.Item.Settings.Item.SettingDefinitions.Item {
    /// <summary>
    /// Provides operations to manage the settingDefinitions property of the microsoft.graph.deviceManagementConfigurationSetting entity.
    /// </summary>
    public class DeviceManagementConfigurationSettingDefinitionItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// List of related Setting Definitions. This property is read-only.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "List of related Setting Definitions. This property is read-only.";
            var deviceManagementConfigurationPolicyIdOption = new Option<string>("--device-management-configuration-policy-id", description: "The unique identifier of deviceManagementConfigurationPolicy") {
            };
            deviceManagementConfigurationPolicyIdOption.IsRequired = true;
            command.AddOption(deviceManagementConfigurationPolicyIdOption);
            var deviceManagementConfigurationSettingIdOption = new Option<string>("--device-management-configuration-setting-id", description: "The unique identifier of deviceManagementConfigurationSetting") {
            };
            deviceManagementConfigurationSettingIdOption.IsRequired = true;
            command.AddOption(deviceManagementConfigurationSettingIdOption);
            var deviceManagementConfigurationSettingDefinitionIdOption = new Option<string>("--device-management-configuration-setting-definition-id", description: "The unique identifier of deviceManagementConfigurationSettingDefinition") {
            };
            deviceManagementConfigurationSettingDefinitionIdOption.IsRequired = true;
            command.AddOption(deviceManagementConfigurationSettingDefinitionIdOption);
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
                var deviceManagementConfigurationPolicyId = invocationContext.ParseResult.GetValueForOption(deviceManagementConfigurationPolicyIdOption);
                var deviceManagementConfigurationSettingId = invocationContext.ParseResult.GetValueForOption(deviceManagementConfigurationSettingIdOption);
                var deviceManagementConfigurationSettingDefinitionId = invocationContext.ParseResult.GetValueForOption(deviceManagementConfigurationSettingDefinitionIdOption);
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
                if (deviceManagementConfigurationPolicyId is not null) requestInfo.PathParameters.Add("deviceManagementConfigurationPolicy%2Did", deviceManagementConfigurationPolicyId);
                if (deviceManagementConfigurationSettingId is not null) requestInfo.PathParameters.Add("deviceManagementConfigurationSetting%2Did", deviceManagementConfigurationSettingId);
                if (deviceManagementConfigurationSettingDefinitionId is not null) requestInfo.PathParameters.Add("deviceManagementConfigurationSettingDefinition%2Did", deviceManagementConfigurationSettingDefinitionId);
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
        /// Instantiates a new <see cref="DeviceManagementConfigurationSettingDefinitionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DeviceManagementConfigurationSettingDefinitionItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/configurationPolicies/{deviceManagementConfigurationPolicy%2Did}/settings/{deviceManagementConfigurationSetting%2Did}/settingDefinitions/{deviceManagementConfigurationSettingDefinition%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementConfigurationSettingDefinitionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeviceManagementConfigurationSettingDefinitionItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/configurationPolicies/{deviceManagementConfigurationPolicy%2Did}/settings/{deviceManagementConfigurationSetting%2Did}/settingDefinitions/{deviceManagementConfigurationSettingDefinition%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// List of related Setting Definitions. This property is read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeviceManagementConfigurationSettingDefinitionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeviceManagementConfigurationSettingDefinitionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// List of related Setting Definitions. This property is read-only.
        /// </summary>
        public class DeviceManagementConfigurationSettingDefinitionItemRequestBuilderGetQueryParameters 
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
