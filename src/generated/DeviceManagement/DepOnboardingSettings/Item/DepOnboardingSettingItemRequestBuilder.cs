// <auto-generated/>
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.DefaultIosEnrollmentProfile;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.DefaultMacOsEnrollmentProfile;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.EnrollmentProfiles;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.GenerateEncryptionPublicKey;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.GetEncryptionPublicKey;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.ShareForSchoolDataSyncService;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.SyncWithAppleDeviceEnrollmentProgram;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.UnshareForSchoolDataSyncService;
using ApiSdk.DeviceManagement.DepOnboardingSettings.Item.UploadDepToken;
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
namespace ApiSdk.DeviceManagement.DepOnboardingSettings.Item {
    /// <summary>
    /// Provides operations to manage the depOnboardingSettings property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class DepOnboardingSettingItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to manage the defaultIosEnrollmentProfile property of the microsoft.graph.depOnboardingSetting entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDefaultIosEnrollmentProfileNavCommand()
        {
            var command = new Command("default-ios-enrollment-profile");
            command.Description = "Provides operations to manage the defaultIosEnrollmentProfile property of the microsoft.graph.depOnboardingSetting entity.";
            var builder = new DefaultIosEnrollmentProfileRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the defaultMacOsEnrollmentProfile property of the microsoft.graph.depOnboardingSetting entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDefaultMacOsEnrollmentProfileNavCommand()
        {
            var command = new Command("default-mac-os-enrollment-profile");
            command.Description = "Provides operations to manage the defaultMacOsEnrollmentProfile property of the microsoft.graph.depOnboardingSetting entity.";
            var builder = new DefaultMacOsEnrollmentProfileRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property depOnboardingSettings for deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete navigation property depOnboardingSettings for deviceManagement";
            var depOnboardingSettingIdOption = new Option<string>("--dep-onboarding-setting-id", description: "The unique identifier of depOnboardingSetting") {
            };
            depOnboardingSettingIdOption.IsRequired = true;
            command.AddOption(depOnboardingSettingIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var depOnboardingSettingId = invocationContext.ParseResult.GetValueForOption(depOnboardingSettingIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (depOnboardingSettingId is not null) requestInfo.PathParameters.Add("depOnboardingSetting%2Did", depOnboardingSettingId);
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
        /// Provides operations to manage the enrollmentProfiles property of the microsoft.graph.depOnboardingSetting entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildEnrollmentProfilesNavCommand()
        {
            var command = new Command("enrollment-profiles");
            command.Description = "Provides operations to manage the enrollmentProfiles property of the microsoft.graph.depOnboardingSetting entity.";
            var builder = new EnrollmentProfilesRequestBuilder(PathParameters);
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
        /// Provides operations to call the generateEncryptionPublicKey method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGenerateEncryptionPublicKeyNavCommand()
        {
            var command = new Command("generate-encryption-public-key");
            command.Description = "Provides operations to call the generateEncryptionPublicKey method.";
            var builder = new GenerateEncryptionPublicKeyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "This collections of multiple DEP tokens per-tenant.";
            var depOnboardingSettingIdOption = new Option<string>("--dep-onboarding-setting-id", description: "The unique identifier of depOnboardingSetting") {
            };
            depOnboardingSettingIdOption.IsRequired = true;
            command.AddOption(depOnboardingSettingIdOption);
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
                var depOnboardingSettingId = invocationContext.ParseResult.GetValueForOption(depOnboardingSettingIdOption);
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
                if (depOnboardingSettingId is not null) requestInfo.PathParameters.Add("depOnboardingSetting%2Did", depOnboardingSettingId);
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
        /// Provides operations to call the getEncryptionPublicKey method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetEncryptionPublicKeyNavCommand()
        {
            var command = new Command("get-encryption-public-key");
            command.Description = "Provides operations to call the getEncryptionPublicKey method.";
            var builder = new GetEncryptionPublicKeyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the importedAppleDeviceIdentities property of the microsoft.graph.depOnboardingSetting entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildImportedAppleDeviceIdentitiesNavCommand()
        {
            var command = new Command("imported-apple-device-identities");
            command.Description = "Provides operations to manage the importedAppleDeviceIdentities property of the microsoft.graph.depOnboardingSetting entity.";
            var builder = new ImportedAppleDeviceIdentitiesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildImportAppleDeviceIdentityListNavCommand());
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
        /// Update the navigation property depOnboardingSettings in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property depOnboardingSettings in deviceManagement";
            var depOnboardingSettingIdOption = new Option<string>("--dep-onboarding-setting-id", description: "The unique identifier of depOnboardingSetting") {
            };
            depOnboardingSettingIdOption.IsRequired = true;
            command.AddOption(depOnboardingSettingIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var depOnboardingSettingId = invocationContext.ParseResult.GetValueForOption(depOnboardingSettingIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DepOnboardingSetting>(DepOnboardingSetting.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (depOnboardingSettingId is not null) requestInfo.PathParameters.Add("depOnboardingSetting%2Did", depOnboardingSettingId);
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
        /// Provides operations to call the shareForSchoolDataSyncService method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildShareForSchoolDataSyncServiceNavCommand()
        {
            var command = new Command("share-for-school-data-sync-service");
            command.Description = "Provides operations to call the shareForSchoolDataSyncService method.";
            var builder = new ShareForSchoolDataSyncServiceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the syncWithAppleDeviceEnrollmentProgram method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSyncWithAppleDeviceEnrollmentProgramNavCommand()
        {
            var command = new Command("sync-with-apple-device-enrollment-program");
            command.Description = "Provides operations to call the syncWithAppleDeviceEnrollmentProgram method.";
            var builder = new SyncWithAppleDeviceEnrollmentProgramRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the unshareForSchoolDataSyncService method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUnshareForSchoolDataSyncServiceNavCommand()
        {
            var command = new Command("unshare-for-school-data-sync-service");
            command.Description = "Provides operations to call the unshareForSchoolDataSyncService method.";
            var builder = new UnshareForSchoolDataSyncServiceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the uploadDepToken method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUploadDepTokenNavCommand()
        {
            var command = new Command("upload-dep-token");
            command.Description = "Provides operations to call the uploadDepToken method.";
            var builder = new UploadDepTokenRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="DepOnboardingSettingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DepOnboardingSettingItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DepOnboardingSettingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DepOnboardingSettingItemRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property depOnboardingSettings for deviceManagement
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DepOnboardingSettingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DepOnboardingSettingItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property depOnboardingSettings in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DepOnboardingSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DepOnboardingSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/deviceManagement/depOnboardingSettings/{depOnboardingSetting%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// This collections of multiple DEP tokens per-tenant.
        /// </summary>
        public class DepOnboardingSettingItemRequestBuilderGetQueryParameters 
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
