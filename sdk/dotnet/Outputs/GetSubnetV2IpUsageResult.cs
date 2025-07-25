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
    public sealed class GetSubnetV2IpUsageResult
    {
        /// <summary>
        /// IP Pool usages
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSubnetV2IpUsageIpPoolUsageResult> IpPoolUsages;
        /// <summary>
        /// Number of assigned IPs.
        /// </summary>
        public readonly int NumAssignedIps;
        /// <summary>
        /// Number of free IPs
        /// </summary>
        public readonly int NumFreeIps;
        /// <summary>
        /// Number of MAC addresses.
        /// </summary>
        public readonly int NumMacs;

        [OutputConstructor]
        private GetSubnetV2IpUsageResult(
            ImmutableArray<Outputs.GetSubnetV2IpUsageIpPoolUsageResult> ipPoolUsages,

            int numAssignedIps,

            int numFreeIps,

            int numMacs)
        {
            IpPoolUsages = ipPoolUsages;
            NumAssignedIps = numAssignedIps;
            NumFreeIps = numFreeIps;
            NumMacs = numMacs;
        }
    }
}
