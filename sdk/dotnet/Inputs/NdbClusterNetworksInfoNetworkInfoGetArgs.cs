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

    public sealed class NdbClusterNetworksInfoNetworkInfoGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// gateway of agent network
        /// </summary>
        [Input("gateway")]
        public Input<string>? Gateway { get; set; }

        /// <summary>
        /// static ip of agent network
        /// </summary>
        [Input("staticIp")]
        public Input<string>? StaticIp { get; set; }

        /// <summary>
        /// subnet mask of agent network
        /// </summary>
        [Input("subnetMask")]
        public Input<string>? SubnetMask { get; set; }

        /// <summary>
        /// vlan name
        /// </summary>
        [Input("vlanName")]
        public Input<string>? VlanName { get; set; }

        public NdbClusterNetworksInfoNetworkInfoGetArgs()
        {
        }
        public static new NdbClusterNetworksInfoNetworkInfoGetArgs Empty => new NdbClusterNetworksInfoNetworkInfoGetArgs();
    }
}