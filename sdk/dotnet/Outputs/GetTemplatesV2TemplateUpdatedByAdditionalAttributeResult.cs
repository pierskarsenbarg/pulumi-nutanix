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
    public sealed class GetTemplatesV2TemplateUpdatedByAdditionalAttributeResult
    {
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateUpdatedByAdditionalAttributeValueResult> Values;

        [OutputConstructor]
        private GetTemplatesV2TemplateUpdatedByAdditionalAttributeResult(
            string name,

            ImmutableArray<Outputs.GetTemplatesV2TemplateUpdatedByAdditionalAttributeValueResult> values)
        {
            Name = name;
            Values = values;
        }
    }
}
