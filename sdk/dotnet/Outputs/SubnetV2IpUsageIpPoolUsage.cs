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
    public sealed class SubnetV2IpUsageIpPoolUsage
    {
        public readonly int? NumFreeIps;
        public readonly int? NumTotalIps;
        public readonly ImmutableArray<Outputs.SubnetV2IpUsageIpPoolUsageRange> Ranges;

        [OutputConstructor]
        private SubnetV2IpUsageIpPoolUsage(
            int? numFreeIps,

            int? numTotalIps,

            ImmutableArray<Outputs.SubnetV2IpUsageIpPoolUsageRange> ranges)
        {
            NumFreeIps = numFreeIps;
            NumTotalIps = numTotalIps;
            Ranges = ranges;
        }
    }
}
