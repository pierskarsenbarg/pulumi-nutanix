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
    public sealed class PcRegistrationV2NetworkNtpServerIpv4
    {
        /// <summary>
        /// - The prefix length of the network to which this host IPv4/IPv6 address belongs.
        /// </summary>
        public readonly int? PrefixLength;
        /// <summary>
        /// - An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private PcRegistrationV2NetworkNtpServerIpv4(
            int? prefixLength,

            string value)
        {
            PrefixLength = prefixLength;
            Value = value;
        }
    }
}
