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

    public sealed class ClusterAddNodeV2NodeParamGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("blockLists")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamBlockListGetArgs>? _blockLists;

        /// <summary>
        /// -(Optional) Block list of a cluster.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamBlockListGetArgs> BlockLists
        {
            get => _blockLists ?? (_blockLists = new InputList<Inputs.ClusterAddNodeV2NodeParamBlockListGetArgs>());
            set => _blockLists = value;
        }

        [Input("bundleInfos")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamBundleInfoGetArgs>? _bundleInfos;

        /// <summary>
        /// -(Optional) Hypervisor bundle information.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamBundleInfoGetArgs> BundleInfos
        {
            get => _bundleInfos ?? (_bundleInfos = new InputList<Inputs.ClusterAddNodeV2NodeParamBundleInfoGetArgs>());
            set => _bundleInfos = value;
        }

        [Input("computeNodeLists")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListGetArgs>? _computeNodeLists;
        public InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListGetArgs> ComputeNodeLists
        {
            get => _computeNodeLists ?? (_computeNodeLists = new InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListGetArgs>());
            set => _computeNodeLists = value;
        }

        /// <summary>
        /// -(Optional) Hyperv SKU.
        /// </summary>
        [Input("hypervSku")]
        public Input<string>? HypervSku { get; set; }

        [Input("hypervisorIsos")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamHypervisorIsoGetArgs>? _hypervisorIsos;

        /// <summary>
        /// -(Optional) Hypervisor type to md5sum map.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamHypervisorIsoGetArgs> HypervisorIsos
        {
            get => _hypervisorIsos ?? (_hypervisorIsos = new InputList<Inputs.ClusterAddNodeV2NodeParamHypervisorIsoGetArgs>());
            set => _hypervisorIsos = value;
        }

        [Input("nodeLists", required: true)]
        private InputList<Inputs.ClusterAddNodeV2NodeParamNodeListGetArgs>? _nodeLists;

        /// <summary>
        /// -(Required) List of nodes in a cluster.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamNodeListGetArgs> NodeLists
        {
            get => _nodeLists ?? (_nodeLists = new InputList<Inputs.ClusterAddNodeV2NodeParamNodeListGetArgs>());
            set => _nodeLists = value;
        }

        /// <summary>
        /// -(Optional) Indicates if the host networking needs to be skipped or not.
        /// </summary>
        [Input("shouldSkipHostNetworking")]
        public Input<bool>? ShouldSkipHostNetworking { get; set; }

        public ClusterAddNodeV2NodeParamGetArgs()
        {
        }
        public static new ClusterAddNodeV2NodeParamGetArgs Empty => new ClusterAddNodeV2NodeParamGetArgs();
    }
}
