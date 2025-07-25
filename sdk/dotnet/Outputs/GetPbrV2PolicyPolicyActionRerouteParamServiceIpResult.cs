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
    public sealed class GetPbrV2PolicyPolicyActionRerouteParamServiceIpResult
    {
        public readonly ImmutableArray<Outputs.GetPbrV2PolicyPolicyActionRerouteParamServiceIpIpv4Result> Ipv4s;
        public readonly ImmutableArray<Outputs.GetPbrV2PolicyPolicyActionRerouteParamServiceIpIpv6Result> Ipv6s;

        [OutputConstructor]
        private GetPbrV2PolicyPolicyActionRerouteParamServiceIpResult(
            ImmutableArray<Outputs.GetPbrV2PolicyPolicyActionRerouteParamServiceIpIpv4Result> ipv4s,

            ImmutableArray<Outputs.GetPbrV2PolicyPolicyActionRerouteParamServiceIpIpv6Result> ipv6s)
        {
            Ipv4s = ipv4s;
            Ipv6s = ipv6s;
        }
    }
}
