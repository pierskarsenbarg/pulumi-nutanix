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
    public sealed class GetTemplateV2TemplateVersionSpecVmSpecBootConfigLegacyBootBootDeviceBootDeviceDiskResult
    {
        /// <summary>
        /// Virtual Machine disk (VM disk).
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecBootConfigLegacyBootBootDeviceBootDeviceDiskDiskAddressResult> DiskAddresses;

        [OutputConstructor]
        private GetTemplateV2TemplateVersionSpecVmSpecBootConfigLegacyBootBootDeviceBootDeviceDiskResult(ImmutableArray<Outputs.GetTemplateV2TemplateVersionSpecVmSpecBootConfigLegacyBootBootDeviceBootDeviceDiskDiskAddressResult> diskAddresses)
        {
            DiskAddresses = diskAddresses;
        }
    }
}
