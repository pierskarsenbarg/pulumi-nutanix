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

    public sealed class ProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListRemoteSnapshotRetentionPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("numSnapshots")]
        public Input<int>? NumSnapshots { get; set; }

        [Input("rollupRetentionPolicyMultiple")]
        public Input<int>? RollupRetentionPolicyMultiple { get; set; }

        [Input("rollupRetentionPolicySnapshotIntervalType")]
        public Input<string>? RollupRetentionPolicySnapshotIntervalType { get; set; }

        public ProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListRemoteSnapshotRetentionPolicyGetArgs()
        {
        }
        public static new ProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListRemoteSnapshotRetentionPolicyGetArgs Empty => new ProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListRemoteSnapshotRetentionPolicyGetArgs();
    }
}
