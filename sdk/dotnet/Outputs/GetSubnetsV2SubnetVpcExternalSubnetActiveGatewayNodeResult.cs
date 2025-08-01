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
    public sealed class GetSubnetsV2SubnetVpcExternalSubnetActiveGatewayNodeResult
    {
        public readonly string NodeId;
        public readonly ImmutableArray<Outputs.GetSubnetsV2SubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressResult> NodeIpAddresses;

        [OutputConstructor]
        private GetSubnetsV2SubnetVpcExternalSubnetActiveGatewayNodeResult(
            string nodeId,

            ImmutableArray<Outputs.GetSubnetsV2SubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressResult> nodeIpAddresses)
        {
            NodeId = nodeId;
            NodeIpAddresses = nodeIpAddresses;
        }
    }
}
