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
    public sealed class GetPbrV2PolicyPolicyMatchSourceResult
    {
        /// <summary>
        /// Address Type like "EXTERNAL" or "ANY".
        /// </summary>
        public readonly string AddressType;
        /// <summary>
        /// Subnet Prefix
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchSourceSubnetPrefixResult> SubnetPrefixes;

        [OutputConstructor]
        private GetPbrV2PolicyPolicyMatchSourceResult(
            string addressType,

            ImmutableArray<Outputs.GetPbrV2PolicyPolicyMatchSourceSubnetPrefixResult> subnetPrefixes)
        {
            AddressType = addressType;
            SubnetPrefixes = subnetPrefixes;
        }
    }
}
