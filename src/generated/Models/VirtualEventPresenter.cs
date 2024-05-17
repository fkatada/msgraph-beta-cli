// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    #pragma warning disable CS1591
    public class VirtualEventPresenter : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Email address of the presenter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Identity information of the presenter. The supported identites are: communicationsGuestIdentity and communicationsUserIdentity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Identity? Identity { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Identity Identity { get; set; }
#endif
        /// <summary>Other detail information of the presenter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VirtualEventPresenterDetails? PresenterDetails { get; set; }
#nullable restore
#else
        public VirtualEventPresenterDetails PresenterDetails { get; set; }
#endif
        /// <summary>The sessions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VirtualEventSession>? Sessions { get; set; }
#nullable restore
#else
        public List<VirtualEventSession> Sessions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VirtualEventPresenter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventPresenter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventPresenter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"email", n => { Email = n.GetStringValue(); } },
                {"identity", n => { Identity = n.GetObjectValue<ApiSdk.Models.Identity>(ApiSdk.Models.Identity.CreateFromDiscriminatorValue); } },
                {"presenterDetails", n => { PresenterDetails = n.GetObjectValue<VirtualEventPresenterDetails>(VirtualEventPresenterDetails.CreateFromDiscriminatorValue); } },
                {"sessions", n => { Sessions = n.GetCollectionOfObjectValues<VirtualEventSession>(VirtualEventSession.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<ApiSdk.Models.Identity>("identity", Identity);
            writer.WriteObjectValue<VirtualEventPresenterDetails>("presenterDetails", PresenterDetails);
            writer.WriteCollectionOfObjectValues<VirtualEventSession>("sessions", Sessions);
        }
    }
}
