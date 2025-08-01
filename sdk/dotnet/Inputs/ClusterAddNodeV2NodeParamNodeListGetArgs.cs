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

    public sealed class ClusterAddNodeV2NodeParamNodeListGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// -(Optional) Block ID.
        /// </summary>
        [Input("blockId")]
        public Input<string>? BlockId { get; set; }

        /// <summary>
        /// -(Optional) Current network interface of a node.
        /// </summary>
        [Input("currentNetworkInterface")]
        public Input<string>? CurrentNetworkInterface { get; set; }

        [Input("cvmIps")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamNodeListCvmIpGetArgs>? _cvmIps;

        /// <summary>
        /// -(Optional) An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamNodeListCvmIpGetArgs> CvmIps
        {
            get => _cvmIps ?? (_cvmIps = new InputList<Inputs.ClusterAddNodeV2NodeParamNodeListCvmIpGetArgs>());
            set => _cvmIps = value;
        }

        [Input("digitalCertificateMapLists")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamNodeListDigitalCertificateMapListGetArgs>? _digitalCertificateMapLists;

        /// <summary>
        /// -(Optional) List of objects containing digital_certificate_base64 and key_management_server_uuid fields for key management server.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamNodeListDigitalCertificateMapListGetArgs> DigitalCertificateMapLists
        {
            get => _digitalCertificateMapLists ?? (_digitalCertificateMapLists = new InputList<Inputs.ClusterAddNodeV2NodeParamNodeListDigitalCertificateMapListGetArgs>());
            set => _digitalCertificateMapLists = value;
        }

        /// <summary>
        /// -(Optional) Name of the host.
        /// </summary>
        [Input("hypervisorHostname")]
        public Input<string>? HypervisorHostname { get; set; }

        [Input("hypervisorIps")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamNodeListHypervisorIpGetArgs>? _hypervisorIps;

        /// <summary>
        /// -(Optional) An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamNodeListHypervisorIpGetArgs> HypervisorIps
        {
            get => _hypervisorIps ?? (_hypervisorIps = new InputList<Inputs.ClusterAddNodeV2NodeParamNodeListHypervisorIpGetArgs>());
            set => _hypervisorIps = value;
        }

        /// <summary>
        /// -(Optional) Hypervisor type.
        /// Valid values are:
        /// - `XEN`: Xen hypervisor.
        /// - `HYPERV`: Hyper-V hypervisor.
        /// - `NATIVEHOST`: NativeHost type where AOS runs natively, without hypervisor.
        /// - `ESX`: ESX hypervisor.
        /// - `AHV`: AHV hypervisor.
        /// </summary>
        [Input("hypervisorType")]
        public Input<string>? HypervisorType { get; set; }

        /// <summary>
        /// -(Optional) Host version of the node.
        /// </summary>
        [Input("hypervisorVersion")]
        public Input<string>? HypervisorVersion { get; set; }

        [Input("ipmiIps")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamNodeListIpmiIpGetArgs>? _ipmiIps;

        /// <summary>
        /// -(Optional) An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamNodeListIpmiIpGetArgs> IpmiIps
        {
            get => _ipmiIps ?? (_ipmiIps = new InputList<Inputs.ClusterAddNodeV2NodeParamNodeListIpmiIpGetArgs>());
            set => _ipmiIps = value;
        }

        [Input("isLightCompute")]
        public Input<bool>? IsLightCompute { get; set; }

        /// <summary>
        /// -(Optional) Is ROBO mixed hypervisor.
        /// </summary>
        [Input("isRoboMixedHypervisor")]
        public Input<bool>? IsRoboMixedHypervisor { get; set; }

        /// <summary>
        /// -(Optional) Rackable unit model name.
        /// </summary>
        [Input("model")]
        public Input<string>? Model { get; set; }

        [Input("networks")]
        private InputList<Inputs.ClusterAddNodeV2NodeParamNodeListNetworkGetArgs>? _networks;

        /// <summary>
        /// -(Optional) Active and standby uplink information of the target nodes.
        /// </summary>
        public InputList<Inputs.ClusterAddNodeV2NodeParamNodeListNetworkGetArgs> Networks
        {
            get => _networks ?? (_networks = new InputList<Inputs.ClusterAddNodeV2NodeParamNodeListNetworkGetArgs>());
            set => _networks = value;
        }

        /// <summary>
        /// -(Optional) Node position.
        /// </summary>
        [Input("nodePosition")]
        public Input<string>? NodePosition { get; set; }

        /// <summary>
        /// -(Optional) Node UUID.
        /// </summary>
        [Input("nodeUuid")]
        public Input<string>? NodeUuid { get; set; }

        /// <summary>
        /// -(Optional) NOS software version of a node.
        /// </summary>
        [Input("nosVersion")]
        public Input<string>? NosVersion { get; set; }

        public ClusterAddNodeV2NodeParamNodeListGetArgs()
        {
        }
        public static new ClusterAddNodeV2NodeParamNodeListGetArgs Empty => new ClusterAddNodeV2NodeParamNodeListGetArgs();
    }
}
