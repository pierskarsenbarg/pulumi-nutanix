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
    public sealed class GetVirtualMachinesV2VmCdRomBackingInfoDataSourceReferenceResult
    {
        public readonly ImmutableArray<Outputs.GetVirtualMachinesV2VmCdRomBackingInfoDataSourceReferenceImageReferenceResult> ImageReferences;
        public readonly ImmutableArray<Outputs.GetVirtualMachinesV2VmCdRomBackingInfoDataSourceReferenceVmDiskReferenceResult> VmDiskReferences;

        [OutputConstructor]
        private GetVirtualMachinesV2VmCdRomBackingInfoDataSourceReferenceResult(
            ImmutableArray<Outputs.GetVirtualMachinesV2VmCdRomBackingInfoDataSourceReferenceImageReferenceResult> imageReferences,

            ImmutableArray<Outputs.GetVirtualMachinesV2VmCdRomBackingInfoDataSourceReferenceVmDiskReferenceResult> vmDiskReferences)
        {
            ImageReferences = imageReferences;
            VmDiskReferences = vmDiskReferences;
        }
    }
}
