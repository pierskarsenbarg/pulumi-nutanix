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
    public sealed class GetVirtualMachineV2NicBackingInfoResult
    {
        /// <summary>
        /// Indicates whether the serial port is connected or not.
        /// </summary>
        public readonly bool IsConnected;
        /// <summary>
        /// MAC address of the emulated NIC.
        /// </summary>
        public readonly string MacAddress;
        /// <summary>
        /// Options for the NIC emulation.
        /// </summary>
        public readonly string Model;
        /// <summary>
        /// The number of Tx/Rx queue pairs for this NIC
        /// </summary>
        public readonly int NumQueues;

        [OutputConstructor]
        private GetVirtualMachineV2NicBackingInfoResult(
            bool isConnected,

            string macAddress,

            string model,

            int numQueues)
        {
            IsConnected = isConnected;
            MacAddress = macAddress;
            Model = model;
            NumQueues = numQueues;
        }
    }
}
