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
    public sealed class GetRecoveryPointV2VolumeGroupRecoveryPointDiskRecoveryPointResult
    {
        /// <summary>
        /// External identifier of the disk.
        /// </summary>
        public readonly string DiskExtId;
        /// <summary>
        /// External identifier of the disk recovery point.
        /// </summary>
        public readonly string DiskRecoveryPointExtId;

        [OutputConstructor]
        private GetRecoveryPointV2VolumeGroupRecoveryPointDiskRecoveryPointResult(
            string diskExtId,

            string diskRecoveryPointExtId)
        {
            DiskExtId = diskExtId;
            DiskRecoveryPointExtId = diskRecoveryPointExtId;
        }
    }
}
