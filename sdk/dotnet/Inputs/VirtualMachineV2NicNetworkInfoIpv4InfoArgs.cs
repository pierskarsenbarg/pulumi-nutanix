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

    public sealed class VirtualMachineV2NicNetworkInfoIpv4InfoArgs : global::Pulumi.ResourceArgs
    {
        [Input("learnedIpAddresses")]
        private InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4InfoLearnedIpAddressArgs>? _learnedIpAddresses;
        public InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4InfoLearnedIpAddressArgs> LearnedIpAddresses
        {
            get => _learnedIpAddresses ?? (_learnedIpAddresses = new InputList<Inputs.VirtualMachineV2NicNetworkInfoIpv4InfoLearnedIpAddressArgs>());
            set => _learnedIpAddresses = value;
        }

        public VirtualMachineV2NicNetworkInfoIpv4InfoArgs()
        {
        }
        public static new VirtualMachineV2NicNetworkInfoIpv4InfoArgs Empty => new VirtualMachineV2NicNetworkInfoIpv4InfoArgs();
    }
}
