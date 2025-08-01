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
    public sealed class SubnetV2VirtualSwitch
    {
        public readonly bool? BondMode;
        public readonly ImmutableArray<Outputs.SubnetV2VirtualSwitchCluster> Clusters;
        public readonly string? Description;
        public readonly string? ExtId;
        public readonly bool? HasDeploymentError;
        public readonly bool? IsDefault;
        public readonly ImmutableArray<Outputs.SubnetV2VirtualSwitchLink> Links;
        public readonly ImmutableArray<Outputs.SubnetV2VirtualSwitchMetadata> Metadatas;
        public readonly int? Mtu;
        public readonly string? Name;
        public readonly string? TenantId;

        [OutputConstructor]
        private SubnetV2VirtualSwitch(
            bool? bondMode,

            ImmutableArray<Outputs.SubnetV2VirtualSwitchCluster> clusters,

            string? description,

            string? extId,

            bool? hasDeploymentError,

            bool? isDefault,

            ImmutableArray<Outputs.SubnetV2VirtualSwitchLink> links,

            ImmutableArray<Outputs.SubnetV2VirtualSwitchMetadata> metadatas,

            int? mtu,

            string? name,

            string? tenantId)
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
