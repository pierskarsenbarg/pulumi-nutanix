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
    public sealed class GetVirtualMachinesV2VmBootConfigUefiBootResult
    {
        public readonly ImmutableArray<Outputs.GetVirtualMachinesV2VmBootConfigUefiBootBootDeviceResult> BootDevices;
        public readonly ImmutableArray<string> BootOrders;
        public readonly bool IsSecureBootEnabled;
        public readonly ImmutableArray<Outputs.GetVirtualMachinesV2VmBootConfigUefiBootNvramDeviceResult> NvramDevices;

        [OutputConstructor]
        private GetVirtualMachinesV2VmBootConfigUefiBootResult(
            ImmutableArray<Outputs.GetVirtualMachinesV2VmBootConfigUefiBootBootDeviceResult> bootDevices,

            ImmutableArray<string> bootOrders,

            bool isSecureBootEnabled,

            ImmutableArray<Outputs.GetVirtualMachinesV2VmBootConfigUefiBootNvramDeviceResult> nvramDevices)
        {
            BootDevices = bootDevices;
            BootOrders = bootOrders;
            IsSecureBootEnabled = isSecureBootEnabled;
            NvramDevices = nvramDevices;
        }
    }
}
