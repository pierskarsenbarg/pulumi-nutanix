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

    public sealed class VirtualMachineV2BootConfigUefiBootBootDeviceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("bootDeviceDisks")]
        private InputList<Inputs.VirtualMachineV2BootConfigUefiBootBootDeviceBootDeviceDiskGetArgs>? _bootDeviceDisks;
        public InputList<Inputs.VirtualMachineV2BootConfigUefiBootBootDeviceBootDeviceDiskGetArgs> BootDeviceDisks
        {
            get => _bootDeviceDisks ?? (_bootDeviceDisks = new InputList<Inputs.VirtualMachineV2BootConfigUefiBootBootDeviceBootDeviceDiskGetArgs>());
            set => _bootDeviceDisks = value;
        }

        [Input("bootDeviceNics")]
        private InputList<Inputs.VirtualMachineV2BootConfigUefiBootBootDeviceBootDeviceNicGetArgs>? _bootDeviceNics;
        public InputList<Inputs.VirtualMachineV2BootConfigUefiBootBootDeviceBootDeviceNicGetArgs> BootDeviceNics
        {
            get => _bootDeviceNics ?? (_bootDeviceNics = new InputList<Inputs.VirtualMachineV2BootConfigUefiBootBootDeviceBootDeviceNicGetArgs>());
            set => _bootDeviceNics = value;
        }

        public VirtualMachineV2BootConfigUefiBootBootDeviceGetArgs()
        {
        }
        public static new VirtualMachineV2BootConfigUefiBootBootDeviceGetArgs Empty => new VirtualMachineV2BootConfigUefiBootBootDeviceGetArgs();
    }
}
