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

    public sealed class FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipv4s")]
        private InputList<Inputs.FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressIpv4Args>? _ipv4s;

        /// <summary>
        /// Reference to IP Configuration
        /// </summary>
        public InputList<Inputs.FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressIpv4Args> Ipv4s
        {
            get => _ipv4s ?? (_ipv4s = new InputList<Inputs.FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressIpv4Args>());
            set => _ipv4s = value;
        }

        [Input("ipv6s")]
        private InputList<Inputs.FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressIpv6Args>? _ipv6s;

        /// <summary>
        /// Reference to IP Configuration
        /// </summary>
        public InputList<Inputs.FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressIpv6Args> Ipv6s
        {
            get => _ipv6s ?? (_ipv6s = new InputList<Inputs.FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressIpv6Args>());
            set => _ipv6s = value;
        }

        public FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressArgs()
        {
        }
        public static new FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressArgs Empty => new FloatingIpV2ExternalSubnetVpcExternalSubnetActiveGatewayNodeNodeIpAddressArgs();
    }
}
