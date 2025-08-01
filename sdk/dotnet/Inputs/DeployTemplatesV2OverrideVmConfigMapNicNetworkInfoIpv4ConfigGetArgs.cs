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

    public sealed class DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipAddresses")]
        private InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigIpAddressGetArgs>? _ipAddresses;
        public InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigIpAddressGetArgs> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigIpAddressGetArgs>());
            set => _ipAddresses = value;
        }

        [Input("secondaryIpAddressLists")]
        private InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigSecondaryIpAddressListGetArgs>? _secondaryIpAddressLists;
        public InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigSecondaryIpAddressListGetArgs> SecondaryIpAddressLists
        {
            get => _secondaryIpAddressLists ?? (_secondaryIpAddressLists = new InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigSecondaryIpAddressListGetArgs>());
            set => _secondaryIpAddressLists = value;
        }

        [Input("shouldAssignIp")]
        public Input<bool>? ShouldAssignIp { get; set; }

        public DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigGetArgs()
        {
        }
        public static new DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigGetArgs Empty => new DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4ConfigGetArgs();
    }
}
