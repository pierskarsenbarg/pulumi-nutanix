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
    public sealed class FloatingIpV2VpcExternalSubnet
    {
        public readonly int? ActiveGatewayCount;
        public readonly ImmutableArray<Outputs.FloatingIpV2VpcExternalSubnetActiveGatewayNode> ActiveGatewayNodes;
        public readonly ImmutableArray<Outputs.FloatingIpV2VpcExternalSubnetExternalIp> ExternalIps;
        public readonly ImmutableArray<string> GatewayNodes;
        public readonly string? SubnetReference;

        [OutputConstructor]
        private FloatingIpV2VpcExternalSubnet(
            int? activeGatewayCount,

            ImmutableArray<Outputs.FloatingIpV2VpcExternalSubnetActiveGatewayNode> activeGatewayNodes,

            ImmutableArray<Outputs.FloatingIpV2VpcExternalSubnetExternalIp> externalIps,

            ImmutableArray<string> gatewayNodes,

            string? subnetReference)
        {
            ActiveGatewayCount = activeGatewayCount;
            ActiveGatewayNodes = activeGatewayNodes;
            ExternalIps = externalIps;
            GatewayNodes = gatewayNodes;
            SubnetReference = subnetReference;
        }
    }
}
