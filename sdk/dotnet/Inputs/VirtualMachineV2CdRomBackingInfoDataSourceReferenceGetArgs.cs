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

    public sealed class VirtualMachineV2CdRomBackingInfoDataSourceReferenceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("imageReferences")]
        private InputList<Inputs.VirtualMachineV2CdRomBackingInfoDataSourceReferenceImageReferenceGetArgs>? _imageReferences;

        /// <summary>
        /// Image Reference
        /// * `image_reference.image_ext_id`: (Required) The globally unique identifier of an image. It should be of type UUID.
        /// </summary>
        public InputList<Inputs.VirtualMachineV2CdRomBackingInfoDataSourceReferenceImageReferenceGetArgs> ImageReferences
        {
            get => _imageReferences ?? (_imageReferences = new InputList<Inputs.VirtualMachineV2CdRomBackingInfoDataSourceReferenceImageReferenceGetArgs>());
            set => _imageReferences = value;
        }

        [Input("vmDiskReferences")]
        private InputList<Inputs.VirtualMachineV2CdRomBackingInfoDataSourceReferenceVmDiskReferenceGetArgs>? _vmDiskReferences;

        /// <summary>
        /// Vm Disk Reference
        /// * `vm_disk_reference.disk_ext_id`: (Optional) The globally unique identifier of a VM disk. It should be of type UUID.
        /// * `vm_disk_reference.disk_address`: (Optional) Disk address.
        /// * `vm_disk_reference.vm_reference`: (Optional) This is a reference to a VM.
        /// </summary>
        public InputList<Inputs.VirtualMachineV2CdRomBackingInfoDataSourceReferenceVmDiskReferenceGetArgs> VmDiskReferences
        {
            get => _vmDiskReferences ?? (_vmDiskReferences = new InputList<Inputs.VirtualMachineV2CdRomBackingInfoDataSourceReferenceVmDiskReferenceGetArgs>());
            set => _vmDiskReferences = value;
        }

        public VirtualMachineV2CdRomBackingInfoDataSourceReferenceGetArgs()
        {
        }
        public static new VirtualMachineV2CdRomBackingInfoDataSourceReferenceGetArgs Empty => new VirtualMachineV2CdRomBackingInfoDataSourceReferenceGetArgs();
    }
}
