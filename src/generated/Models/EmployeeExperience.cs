// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class EmployeeExperience : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of communities in Viva Engage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Community>? Communities { get; set; }
#nullable restore
#else
        public List<Community> Communities { get; set; }
#endif
        /// <summary>A collection of long-running, asynchronous operations related to Viva Engage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EngagementAsyncOperation>? EngagementAsyncOperations { get; set; }
#nullable restore
#else
        public List<EngagementAsyncOperation> EngagementAsyncOperations { get; set; }
#endif
        /// <summary>Represents a collection of goals in a Viva Goals organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Goals? Goals { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Goals Goals { get; set; }
#endif
        /// <summary>The learningCourseActivities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LearningCourseActivity>? LearningCourseActivities { get; set; }
#nullable restore
#else
        public List<LearningCourseActivity> LearningCourseActivities { get; set; }
#endif
        /// <summary>A collection of learning providers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LearningProvider>? LearningProviders { get; set; }
#nullable restore
#else
        public List<LearningProvider> LearningProviders { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EmployeeExperience"/> and sets the default values.
        /// </summary>
        public EmployeeExperience()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EmployeeExperience"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EmployeeExperience CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmployeeExperience();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"communities", n => { Communities = n.GetCollectionOfObjectValues<Community>(Community.CreateFromDiscriminatorValue)?.ToList(); } },
                {"engagementAsyncOperations", n => { EngagementAsyncOperations = n.GetCollectionOfObjectValues<EngagementAsyncOperation>(EngagementAsyncOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"goals", n => { Goals = n.GetObjectValue<ApiSdk.Models.Goals>(ApiSdk.Models.Goals.CreateFromDiscriminatorValue); } },
                {"learningCourseActivities", n => { LearningCourseActivities = n.GetCollectionOfObjectValues<LearningCourseActivity>(LearningCourseActivity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"learningProviders", n => { LearningProviders = n.GetCollectionOfObjectValues<LearningProvider>(LearningProvider.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Community>("communities", Communities);
            writer.WriteCollectionOfObjectValues<EngagementAsyncOperation>("engagementAsyncOperations", EngagementAsyncOperations);
            writer.WriteObjectValue<ApiSdk.Models.Goals>("goals", Goals);
            writer.WriteCollectionOfObjectValues<LearningCourseActivity>("learningCourseActivities", LearningCourseActivities);
            writer.WriteCollectionOfObjectValues<LearningProvider>("learningProviders", LearningProviders);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
