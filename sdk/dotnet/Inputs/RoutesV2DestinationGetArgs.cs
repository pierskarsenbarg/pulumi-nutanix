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

    public sealed class RoutesV2DestinationGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// IPv4 Subnet Object
        /// * `ipv4.ip`: (Required) An unique address that identifies a device on the internet or a local network in IPv4 format.
        /// * `ipv4.ip.value`: (Required) The IPv4 address of the host.
        /// * `ipv4.ip.prefix_length`: (Optional) The prefix length of the network to which this host IPv4 address belongs.
        /// * `ipv4.prefix_length`: (Required) The prefix length of the network to which this host IPv4 address belongs.
        /// </summary>
        [Input("ipv4")]
        public Input<Inputs.RoutesV2DestinationIpv4GetArgs>? Ipv4 { get; set; }

        /// <summary>
        /// IPv6 Subnet Object
        /// * `ipv6.ip`: (Required) IP address format
        /// * `ipv6.ip.value`: (Required) The IPv6 address of the host.
        /// * `ipv6.ip.prefix_length`: (Optional) The prefix length of the network to which this host IPv6 address belongs.
        /// * `ipv6.prefix_length`: (Required) The prefix length of the network to which this host IPv6 address belongs.
        /// </summary>
        [Input("ipv6")]
        public Input<Inputs.RoutesV2DestinationIpv6GetArgs>? Ipv6 { get; set; }

        public RoutesV2DestinationGetArgs()
        {
        }
        public static new RoutesV2DestinationGetArgs Empty => new RoutesV2DestinationGetArgs();
    }
}
