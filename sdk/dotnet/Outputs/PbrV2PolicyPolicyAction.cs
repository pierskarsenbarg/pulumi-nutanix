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
    public sealed class PbrV2PolicyPolicyAction
    {
        public readonly string ActionType;
        public readonly ImmutableArray<Outputs.PbrV2PolicyPolicyActionNexthopIpAddress> NexthopIpAddresses;
        public readonly ImmutableArray<Outputs.PbrV2PolicyPolicyActionRerouteParam> RerouteParams;

        [OutputConstructor]
        private PbrV2PolicyPolicyAction(
            string actionType,

            ImmutableArray<Outputs.PbrV2PolicyPolicyActionNexthopIpAddress> nexthopIpAddresses,

            ImmutableArray<Outputs.PbrV2PolicyPolicyActionRerouteParam> rerouteParams)
        {
            ActionType = actionType;
            NexthopIpAddresses = nexthopIpAddresses;
            RerouteParams = rerouteParams;
        }
    }
}
