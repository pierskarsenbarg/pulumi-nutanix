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
    public sealed class GetKarbonClustersClusterWorkerNodePoolNodeResult
    {
        public readonly string Hostname;
        public readonly string Ipv4Address;

        [OutputConstructor]
        private GetKarbonClustersClusterWorkerNodePoolNodeResult(
            string hostname,

            string ipv4Address)
        {
            Hostname = hostname;
            Ipv4Address = ipv4Address;
        }
    }
}
