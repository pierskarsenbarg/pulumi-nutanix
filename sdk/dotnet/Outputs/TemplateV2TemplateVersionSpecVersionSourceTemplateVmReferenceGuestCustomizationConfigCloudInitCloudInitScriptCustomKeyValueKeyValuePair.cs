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
    public sealed class TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePair
    {
        public readonly string? Name;
        public readonly ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairValue> Values;

        [OutputConstructor]
        private TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePair(
            string? name,

            ImmutableArray<Outputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitCloudInitScriptCustomKeyValueKeyValuePairValue> values)
        {
            Name = name;
            Values = values;
        }
    }
}
