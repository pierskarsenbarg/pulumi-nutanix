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

    public sealed class GetVolumeIscsiClientV2IscsiInitiatorNetworkIdIpv4Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// - The prefix length of the network to which this host IPv6 address belongs.
        /// </summary>
        [Input("prefixLength", required: true)]
        public int PrefixLength { get; set; }

        /// <summary>
        /// - The fully qualified domain name.
        /// </summary>
        [Input("value", required: true)]
        public string Value { get; set; } = null!;

        public GetVolumeIscsiClientV2IscsiInitiatorNetworkIdIpv4Args()
        {
        }
        public static new GetVolumeIscsiClientV2IscsiInitiatorNetworkIdIpv4Args Empty => new GetVolumeIscsiClientV2IscsiInitiatorNetworkIdIpv4Args();
    }
}
