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
    public sealed class GetFloatingIpsV2FloatingIpExternalSubnetResult
    {
        public readonly string BridgeName;
        public readonly string ClusterName;
        public readonly string ClusterReference;
        /// <summary>
        /// Description for the Floating IP.
        /// </summary>
        public readonly string Description;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetDhcpOptionResult> DhcpOptions;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetDynamicIpAddressResult> DynamicIpAddresses;
        /// <summary>
        /// Floating IP UUID
        /// </summary>
        public readonly string ExtId;
        public readonly string HypervisorType;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetIpConfigResult> IpConfigs;
        public readonly string IpPrefix;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetIpUsageResult> IpUsages;
        public readonly bool IsAdvancedNetworking;
        public readonly bool IsExternal;
        public readonly bool IsNatEnabled;
        /// <summary>
        /// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetLinkResult> Links;
        public readonly string MigrationState;
        /// <summary>
        /// Name of the floating IP.
        /// </summary>
        public readonly string Name;
        public readonly string NetworkFunctionChainReference;
        public readonly int NetworkId;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetReservedIpAddressResult> ReservedIpAddresses;
        public readonly string SubnetType;
        public readonly string VirtualSwitchReference;
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchResult> VirtualSwitches;
        /// <summary>
        /// VPC reference UUID
        /// </summary>
        public readonly string VpcReference;
        /// <summary>
        /// Networking common base object
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcResult> Vpcs;

        [OutputConstructor]
        private GetFloatingIpsV2FloatingIpExternalSubnetResult(
            string bridgeName,

            string clusterName,

            string clusterReference,

            string description,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetDhcpOptionResult> dhcpOptions,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetDynamicIpAddressResult> dynamicIpAddresses,

            string extId,

            string hypervisorType,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetIpConfigResult> ipConfigs,

            string ipPrefix,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetIpUsageResult> ipUsages,

            bool isAdvancedNetworking,

            bool isExternal,

            bool isNatEnabled,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetLinkResult> links,

            string migrationState,

            string name,

            string networkFunctionChainReference,

            int networkId,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetReservedIpAddressResult> reservedIpAddresses,

            string subnetType,

            string virtualSwitchReference,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVirtualSwitchResult> virtualSwitches,

            string vpcReference,

            ImmutableArray<Outputs.GetFloatingIpsV2FloatingIpExternalSubnetVpcResult> vpcs)
        {
            BridgeName = bridgeName;
            ClusterName = clusterName;
            ClusterReference = clusterReference;
            Description = description;
            DhcpOptions = dhcpOptions;
            DynamicIpAddresses = dynamicIpAddresses;
            ExtId = extId;
            HypervisorType = hypervisorType;
            IpConfigs = ipConfigs;
            IpPrefix = ipPrefix;
            IpUsages = ipUsages;
            IsAdvancedNetworking = isAdvancedNetworking;
            IsExternal = isExternal;
            IsNatEnabled = isNatEnabled;
            Links = links;
            MigrationState = migrationState;
            Name = name;
            NetworkFunctionChainReference = networkFunctionChainReference;
            NetworkId = networkId;
            ReservedIpAddresses = reservedIpAddresses;
            SubnetType = subnetType;
            VirtualSwitchReference = virtualSwitchReference;
            VirtualSwitches = virtualSwitches;
            VpcReference = vpcReference;
            Vpcs = vpcs;
        }
    }
}
