// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class VirtualMachineV2BootConfigUefiBootGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicate whether to enable secure boot or not
        /// </summary>
        [Input("isSecureBootEnabled")]
        public Input<bool>? IsSecureBootEnabled { get; set; }

        [Input("nvramDevices")]
        private InputList<Inputs.VirtualMachineV2BootConfigUefiBootNvramDeviceGetArgs>? _nvramDevices;

        /// <summary>
        /// Configuration for NVRAM to be presented to the VM.
        /// * `nvram_device.backing_storage_info`: (Required) Storage provided by Nutanix ADSF
        /// </summary>
        public InputList<Inputs.VirtualMachineV2BootConfigUefiBootNvramDeviceGetArgs> NvramDevices
        {
            get => _nvramDevices ?? (_nvramDevices = new InputList<Inputs.VirtualMachineV2BootConfigUefiBootNvramDeviceGetArgs>());
            set => _nvramDevices = value;
        }

        public VirtualMachineV2BootConfigUefiBootGetArgs()
        {
        }
        public static new VirtualMachineV2BootConfigUefiBootGetArgs Empty => new VirtualMachineV2BootConfigUefiBootGetArgs();
    }
}
