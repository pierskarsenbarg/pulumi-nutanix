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

    public sealed class VirtualMachineGpuListGetArgs : Pulumi.ResourceArgs
    {
        [Input("deviceId")]
        public Input<int>? DeviceId { get; set; }

        /// <summary>
        /// Fraction of the physical GPU assigned.
        /// * `mode`: - (Optional) The mode of this GPU.
        /// * `num_virtual_display_heads`: - (ReadOnly) Number of supported virtual display heads.
        /// * `guest_driver_version`: - (ReadOnly) Last determined guest driver version.
        /// * `device_id`: - (Computed) The device ID of the GPU.
        /// </summary>
        [Input("fraction")]
        public Input<int>? Fraction { get; set; }

        [Input("frameBufferSizeMib")]
        public Input<int>? FrameBufferSizeMib { get; set; }

        [Input("guestDriverVersion")]
        public Input<string>? GuestDriverVersion { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("numVirtualDisplayHeads")]
        public Input<int>? NumVirtualDisplayHeads { get; set; }

        /// <summary>
        /// GPU {segment:bus:device:function} (sbdf) address if assigned.
        /// </summary>
        [Input("pciAddress")]
        public Input<string>? PciAddress { get; set; }

        [Input("uuid")]
        public Input<string>? Uuid { get; set; }

        [Input("vendor")]
        public Input<string>? Vendor { get; set; }

        public VirtualMachineGpuListGetArgs()
        {
        }
    }
}
