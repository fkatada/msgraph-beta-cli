// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    [Flags]
    #pragma warning disable CS1591
    public enum ConditionalAccessConditions
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "application")]
        #pragma warning disable CS1591
        Application = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "users")]
        #pragma warning disable CS1591
        Users = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "devicePlatform")]
        #pragma warning disable CS1591
        DevicePlatform = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "location")]
        #pragma warning disable CS1591
        Location = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "clientType")]
        #pragma warning disable CS1591
        ClientType = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "signInRisk")]
        #pragma warning disable CS1591
        SignInRisk = 64,
        #pragma warning restore CS1591
        [EnumMember(Value = "userRisk")]
        #pragma warning disable CS1591
        UserRisk = 128,
        #pragma warning restore CS1591
        [EnumMember(Value = "time")]
        #pragma warning disable CS1591
        Time = 256,
        #pragma warning restore CS1591
        [EnumMember(Value = "deviceState")]
        #pragma warning disable CS1591
        DeviceState = 512,
        #pragma warning restore CS1591
        [EnumMember(Value = "client")]
        #pragma warning disable CS1591
        Client = 1024,
        #pragma warning restore CS1591
        [EnumMember(Value = "ipAddressSeenByAzureAD")]
        #pragma warning disable CS1591
        IpAddressSeenByAzureAD = 2048,
        #pragma warning restore CS1591
        [EnumMember(Value = "ipAddressSeenByResourceProvider")]
        #pragma warning disable CS1591
        IpAddressSeenByResourceProvider = 4096,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 8192,
        #pragma warning restore CS1591
        [EnumMember(Value = "servicePrincipals")]
        #pragma warning disable CS1591
        ServicePrincipals = 16384,
        #pragma warning restore CS1591
        [EnumMember(Value = "servicePrincipalRisk")]
        #pragma warning disable CS1591
        ServicePrincipalRisk = 32768,
        #pragma warning restore CS1591
        [EnumMember(Value = "authenticationFlows")]
        #pragma warning disable CS1591
        AuthenticationFlows = 65536,
        #pragma warning restore CS1591
        [EnumMember(Value = "insiderRisk")]
        #pragma warning disable CS1591
        InsiderRisk = 131072,
        #pragma warning restore CS1591
    }
}
