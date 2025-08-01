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

    public sealed class SubnetV2IpConfigIpv6GetArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultGatewayIps")]
        private InputList<Inputs.SubnetV2IpConfigIpv6DefaultGatewayIpGetArgs>? _defaultGatewayIps;
        public InputList<Inputs.SubnetV2IpConfigIpv6DefaultGatewayIpGetArgs> DefaultGatewayIps
        {
            get => _defaultGatewayIps ?? (_defaultGatewayIps = new InputList<Inputs.SubnetV2IpConfigIpv6DefaultGatewayIpGetArgs>());
            set => _defaultGatewayIps = value;
        }

        [Input("dhcpServerAddresses")]
        private InputList<Inputs.SubnetV2IpConfigIpv6DhcpServerAddressGetArgs>? _dhcpServerAddresses;
        public InputList<Inputs.SubnetV2IpConfigIpv6DhcpServerAddressGetArgs> DhcpServerAddresses
        {
            get => _dhcpServerAddresses ?? (_dhcpServerAddresses = new InputList<Inputs.SubnetV2IpConfigIpv6DhcpServerAddressGetArgs>());
            set => _dhcpServerAddresses = value;
        }

        [Input("ipSubnets")]
        private InputList<Inputs.SubnetV2IpConfigIpv6IpSubnetGetArgs>? _ipSubnets;
        public InputList<Inputs.SubnetV2IpConfigIpv6IpSubnetGetArgs> IpSubnets
        {
            get => _ipSubnets ?? (_ipSubnets = new InputList<Inputs.SubnetV2IpConfigIpv6IpSubnetGetArgs>());
            set => _ipSubnets = value;
        }

        [Input("poolLists")]
        private InputList<Inputs.SubnetV2IpConfigIpv6PoolListGetArgs>? _poolLists;
        public InputList<Inputs.SubnetV2IpConfigIpv6PoolListGetArgs> PoolLists
        {
            get => _poolLists ?? (_poolLists = new InputList<Inputs.SubnetV2IpConfigIpv6PoolListGetArgs>());
            set => _poolLists = value;
        }

        public SubnetV2IpConfigIpv6GetArgs()
        {
        }
        public static new SubnetV2IpConfigIpv6GetArgs Empty => new SubnetV2IpConfigIpv6GetArgs();
    }
}
