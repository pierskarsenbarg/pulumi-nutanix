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
    public sealed class GetFloatingIpV2ExternalSubnetIpConfigIpv6Result
    {
        public readonly ImmutableArray<Outputs.GetFloatingIpV2ExternalSubnetIpConfigIpv6DefaultGatewayIpResult> DefaultGatewayIps;
        public readonly ImmutableArray<Outputs.GetFloatingIpV2ExternalSubnetIpConfigIpv6DhcpServerAddressResult> DhcpServerAddresses;
        public readonly ImmutableArray<Outputs.GetFloatingIpV2ExternalSubnetIpConfigIpv6IpSubnetResult> IpSubnets;
        public readonly ImmutableArray<Outputs.GetFloatingIpV2ExternalSubnetIpConfigIpv6PoolListResult> PoolLists;

        [OutputConstructor]
        private GetFloatingIpV2ExternalSubnetIpConfigIpv6Result(
            ImmutableArray<Outputs.GetFloatingIpV2ExternalSubnetIpConfigIpv6DefaultGatewayIpResult> defaultGatewayIps,

            ImmutableArray<Outputs.GetFloatingIpV2ExternalSubnetIpConfigIpv6DhcpServerAddressResult> dhcpServerAddresses,

            ImmutableArray<Outputs.GetFloatingIpV2ExternalSubnetIpConfigIpv6IpSubnetResult> ipSubnets,

            ImmutableArray<Outputs.GetFloatingIpV2ExternalSubnetIpConfigIpv6PoolListResult> poolLists)
        {
            DefaultGatewayIps = defaultGatewayIps;
            DhcpServerAddresses = dhcpServerAddresses;
            IpSubnets = ipSubnets;
            PoolLists = poolLists;
        }
    }
}
