// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class ConditionalAccessWhatIfConditions : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The authenticationFlow property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AuthenticationFlow? AuthenticationFlow { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AuthenticationFlow AuthenticationFlow { get; set; }
#endif
        /// <summary>The clientAppType property</summary>
        public ConditionalAccessClientApp? ClientAppType { get; set; }
        /// <summary>The country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The deviceInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DeviceInfo? DeviceInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DeviceInfo DeviceInfo { get; set; }
#endif
        /// <summary>The devicePlatform property</summary>
        public ConditionalAccessDevicePlatform? DevicePlatform { get; set; }
        /// <summary>The insiderRiskLevel property</summary>
        public ApiSdk.Models.InsiderRiskLevel? InsiderRiskLevel { get; set; }
        /// <summary>The ipAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The servicePrincipalRiskLevel property</summary>
        public RiskLevel? ServicePrincipalRiskLevel { get; set; }
        /// <summary>The signInRiskLevel property</summary>
        public RiskLevel? SignInRiskLevel { get; set; }
        /// <summary>The userRiskLevel property</summary>
        public RiskLevel? UserRiskLevel { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ConditionalAccessWhatIfConditions"/> and sets the default values.
        /// </summary>
        public ConditionalAccessWhatIfConditions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConditionalAccessWhatIfConditions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessWhatIfConditions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessWhatIfConditions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authenticationFlow", n => { AuthenticationFlow = n.GetObjectValue<ApiSdk.Models.AuthenticationFlow>(ApiSdk.Models.AuthenticationFlow.CreateFromDiscriminatorValue); } },
                { "clientAppType", n => { ClientAppType = n.GetEnumValue<ConditionalAccessClientApp>(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "deviceInfo", n => { DeviceInfo = n.GetObjectValue<ApiSdk.Models.DeviceInfo>(ApiSdk.Models.DeviceInfo.CreateFromDiscriminatorValue); } },
                { "devicePlatform", n => { DevicePlatform = n.GetEnumValue<ConditionalAccessDevicePlatform>(); } },
                { "insiderRiskLevel", n => { InsiderRiskLevel = n.GetEnumValue<InsiderRiskLevel>(); } },
                { "ipAddress", n => { IpAddress = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "servicePrincipalRiskLevel", n => { ServicePrincipalRiskLevel = n.GetEnumValue<RiskLevel>(); } },
                { "signInRiskLevel", n => { SignInRiskLevel = n.GetEnumValue<RiskLevel>(); } },
                { "userRiskLevel", n => { UserRiskLevel = n.GetEnumValue<RiskLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.AuthenticationFlow>("authenticationFlow", AuthenticationFlow);
            writer.WriteEnumValue<ConditionalAccessClientApp>("clientAppType", ClientAppType);
            writer.WriteStringValue("country", Country);
            writer.WriteObjectValue<ApiSdk.Models.DeviceInfo>("deviceInfo", DeviceInfo);
            writer.WriteEnumValue<ConditionalAccessDevicePlatform>("devicePlatform", DevicePlatform);
            writer.WriteEnumValue<InsiderRiskLevel>("insiderRiskLevel", InsiderRiskLevel);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RiskLevel>("servicePrincipalRiskLevel", ServicePrincipalRiskLevel);
            writer.WriteEnumValue<RiskLevel>("signInRiskLevel", SignInRiskLevel);
            writer.WriteEnumValue<RiskLevel>("userRiskLevel", UserRiskLevel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
