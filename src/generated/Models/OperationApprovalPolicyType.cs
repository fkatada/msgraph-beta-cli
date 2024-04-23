// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>The set of available policy types that can be configured for approval. There is no default value for this enum, indicating that the policy type must always be chosen.</summary>
    public enum OperationApprovalPolicyType
    {
        /// <summary>Default. Indicates that the configured policy type is unknown. This property is not allowed on an OperationApprovalRequest unless the PolicySet contains a different OperationApprovalPolicyType.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the configured policy type is for a Device Action.</summary>
        [EnumMember(Value = "deviceAction")]
        DeviceAction,
        /// <summary>Indicates that the configured policy type is for a Device Wipe Action.</summary>
        [EnumMember(Value = "deviceWipe")]
        DeviceWipe,
        /// <summary>Indicates that the configured policy type is for a Device Retire Action.</summary>
        [EnumMember(Value = "deviceRetire")]
        DeviceRetire,
        /// <summary>Indicates that the configured policy type is for a Retire Non-Compliant Devices Action.</summary>
        [EnumMember(Value = "deviceRetireNonCompliant")]
        DeviceRetireNonCompliant,
        /// <summary>Indicates that the configured policy type is for a Device Delete Action.</summary>
        [EnumMember(Value = "deviceDelete")]
        DeviceDelete,
        /// <summary>Indicates that the configured policy type is for a Device Lock Action.</summary>
        [EnumMember(Value = "deviceLock")]
        DeviceLock,
        /// <summary>Indicates that the configured policy type is for a Device Erase Action.</summary>
        [EnumMember(Value = "deviceErase")]
        DeviceErase,
        /// <summary>Indicates that the configured policy type is for a Device Disable Activation Lock Action.</summary>
        [EnumMember(Value = "deviceDisableActivationLock")]
        DeviceDisableActivationLock,
        /// <summary>Indicates that the configured policy type is for a Windows Enrollment.</summary>
        [EnumMember(Value = "windowsEnrollment")]
        WindowsEnrollment,
        /// <summary>Indicates that the configured policy type is for a Compliance Policy.</summary>
        [EnumMember(Value = "compliancePolicy")]
        CompliancePolicy,
        /// <summary>Indicates that the configured policy type is for a Configuration Policy.</summary>
        [EnumMember(Value = "configurationPolicy")]
        ConfigurationPolicy,
        /// <summary>Indicates that the configured policy type is for an App Protection Policy.</summary>
        [EnumMember(Value = "appProtectionPolicy")]
        AppProtectionPolicy,
        /// <summary>Indicates that the configured policy type is for a Policy Set.</summary>
        [EnumMember(Value = "policySet")]
        PolicySet,
        /// <summary>Indicates that the configured policy type is for a Filter.</summary>
        [EnumMember(Value = "filter")]
        Filter,
        /// <summary>Indicates that the configured policy type is for an Endpoint Security Policy.</summary>
        [EnumMember(Value = "endpointSecurityPolicy")]
        EndpointSecurityPolicy,
        /// <summary>Indicates that the configured policy type is an application type, such as mobile apps or built-in apps.</summary>
        [EnumMember(Value = "app")]
        App,
        /// <summary>Indicates that the configured policy type is a script type, such as Powershell scripts or remediation scripts.</summary>
        [EnumMember(Value = "script")]
        Script,
        /// <summary>Indicates that the configured policy type is for a Role.</summary>
        [EnumMember(Value = "role")]
        Role,
        /// <summary>Indicates that the configured policy type is for a Device Reset Passcode Action.</summary>
        [EnumMember(Value = "deviceResetPasscode")]
        DeviceResetPasscode,
        /// <summary>Indicates that the configured policy type is for a Custom Organizational Message.</summary>
        [EnumMember(Value = "customOrganizationalMessage")]
        CustomOrganizationalMessage,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
