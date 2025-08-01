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

    public sealed class GetSubnetV2ReservedIpAddressInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The prefix length of the network to which this host IPv4/IPv6 address belongs.
        /// </summary>
        [Input("prefixLength", required: true)]
        public Input<int> PrefixLength { get; set; } = null!;

        /// <summary>
        /// value of address
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public GetSubnetV2ReservedIpAddressInputArgs()
        {
        }
        public static new GetSubnetV2ReservedIpAddressInputArgs Empty => new GetSubnetV2ReservedIpAddressInputArgs();
    }
}
