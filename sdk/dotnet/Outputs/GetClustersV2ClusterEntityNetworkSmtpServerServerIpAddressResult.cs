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
    public sealed class GetClustersV2ClusterEntityNetworkSmtpServerServerIpAddressResult
    {
        /// <summary>
        /// - Cluster fully qualified domain name. This is part of payload for cluster update operation only.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClustersV2ClusterEntityNetworkSmtpServerServerIpAddressFqdnResult> Fqdns;
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClustersV2ClusterEntityNetworkSmtpServerServerIpAddressIpv4Result> Ipv4s;
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv6 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClustersV2ClusterEntityNetworkSmtpServerServerIpAddressIpv6Result> Ipv6s;

        [OutputConstructor]
        private GetClustersV2ClusterEntityNetworkSmtpServerServerIpAddressResult(
            ImmutableArray<Outputs.GetClustersV2ClusterEntityNetworkSmtpServerServerIpAddressFqdnResult> fqdns,

            ImmutableArray<Outputs.GetClustersV2ClusterEntityNetworkSmtpServerServerIpAddressIpv4Result> ipv4s,

            ImmutableArray<Outputs.GetClustersV2ClusterEntityNetworkSmtpServerServerIpAddressIpv6Result> ipv6s)
        {
            Fqdns = fqdns;
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
