// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// Describes deployment security group to assign a deployment to. The backend will expand the security Group ID to extract device serial numbers prior sending a create deployment request to Zebra.
    /// </summary>
    public class AndroidFotaDeploymentAssignment : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Azure Active Directory (Azure AD) we are deploying firmware updates to (e.g.: d93c8f48-bd42-4514-ba40-bc6b84780930). NOTE: Use this property moving forward because the existing property, target, is deprecated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceAndAppManagementAssignmentTarget? AssignmentTarget { get; set; }
#nullable restore
#else
        public DeviceAndAppManagementAssignmentTarget AssignmentTarget { get; set; }
#endif
        /// <summary>The display name of the Azure AD security group used for the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>A unique identifier assigned to each Android FOTA Assignment entity</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The AAD Group we are deploying firmware updates to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidFotaDeploymentAssignmentTarget? Target { get; set; }
#nullable restore
#else
        public AndroidFotaDeploymentAssignmentTarget Target { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AndroidFotaDeploymentAssignment"/> and sets the default values.
        /// </summary>
        public AndroidFotaDeploymentAssignment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidFotaDeploymentAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidFotaDeploymentAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidFotaDeploymentAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignmentTarget", n => { AssignmentTarget = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "target", n => { Target = n.GetObjectValue<AndroidFotaDeploymentAssignmentTarget>(AndroidFotaDeploymentAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("assignmentTarget", AssignmentTarget);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AndroidFotaDeploymentAssignmentTarget>("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
