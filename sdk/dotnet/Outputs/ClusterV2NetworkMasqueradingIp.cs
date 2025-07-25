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
    public sealed class ClusterV2NetworkMasqueradingIp
    {
        /// <summary>
        /// - (Optional) ip address params.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterV2NetworkMasqueradingIpIpv4> Ipv4s;
        /// <summary>
        /// - (Optional) Ip address params.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterV2NetworkMasqueradingIpIpv6> Ipv6s;

        [OutputConstructor]
        private ClusterV2NetworkMasqueradingIp(
            ImmutableArray<Outputs.ClusterV2NetworkMasqueradingIpIpv4> ipv4s,

            ImmutableArray<Outputs.ClusterV2NetworkMasqueradingIpIpv6> ipv6s)
        {
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
