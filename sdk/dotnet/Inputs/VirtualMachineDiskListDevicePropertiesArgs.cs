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

    public sealed class VirtualMachineDiskListDevicePropertiesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - A Disk type (default: DISK).
        /// </summary>
        [Input("deviceType")]
        public Input<string>? DeviceType { get; set; }

        [Input("diskAddress")]
        private InputMap<string>? _diskAddress;

        /// <summary>
        /// - Address of disk to boot from.
        /// </summary>
        public InputMap<string> DiskAddress
        {
            get => _diskAddress ?? (_diskAddress = new InputMap<string>());
            set => _diskAddress = value;
        }

        public VirtualMachineDiskListDevicePropertiesArgs()
        {
        }
        public static new VirtualMachineDiskListDevicePropertiesArgs Empty => new VirtualMachineDiskListDevicePropertiesArgs();
    }
}
