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

    public sealed class VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipv4s")]
        private InputList<Inputs.VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressIpv4Args>? _ipv4s;
        public InputList<Inputs.VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressIpv4Args> Ipv4s
        {
            get => _ipv4s ?? (_ipv4s = new InputList<Inputs.VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressIpv4Args>());
            set => _ipv4s = value;
        }

        [Input("ipv6s")]
        private InputList<Inputs.VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressIpv6Args>? _ipv6s;
        public InputList<Inputs.VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressIpv6Args> Ipv6s
        {
            get => _ipv6s ?? (_ipv6s = new InputList<Inputs.VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressIpv6Args>());
            set => _ipv6s = value;
        }

        public VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressArgs()
        {
        }
        public static new VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressArgs Empty => new VpcV2ExternalSubnetActiveGatewayNodeNodeIpAddressArgs();
    }
}
