// <auto-generated/>
using ApiSdk.Applications.Item.Owners.Item.GraphEndpoint;
using ApiSdk.Applications.Item.Owners.Item.GraphServicePrincipal;
using ApiSdk.Applications.Item.Owners.Item.GraphUser;
using ApiSdk.Applications.Item.Owners.Item.Ref;
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
namespace ApiSdk.Applications.Item.Owners.Item {
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\owners\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseCliRequestBuilder 
    {
        /// <summary>
        /// Casts the previous resource to endpoint.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGraphEndpointByIdNavCommand()
        {
            var command = new Command("graph-endpoint-by-id");
            command.Description = "Casts the previous resource to endpoint.";
            var builder = new GraphEndpointRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to servicePrincipal.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGraphServicePrincipalByIdNavCommand()
        {
            var command = new Command("graph-service-principal-by-id");
            command.Description = "Casts the previous resource to servicePrincipal.";
            var builder = new GraphServicePrincipalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to user.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGraphUserByIdNavCommand()
        {
            var command = new Command("graph-user-by-id");
            command.Description = "Casts the previous resource to user.";
            var builder = new GraphUserRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of application entities.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRefByIdNavCommand()
        {
            var command = new Command("ref-by-id");
            command.Description = "Provides operations to manage the collection of application entities.";
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
        /// Instantiates a new <see cref="DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/applications/{application%2Did}/owners/{directoryObject%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl) : base("{+baseurl}/applications/{application%2Did}/owners/{directoryObject%2Did}", rawUrl)
        {
        }
    }
}
