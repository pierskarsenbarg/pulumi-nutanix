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
    public sealed class GetSubnetV2VpcResult
    {
        public readonly ImmutableArray<Outputs.GetSubnetV2VpcCommonDhcpOptionResult> CommonDhcpOptions;
        /// <summary>
        /// Description of the subnet.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// - (Required) The UUID of the subnet.
        /// </summary>
        public readonly string ExtId;
        public readonly string ExternalRoutingDomainReference;
        public readonly ImmutableArray<Outputs.GetSubnetV2VpcExternalSubnetResult> ExternalSubnets;
        public readonly ImmutableArray<Outputs.GetSubnetV2VpcExternallyRoutablePrefixResult> ExternallyRoutablePrefixes;
        /// <summary>
        /// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSubnetV2VpcLinkResult> Links;
        public readonly ImmutableArray<Outputs.GetSubnetV2VpcMetadataResult> Metadatas;
        /// <summary>
        /// Name of the subnet.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetSubnetV2VpcSnatIpResult> SnatIps;
        public readonly string TenantId;
        public readonly string VpcType;

        [OutputConstructor]
        private GetSubnetV2VpcResult(
            ImmutableArray<Outputs.GetSubnetV2VpcCommonDhcpOptionResult> commonDhcpOptions,

            string description,

            string extId,

            string externalRoutingDomainReference,

            ImmutableArray<Outputs.GetSubnetV2VpcExternalSubnetResult> externalSubnets,

            ImmutableArray<Outputs.GetSubnetV2VpcExternallyRoutablePrefixResult> externallyRoutablePrefixes,

            ImmutableArray<Outputs.GetSubnetV2VpcLinkResult> links,

            ImmutableArray<Outputs.GetSubnetV2VpcMetadataResult> metadatas,

            string name,

            ImmutableArray<Outputs.GetSubnetV2VpcSnatIpResult> snatIps,

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
