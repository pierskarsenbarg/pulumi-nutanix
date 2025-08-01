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
    public sealed class VpcV2ExternallyRoutablePrefixIpv6
    {
        public readonly ImmutableArray<Outputs.VpcV2ExternallyRoutablePrefixIpv6Ip> Ips;
        public readonly int PrefixLength;

        [OutputConstructor]
        private VpcV2ExternallyRoutablePrefixIpv6(
            ImmutableArray<Outputs.VpcV2ExternallyRoutablePrefixIpv6Ip> ips,

            int prefixLength)
        {
            Ips = ips;
            PrefixLength = prefixLength;
        }
    }
}
