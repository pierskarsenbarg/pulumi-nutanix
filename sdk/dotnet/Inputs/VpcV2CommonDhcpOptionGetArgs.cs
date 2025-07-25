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

    public sealed class VpcV2CommonDhcpOptionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("domainNameServers")]
        private InputList<Inputs.VpcV2CommonDhcpOptionDomainNameServerGetArgs>? _domainNameServers;

        /// <summary>
        /// List of Domain Name Server addresses
        /// - `domain_name_servers.ipv4`:(Optional) Reference to address configuration
        /// - `domain_name_servers.ipv6`: (Optional) Reference to address configuration
        /// </summary>
        public InputList<Inputs.VpcV2CommonDhcpOptionDomainNameServerGetArgs> DomainNameServers
        {
            get => _domainNameServers ?? (_domainNameServers = new InputList<Inputs.VpcV2CommonDhcpOptionDomainNameServerGetArgs>());
            set => _domainNameServers = value;
        }

        public VpcV2CommonDhcpOptionGetArgs()
        {
        }
        public static new VpcV2CommonDhcpOptionGetArgs Empty => new VpcV2CommonDhcpOptionGetArgs();
    }
}
