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
    public sealed class ClusterV2NetworkNameServerIpList
    {
        /// <summary>
        /// - (Optional) A fully qualified domain name that specifies its exact location in the tree hierarchy of the Domain Name System.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterV2NetworkNameServerIpListFqdn> Fqdns;
        /// <summary>
        /// - (Optional) ip address params.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterV2NetworkNameServerIpListIpv4> Ipv4s;
        /// <summary>
        /// - (Optional) Ip address params.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterV2NetworkNameServerIpListIpv6> Ipv6s;

        [OutputConstructor]
        private ClusterV2NetworkNameServerIpList(
            ImmutableArray<Outputs.ClusterV2NetworkNameServerIpListFqdn> fqdns,

            ImmutableArray<Outputs.ClusterV2NetworkNameServerIpListIpv4> ipv4s,

            ImmutableArray<Outputs.ClusterV2NetworkNameServerIpListIpv6> ipv6s)
        {
            Fqdns = fqdns;
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
