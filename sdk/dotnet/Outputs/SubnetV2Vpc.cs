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
    public sealed class SubnetV2Vpc
    {
        public readonly ImmutableArray<Outputs.SubnetV2VpcCommonDhcpOption> CommonDhcpOptions;
        public readonly string? Description;
        public readonly string? ExtId;
        public readonly string? ExternalRoutingDomainReference;
        public readonly ImmutableArray<Outputs.SubnetV2VpcExternalSubnet> ExternalSubnets;
        public readonly ImmutableArray<Outputs.SubnetV2VpcExternallyRoutablePrefix> ExternallyRoutablePrefixes;
        public readonly ImmutableArray<Outputs.SubnetV2VpcLink> Links;
        public readonly ImmutableArray<Outputs.SubnetV2VpcMetadata> Metadatas;
        public readonly string? Name;
        public readonly ImmutableArray<Outputs.SubnetV2VpcSnatIp> SnatIps;
        public readonly string? TenantId;
        public readonly string? VpcType;

        [OutputConstructor]
        private SubnetV2Vpc(
            ImmutableArray<Outputs.SubnetV2VpcCommonDhcpOption> commonDhcpOptions,

            string? description,

            string? extId,

            string? externalRoutingDomainReference,

            ImmutableArray<Outputs.SubnetV2VpcExternalSubnet> externalSubnets,

            ImmutableArray<Outputs.SubnetV2VpcExternallyRoutablePrefix> externallyRoutablePrefixes,

            ImmutableArray<Outputs.SubnetV2VpcLink> links,

            ImmutableArray<Outputs.SubnetV2VpcMetadata> metadatas,

            string? name,

            ImmutableArray<Outputs.SubnetV2VpcSnatIp> snatIps,

            string? tenantId,

            string? vpcType)
        {
            CommonDhcpOptions = commonDhcpOptions;
            Description = description;
            ExtId = extId;
            ExternalRoutingDomainReference = externalRoutingDomainReference;
            ExternalSubnets = externalSubnets;
            ExternallyRoutablePrefixes = externallyRoutablePrefixes;
            Links = links;
            Metadatas = metadatas;
            Name = name;
            SnatIps = snatIps;
            TenantId = tenantId;
            VpcType = vpcType;
        }
    }
}
