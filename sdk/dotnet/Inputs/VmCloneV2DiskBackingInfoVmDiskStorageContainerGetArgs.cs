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

    public sealed class VmCloneV2DiskBackingInfoVmDiskStorageContainerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        public VmCloneV2DiskBackingInfoVmDiskStorageContainerGetArgs()
        {
        }
        public static new VmCloneV2DiskBackingInfoVmDiskStorageContainerGetArgs Empty => new VmCloneV2DiskBackingInfoVmDiskStorageContainerGetArgs();
    }
}
