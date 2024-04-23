// <auto-generated/>
using ApiSdk.Policies.MobileAppManagementPolicies.Item.IncludedGroups.Item.Ref;
using ApiSdk.Policies.MobileAppManagementPolicies.Item.IncludedGroups.Item.ServiceProvisioningErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ApiSdk.Policies.MobileAppManagementPolicies.Item.IncludedGroups.Item {
    /// <summary>
    /// Builds and executes requests for operations under \policies\mobileAppManagementPolicies\{mobilityManagementPolicy-id}\includedGroups\{group-id}
    /// </summary>
    public class GroupItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to manage the collection of policyRoot entities.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRefByIdNavCommand()
        {
            var command = new Command("ref-by-id");
            command.Description = "Provides operations to manage the collection of policyRoot entities.";
            var builder = new RefRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// The serviceProvisioningErrors property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildServiceProvisioningErrorsNavCommand()
        {
            var command = new Command("service-provisioning-errors");
            command.Description = "The serviceProvisioningErrors property";
            var builder = new ServiceProvisioningErrorsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildGetCommand());
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
        /// Instantiates a new <see cref="GroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GroupItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/policies/mobileAppManagementPolicies/{mobilityManagementPolicy%2Did}/includedGroups/{group%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GroupItemRequestBuilder(string rawUrl) : base("{+baseurl}/policies/mobileAppManagementPolicies/{mobilityManagementPolicy%2Did}/includedGroups/{group%2Did}", rawUrl)
        {
        }
    }
}
