// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class TooManyGlobalAdminsAssignedToTenantAlertConfiguration : UnifiedRoleManagementAlertConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The threshold for the number of accounts assigned the Global Administrator role in the tenant. Triggers an alert if the number of global administrators in the tenant reaches or crosses this threshold value.</summary>
        public int? GlobalAdminCountThreshold { get; set; }
        /// <summary>Threshold of the percentage of global administrators out of all the role assignments in the tenant. Triggers an alert if the percentage in the tenant reaches or crosses this threshold value.</summary>
        public int? PercentageOfGlobalAdminsOutOfRolesThreshold { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="TooManyGlobalAdminsAssignedToTenantAlertConfiguration"/> and sets the default values.
        /// </summary>
        public TooManyGlobalAdminsAssignedToTenantAlertConfiguration() : base()
        {
            OdataType = "#microsoft.graph.tooManyGlobalAdminsAssignedToTenantAlertConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TooManyGlobalAdminsAssignedToTenantAlertConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TooManyGlobalAdminsAssignedToTenantAlertConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TooManyGlobalAdminsAssignedToTenantAlertConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "globalAdminCountThreshold", n => { GlobalAdminCountThreshold = n.GetIntValue(); } },
                { "percentageOfGlobalAdminsOutOfRolesThreshold", n => { PercentageOfGlobalAdminsOutOfRolesThreshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("globalAdminCountThreshold", GlobalAdminCountThreshold);
            writer.WriteIntValue("percentageOfGlobalAdminsOutOfRolesThreshold", PercentageOfGlobalAdminsOutOfRolesThreshold);
        }
    }
}
