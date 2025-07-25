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

    public sealed class VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceArgs : global::Pulumi.ResourceArgs
    {
        [Input("diskAddresses")]
        private InputList<Inputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceDiskAddressArgs>? _diskAddresses;
        public InputList<Inputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceDiskAddressArgs> DiskAddresses
        {
            get => _diskAddresses ?? (_diskAddresses = new InputList<Inputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceDiskAddressArgs>());
            set => _diskAddresses = value;
        }

        [Input("diskExtId")]
        public Input<string>? DiskExtId { get; set; }

        [Input("vmReferences")]
        private InputList<Inputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceVmReferenceArgs>? _vmReferences;
        public InputList<Inputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceVmReferenceArgs> VmReferences
        {
            get => _vmReferences ?? (_vmReferences = new InputList<Inputs.VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceVmReferenceArgs>());
            set => _vmReferences = value;
        }

        public VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceArgs()
        {
        }
        public static new VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceArgs Empty => new VmCloneV2BootConfigUefiBootNvramDeviceBackingStorageInfoDataSourceReferenceVmDiskReferenceArgs();
    }
}
