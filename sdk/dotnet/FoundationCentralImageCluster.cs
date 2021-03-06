// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    [NutanixResourceType("nutanix:index/foundationCentralImageCluster:FoundationCentralImageCluster")]
    public partial class FoundationCentralImageCluster : Pulumi.CustomResource
    {
        [Output("aosPackageSha256sum")]
        public Output<string> AosPackageSha256sum { get; private set; } = null!;

        [Output("aosPackageUrl")]
        public Output<string> AosPackageUrl { get; private set; } = null!;

        [Output("archived")]
        public Output<bool> Archived { get; private set; } = null!;

        [Output("clusterExternalIp")]
        public Output<string> ClusterExternalIp { get; private set; } = null!;

        [Output("clusterName")]
        public Output<string> ClusterName { get; private set; } = null!;

        [Output("clusterSize")]
        public Output<int> ClusterSize { get; private set; } = null!;

        [Output("clusterStatus")]
        public Output<Outputs.FoundationCentralImageClusterClusterStatus> ClusterStatus { get; private set; } = null!;

        [Output("commonNetworkSettings")]
        public Output<Outputs.FoundationCentralImageClusterCommonNetworkSettings> CommonNetworkSettings { get; private set; } = null!;

        [Output("createdTimestamp")]
        public Output<string> CreatedTimestamp { get; private set; } = null!;

        [Output("currentTime")]
        public Output<string> CurrentTime { get; private set; } = null!;

        [Output("destroyed")]
        public Output<bool> Destroyed { get; private set; } = null!;

        [Output("foundationInitConfigs")]
        public Output<ImmutableArray<Outputs.FoundationCentralImageClusterFoundationInitConfig>> FoundationInitConfigs { get; private set; } = null!;

        [Output("foundationInitNodeUuid")]
        public Output<string> FoundationInitNodeUuid { get; private set; } = null!;

        [Output("hypervisorIsoDetails")]
        public Output<Outputs.FoundationCentralImageClusterHypervisorIsoDetails> HypervisorIsoDetails { get; private set; } = null!;

        [Output("imageClusterUuid")]
        public Output<string> ImageClusterUuid { get; private set; } = null!;

        [Output("imagedClusterUuid")]
        public Output<string> ImagedClusterUuid { get; private set; } = null!;

        [Output("imagedNodeUuidLists")]
        public Output<ImmutableArray<string>> ImagedNodeUuidLists { get; private set; } = null!;

        [Output("nodeLists")]
        public Output<ImmutableArray<Outputs.FoundationCentralImageClusterNodeList>> NodeLists { get; private set; } = null!;

        [Output("redundancyFactor")]
        public Output<int> RedundancyFactor { get; private set; } = null!;

        [Output("skipClusterCreation")]
        public Output<bool?> SkipClusterCreation { get; private set; } = null!;

        [Output("storageNodeCount")]
        public Output<int> StorageNodeCount { get; private set; } = null!;

        [Output("timezone")]
        public Output<string> Timezone { get; private set; } = null!;

        [Output("workflowType")]
        public Output<string> WorkflowType { get; private set; } = null!;


        /// <summary>
        /// Create a FoundationCentralImageCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FoundationCentralImageCluster(string name, FoundationCentralImageClusterArgs? args = null, CustomResourceOptions? options = null)
            : base("nutanix:index/foundationCentralImageCluster:FoundationCentralImageCluster", name, args ?? new FoundationCentralImageClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FoundationCentralImageCluster(string name, Input<string> id, FoundationCentralImageClusterState? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/foundationCentralImageCluster:FoundationCentralImageCluster", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/pierskarsenbarg/pulumi-nutanix/releases/download/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FoundationCentralImageCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FoundationCentralImageCluster Get(string name, Input<string> id, FoundationCentralImageClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new FoundationCentralImageCluster(name, id, state, options);
        }
    }

    public sealed class FoundationCentralImageClusterArgs : Pulumi.ResourceArgs
    {
        [Input("aosPackageSha256sum")]
        public Input<string>? AosPackageSha256sum { get; set; }

        [Input("aosPackageUrl")]
        public Input<string>? AosPackageUrl { get; set; }

        [Input("clusterExternalIp")]
        public Input<string>? ClusterExternalIp { get; set; }

        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        [Input("clusterSize")]
        public Input<int>? ClusterSize { get; set; }

        [Input("clusterStatus")]
        public Input<Inputs.FoundationCentralImageClusterClusterStatusArgs>? ClusterStatus { get; set; }

        [Input("commonNetworkSettings")]
        public Input<Inputs.FoundationCentralImageClusterCommonNetworkSettingsArgs>? CommonNetworkSettings { get; set; }

        [Input("hypervisorIsoDetails")]
        public Input<Inputs.FoundationCentralImageClusterHypervisorIsoDetailsArgs>? HypervisorIsoDetails { get; set; }

        [Input("imageClusterUuid")]
        public Input<string>? ImageClusterUuid { get; set; }

        [Input("nodeLists")]
        private InputList<Inputs.FoundationCentralImageClusterNodeListArgs>? _nodeLists;
        public InputList<Inputs.FoundationCentralImageClusterNodeListArgs> NodeLists
        {
            get => _nodeLists ?? (_nodeLists = new InputList<Inputs.FoundationCentralImageClusterNodeListArgs>());
            set => _nodeLists = value;
        }

        [Input("redundancyFactor")]
        public Input<int>? RedundancyFactor { get; set; }

        [Input("skipClusterCreation")]
        public Input<bool>? SkipClusterCreation { get; set; }

        [Input("storageNodeCount")]
        public Input<int>? StorageNodeCount { get; set; }

        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        public FoundationCentralImageClusterArgs()
        {
        }
    }

    public sealed class FoundationCentralImageClusterState : Pulumi.ResourceArgs
    {
        [Input("aosPackageSha256sum")]
        public Input<string>? AosPackageSha256sum { get; set; }

        [Input("aosPackageUrl")]
        public Input<string>? AosPackageUrl { get; set; }

        [Input("archived")]
        public Input<bool>? Archived { get; set; }

        [Input("clusterExternalIp")]
        public Input<string>? ClusterExternalIp { get; set; }

        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        [Input("clusterSize")]
        public Input<int>? ClusterSize { get; set; }

        [Input("clusterStatus")]
        public Input<Inputs.FoundationCentralImageClusterClusterStatusGetArgs>? ClusterStatus { get; set; }

        [Input("commonNetworkSettings")]
        public Input<Inputs.FoundationCentralImageClusterCommonNetworkSettingsGetArgs>? CommonNetworkSettings { get; set; }

        [Input("createdTimestamp")]
        public Input<string>? CreatedTimestamp { get; set; }

        [Input("currentTime")]
        public Input<string>? CurrentTime { get; set; }

        [Input("destroyed")]
        public Input<bool>? Destroyed { get; set; }

        [Input("foundationInitConfigs")]
        private InputList<Inputs.FoundationCentralImageClusterFoundationInitConfigGetArgs>? _foundationInitConfigs;
        public InputList<Inputs.FoundationCentralImageClusterFoundationInitConfigGetArgs> FoundationInitConfigs
        {
            get => _foundationInitConfigs ?? (_foundationInitConfigs = new InputList<Inputs.FoundationCentralImageClusterFoundationInitConfigGetArgs>());
            set => _foundationInitConfigs = value;
        }

        [Input("foundationInitNodeUuid")]
        public Input<string>? FoundationInitNodeUuid { get; set; }

        [Input("hypervisorIsoDetails")]
        public Input<Inputs.FoundationCentralImageClusterHypervisorIsoDetailsGetArgs>? HypervisorIsoDetails { get; set; }

        [Input("imageClusterUuid")]
        public Input<string>? ImageClusterUuid { get; set; }

        [Input("imagedClusterUuid")]
        public Input<string>? ImagedClusterUuid { get; set; }

        [Input("imagedNodeUuidLists")]
        private InputList<string>? _imagedNodeUuidLists;
        public InputList<string> ImagedNodeUuidLists
        {
            get => _imagedNodeUuidLists ?? (_imagedNodeUuidLists = new InputList<string>());
            set => _imagedNodeUuidLists = value;
        }

        [Input("nodeLists")]
        private InputList<Inputs.FoundationCentralImageClusterNodeListGetArgs>? _nodeLists;
        public InputList<Inputs.FoundationCentralImageClusterNodeListGetArgs> NodeLists
        {
            get => _nodeLists ?? (_nodeLists = new InputList<Inputs.FoundationCentralImageClusterNodeListGetArgs>());
            set => _nodeLists = value;
        }

        [Input("redundancyFactor")]
        public Input<int>? RedundancyFactor { get; set; }

        [Input("skipClusterCreation")]
        public Input<bool>? SkipClusterCreation { get; set; }

        [Input("storageNodeCount")]
        public Input<int>? StorageNodeCount { get; set; }

        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        [Input("workflowType")]
        public Input<string>? WorkflowType { get; set; }

        public FoundationCentralImageClusterState()
        {
        }
    }
}
