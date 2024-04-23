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
namespace ApiSdk.DeviceManagement.ManagedDevices.Item.RemoveDeviceFirmwareConfigurationInterfaceManagement {
    /// <summary>
    /// Provides operations to call the removeDeviceFirmwareConfigurationInterfaceManagement method.
    /// </summary>
    public class RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Remove device from Device Firmware Configuration Interface management
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Remove device from Device Firmware Configuration Interface management";
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "The unique identifier of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            command.SetHandler(async (invocationContext) => {
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
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
        /// Instantiates a new <see cref="RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/managedDevices/{managedDevice%2Did}/removeDeviceFirmwareConfigurationInterfaceManagement", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/managedDevices/{managedDevice%2Did}/removeDeviceFirmwareConfigurationInterfaceManagement", rawUrl)
        {
        }
        /// <summary>
        /// Remove device from Device Firmware Configuration Interface management
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
