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
    public sealed class GetVirtualMachineV2CdRomResult
    {
        /// <summary>
        /// Defines a NIC emulated by the hypervisor
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualMachineV2CdRomBackingInfoResult> BackingInfos;
        /// <summary>
        /// Virtual Machine disk (VM disk).
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualMachineV2CdRomDiskAddressResult> DiskAddresses;
        /// <summary>
        /// Represents virtual machine UUID
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// Type of ISO image inserted in CD-ROM
        /// </summary>
        public readonly string IsoType;

        [OutputConstructor]
        private GetVirtualMachineV2CdRomResult(
            ImmutableArray<Outputs.GetVirtualMachineV2CdRomBackingInfoResult> backingInfos,

            ImmutableArray<Outputs.GetVirtualMachineV2CdRomDiskAddressResult> diskAddresses,

            string extId,

            string isoType)
        {
            BackingInfos = backingInfos;
            DiskAddresses = diskAddresses;
            ExtId = extId;
            IsoType = isoType;
        }
    }
}
