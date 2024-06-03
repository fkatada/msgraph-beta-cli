// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    /// <summary>VPN Authentication Method.</summary>
    public enum VpnAuthenticationMethod
    {
        /// <summary>Authenticate with a certificate.</summary>
        [EnumMember(Value = "certificate")]
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        [EnumMember(Value = "usernameAndPassword")]
        UsernameAndPassword,
        /// <summary>Use Shared Secret for Authentication.  Only valid for iOS IKEv2.</summary>
        [EnumMember(Value = "sharedSecret")]
        SharedSecret,
        /// <summary>Use Derived Credential for Authentication.</summary>
        [EnumMember(Value = "derivedCredential")]
        DerivedCredential,
        /// <summary>Use Azure AD for authentication.</summary>
        [EnumMember(Value = "azureAD")]
        AzureAD,
    }
}
