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
    public sealed class GetImageV2PlacementPolicyStatusResult
    {
        /// <summary>
        /// Compliance status for a placement policy.
        /// </summary>
        public readonly string ComplianceStatus;
        /// <summary>
        /// List of image placement policy external identifier that conflict with the current one.
        /// </summary>
        public readonly ImmutableArray<string> ConflictingPolicyExtIds;
        /// <summary>
        /// List of cluster external identifiers for the enforced placement policy.
        /// </summary>
        public readonly ImmutableArray<string> EnforcedClusterExtIds;
        /// <summary>
        /// Indicates whether the placement policy enforcement is ongoing or has failed.
        /// </summary>
        public readonly string EnforcementMode;
        /// <summary>
        /// Image placement policy external identifier.
        /// </summary>
        public readonly string PlacementPolicyExtId;
        /// <summary>
        /// List of cluster external identifiers of the image location for the enforced placement policy.
        /// </summary>
        public readonly ImmutableArray<string> PolicyClusterExtIds;

        [OutputConstructor]
        private GetImageV2PlacementPolicyStatusResult(
            string complianceStatus,

            ImmutableArray<string> conflictingPolicyExtIds,

            ImmutableArray<string> enforcedClusterExtIds,

            string enforcementMode,

            string placementPolicyExtId,

            ImmutableArray<string> policyClusterExtIds)
        {
            ComplianceStatus = complianceStatus;
            ConflictingPolicyExtIds = conflictingPolicyExtIds;
            EnforcedClusterExtIds = enforcedClusterExtIds;
            EnforcementMode = enforcementMode;
            PlacementPolicyExtId = placementPolicyExtId;
            PolicyClusterExtIds = policyClusterExtIds;
        }
    }
}
