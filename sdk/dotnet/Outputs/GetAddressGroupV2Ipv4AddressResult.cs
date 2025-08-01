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
    public sealed class GetAddressGroupV2Ipv4AddressResult
    {
        /// <summary>
        /// The prefix length of the network to which this host IPv4 address belongs.
        /// </summary>
        public readonly int PrefixLength;
        /// <summary>
        /// ip of address
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetAddressGroupV2Ipv4AddressResult(
            int prefixLength,

            string value)
        {
            PrefixLength = prefixLength;
            Value = value;
        }
    }
}
