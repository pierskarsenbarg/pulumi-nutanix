// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class VirtualMachineV2NicNetworkInfoIpv4Info
    {
        public readonly ImmutableArray<Outputs.VirtualMachineV2NicNetworkInfoIpv4InfoLearnedIpAddress> LearnedIpAddresses;

        [OutputConstructor]
        private VirtualMachineV2NicNetworkInfoIpv4Info(ImmutableArray<Outputs.VirtualMachineV2NicNetworkInfoIpv4InfoLearnedIpAddress> learnedIpAddresses)
        {
            LearnedIpAddresses = learnedIpAddresses;
        }
    }
}
