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

    public sealed class ClusterAddNodeV2NodeParamComputeNodeListGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("blockId")]
        public Input<string>? BlockId { get; set; }

        [Input("digitalCertificateMapLists")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListDigitalCertificateMapListGetArgs>? _digitalCertificateMapLists;
        public InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListDigitalCertificateMapListGetArgs> DigitalCertificateMapLists
        {
            get => _digitalCertificateMapLists ?? (_digitalCertificateMapLists = new InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListDigitalCertificateMapListGetArgs>());
            set => _digitalCertificateMapLists = value;
        }

        [Input("hypervisorHostname")]
        public Input<string>? HypervisorHostname { get; set; }

        [Input("hypervisorIps")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListHypervisorIpGetArgs>? _hypervisorIps;
        public InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListHypervisorIpGetArgs> HypervisorIps
        {
            get => _hypervisorIps ?? (_hypervisorIps = new InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListHypervisorIpGetArgs>());
            set => _hypervisorIps = value;
        }

        [Input("ipmiIps")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListIpmiIpGetArgs>? _ipmiIps;
        public InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListIpmiIpGetArgs> IpmiIps
        {
            get => _ipmiIps ?? (_ipmiIps = new InputList<Inputs.ClusterAddNodeV2NodeParamComputeNodeListIpmiIpGetArgs>());
            set => _ipmiIps = value;
        }

        [Input("model")]
        public Input<string>? Model { get; set; }

        [Input("nodePosition")]
        public Input<string>? NodePosition { get; set; }

        [Input("nodeUuid")]
        public Input<string>? NodeUuid { get; set; }

        public ClusterAddNodeV2NodeParamComputeNodeListGetArgs()
        {
        }
        public static new ClusterAddNodeV2NodeParamComputeNodeListGetArgs Empty => new ClusterAddNodeV2NodeParamComputeNodeListGetArgs();
    }
}
