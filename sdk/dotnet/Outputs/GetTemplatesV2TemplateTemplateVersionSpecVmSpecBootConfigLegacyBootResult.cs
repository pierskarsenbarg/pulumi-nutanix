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
    public sealed class GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigLegacyBootResult
    {
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigLegacyBootBootDeviceResult> BootDevices;
        public readonly ImmutableArray<string> BootOrders;

        [OutputConstructor]
        private GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigLegacyBootResult(
            ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigLegacyBootBootDeviceResult> bootDevices,

            ImmutableArray<string> bootOrders)
        {
            BootDevices = bootDevices;
            BootOrders = bootOrders;
        }
    }
}
