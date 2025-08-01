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
    public sealed class GetTemplatesV2TemplateTemplateVersionSpecVmSpecStorageConfigResult
    {
        public readonly bool IsFlashModeEnabled;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecStorageConfigQosConfigResult> QosConfigs;

        [OutputConstructor]
        private GetTemplatesV2TemplateTemplateVersionSpecVmSpecStorageConfigResult(
            bool isFlashModeEnabled,

            ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecStorageConfigQosConfigResult> qosConfigs)
        {
            IsFlashModeEnabled = isFlashModeEnabled;
            QosConfigs = qosConfigs;
        }
    }
}
