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

    public sealed class DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4InfoArgs : global::Pulumi.ResourceArgs
    {
        [Input("learnedIpAddresses")]
        private InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4InfoLearnedIpAddressArgs>? _learnedIpAddresses;
        public InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4InfoLearnedIpAddressArgs> LearnedIpAddresses
        {
            get => _learnedIpAddresses ?? (_learnedIpAddresses = new InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4InfoLearnedIpAddressArgs>());
            set => _learnedIpAddresses = value;
        }

        public DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4InfoArgs()
        {
        }
        public static new DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4InfoArgs Empty => new DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4InfoArgs();
    }
}
