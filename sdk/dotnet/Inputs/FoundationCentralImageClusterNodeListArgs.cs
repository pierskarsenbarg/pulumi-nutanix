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

    public sealed class FoundationCentralImageClusterNodeListArgs : Pulumi.ResourceArgs
    {
        [Input("cvmGateway")]
        public Input<string>? CvmGateway { get; set; }

        [Input("cvmIp")]
        public Input<string>? CvmIp { get; set; }

        [Input("cvmNetmask")]
        public Input<string>? CvmNetmask { get; set; }

        [Input("cvmRamGb")]
        public Input<int>? CvmRamGb { get; set; }

        [Input("cvmVlanId")]
        public Input<int>? CvmVlanId { get; set; }

        [Input("hardwareAttributesOverride")]
        private InputMap<object>? _hardwareAttributesOverride;
        public InputMap<object> HardwareAttributesOverride
        {
            get => _hardwareAttributesOverride ?? (_hardwareAttributesOverride = new InputMap<object>());
            set => _hardwareAttributesOverride = value;
        }

        [Input("hypervisorGateway")]
        public Input<string>? HypervisorGateway { get; set; }

        [Input("hypervisorHostname")]
        public Input<string>? HypervisorHostname { get; set; }

        [Input("hypervisorIp")]
        public Input<string>? HypervisorIp { get; set; }

        [Input("hypervisorNetmask")]
        public Input<string>? HypervisorNetmask { get; set; }

        [Input("hypervisorType")]
        public Input<string>? HypervisorType { get; set; }

        [Input("imageNow")]
        public Input<bool>? ImageNow { get; set; }

        [Input("imagedNodeUuid")]
        public Input<string>? ImagedNodeUuid { get; set; }

        [Input("ipmiGateway")]
        public Input<string>? IpmiGateway { get; set; }

        [Input("ipmiIp")]
        public Input<string>? IpmiIp { get; set; }

        [Input("ipmiNetmask")]
        public Input<string>? IpmiNetmask { get; set; }

        [Input("rdmaPassthrough")]
        public Input<bool>? RdmaPassthrough { get; set; }

        [Input("useExistingNetworkSettings")]
        public Input<bool>? UseExistingNetworkSettings { get; set; }

        public FoundationCentralImageClusterNodeListArgs()
        {
        }
    }
}