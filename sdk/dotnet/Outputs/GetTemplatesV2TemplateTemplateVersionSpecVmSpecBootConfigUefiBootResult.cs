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
    public sealed class GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootResult
    {
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootBootDeviceResult> BootDevices;
        public readonly ImmutableArray<string> BootOrders;
        public readonly bool IsSecureBootEnabled;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootNvramDeviceResult> NvramDevices;

        [OutputConstructor]
        private GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootResult(
            ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootBootDeviceResult> bootDevices,

            ImmutableArray<string> bootOrders,

            bool isSecureBootEnabled,

            ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootNvramDeviceResult> nvramDevices)
        {
            BootDevices = bootDevices;
            BootOrders = bootOrders;
            IsSecureBootEnabled = isSecureBootEnabled;
            NvramDevices = nvramDevices;
        }
    }
}
