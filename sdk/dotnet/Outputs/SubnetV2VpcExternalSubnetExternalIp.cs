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
    public sealed class SubnetV2VpcExternalSubnetExternalIp
    {
        public readonly ImmutableArray<Outputs.SubnetV2VpcExternalSubnetExternalIpIpv4> Ipv4s;
        public readonly ImmutableArray<Outputs.SubnetV2VpcExternalSubnetExternalIpIpv6> Ipv6s;

        [OutputConstructor]
        private SubnetV2VpcExternalSubnetExternalIp(
            ImmutableArray<Outputs.SubnetV2VpcExternalSubnetExternalIpIpv4> ipv4s,

            ImmutableArray<Outputs.SubnetV2VpcExternalSubnetExternalIpIpv6> ipv6s)
        {
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
