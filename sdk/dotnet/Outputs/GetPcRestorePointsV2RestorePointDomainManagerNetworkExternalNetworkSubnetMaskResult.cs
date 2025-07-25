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
    public sealed class GetPcRestorePointsV2RestorePointDomainManagerNetworkExternalNetworkSubnetMaskResult
    {
        public readonly ImmutableArray<Outputs.GetPcRestorePointsV2RestorePointDomainManagerNetworkExternalNetworkSubnetMaskFqdnResult> Fqdns;
        public readonly ImmutableArray<Outputs.GetPcRestorePointsV2RestorePointDomainManagerNetworkExternalNetworkSubnetMaskIpv4Result> Ipv4s;
        public readonly ImmutableArray<Outputs.GetPcRestorePointsV2RestorePointDomainManagerNetworkExternalNetworkSubnetMaskIpv6Result> Ipv6s;

        [OutputConstructor]
        private GetPcRestorePointsV2RestorePointDomainManagerNetworkExternalNetworkSubnetMaskResult(
            ImmutableArray<Outputs.GetPcRestorePointsV2RestorePointDomainManagerNetworkExternalNetworkSubnetMaskFqdnResult> fqdns,

            ImmutableArray<Outputs.GetPcRestorePointsV2RestorePointDomainManagerNetworkExternalNetworkSubnetMaskIpv4Result> ipv4s,

            ImmutableArray<Outputs.GetPcRestorePointsV2RestorePointDomainManagerNetworkExternalNetworkSubnetMaskIpv6Result> ipv6s)
        {
            Fqdns = fqdns;
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
