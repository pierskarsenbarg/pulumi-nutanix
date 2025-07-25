// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class GetVolumeIscsiClientsV2IscsiClientResult
    {
        /// <summary>
        /// associated with each iSCSI target corresponding to the iSCSI client)
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVolumeIscsiClientsV2IscsiClientAttachedTargetResult> AttachedTargets;
        /// <summary>
        /// The site where the Volume Group attach operation should be processed. This is an optional field. This field may only be set if Metro DR has been configured for this Volume Group.
        /// </summary>
        public readonly string AttachmentSite;
        /// <summary>
        /// The UUID of the cluster that will host the iSCSI client. This field is read-only.
        /// </summary>
        public readonly string ClusterReference;
        /// <summary>
        /// The authentication type enabled for the Volume Group. This is an optional field. If omitted, authentication is not configured for the Volume Group. If this is set to CHAP, the target/client secret must be provided.
        /// </summary>
        public readonly string EnabledAuthentications;
        /// <summary>
        /// A globally unique identifier of an instance that is suitable for external consumption.
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// iSCSI initiator name. During the attach operation, exactly one of iscsiInitiatorName and iscsiInitiatorNetworkId must be specified. This field is immutable.
        /// </summary>
        public readonly string IscsiInitiatorName;
        /// <summary>
        /// An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVolumeIscsiClientsV2IscsiClientIscsiInitiatorNetworkIdResult> IscsiInitiatorNetworkIds;
        /// <summary>
        /// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVolumeIscsiClientsV2IscsiClientLinkResult> Links;
        /// <summary>
        /// A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
        /// </summary>
        public readonly string TenantId;

        [OutputConstructor]
        private GetVolumeIscsiClientsV2IscsiClientResult(
            ImmutableArray<Outputs.GetVolumeIscsiClientsV2IscsiClientAttachedTargetResult> attachedTargets,

            string attachmentSite,

            string clusterReference,

            string enabledAuthentications,

            string extId,

            string iscsiInitiatorName,

            ImmutableArray<Outputs.GetVolumeIscsiClientsV2IscsiClientIscsiInitiatorNetworkIdResult> iscsiInitiatorNetworkIds,

            ImmutableArray<Outputs.GetVolumeIscsiClientsV2IscsiClientLinkResult> links,

            string tenantId)
        {
            AttachedTargets = attachedTargets;
            AttachmentSite = attachmentSite;
            ClusterReference = clusterReference;
            EnabledAuthentications = enabledAuthentications;
            ExtId = extId;
            IscsiInitiatorName = iscsiInitiatorName;
            IscsiInitiatorNetworkIds = iscsiInitiatorNetworkIds;
            Links = links;
            TenantId = tenantId;
        }
    }
}
