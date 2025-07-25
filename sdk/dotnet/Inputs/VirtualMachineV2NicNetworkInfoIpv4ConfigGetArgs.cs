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

    public sealed class VirtualMachineV2NicNetworkInfoIpv4ConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipAddresses")]
        private InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigIpAddressGetArgs>? _ipAddresses;

        /// <summary>
        /// The IP address of the NIC.
        /// </summary>
        public InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigIpAddressGetArgs> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigIpAddressGetArgs>());
            set => _ipAddresses = value;
        }

        [Input("secondaryIpAddressLists")]
        private InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigSecondaryIpAddressListGetArgs>? _secondaryIpAddressLists;

        /// <summary>
        /// Secondary IP addresses for the NIC.
        /// </summary>
        public InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigSecondaryIpAddressListGetArgs> SecondaryIpAddressLists
        {
            get => _secondaryIpAddressLists ?? (_secondaryIpAddressLists = new InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4ConfigSecondaryIpAddressListGetArgs>());
            set => _secondaryIpAddressLists = value;
        }

        /// <summary>
        /// If set to true (default value), an IP address must be assigned to the VM NIC - either the one explicitly specified by the user or allocated automatically by the IPAM service by not specifying the IP address. If false, then no IP assignment is required for this VM NIC.
        /// </summary>
        [Input("shouldAssignIp")]
        public Input<bool>? ShouldAssignIp { get; set; }

        public VirtualMachineV2NicNetworkInfoIpv4ConfigGetArgs()
        {
        }
        public static new VirtualMachineV2NicNetworkInfoIpv4ConfigGetArgs Empty => new VirtualMachineV2NicNetworkInfoIpv4ConfigGetArgs();
    }
}
