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
    public sealed class NetworkSecurityRuleAdRuleOutboundAllowListFilterParam
    {
        /// <summary>
        /// - (Required) The name for the network_security_rule.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private NetworkSecurityRuleAdRuleOutboundAllowListFilterParam(
            string name,

            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
}
