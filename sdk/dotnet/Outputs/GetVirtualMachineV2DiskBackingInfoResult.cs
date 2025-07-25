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
    public sealed class GetVirtualMachineV2DiskBackingInfoResult
    {
        /// <summary>
        /// Volume Group Reference
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualMachineV2DiskBackingInfoAdfsVolumeGroupReferenceResult> AdfsVolumeGroupReferences;
        /// <summary>
        /// backing Info for vmDisk
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualMachineV2DiskBackingInfoVmDiskResult> VmDisks;

        [OutputConstructor]
        private GetVirtualMachineV2DiskBackingInfoResult(
            ImmutableArray<Outputs.GetVirtualMachineV2DiskBackingInfoAdfsVolumeGroupReferenceResult> adfsVolumeGroupReferences,

            ImmutableArray<Outputs.GetVirtualMachineV2DiskBackingInfoVmDiskResult> vmDisks)
        {
            AdfsVolumeGroupReferences = adfsVolumeGroupReferences;
            VmDisks = vmDisks;
        }
    }
}
