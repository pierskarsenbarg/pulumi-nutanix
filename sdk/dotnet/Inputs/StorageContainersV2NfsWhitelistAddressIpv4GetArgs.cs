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

    public sealed class StorageContainersV2NfsWhitelistAddressIpv4GetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The prefix length of the network to which this host IPv4/IPv6 address belongs.
        /// </summary>
        [Input("prefixLength")]
        public Input<int>? PrefixLength { get; set; }

        /// <summary>
        /// value of fqdn address
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public StorageContainersV2NfsWhitelistAddressIpv4GetArgs()
        {
        }
        public static new StorageContainersV2NfsWhitelistAddressIpv4GetArgs Empty => new StorageContainersV2NfsWhitelistAddressIpv4GetArgs();
    }
}
