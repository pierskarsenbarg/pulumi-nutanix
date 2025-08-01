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

    public sealed class PcDeployV2NetworkGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// -(Optional) An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        [Input("externalAddress")]
        public Input<Inputs.PcDeployV2NetworkExternalAddressGetArgs>? ExternalAddress { get; set; }

        [Input("externalNetworks")]
        private InputList<Inputs.PcDeployV2NetworkExternalNetworkGetArgs>? _externalNetworks;

        /// <summary>
        /// -(Required) This configuration is used to manage Prism Central.
        /// </summary>
        public InputList<Inputs.PcDeployV2NetworkExternalNetworkGetArgs> ExternalNetworks
        {
            get => _externalNetworks ?? (_externalNetworks = new InputList<Inputs.PcDeployV2NetworkExternalNetworkGetArgs>());
            set => _externalNetworks = value;
        }

        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        /// <summary>
        /// -(Required) This configuration is used to internally manage Prism Central network.
        /// </summary>
        [Input("internalNetworks")]
        public Input<Inputs.PcDeployV2NetworkInternalNetworksGetArgs>? InternalNetworks { get; set; }

        [Input("nameServers", required: true)]
        private InputList<Inputs.PcDeployV2NetworkNameServerGetArgs>? _nameServers;

        /// <summary>
        /// -(Required) List of name servers on a cluster. This is part of payload for both cluster create &amp; update operations. For create operation, only ipv4 address / fqdn values are supported currently.
        /// </summary>
        public InputList<Inputs.PcDeployV2NetworkNameServerGetArgs> NameServers
        {
            get => _nameServers ?? (_nameServers = new InputList<Inputs.PcDeployV2NetworkNameServerGetArgs>());
            set => _nameServers = value;
        }

        [Input("ntpServers", required: true)]
        private InputList<Inputs.PcDeployV2NetworkNtpServerGetArgs>? _ntpServers;

        /// <summary>
        /// -(Required) List of NTP servers on a cluster. This is part of payload for both cluster create &amp; update operations. For create operation, only ipv4 address / fqdn values are supported currently.
        /// </summary>
        public InputList<Inputs.PcDeployV2NetworkNtpServerGetArgs> NtpServers
        {
            get => _ntpServers ?? (_ntpServers = new InputList<Inputs.PcDeployV2NetworkNtpServerGetArgs>());
            set => _ntpServers = value;
        }

        public PcDeployV2NetworkGetArgs()
        {
        }
        public static new PcDeployV2NetworkGetArgs Empty => new PcDeployV2NetworkGetArgs();
    }
}
