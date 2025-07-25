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
    public sealed class GetFloatingIpsV2FloatingIpVpcExternalSubnetActiveGatewayNodeResult
    {
        public readonly string NodeId;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpVpcExternalSubnetActiveGatewayNodeNodeIpAddressResult> NodeIpAddresses;

        [OutputConstructor]
        private GetFloatingIpsV2FloatingIpVpcExternalSubnetActiveGatewayNodeResult(
            string nodeId,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpVpcExternalSubnetActiveGatewayNodeNodeIpAddressResult> nodeIpAddresses)
        {
            NodeId = nodeId;
            NodeIpAddresses = nodeIpAddresses;
        }
    }
}
