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
    public sealed class GetFoundationCentralClusterDetailsFoundationInitConfigResult
    {
        public readonly ImmutableArray<Outputs.GetFoundationCentralClusterDetailsFoundationInitConfigBlockResult> Blocks;
        public readonly ImmutableArray<Outputs.GetFoundationCentralClusterDetailsFoundationInitConfigClusterResult> Clusters;
        public readonly string CvmGateway;
        public readonly string CvmNetmask;
        public readonly string DnsServers;
        public readonly string HypervProductKey;
        public readonly string HypervSku;
        public readonly string HypervisorGateway;
        public readonly ImmutableDictionary<string, string> HypervisorIsoUrl;
        public readonly ImmutableArray<Outputs.GetFoundationCentralClusterDetailsFoundationInitConfigHypervisorIsoResult> HypervisorIsos;
        public readonly string HypervisorNetmask;
        public readonly string IpmiGateway;
        public readonly string IpmiNetmask;
        public readonly ImmutableArray<Outputs.GetFoundationCentralClusterDetailsFoundationInitConfigNosPackageUrlResult> NosPackageUrls;

        [OutputConstructor]
        private GetFoundationCentralClusterDetailsFoundationInitConfigResult(
            ImmutableArray<Outputs.GetFoundationCentralClusterDetailsFoundationInitConfigBlockResult> blocks,

            ImmutableArray<Outputs.GetFoundationCentralClusterDetailsFoundationInitConfigClusterResult> clusters,

            string cvmGateway,

            string cvmNetmask,

            string dnsServers,

            string hypervProductKey,

            string hypervSku,

            string hypervisorGateway,

            ImmutableDictionary<string, string> hypervisorIsoUrl,

            ImmutableArray<Outputs.GetFoundationCentralClusterDetailsFoundationInitConfigHypervisorIsoResult> hypervisorIsos,

            string hypervisorNetmask,

            string ipmiGateway,

            string ipmiNetmask,

            ImmutableArray<Outputs.GetFoundationCentralClusterDetailsFoundationInitConfigNosPackageUrlResult> nosPackageUrls)
        {
            Blocks = blocks;
            Clusters = clusters;
            CvmGateway = cvmGateway;
            CvmNetmask = cvmNetmask;
            DnsServers = dnsServers;
            HypervProductKey = hypervProductKey;
            HypervSku = hypervSku;
            HypervisorGateway = hypervisorGateway;
            HypervisorIsoUrl = hypervisorIsoUrl;
            HypervisorIsos = hypervisorIsos;
            HypervisorNetmask = hypervisorNetmask;
            IpmiGateway = ipmiGateway;
            IpmiNetmask = ipmiNetmask;
            NosPackageUrls = nosPackageUrls;
        }
    }
}
