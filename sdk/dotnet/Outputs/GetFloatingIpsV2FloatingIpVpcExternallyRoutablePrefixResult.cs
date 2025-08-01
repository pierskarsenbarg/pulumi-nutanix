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
    public sealed class GetFloatingIpsV2FloatingIpVpcExternallyRoutablePrefixResult
    {
        /// <summary>
        /// Reference to IP Configuration
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpVpcExternallyRoutablePrefixIpv4Result> Ipv4s;
        /// <summary>
        /// Reference to IP Configuration
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpVpcExternallyRoutablePrefixIpv6Result> Ipv6s;

        [OutputConstructor]
        private GetFloatingIpsV2FloatingIpVpcExternallyRoutablePrefixResult(
            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpVpcExternallyRoutablePrefixIpv4Result> ipv4s,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpVpcExternallyRoutablePrefixIpv6Result> ipv6s)
        {
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
