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
    public sealed class GetNdbNetworkIpPoolResult
    {
        /// <summary>
        /// address of ips ranges
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNdbNetworkIpPoolAddressResult> Addresses;
        /// <summary>
        /// end ip
        /// </summary>
        public readonly string EndIp;
        /// <summary>
        /// start ip
        /// </summary>
        public readonly string StartIp;

        [OutputConstructor]
        private GetNdbNetworkIpPoolResult(
            ImmutableArray<Outputs.GetNdbNetworkIpPoolAddressResult> addresses,

            string endIp,

            string startIp)
        {
            Addresses = addresses;
            EndIp = endIp;
            StartIp = startIp;
        }
    }
}
