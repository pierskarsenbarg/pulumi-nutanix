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
    public sealed class GetVirtualMachineV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceDiskAddressResult
    {
        /// <summary>
        /// Bus type for the device. The acceptable values are: SCSI, IDE, PCI, SATA, SPAPR (only PPC).
        /// </summary>
        public readonly string BusType;
        /// <summary>
        /// Device index on the bus. This field is ignored unless the bus details are specified.
        /// </summary>
        public readonly int Index;

        [OutputConstructor]
        private GetVirtualMachineV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceDiskAddressResult(
            string busType,

            int index)
        {
            BusType = busType;
            Index = index;
        }
    }
}
