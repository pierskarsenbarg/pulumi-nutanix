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

    public sealed class NetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("isolationGroups", required: true)]
        private InputList<Inputs.NetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupIsolationGroupGetArgs>? _isolationGroups;

        /// <summary>
        /// Denotes the list of secured groups that will be used in All to All mutual isolation.
        /// </summary>
        public InputList<Inputs.NetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupIsolationGroupGetArgs> IsolationGroups
        {
            get => _isolationGroups ?? (_isolationGroups = new InputList<Inputs.NetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupIsolationGroupGetArgs>());
            set => _isolationGroups = value;
        }

        public NetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupGetArgs()
        {
        }
        public static new NetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupGetArgs Empty => new NetworkSecurityPolicyV2RuleSpecMultiEnvIsolationRuleSpecSpecAllToAllIsolationGroupGetArgs();
    }
}
