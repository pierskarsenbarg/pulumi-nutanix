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
    public sealed class GetTemplateV2CreatedByAdditionalAttributeResult
    {
        /// <summary>
        /// Name of the GPU resource.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetTemplateV2CreatedByAdditionalAttributeValueResult> Values;

        [OutputConstructor]
        private GetTemplateV2CreatedByAdditionalAttributeResult(
            string name,

            ImmutableArray<Outputs.GetTemplateV2CreatedByAdditionalAttributeValueResult> values)
        {
            Name = name;
            Values = values;
        }
    }
}
