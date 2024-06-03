// <auto-generated/>
using ApiSdk.Education.Schools.Item.Classes.Item.Ref;
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
namespace ApiSdk.Education.Schools.Item.Classes.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \education\schools\{educationSchool-id}\classes\{educationClass-id}
    /// </summary>
    public class EducationClassItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the collection of educationRoot entities.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRefByIdNavCommand()
        {
            var command = new Command("ref-by-id");
            command.Description = "Provides operations to manage the collection of educationRoot entities.";
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
        /// Instantiates a new <see cref="EducationClassItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationClassItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/schools/{educationSchool%2Did}/classes/{educationClass%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="EducationClassItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EducationClassItemRequestBuilder(string rawUrl) : base("{+baseurl}/education/schools/{educationSchool%2Did}/classes/{educationClass%2Did}", rawUrl)
        {
        }
    }
}
