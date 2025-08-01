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
    public sealed class ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplink
    {
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkCvmIp> CvmIps;
        /// <summary>
        /// - Uplink details for a controller VM.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkUplinkList> UplinkLists;

        [OutputConstructor]
        private ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplink(
            ImmutableArray<Outputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkCvmIp> cvmIps,

            ImmutableArray<Outputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkUplinkList> uplinkLists)
        {
            CvmIps = cvmIps;
            UplinkLists = uplinkLists;
        }
    }
}
