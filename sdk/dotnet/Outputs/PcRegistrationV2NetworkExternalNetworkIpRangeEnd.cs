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
    public sealed class PcRegistrationV2NetworkExternalNetworkIpRangeEnd
    {
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv4> Ipv4s;
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv6 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv6> Ipv6s;

        [OutputConstructor]
        private PcRegistrationV2NetworkExternalNetworkIpRangeEnd(
            ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv4> ipv4s,

            ImmutableArray<Outputs.PcRegistrationV2NetworkExternalNetworkIpRangeEndIpv6> ipv6s)
        {
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
