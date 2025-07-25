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

    public sealed class VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceArgs : global::Pulumi.ResourceArgs
    {
        [Input("diskAddresses")]
        private InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceDiskAddressArgs>? _diskAddresses;
        public InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceDiskAddressArgs> DiskAddresses
        {
            get => _diskAddresses ?? (_diskAddresses = new InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceDiskAddressArgs>());
            set => _diskAddresses = value;
        }

        [Input("diskExtId")]
        public Input<string>? DiskExtId { get; set; }

        [Input("vmReferences")]
        private InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceVmReferenceArgs>? _vmReferences;
        public InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceVmReferenceArgs> VmReferences
        {
            get => _vmReferences ?? (_vmReferences = new InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceVmReferenceArgs>());
            set => _vmReferences = value;
        }

        public VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceArgs()
        {
        }
        public static new VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceArgs Empty => new VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceArgs();
    }
}
