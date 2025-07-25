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
    public sealed class GetSubnetV2IpConfigIpv6PoolListResult
    {
        /// <summary>
        /// Reference to address configuration
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSubnetV2IpConfigIpv6PoolListEndIpResult> EndIps;
        /// <summary>
        /// Reference to address configuration
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSubnetV2IpConfigIpv6PoolListStartIpResult> StartIps;

        [OutputConstructor]
        private GetSubnetV2IpConfigIpv6PoolListResult(
            ImmutableArray<Outputs.GetSubnetV2IpConfigIpv6PoolListEndIpResult> endIps,

            ImmutableArray<Outputs.GetSubnetV2IpConfigIpv6PoolListStartIpResult> startIps)
        {
            EndIps = endIps;
            StartIps = startIps;
        }
    }
}
