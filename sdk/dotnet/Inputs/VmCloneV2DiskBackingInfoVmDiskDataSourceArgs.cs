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

    public sealed class VmCloneV2DiskBackingInfoVmDiskDataSourceArgs : global::Pulumi.ResourceArgs
    {
        [Input("references")]
        private InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceArgs>? _references;
        public InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceArgs> References
        {
            get => _references ?? (_references = new InputList<Inputs.VmCloneV2DiskBackingInfoVmDiskDataSourceReferenceArgs>());
            set => _references = value;
        }

        public VmCloneV2DiskBackingInfoVmDiskDataSourceArgs()
        {
        }
        public static new VmCloneV2DiskBackingInfoVmDiskDataSourceArgs Empty => new VmCloneV2DiskBackingInfoVmDiskDataSourceArgs();
    }
}
