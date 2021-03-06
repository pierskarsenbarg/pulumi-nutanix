// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class KarbonClusterEtcdNodePoolGetArgs : Pulumi.ResourceArgs
    {
        [Input("ahvConfig")]
        public Input<Inputs.KarbonClusterEtcdNodePoolAhvConfigGetArgs>? AhvConfig { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("nodeOsVersion", required: true)]
        public Input<string> NodeOsVersion { get; set; } = null!;

        [Input("nodes")]
        private InputList<Inputs.KarbonClusterEtcdNodePoolNodeGetArgs>? _nodes;
        public InputList<Inputs.KarbonClusterEtcdNodePoolNodeGetArgs> Nodes
        {
            get => _nodes ?? (_nodes = new InputList<Inputs.KarbonClusterEtcdNodePoolNodeGetArgs>());
            set => _nodes = value;
        }

        [Input("numInstances", required: true)]
        public Input<int> NumInstances { get; set; } = null!;

        public KarbonClusterEtcdNodePoolGetArgs()
        {
        }
    }
}
