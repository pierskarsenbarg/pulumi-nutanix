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

    public sealed class FoundationCentralImageClusterClusterStatusNodeProgressDetailArgs : Pulumi.ResourceArgs
    {
        [Input("imagedNodeUuid")]
        public Input<string>? ImagedNodeUuid { get; set; }

        [Input("imagingStopped")]
        public Input<bool>? ImagingStopped { get; set; }

        [Input("intentPickedUp")]
        public Input<bool>? IntentPickedUp { get; set; }

        [Input("messageLists")]
        private InputList<string>? _messageLists;
        public InputList<string> MessageLists
        {
            get => _messageLists ?? (_messageLists = new InputList<string>());
            set => _messageLists = value;
        }

        [Input("percentComplete")]
        public Input<double>? PercentComplete { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        public FoundationCentralImageClusterClusterStatusNodeProgressDetailArgs()
        {
        }
    }
}