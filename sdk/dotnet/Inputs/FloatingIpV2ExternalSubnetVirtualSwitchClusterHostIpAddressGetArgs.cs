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

    public sealed class FloatingIpV2ExternalSubnetVirtualSwitchClusterHostIpAddressGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ips")]
        private InputList<Inputs.FloatingIpV2ExternalSubnetVirtualSwitchClusterHostIpAddressIpGetArgs>? _ips;
        public InputList<Inputs.FloatingIpV2ExternalSubnetVirtualSwitchClusterHostIpAddressIpGetArgs> Ips
        {
            get => _ips ?? (_ips = new InputList<Inputs.FloatingIpV2ExternalSubnetVirtualSwitchClusterHostIpAddressIpGetArgs>());
            set => _ips = value;
        }

        /// <summary>
        /// Prefix length of the network to which this host IPv4 address belongs. Default value is 32.
        /// </summary>
        [Input("prefixLength")]
        public Input<int>? PrefixLength { get; set; }

        public FloatingIpV2ExternalSubnetVirtualSwitchClusterHostIpAddressGetArgs()
        {
        }
        public static new FloatingIpV2ExternalSubnetVirtualSwitchClusterHostIpAddressGetArgs Empty => new FloatingIpV2ExternalSubnetVirtualSwitchClusterHostIpAddressGetArgs();
    }
}
