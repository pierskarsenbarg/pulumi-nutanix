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
    public sealed class GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootBootDeviceResult
    {
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootBootDeviceBootDeviceDiskResult> BootDeviceDisks;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootBootDeviceBootDeviceNicResult> BootDeviceNics;

        [OutputConstructor]
        private GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootBootDeviceResult(
            ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootBootDeviceBootDeviceDiskResult> bootDeviceDisks,

            ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecBootConfigUefiBootBootDeviceBootDeviceNicResult> bootDeviceNics)
        {
            BootDeviceDisks = bootDeviceDisks;
            BootDeviceNics = bootDeviceNics;
        }
    }
}
