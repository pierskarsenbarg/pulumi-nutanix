// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class GetNetworkSecurityRuleQuarantineRuleInboundAllowListResult
    {
        public readonly string ExpirationTime;
        public readonly ImmutableArray<string> FilterKindLists;
        public readonly ImmutableArray<Outputs.GetNetworkSecurityRuleQuarantineRuleInboundAllowListFilterParamResult> FilterParams;
        public readonly string FilterType;
        public readonly ImmutableArray<Outputs.GetNetworkSecurityRuleQuarantineRuleInboundAllowListIcmpTypeCodeListResult> IcmpTypeCodeLists;
        public readonly string IpSubnet;
        public readonly string IpSubnetPrefixLength;
        public readonly ImmutableDictionary<string, string> NetworkFunctionChainReference;
        public readonly string PeerSpecificationType;
        public readonly string Protocol;
        public readonly ImmutableArray<Outputs.GetNetworkSecurityRuleQuarantineRuleInboundAllowListTcpPortRangeListResult> TcpPortRangeLists;
        public readonly ImmutableArray<Outputs.GetNetworkSecurityRuleQuarantineRuleInboundAllowListUdpPortRangeListResult> UdpPortRangeLists;

        [OutputConstructor]
        private GetNetworkSecurityRuleQuarantineRuleInboundAllowListResult(
            string expirationTime,

            ImmutableArray<string> filterKindLists,

            ImmutableArray<Outputs.GetNetworkSecurityRuleQuarantineRuleInboundAllowListFilterParamResult> filterParams,

            string filterType,

            ImmutableArray<Outputs.GetNetworkSecurityRuleQuarantineRuleInboundAllowListIcmpTypeCodeListResult> icmpTypeCodeLists,

            string ipSubnet,

            string ipSubnetPrefixLength,

            ImmutableDictionary<string, string> networkFunctionChainReference,

            string peerSpecificationType,

            string protocol,

            ImmutableArray<Outputs.GetNetworkSecurityRuleQuarantineRuleInboundAllowListTcpPortRangeListResult> tcpPortRangeLists,

            ImmutableArray<Outputs.GetNetworkSecurityRuleQuarantineRuleInboundAllowListUdpPortRangeListResult> udpPortRangeLists)
        {
            ExpirationTime = expirationTime;
            FilterKindLists = filterKindLists;
            FilterParams = filterParams;
            FilterType = filterType;
            IcmpTypeCodeLists = icmpTypeCodeLists;
            IpSubnet = ipSubnet;
            IpSubnetPrefixLength = ipSubnetPrefixLength;
            NetworkFunctionChainReference = networkFunctionChainReference;
            PeerSpecificationType = peerSpecificationType;
            Protocol = protocol;
            TcpPortRangeLists = tcpPortRangeLists;
            UdpPortRangeLists = udpPortRangeLists;
        }
    }
}