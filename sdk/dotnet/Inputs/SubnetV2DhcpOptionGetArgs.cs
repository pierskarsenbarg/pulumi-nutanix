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

    public sealed class SubnetV2DhcpOptionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("bootFileName")]
        public Input<string>? BootFileName { get; set; }

        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        [Input("domainNameServers")]
        private InputList<Inputs.SubnetV2DhcpOptionDomainNameServerGetArgs>? _domainNameServers;
        public InputList<Inputs.SubnetV2DhcpOptionDomainNameServerGetArgs> DomainNameServers
        {
            get => _domainNameServers ?? (_domainNameServers = new InputList<Inputs.SubnetV2DhcpOptionDomainNameServerGetArgs>());
            set => _domainNameServers = value;
        }

        [Input("ntpServers")]
        private InputList<Inputs.SubnetV2DhcpOptionNtpServerGetArgs>? _ntpServers;
        public InputList<Inputs.SubnetV2DhcpOptionNtpServerGetArgs> NtpServers
        {
            get => _ntpServers ?? (_ntpServers = new InputList<Inputs.SubnetV2DhcpOptionNtpServerGetArgs>());
            set => _ntpServers = value;
        }

        [Input("searchDomains")]
        private InputList<string>? _searchDomains;
        public InputList<string> SearchDomains
        {
            get => _searchDomains ?? (_searchDomains = new InputList<string>());
            set => _searchDomains = value;
        }

        [Input("tftpServerName")]
        public Input<string>? TftpServerName { get; set; }

        public SubnetV2DhcpOptionGetArgs()
        {
        }
        public static new SubnetV2DhcpOptionGetArgs Empty => new SubnetV2DhcpOptionGetArgs();
    }
}
