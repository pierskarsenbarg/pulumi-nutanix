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
    public sealed class GetProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListResult
    {
        public readonly int AutoSuspendTimeoutSecs;
        public readonly ImmutableArray<Outputs.GetProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListLocalSnapshotRetentionPolicyResult> LocalSnapshotRetentionPolicies;
        public readonly int RecoveryPointObjectiveSecs;
        public readonly ImmutableArray<Outputs.GetProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListRemoteSnapshotRetentionPolicyResult> RemoteSnapshotRetentionPolicies;
        public readonly string SnapshotType;

        [OutputConstructor]
        private GetProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListResult(
            int autoSuspendTimeoutSecs,

            ImmutableArray<Outputs.GetProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListLocalSnapshotRetentionPolicyResult> localSnapshotRetentionPolicies,

            int recoveryPointObjectiveSecs,

            ImmutableArray<Outputs.GetProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListRemoteSnapshotRetentionPolicyResult> remoteSnapshotRetentionPolicies,

            string snapshotType)
        {
            AutoSuspendTimeoutSecs = autoSuspendTimeoutSecs;
            LocalSnapshotRetentionPolicies = localSnapshotRetentionPolicies;
            RecoveryPointObjectiveSecs = recoveryPointObjectiveSecs;
            RemoteSnapshotRetentionPolicies = remoteSnapshotRetentionPolicies;
            SnapshotType = snapshotType;
        }
    }
}
