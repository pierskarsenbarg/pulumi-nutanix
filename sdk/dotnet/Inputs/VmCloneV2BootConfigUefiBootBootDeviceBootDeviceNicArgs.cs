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

    public sealed class VmCloneV2BootConfigUefiBootBootDeviceBootDeviceNicArgs : global::Pulumi.ResourceArgs
    {
        [Input("macAddress")]
        public Input<string>? MacAddress { get; set; }

        public VmCloneV2BootConfigUefiBootBootDeviceBootDeviceNicArgs()
        {
        }
        public static new VmCloneV2BootConfigUefiBootBootDeviceBootDeviceNicArgs Empty => new VmCloneV2BootConfigUefiBootBootDeviceBootDeviceNicArgs();
    }
}
