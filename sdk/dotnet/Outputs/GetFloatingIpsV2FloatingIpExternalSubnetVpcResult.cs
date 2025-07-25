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
    public sealed class GetFloatingIpsV2FloatingIpExternalSubnetVpcResult
    {
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcCommonDhcpOptionResult> CommonDhcpOptions;
        /// <summary>
        /// Description for the Floating IP.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Floating IP UUID
        /// </summary>
        public readonly string ExtId;
        public readonly string ExternalRoutingDomainReference;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcExternalSubnetResult> ExternalSubnets;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcExternallyRoutablePrefixResult> ExternallyRoutablePrefixes;
        /// <summary>
        /// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcLinkResult> Links;
        /// <summary>
        /// Metadata associated with this resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcMetadataResult> Metadatas;
        /// <summary>
        /// Name of the floating IP.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcSnatIpResult> SnatIps;
        /// <summary>
        /// A globally unique identifier that represents the tenant that owns this entity.
        /// </summary>
        public readonly string TenantId;
        public readonly string VpcType;

        [OutputConstructor]
        private GetFloatingIpsV2FloatingIpExternalSubnetVpcResult(
            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcCommonDhcpOptionResult> commonDhcpOptions,

            string description,

            string extId,

            string externalRoutingDomainReference,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcExternalSubnetResult> externalSubnets,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcExternallyRoutablePrefixResult> externallyRoutablePrefixes,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcLinkResult> links,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcMetadataResult> metadatas,

            string name,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcSnatIpResult> snatIps,

            string tenantId,

            string vpcType)
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
