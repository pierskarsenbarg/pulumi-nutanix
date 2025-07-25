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
    public sealed class GetProtectionPoliciesV2ProtectionPolicyResult
    {
        public readonly ImmutableArray<string> CategoryIds;
        public readonly string Description;
        public readonly string ExtId;
        public readonly bool IsApprovalPolicyNeeded;
        public readonly ImmutableArray<Outputs.GetProtectionPoliciesV2ProtectionPolicyLinkResult> Links;
        public readonly string Name;
        public readonly string OwnerExtId;
        public readonly ImmutableArray<Outputs.GetProtectionPoliciesV2ProtectionPolicyReplicationConfigurationResult> ReplicationConfigurations;
        public readonly ImmutableArray<Outputs.GetProtectionPoliciesV2ProtectionPolicyReplicationLocationResult> ReplicationLocations;
        public readonly string TenantId;

        [OutputConstructor]
        private GetProtectionPoliciesV2ProtectionPolicyResult(
            ImmutableArray<string> categoryIds,

            string description,

            string extId,

            bool isApprovalPolicyNeeded,

            ImmutableArray<Outputs.GetProtectionPoliciesV2ProtectionPolicyLinkResult> links,

            string name,

            string ownerExtId,

            ImmutableArray<Outputs.GetProtectionPoliciesV2ProtectionPolicyReplicationConfigurationResult> replicationConfigurations,

            ImmutableArray<Outputs.GetProtectionPoliciesV2ProtectionPolicyReplicationLocationResult> replicationLocations,

            string tenantId)
        {
            CategoryIds = categoryIds;
            Description = description;
            ExtId = extId;
            IsApprovalPolicyNeeded = isApprovalPolicyNeeded;
            Links = links;
            Name = name;
            OwnerExtId = ownerExtId;
            ReplicationConfigurations = replicationConfigurations;
            ReplicationLocations = replicationLocations;
            TenantId = tenantId;
        }
    }
}
