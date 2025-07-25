// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class VirtualMachineV2NicBackingInfo
    {
        public readonly bool? IsConnected;
        /// <summary>
        /// MAC address of the emulated NIC.
        /// </summary>
        public readonly string? MacAddress;
        /// <summary>
        /// Options for the NIC emulation. Valid values "VIRTIO" , "E1000".
        /// </summary>
        public readonly string? Model;
        /// <summary>
        /// The number of Tx/Rx queue pairs for this NIC. Default is 1.
        /// </summary>
        public readonly int? NumQueues;

        [OutputConstructor]
        private VirtualMachineV2NicBackingInfo(
            bool? isConnected,

            string? macAddress,

            string? model,

            int? numQueues)
        {
            IsConnected = isConnected;
            MacAddress = macAddress;
            Model = model;
            NumQueues = numQueues;
        }
    }
}
