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

    public sealed class PcDeployV2NetworkExternalNetworkArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// -(Required) An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
        /// </summary>
        [Input("defaultGateway", required: true)]
        public Input<Inputs.PcDeployV2NetworkExternalNetworkDefaultGatewayArgs> DefaultGateway { get; set; } = null!;

        [Input("ipRanges", required: true)]
        private InputList<Inputs.PcDeployV2NetworkExternalNetworkIpRangeArgs>? _ipRanges;

        /// <summary>
        /// -(Required) Range of IPs used for Prism Central network setup.
        /// </summary>
        public InputList<Inputs.PcDeployV2NetworkExternalNetworkIpRangeArgs> IpRanges
        {
            get => _ipRanges ?? (_ipRanges = new InputList<Inputs.PcDeployV2NetworkExternalNetworkIpRangeArgs>());
            set => _ipRanges = value;
        }

        /// <summary>
        /// -(Required) The network external identifier to which Domain Manager (Prism Central) is to be deployed or is already configured.
        /// </summary>
        [Input("networkExtId", required: true)]
        public Input<string> NetworkExtId { get; set; } = null!;

        /// <summary>
        /// -(Required) An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
        /// </summary>
        [Input("subnetMask", required: true)]
        public Input<Inputs.PcDeployV2NetworkExternalNetworkSubnetMaskArgs> SubnetMask { get; set; } = null!;

        public PcDeployV2NetworkExternalNetworkArgs()
        {
        }
        public static new PcDeployV2NetworkExternalNetworkArgs Empty => new PcDeployV2NetworkExternalNetworkArgs();
    }
}
