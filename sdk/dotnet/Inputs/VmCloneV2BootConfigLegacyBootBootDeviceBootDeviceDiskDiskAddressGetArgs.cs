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

    public sealed class VmCloneV2BootConfigLegacyBootBootDeviceBootDeviceDiskDiskAddressGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("busType")]
        public Input<string>? BusType { get; set; }

        [Input("index")]
        public Input<int>? Index { get; set; }

        public VmCloneV2BootConfigLegacyBootBootDeviceBootDeviceDiskDiskAddressGetArgs()
        {
        }
        public static new VmCloneV2BootConfigLegacyBootBootDeviceBootDeviceDiskDiskAddressGetArgs Empty => new VmCloneV2BootConfigLegacyBootBootDeviceBootDeviceDiskDiskAddressGetArgs();
    }
}
