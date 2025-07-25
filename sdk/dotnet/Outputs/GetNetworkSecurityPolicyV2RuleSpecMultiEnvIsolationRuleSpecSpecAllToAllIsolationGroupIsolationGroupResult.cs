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
    public sealed class GetNetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupIsolationGroupResult
    {
        /// <summary>
        /// External identifiers of categories belonging to the isolation group.
        /// </summary>
        public readonly ImmutableArray<string> GroupCategoryReferences;

        [OutputConstructor]
        private GetNetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupIsolationGroupResult(ImmutableArray<string> groupCategoryReferences)
        {
            GroupCategoryReferences = groupCategoryReferences;
        }
    }
}
