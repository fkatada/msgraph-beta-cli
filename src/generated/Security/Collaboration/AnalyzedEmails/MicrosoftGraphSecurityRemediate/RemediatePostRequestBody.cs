// <auto-generated/>
using ApiSdk.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Security.Collaboration.AnalyzedEmails.MicrosoftGraphSecurityRemediate {
    #pragma warning disable CS1591
    public class RemediatePostRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public RemediationAction? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The analyzedEmails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AnalyzedEmail>? AnalyzedEmails { get; set; }
#nullable restore
#else
        public List<AnalyzedEmail> AnalyzedEmails { get; set; }
#endif
        /// <summary>The approverUpn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApproverUpn { get; set; }
#nullable restore
#else
        public string ApproverUpn { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The remediateSendersCopy property</summary>
        public bool? RemediateSendersCopy { get; set; }
        /// <summary>The severity property</summary>
        public RemediationSeverity? Severity { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RemediatePostRequestBody"/> and sets the default values.
        /// </summary>
        public RemediatePostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RemediatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RemediatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemediatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"action", n => { Action = n.GetEnumValue<RemediationAction>(); } },
                {"analyzedEmails", n => { AnalyzedEmails = n.GetCollectionOfObjectValues<AnalyzedEmail>(AnalyzedEmail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"approverUpn", n => { ApproverUpn = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"remediateSendersCopy", n => { RemediateSendersCopy = n.GetBoolValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<RemediationSeverity>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RemediationAction>("action", Action);
            writer.WriteCollectionOfObjectValues<AnalyzedEmail>("analyzedEmails", AnalyzedEmails);
            writer.WriteStringValue("approverUpn", ApproverUpn);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("remediateSendersCopy", RemediateSendersCopy);
            writer.WriteEnumValue<RemediationSeverity>("severity", Severity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
