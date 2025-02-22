// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class PcRegistrationV2NetworkExternalNetwork
    {
        public readonly ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkDefaultGateway> DefaultGateways;
        public readonly ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkIpRange> IpRanges;
        public readonly string? NetworkExtId;
        public readonly ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkSubnetMask> SubnetMasks;

        [OutputConstructor]
        private PcRegistrationV2NetworkExternalNetwork(
            ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkDefaultGateway> defaultGateways,

            ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkIpRange> ipRanges,

            string? networkExtId,

            ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkSubnetMask> subnetMasks)
        {
            DefaultGateways = defaultGateways;
            IpRanges = ipRanges;
            NetworkExtId = networkExtId;
            SubnetMasks = subnetMasks;
        }
    }
}
