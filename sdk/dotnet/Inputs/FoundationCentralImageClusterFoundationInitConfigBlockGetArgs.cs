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

    public sealed class FoundationCentralImageClusterFoundationInitConfigBlockGetArgs : Pulumi.ResourceArgs
    {
        [Input("blockId")]
        public Input<string>? BlockId { get; set; }

        [Input("nodes")]
        private InputList<Inputs.FoundationCentralImageClusterFoundationInitConfigBlockNodeGetArgs>? _nodes;
        public InputList<Inputs.FoundationCentralImageClusterFoundationInitConfigBlockNodeGetArgs> Nodes
        {
            get => _nodes ?? (_nodes = new InputList<Inputs.FoundationCentralImageClusterFoundationInitConfigBlockNodeGetArgs>());
            set => _nodes = value;
        }

        public FoundationCentralImageClusterFoundationInitConfigBlockGetArgs()
        {
        }
    }
}