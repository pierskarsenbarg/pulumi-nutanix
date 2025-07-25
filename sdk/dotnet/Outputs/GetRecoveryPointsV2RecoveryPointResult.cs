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
    public sealed class GetRecoveryPointsV2RecoveryPointResult
    {
        public readonly string CreationTime;
        public readonly string ExpirationTime;
        public readonly string ExtId;
        public readonly ImmutableArray<Outputs.GetRecoveryPointsV2RecoveryPointLinkResult> Links;
        public readonly string LocationAgnosticId;
        public readonly ImmutableArray<Outputs.GetRecoveryPointsV2RecoveryPointLocationReferenceResult> LocationReferences;
        public readonly string Name;
        public readonly string OwnerExtId;
        public readonly string RecoveryPointType;
        public readonly string Status;
        public readonly string TenantId;
        public readonly ImmutableArray<Outputs.GetRecoveryPointsV2RecoveryPointVmRecoveryPointResult> VmRecoveryPoints;
        public readonly ImmutableArray<Outputs.GetRecoveryPointsV2RecoveryPointVolumeGroupRecoveryPointResult> VolumeGroupRecoveryPoints;

        [OutputConstructor]
        private GetRecoveryPointsV2RecoveryPointResult(
            string creationTime,

            string expirationTime,

            string extId,

            ImmutableArray<Outputs.GetRecoveryPointsV2RecoveryPointLinkResult> links,

            string locationAgnosticId,

            ImmutableArray<Outputs.GetRecoveryPointsV2RecoveryPointLocationReferenceResult> locationReferences,

            string name,

            string ownerExtId,

            string recoveryPointType,

            string status,

            string tenantId,

            ImmutableArray<Outputs.GetRecoveryPointsV2RecoveryPointVmRecoveryPointResult> vmRecoveryPoints,

            ImmutableArray<Outputs.GetRecoveryPointsV2RecoveryPointVolumeGroupRecoveryPointResult> volumeGroupRecoveryPoints)
        {
            CreationTime = creationTime;
            ExpirationTime = expirationTime;
            ExtId = extId;
            Links = links;
            LocationAgnosticId = locationAgnosticId;
            LocationReferences = locationReferences;
            Name = name;
            OwnerExtId = ownerExtId;
            RecoveryPointType = recoveryPointType;
            Status = status;
            TenantId = tenantId;
            VmRecoveryPoints = vmRecoveryPoints;
            VolumeGroupRecoveryPoints = volumeGroupRecoveryPoints;
        }
    }
}
