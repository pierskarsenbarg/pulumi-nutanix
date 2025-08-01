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
    public sealed class GetVpcV2ExternalSubnetExternalIpResult
    {
        /// <summary>
        /// IP V4 Configuration
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVpcV2ExternalSubnetExternalIpIpv4Result> Ipv4s;
        /// <summary>
        /// IP V6 Configuration
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVpcV2ExternalSubnetExternalIpIpv6Result> Ipv6s;

        [OutputConstructor]
        private GetVpcV2ExternalSubnetExternalIpResult(
            ImmutableArray<Outputs.GetVpcV2ExternalSubnetExternalIpIpv4Result> ipv4s,

            ImmutableArray<Outputs.GetVpcV2ExternalSubnetExternalIpIpv6Result> ipv6s)
        {
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
