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
    public sealed class VirtualMachineV2DiskBackingInfo
    {
        public readonly ImmutableArray<Outputs.VirtualMachineV2DiskBackingInfoAdfsVolumeGroupReference> AdfsVolumeGroupReferences;
        public readonly ImmutableArray<Outputs.VirtualMachineV2DiskBackingInfoVmDisk> VmDisks;

        [OutputConstructor]
        private VirtualMachineV2DiskBackingInfo(
            ImmutableArray<Outputs.VirtualMachineV2DiskBackingInfoAdfsVolumeGroupReference> adfsVolumeGroupReferences,

            ImmutableArray<Outputs.VirtualMachineV2DiskBackingInfoVmDisk> vmDisks)
        {
            AdfsVolumeGroupReferences = adfsVolumeGroupReferences;
            VmDisks = vmDisks;
        }
    }
}
