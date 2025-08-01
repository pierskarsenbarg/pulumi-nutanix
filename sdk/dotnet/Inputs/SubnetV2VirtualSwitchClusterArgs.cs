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

    public sealed class SubnetV2VirtualSwitchClusterArgs : global::Pulumi.ResourceArgs
    {
        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        [Input("gatewayIpAddresses")]
        private InputList<Inputs.SubnetV2VirtualSwitchClusterGatewayIpAddressArgs>? _gatewayIpAddresses;
        public InputList<Inputs.SubnetV2VirtualSwitchClusterGatewayIpAddressArgs> GatewayIpAddresses
        {
            get => _gatewayIpAddresses ?? (_gatewayIpAddresses = new InputList<Inputs.SubnetV2VirtualSwitchClusterGatewayIpAddressArgs>());
            set => _gatewayIpAddresses = value;
        }

        [Input("hosts")]
        private InputList<Inputs.SubnetV2VirtualSwitchClusterHostArgs>? _hosts;
        public InputList<Inputs.SubnetV2VirtualSwitchClusterHostArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.SubnetV2VirtualSwitchClusterHostArgs>());
            set => _hosts = value;
        }

        public SubnetV2VirtualSwitchClusterArgs()
        {
        }
        public static new SubnetV2VirtualSwitchClusterArgs Empty => new SubnetV2VirtualSwitchClusterArgs();
    }
}
