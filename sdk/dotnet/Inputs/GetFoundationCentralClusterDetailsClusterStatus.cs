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

    public sealed class GetFoundationCentralClusterDetailsClusterStatusArgs : Pulumi.InvokeArgs
    {
        [Input("aggregatePercentComplete", required: true)]
        public double AggregatePercentComplete { get; set; }

        [Input("clusterCreationStarted", required: true)]
        public bool ClusterCreationStarted { get; set; }

        [Input("clusterProgressDetails", required: true)]
        private List<Inputs.GetFoundationCentralClusterDetailsClusterStatusClusterProgressDetailArgs>? _clusterProgressDetails;
        public List<Inputs.GetFoundationCentralClusterDetailsClusterStatusClusterProgressDetailArgs> ClusterProgressDetails
        {
            get => _clusterProgressDetails ?? (_clusterProgressDetails = new List<Inputs.GetFoundationCentralClusterDetailsClusterStatusClusterProgressDetailArgs>());
            set => _clusterProgressDetails = value;
        }

        [Input("currentFoundationIp", required: true)]
        public string CurrentFoundationIp { get; set; } = null!;

        [Input("foundationSessionId", required: true)]
        public string FoundationSessionId { get; set; } = null!;

        [Input("imagingStopped", required: true)]
        public bool ImagingStopped { get; set; }

        [Input("intentPickedUp", required: true)]
        public bool IntentPickedUp { get; set; }

        [Input("nodeProgressDetails", required: true)]
        private List<Inputs.GetFoundationCentralClusterDetailsClusterStatusNodeProgressDetailArgs>? _nodeProgressDetails;
        public List<Inputs.GetFoundationCentralClusterDetailsClusterStatusNodeProgressDetailArgs> NodeProgressDetails
        {
            get => _nodeProgressDetails ?? (_nodeProgressDetails = new List<Inputs.GetFoundationCentralClusterDetailsClusterStatusNodeProgressDetailArgs>());
            set => _nodeProgressDetails = value;
        }

        public GetFoundationCentralClusterDetailsClusterStatusArgs()
        {
        }
    }
}