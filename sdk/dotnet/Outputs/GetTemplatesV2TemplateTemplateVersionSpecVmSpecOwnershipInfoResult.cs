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
    public sealed class GetTemplatesV2TemplateTemplateVersionSpecVmSpecOwnershipInfoResult
    {
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecOwnershipInfoOwnerResult> Owners;

        [OutputConstructor]
        private GetTemplatesV2TemplateTemplateVersionSpecVmSpecOwnershipInfoResult(ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecVmSpecOwnershipInfoOwnerResult> owners)
        {
            Owners = owners;
        }
    }
}
