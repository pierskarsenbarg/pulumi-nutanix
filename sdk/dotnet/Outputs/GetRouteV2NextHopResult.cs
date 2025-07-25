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
    public sealed class GetRouteV2NextHopResult
    {
        /// <summary>
        /// An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRouteV2NextHopNextHopIpAddressResult> NextHopIpAddresses;
        public readonly string NextHopName;
        /// <summary>
        /// The reference to a link, such as a VPN connection or a subnet.
        /// </summary>
        public readonly string NextHopReference;
        /// <summary>
        /// Nexthop type.
        /// - supported values:
        /// - `LOCAL_SUBNET`: - Next hop is an internal subnet.
        /// - `DIRECT_CONNECT_VIF`: - Next hop is a direct connect VIF.
        /// - `VPN_CONNECTION`: - Next hop is a VPN connection.
        /// - `IP_ADDRESS`: - Next hop is an IP address.
        /// - `EXTERNAL_SUBNET`: - Next hop is an external subnet.
        /// </summary>
        public readonly string NextHopType;

        [OutputConstructor]
        private GetRouteV2NextHopResult(
            ImmutableArray<Outputs.GetRouteV2NextHopNextHopIpAddressResult> nextHopIpAddresses,

            string nextHopName,

            string nextHopReference,

            string nextHopType)
        {
            NextHopIpAddresses = nextHopIpAddresses;
            NextHopName = nextHopName;
            NextHopReference = nextHopReference;
            NextHopType = nextHopType;
        }
    }
}
