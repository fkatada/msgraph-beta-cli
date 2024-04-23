// <auto-generated/>
using ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.IncompatibleGroups.Item.Ref;
using ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.IncompatibleGroups.Item.ServiceProvisioningErrors;
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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.IncompatibleGroups.Item {
    /// <summary>
    /// Builds and executes requests for operations under \identityGovernance\entitlementManagement\accessPackageAssignments\{accessPackageAssignment-id}\accessPackage\incompatibleGroups\{group-id}
    /// </summary>
    public class GroupItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Provides operations to manage the collection of identityGovernance entities.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRefByIdNavCommand()
        {
            var command = new Command("ref-by-id");
            command.Description = "Provides operations to manage the collection of identityGovernance entities.";
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
        public GroupItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackage/incompatibleGroups/{group%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GroupItemRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackage/incompatibleGroups/{group%2Did}", rawUrl)
        {
        }
    }
}
