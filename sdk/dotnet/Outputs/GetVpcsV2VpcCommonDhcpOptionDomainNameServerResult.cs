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
    public sealed class GetVpcsV2VpcCommonDhcpOptionDomainNameServerResult
    {
        public readonly ImmutableArray<Outputs.GetVpcsV2VpcCommonDhcpOptionDomainNameServerIpv4Result> Ipv4s;
        public readonly ImmutableArray<Outputs.GetVpcsV2VpcCommonDhcpOptionDomainNameServerIpv6Result> Ipv6s;

        [OutputConstructor]
        private GetVpcsV2VpcCommonDhcpOptionDomainNameServerResult(
            ImmutableArray<Outputs.GetVpcsV2VpcCommonDhcpOptionDomainNameServerIpv4Result> ipv4s,

            ImmutableArray<Outputs.GetVpcsV2VpcCommonDhcpOptionDomainNameServerIpv6Result> ipv6s)
        {
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
