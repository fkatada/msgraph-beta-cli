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
namespace ApiSdk.Education.Schools.Item.Classes.Item.Ref {
    /// <summary>
    /// Provides operations to manage the collection of educationRoot entities.
    /// </summary>
    public class RefRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Delete a class from a school.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/educationschool-delete-classes?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete a class from a school.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/educationschool-delete-classes?view=graph-rest-1.0";
            var educationSchoolIdOption = new Option<string>("--education-school-id", description: "The unique identifier of educationSchool") {
            };
            educationSchoolIdOption.IsRequired = true;
            command.AddOption(educationSchoolIdOption);
            var educationClassIdOption = new Option<string>("--education-class-id", description: "The unique identifier of educationClass") {
            };
            educationClassIdOption.IsRequired = true;
            command.AddOption(educationClassIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            var idOption = new Option<string>("--id", description: "Delete Uri") {
            };
            idOption.IsRequired = false;
            command.AddOption(idOption);
            command.SetHandler(async (invocationContext) => {
                var educationSchoolId = invocationContext.ParseResult.GetValueForOption(educationSchoolIdOption);
                var educationClassId = invocationContext.ParseResult.GetValueForOption(educationClassIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var id = invocationContext.ParseResult.GetValueForOption(idOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                    if (!string.IsNullOrEmpty(id)) q.QueryParameters.Id = id;
                });
                if (educationSchoolId is not null) requestInfo.PathParameters.Add("educationSchool%2Did", educationSchoolId);
                if (educationClassId is not null) requestInfo.PathParameters.Add("educationClass%2Did", educationClassId);
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
        /// Instantiates a new RefRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public RefRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/schools/{educationSchool%2Did}/classes/{educationClass%2Did}/$ref{?%40id*}", pathParameters) {
        }
        /// <summary>
        /// Delete a class from a school.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<RefRequestBuilderDeleteQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<RefRequestBuilderDeleteQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<RefRequestBuilderDeleteQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete a class from a school.
        /// </summary>
        public class RefRequestBuilderDeleteQueryParameters {
            /// <summary>Delete Uri</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%40id")]
            public string? Id { get; set; }
#nullable restore
#else
            [QueryParameter("%40id")]
            public string Id { get; set; }
#endif
        }
    }
}
