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
    public sealed class GetTemplatesV2TemplateTemplateVersionSpecVmSpecGuestCustomizationConfigCloudInitResult
    {
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecGuestCustomizationConfigCloudInitCloudInitScriptResult> CloudInitScripts;
        public readonly string DatasourceType;
        public readonly string Metadata;

        [OutputConstructor]
        private GetTemplatesV2TemplateTemplateVersionSpecVmSpecGuestCustomizationConfigCloudInitResult(
            ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecGuestCustomizationConfigCloudInitCloudInitScriptResult> cloudInitScripts,

            string datasourceType,

            string metadata)
        {
            CloudInitScripts = cloudInitScripts;
            DatasourceType = datasourceType;
            Metadata = metadata;
        }
    }
}
