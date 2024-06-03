// <auto-generated/>
using ApiSdk.DirectoryNamespace.AdministrativeUnits;
using ApiSdk.DirectoryNamespace.AttributeSets;
using ApiSdk.DirectoryNamespace.CertificateAuthorities;
using ApiSdk.DirectoryNamespace.CustomSecurityAttributeDefinitions;
using ApiSdk.DirectoryNamespace.DeletedItems;
using ApiSdk.DirectoryNamespace.DeviceLocalCredentials;
using ApiSdk.DirectoryNamespace.ExternalUserProfiles;
using ApiSdk.DirectoryNamespace.FeatureRolloutPolicies;
using ApiSdk.DirectoryNamespace.FederationConfigurations;
using ApiSdk.DirectoryNamespace.ImpactedResources;
using ApiSdk.DirectoryNamespace.InboundSharedUserProfiles;
using ApiSdk.DirectoryNamespace.OnPremisesSynchronization;
using ApiSdk.DirectoryNamespace.OutboundSharedUserProfiles;
using ApiSdk.DirectoryNamespace.PendingExternalUserProfiles;
using ApiSdk.DirectoryNamespace.Recommendations;
using ApiSdk.DirectoryNamespace.SharedEmailDomains;
using ApiSdk.DirectoryNamespace.Subscriptions;
using ApiSdk.DirectoryNamespace.SubscriptionsWithCommerceSubscriptionId;
using ApiSdk.DirectoryNamespace.SubscriptionsWithOcpSubscriptionId;
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
namespace ApiSdk.DirectoryNamespace
{
    /// <summary>
    /// Provides operations to manage the directory singleton.
    /// </summary>
    public class DirectoryRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the administrativeUnits property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAdministrativeUnitsNavCommand()
        {
            var command = new Command("administrative-units");
            command.Description = "Provides operations to manage the administrativeUnits property of the microsoft.graph.directory entity.";
            var builder = new AdministrativeUnitsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
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
        /// Provides operations to manage the attributeSets property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAttributeSetsNavCommand()
        {
            var command = new Command("attribute-sets");
            command.Description = "Provides operations to manage the attributeSets property of the microsoft.graph.directory entity.";
            var builder = new AttributeSetsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the certificateAuthorities property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCertificateAuthoritiesNavCommand()
        {
            var command = new Command("certificate-authorities");
            command.Description = "Provides operations to manage the certificateAuthorities property of the microsoft.graph.directory entity.";
            var builder = new CertificateAuthoritiesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCertificateBasedApplicationConfigurationsNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the customSecurityAttributeDefinitions property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCustomSecurityAttributeDefinitionsNavCommand()
        {
            var command = new Command("custom-security-attribute-definitions");
            command.Description = "Provides operations to manage the customSecurityAttributeDefinitions property of the microsoft.graph.directory entity.";
            var builder = new CustomSecurityAttributeDefinitionsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the deletedItems property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeletedItemsNavCommand()
        {
            var command = new Command("deleted-items");
            command.Description = "Provides operations to manage the deletedItems property of the microsoft.graph.directory entity.";
            var builder = new DeletedItemsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            nonExecCommands.Add(builder.BuildGetByIdsNavCommand());
            nonExecCommands.Add(builder.BuildGraphAdministrativeUnitNavCommand());
            nonExecCommands.Add(builder.BuildGraphApplicationNavCommand());
            nonExecCommands.Add(builder.BuildGraphDeviceNavCommand());
            nonExecCommands.Add(builder.BuildGraphGroupNavCommand());
            nonExecCommands.Add(builder.BuildGraphServicePrincipalNavCommand());
            nonExecCommands.Add(builder.BuildGraphUserNavCommand());
            execCommands.Add(builder.BuildListCommand());
            nonExecCommands.Add(builder.BuildValidatePropertiesNavCommand());
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
        /// Provides operations to manage the deviceLocalCredentials property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeviceLocalCredentialsNavCommand()
        {
            var command = new Command("device-local-credentials");
            command.Description = "Provides operations to manage the deviceLocalCredentials property of the microsoft.graph.directory entity.";
            var builder = new DeviceLocalCredentialsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the externalUserProfiles property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildExternalUserProfilesNavCommand()
        {
            var command = new Command("external-user-profiles");
            command.Description = "Provides operations to manage the externalUserProfiles property of the microsoft.graph.directory entity.";
            var builder = new ExternalUserProfilesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the featureRolloutPolicies property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildFeatureRolloutPoliciesNavCommand()
        {
            var command = new Command("feature-rollout-policies");
            command.Description = "Provides operations to manage the featureRolloutPolicies property of the microsoft.graph.directory entity.";
            var builder = new FeatureRolloutPoliciesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the federationConfigurations property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildFederationConfigurationsNavCommand()
        {
            var command = new Command("federation-configurations");
            command.Description = "Provides operations to manage the federationConfigurations property of the microsoft.graph.directory entity.";
            var builder = new FederationConfigurationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAvailableProviderTypesNavCommand());
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
        /// Get directory
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get directory";
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
        /// Provides operations to manage the impactedResources property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildImpactedResourcesNavCommand()
        {
            var command = new Command("impacted-resources");
            command.Description = "Provides operations to manage the impactedResources property of the microsoft.graph.directory entity.";
            var builder = new ImpactedResourcesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the inboundSharedUserProfiles property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildInboundSharedUserProfilesNavCommand()
        {
            var command = new Command("inbound-shared-user-profiles");
            command.Description = "Provides operations to manage the inboundSharedUserProfiles property of the microsoft.graph.directory entity.";
            var builder = new InboundSharedUserProfilesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the onPremisesSynchronization property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildOnPremisesSynchronizationNavCommand()
        {
            var command = new Command("on-premises-synchronization");
            command.Description = "Provides operations to manage the onPremisesSynchronization property of the microsoft.graph.directory entity.";
            var builder = new OnPremisesSynchronizationRequestBuilder(PathParameters);
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
        /// Provides operations to manage the outboundSharedUserProfiles property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildOutboundSharedUserProfilesNavCommand()
        {
            var command = new Command("outbound-shared-user-profiles");
            command.Description = "Provides operations to manage the outboundSharedUserProfiles property of the microsoft.graph.directory entity.";
            var builder = new OutboundSharedUserProfilesRequestBuilder(PathParameters);
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
        /// Update directory
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update directory";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DirectoryObject1>(DirectoryObject1.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
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
        /// Provides operations to manage the pendingExternalUserProfiles property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPendingExternalUserProfilesNavCommand()
        {
            var command = new Command("pending-external-user-profiles");
            command.Description = "Provides operations to manage the pendingExternalUserProfiles property of the microsoft.graph.directory entity.";
            var builder = new PendingExternalUserProfilesRequestBuilder(PathParameters);
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
        /// Provides operations to manage the recommendations property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRecommendationsNavCommand()
        {
            var command = new Command("recommendations");
            command.Description = "Provides operations to manage the recommendations property of the microsoft.graph.directory entity.";
            var builder = new RecommendationsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the sharedEmailDomains property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSharedEmailDomainsNavCommand()
        {
            var command = new Command("shared-email-domains");
            command.Description = "Provides operations to manage the sharedEmailDomains property of the microsoft.graph.directory entity.";
            var builder = new SharedEmailDomainsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSubscriptionsNavCommand()
        {
            var command = new Command("subscriptions");
            command.Description = "Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.";
            var builder = new SubscriptionsRequestBuilder(PathParameters);
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
        /// Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSubscriptionsWithCommerceSubscriptionIdRbCommand()
        {
            var command = new Command("subscriptions-with-commerce-subscription-id");
            command.Description = "Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.";
            var builder = new SubscriptionsWithCommerceSubscriptionIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSubscriptionsWithOcpSubscriptionIdRbCommand()
        {
            var command = new Command("subscriptions-with-ocp-subscription-id");
            command.Description = "Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.";
            var builder = new SubscriptionsWithOcpSubscriptionIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="DirectoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DirectoryRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/directory{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DirectoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DirectoryRequestBuilder(string rawUrl) : base("{+baseurl}/directory{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get directory
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DirectoryRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DirectoryRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update directory
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get directory
        /// </summary>
        public class DirectoryRequestBuilderGetQueryParameters 
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
