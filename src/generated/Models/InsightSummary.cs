// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class InsightSummary : Entity, IParsable 
    {
        /// <summary>Daily active users.</summary>
        public long? ActiveUsers { get; set; }
        /// <summary>The ID of the Microsoft Entra application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>Daily authentication completions.</summary>
        public long? AuthenticationCompletions { get; set; }
        /// <summary>Daily authentication requests.</summary>
        public long? AuthenticationRequests { get; set; }
        /// <summary>The date of the insight.</summary>
        public Date? FactDate { get; set; }
        /// <summary>The platform for the device that the customers used. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Os { get; set; }
#nullable restore
#else
        public string Os { get; set; }
#endif
        /// <summary>Daily MFA SMS completions.</summary>
        public long? SecurityTextCompletions { get; set; }
        /// <summary>Daily MFA SMS requests.</summary>
        public long? SecurityTextRequests { get; set; }
        /// <summary>Daily MFA Voice completions.</summary>
        public long? SecurityVoiceCompletions { get; set; }
        /// <summary>Daily MFA Voice requests.</summary>
        public long? SecurityVoiceRequests { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="InsightSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InsightSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InsightSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"activeUsers", n => { ActiveUsers = n.GetLongValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"authenticationCompletions", n => { AuthenticationCompletions = n.GetLongValue(); } },
                {"authenticationRequests", n => { AuthenticationRequests = n.GetLongValue(); } },
                {"factDate", n => { FactDate = n.GetDateValue(); } },
                {"os", n => { Os = n.GetStringValue(); } },
                {"securityTextCompletions", n => { SecurityTextCompletions = n.GetLongValue(); } },
                {"securityTextRequests", n => { SecurityTextRequests = n.GetLongValue(); } },
                {"securityVoiceCompletions", n => { SecurityVoiceCompletions = n.GetLongValue(); } },
                {"securityVoiceRequests", n => { SecurityVoiceRequests = n.GetLongValue(); } },
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
            writer.WriteLongValue("activeUsers", ActiveUsers);
            writer.WriteStringValue("appId", AppId);
            writer.WriteLongValue("authenticationCompletions", AuthenticationCompletions);
            writer.WriteLongValue("authenticationRequests", AuthenticationRequests);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteStringValue("os", Os);
            writer.WriteLongValue("securityTextCompletions", SecurityTextCompletions);
            writer.WriteLongValue("securityTextRequests", SecurityTextRequests);
            writer.WriteLongValue("securityVoiceCompletions", SecurityVoiceCompletions);
            writer.WriteLongValue("securityVoiceRequests", SecurityVoiceRequests);
        }
    }
}
