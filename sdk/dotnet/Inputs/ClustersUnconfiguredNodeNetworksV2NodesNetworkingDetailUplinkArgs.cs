// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkArgs : global::Pulumi.ResourceArgs
    {
        [Input("cvmIps")]
        private InputList<Inputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkCvmIpArgs>? _cvmIps;

        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public InputList<Inputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkCvmIpArgs> CvmIps
        {
            get => _cvmIps ?? (_cvmIps = new InputList<Inputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkCvmIpArgs>());
            set => _cvmIps = value;
        }

        [Input("uplinkLists")]
        private InputList<Inputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkUplinkListArgs>? _uplinkLists;

        /// <summary>
        /// - Uplink details for a controller VM.
        /// </summary>
        public InputList<Inputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkUplinkListArgs> UplinkLists
        {
            get => _uplinkLists ?? (_uplinkLists = new InputList<Inputs.ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkUplinkListArgs>());
            set => _uplinkLists = value;
        }

        public ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkArgs()
        {
        }
        public static new ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkArgs Empty => new ClustersUnconfiguredNodeNetworksV2NodesNetworkingDetailUplinkArgs();
    }
}
