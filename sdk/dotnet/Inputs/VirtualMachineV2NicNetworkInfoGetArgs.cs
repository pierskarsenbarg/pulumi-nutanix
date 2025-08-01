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

    public sealed class VirtualMachineV2NicNetworkInfoGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipv4Configs")]
        private InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigGetArgs>? _ipv4Configs;

        /// <summary>
        /// The IP address configurations.
        /// </summary>
        public InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigGetArgs> Ipv4Configs
        {
            get => _ipv4Configs ?? (_ipv4Configs = new InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigGetArgs>());
            set => _ipv4Configs = value;
        }

        [Input("ipv4Infos")]
        private InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4InfoGetArgs>? _ipv4Infos;
        public InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4InfoGetArgs> Ipv4Infos
        {
            get => _ipv4Infos ?? (_ipv4Infos = new InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4InfoGetArgs>());
            set => _ipv4Infos = value;
        }

        [Input("networkFunctionChains")]
        private InputList<Inputs.VirtualMachineV2NicNetworkInfoNetworkFunctionChainGetArgs>? _networkFunctionChains;

        /// <summary>
        /// The network function chain associates with the NIC. Only valid if nic_type is NORMAL_NIC.
        /// </summary>
        public InputList<Inputs.VirtualMachineV2NicNetworkInfoNetworkFunctionChainGetArgs> NetworkFunctionChains
        {
            get => _networkFunctionChains ?? (_networkFunctionChains = new InputList<Inputs.VirtualMachineV2NicNetworkInfoNetworkFunctionChainGetArgs>());
            set => _networkFunctionChains = value;
        }

        /// <summary>
        /// The type of this Network function NIC. Defaults to INGRESS.
        /// </summary>
        [Input("networkFunctionNicType")]
        public Input<string>? NetworkFunctionNicType { get; set; }

        /// <summary>
        /// NIC type. Valid values "SPAN_DESTINATION_NIC",  "NORMAL_NIC", "DIRECT_NIC", "NETWORK_FUNCTION_NIC" .
        /// </summary>
        [Input("nicType")]
        public Input<string>? NicType { get; set; }

        /// <summary>
        /// Indicates whether an unknown unicast traffic is forwarded to this NIC or not. This is applicable only for the NICs on the overlay subnets.
        /// </summary>
        [Input("shouldAllowUnknownMacs")]
        public Input<bool>? ShouldAllowUnknownMacs { get; set; }

        [Input("subnets")]
        private InputList<Inputs.VirtualMachineV2NicNetworkInfoSubnetGetArgs>? _subnets;

        /// <summary>
        /// Network identifier for this adapter. Only valid if nic_type is NORMAL_NIC or DIRECT_NIC
        /// * `subnet.ext_id`: (Optional) The globally unique identifier of a subnet of type UUID.
        /// </summary>
        public InputList<Inputs.VirtualMachineV2NicNetworkInfoSubnetGetArgs> Subnets
        {
            get => _subnets ?? (_subnets = new InputList<Inputs.VirtualMachineV2NicNetworkInfoSubnetGetArgs>());
            set => _subnets = value;
        }

        [Input("trunkedVlans")]
        private InputList<int>? _trunkedVlans;

        /// <summary>
        /// List of networks to trunk if VLAN mode is marked as TRUNKED. If empty and VLAN mode is set to TRUNKED, all the VLANs are trunked.
        /// </summary>
        public InputList<int> TrunkedVlans
        {
            get => _trunkedVlans ?? (_trunkedVlans = new InputList<int>());
            set => _trunkedVlans = value;
        }

        /// <summary>
        /// all the virtual NICs are created in ACCESS mode, which permits only one VLAN per virtual network. TRUNKED mode allows multiple VLANs on a single VM NIC for network-aware user VMs.
        /// </summary>
        [Input("vlanMode")]
        public Input<string>? VlanMode { get; set; }

        public VirtualMachineV2NicNetworkInfoGetArgs()
        {
        }
        public static new VirtualMachineV2NicNetworkInfoGetArgs Empty => new VirtualMachineV2NicNetworkInfoGetArgs();
    }
}
