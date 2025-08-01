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
    public sealed class DeployTemplatesV2OverrideVmConfigMapNicNetworkInfo
    {
        public readonly ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4Config> Ipv4Configs;
        public readonly ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4Info> Ipv4Infos;
        public readonly ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoNetworkFunctionChain> NetworkFunctionChains;
        public readonly string? NetworkFunctionNicType;
        public readonly string? NicType;
        public readonly bool? ShouldAllowUnknownMacs;
        public readonly ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoSubnet> Subnets;
        public readonly ImmutableArray<int> TrunkedVlans;
        public readonly string? VlanMode;

        [OutputConstructor]
        private DeployTemplatesV2OverrideVmConfigMapNicNetworkInfo(
            ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4Config> ipv4Configs,

            ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoIpv4Info> ipv4Infos,

            ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoNetworkFunctionChain> networkFunctionChains,

            string? networkFunctionNicType,

            string? nicType,

            bool? shouldAllowUnknownMacs,

            ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapNicNetworkInfoSubnet> subnets,

            ImmutableArray<int> trunkedVlans,

            string? vlanMode)
        {
            Ipv4Configs = ipv4Configs;
            Ipv4Infos = ipv4Infos;
            NetworkFunctionChains = networkFunctionChains;
            NetworkFunctionNicType = networkFunctionNicType;
            NicType = nicType;
            ShouldAllowUnknownMacs = shouldAllowUnknownMacs;
            Subnets = subnets;
            TrunkedVlans = trunkedVlans;
            VlanMode = vlanMode;
        }
    }
}
