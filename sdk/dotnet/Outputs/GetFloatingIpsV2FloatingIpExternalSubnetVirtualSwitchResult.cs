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
    public sealed class GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchResult
    {
        public readonly bool BondMode;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchClusterResult> Clusters;
        /// <summary>
        /// Description for the Floating IP.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Floating IP UUID
        /// </summary>
        public readonly string ExtId;
        public readonly bool HasDeploymentError;
        public readonly bool IsDefault;
        /// <summary>
        /// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchLinkResult> Links;
        /// <summary>
        /// Metadata associated with this resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchMetadataResult> Metadatas;
        public readonly int Mtu;
        /// <summary>
        /// Name of the floating IP.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A globally unique identifier that represents the tenant that owns this entity.
        /// </summary>
        public readonly string TenantId;

        [OutputConstructor]
        private GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchResult(
            bool bondMode,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchClusterResult> clusters,

            string description,

            string extId,

            bool hasDeploymentError,

            bool isDefault,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchLinkResult> links,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchMetadataResult> metadatas,

            int mtu,

            string name,

            string tenantId)
        {
            BondMode = bondMode;
            Clusters = clusters;
            Description = description;
            ExtId = extId;
            HasDeploymentError = hasDeploymentError;
            IsDefault = isDefault;
            Links = links;
            Metadatas = metadatas;
            Mtu = mtu;
            Name = name;
            TenantId = tenantId;
        }
    }
}
