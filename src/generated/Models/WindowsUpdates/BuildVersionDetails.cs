// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.WindowsUpdates
{
    #pragma warning disable CS1591
    public class BuildVersionDetails : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The build number of the product release. Read-only.</summary>
        public int? BuildNumber { get; set; }
        /// <summary>The major version of the product release. Read-only.</summary>
        public int? MajorVersion { get; set; }
        /// <summary>The minor version of the product release. Read-only.</summary>
        public int? MinorVersion { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The update build revision number of the product revision. Read-only.</summary>
        public int? UpdateBuildRevision { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="BuildVersionDetails"/> and sets the default values.
        /// </summary>
        public BuildVersionDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BuildVersionDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BuildVersionDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BuildVersionDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "buildNumber", n => { BuildNumber = n.GetIntValue(); } },
                { "majorVersion", n => { MajorVersion = n.GetIntValue(); } },
                { "minorVersion", n => { MinorVersion = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "updateBuildRevision", n => { UpdateBuildRevision = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("buildNumber", BuildNumber);
            writer.WriteIntValue("majorVersion", MajorVersion);
            writer.WriteIntValue("minorVersion", MinorVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("updateBuildRevision", UpdateBuildRevision);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
