// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    /// <summary>
    /// The endpoint privilege management elevation result entity representing a single elevation action on a client device.
    /// </summary>
    public class PrivilegeManagementElevation : Entity, IParsable
    {
        /// <summary>The certificate payload of the application. This is computed by hashing the certificate information on the client. Example: `32c220482c68413fbf8290e3b1e49b0a85901cfcd62ab0738760568a2a6e8a50`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificatePayload { get; set; }
#nullable restore
#else
        public string CertificatePayload { get; set; }
#endif
        /// <summary>The company name of the application. This value is set by the creator of the application. Example: `Microsoft Corporation`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>The Intune deviceId. Unique identifier for the managed device. Example: `92ce5047-9553-4731-817f-9b401a999a1b`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>The name associated with the device in the intune database. Example: `JOHNDOE-LAPTOP`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>Indicates the type of elevation occured</summary>
        public PrivilegeManagementElevationType? ElevationType { get; set; }
        /// <summary>The date and time when the application was elevated. Example:`2014-01-01T00:00:00Z`</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>The file description of the application. This value is set by the creator of the application. Example: `Editor of multiple coding languages.`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileDescription { get; set; }
#nullable restore
#else
        public string FileDescription { get; set; }
#endif
        /// <summary>The full file path of the application including the filename and file extension. Example: `C:\Program Files\vscode.exe`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePath { get; set; }
#nullable restore
#else
        public string FilePath { get; set; }
#endif
        /// <summary>The version of the application. This value is set by the creator of the application. Example: `6.2211.1035.1000`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileVersion { get; set; }
#nullable restore
#else
        public string FileVersion { get; set; }
#endif
        /// <summary>The sha256 hash of the application. Example: `32c220482c68413fbf8290e3b1e49b0a85901cfcd62ab0738760568a2a6e8a57`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hash { get; set; }
#nullable restore
#else
        public string Hash { get; set; }
#endif
        /// <summary>The internal name of the application. This value is set by the creator of the application. Example: `VS code`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalName { get; set; }
#nullable restore
#else
        public string InternalName { get; set; }
#endif
        /// <summary>The justification to elevate the application. This is an input by the user when the privilegeManagementElevationType is of type userConfirmedElevation or support approved elevation. This will be null in all other scenarios. The length is capped at 256 char, enforced on the client side. Example: `To install debug tool.`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification { get; set; }
#nullable restore
#else
        public string Justification { get; set; }
#endif
        /// <summary>The name of parent process associated with the elevated process. This is always populated for both parent and child process types</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentProcessName { get; set; }
#nullable restore
#else
        public string ParentProcessName { get; set; }
#endif
        /// <summary>Unique Identifier of the policy configured to run the application with elevated access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId { get; set; }
#nullable restore
#else
        public string PolicyId { get; set; }
#endif
        /// <summary>The name of the policy configured to run the application in elevated access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyName { get; set; }
#nullable restore
#else
        public string PolicyName { get; set; }
#endif
        /// <summary>Indicates the type of elevated process</summary>
        public PrivilegeManagementProcessType? ProcessType { get; set; }
        /// <summary>The product name of the application. This value is set by the creator of the application. Example: `Visual Studio`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName { get; set; }
#nullable restore
#else
        public string ProductName { get; set; }
#endif
        /// <summary>The result of the elevation action with 0 being success, and everything else being exit code if the elevation was unsuccessful. The value will always be 0 on all unmanaged elevation. Example: `0`. Valid values 0 to 2147483647</summary>
        public int? Result { get; set; }
        /// <summary>Unique identifier of the rule configured to run the application with elevated access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleId { get; set; }
#nullable restore
#else
        public string RuleId { get; set; }
#endif
        /// <summary>To identify if the elevation is initiated by system or user interaction</summary>
        public bool? SystemInitiatedElevation { get; set; }
        /// <summary>The User Principal Name of the user who performed the elevation. Example: `john@domain.com`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Upn { get; set; }
#nullable restore
#else
        public string Upn { get; set; }
#endif
        /// <summary>The type of user account on Windows that was used to performed the elevation.</summary>
        public PrivilegeManagementEndUserType? UserType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivilegeManagementElevation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegeManagementElevation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegeManagementElevation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificatePayload", n => { CertificatePayload = n.GetStringValue(); } },
                { "companyName", n => { CompanyName = n.GetStringValue(); } },
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "elevationType", n => { ElevationType = n.GetEnumValue<PrivilegeManagementElevationType>(); } },
                { "eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                { "fileDescription", n => { FileDescription = n.GetStringValue(); } },
                { "filePath", n => { FilePath = n.GetStringValue(); } },
                { "fileVersion", n => { FileVersion = n.GetStringValue(); } },
                { "hash", n => { Hash = n.GetStringValue(); } },
                { "internalName", n => { InternalName = n.GetStringValue(); } },
                { "justification", n => { Justification = n.GetStringValue(); } },
                { "parentProcessName", n => { ParentProcessName = n.GetStringValue(); } },
                { "policyId", n => { PolicyId = n.GetStringValue(); } },
                { "policyName", n => { PolicyName = n.GetStringValue(); } },
                { "processType", n => { ProcessType = n.GetEnumValue<PrivilegeManagementProcessType>(); } },
                { "productName", n => { ProductName = n.GetStringValue(); } },
                { "result", n => { Result = n.GetIntValue(); } },
                { "ruleId", n => { RuleId = n.GetStringValue(); } },
                { "systemInitiatedElevation", n => { SystemInitiatedElevation = n.GetBoolValue(); } },
                { "upn", n => { Upn = n.GetStringValue(); } },
                { "userType", n => { UserType = n.GetEnumValue<PrivilegeManagementEndUserType>(); } },
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
            writer.WriteStringValue("certificatePayload", CertificatePayload);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<PrivilegeManagementElevationType>("elevationType", ElevationType);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("fileDescription", FileDescription);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteStringValue("fileVersion", FileVersion);
            writer.WriteStringValue("hash", Hash);
            writer.WriteStringValue("internalName", InternalName);
            writer.WriteStringValue("justification", Justification);
            writer.WriteStringValue("parentProcessName", ParentProcessName);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteEnumValue<PrivilegeManagementProcessType>("processType", ProcessType);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteIntValue("result", Result);
            writer.WriteStringValue("ruleId", RuleId);
            writer.WriteBoolValue("systemInitiatedElevation", SystemInitiatedElevation);
            writer.WriteStringValue("upn", Upn);
            writer.WriteEnumValue<PrivilegeManagementEndUserType>("userType", UserType);
        }
    }
}
