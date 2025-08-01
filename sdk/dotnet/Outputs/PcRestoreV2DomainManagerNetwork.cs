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
    public sealed class PcRestoreV2DomainManagerNetwork
    {
        /// <summary>
        /// -(Optional) An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public readonly Outputs.PcRestoreV2DomainManagerNetworkExternalAddress? ExternalAddress;
        /// <summary>
        /// -(Required) This configuration is used to manage Prism Central.
        /// </summary>
        public readonly ImmutableArray<Outputs.PcRestoreV2DomainManagerNetworkExternalNetwork> ExternalNetworks;
        public readonly string? Fqdn;
        /// <summary>
        /// -(Required) This configuration is used to internally manage Prism Central network.
        /// </summary>
        public readonly Outputs.PcRestoreV2DomainManagerNetworkInternalNetworks? InternalNetworks;
        /// <summary>
        /// -(Required) List of name servers on a cluster. This is part of payload for both cluster create &amp; update operations. For create operation, only ipv4 address / fqdn values are supported currently.
        /// </summary>
        public readonly ImmutableArray<Outputs.PcRestoreV2DomainManagerNetworkNameServer> NameServers;
        /// <summary>
        /// -(Required) List of NTP servers on a cluster. This is part of payload for both cluster create &amp; update operations. For create operation, only ipv4 address / fqdn values are supported currently.
        /// </summary>
        public readonly ImmutableArray<Outputs.PcRestoreV2DomainManagerNetworkNtpServer> NtpServers;

        [OutputConstructor]
        private PcRestoreV2DomainManagerNetwork(
            Outputs.PcRestoreV2DomainManagerNetworkExternalAddress? externalAddress,

            ImmutableArray<Outputs.PcRestoreV2DomainManagerNetworkExternalNetwork> externalNetworks,

            string? fqdn,

            Outputs.PcRestoreV2DomainManagerNetworkInternalNetworks? internalNetworks,

            ImmutableArray<Outputs.PcRestoreV2DomainManagerNetworkNameServer> nameServers,

            ImmutableArray<Outputs.PcRestoreV2DomainManagerNetworkNtpServer> ntpServers)
        {
            ExternalAddress = externalAddress;
            ExternalNetworks = externalNetworks;
            Fqdn = fqdn;
            InternalNetworks = internalNetworks;
            NameServers = nameServers;
            NtpServers = ntpServers;
        }
    }
}
