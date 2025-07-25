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
    public sealed class TemplateV2TemplateVersionSpecVmSpecStorageConfig
    {
        public readonly bool? IsFlashModeEnabled;
        public readonly ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVmSpecStorageConfigQosConfig> QosConfigs;

        [OutputConstructor]
        private TemplateV2TemplateVersionSpecVmSpecStorageConfig(
            bool? isFlashModeEnabled,

            ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVmSpecStorageConfigQosConfig> qosConfigs)
        {
            IsFlashModeEnabled = isFlashModeEnabled;
            QosConfigs = qosConfigs;
        }
    }
}
