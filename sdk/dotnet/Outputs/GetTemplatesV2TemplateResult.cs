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
    public sealed class GetTemplatesV2TemplateResult
    {
        public readonly string CreateTime;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateCreatedByResult> CreatedBies;
        public readonly string ExtId;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateGuestUpdateStatusResult> GuestUpdateStatuses;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateLinkResult> Links;
        public readonly string TemplateDescription;
        public readonly string TemplateName;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecResult> TemplateVersionSpecs;
        public readonly string TenantId;
        public readonly string UpdateTime;
        public readonly ImmutableArray<Outputs.GetTemplatesV2TemplateUpdatedByResult> UpdatedBies;

        [OutputConstructor]
        private GetTemplatesV2TemplateResult(
            string createTime,

            ImmutableArray<Outputs.GetTemplatesV2TemplateCreatedByResult> createdBies,

            string extId,

            ImmutableArray<Outputs.GetTemplatesV2TemplateGuestUpdateStatusResult> guestUpdateStatuses,

            ImmutableArray<Outputs.GetTemplatesV2TemplateLinkResult> links,

            string templateDescription,

            string templateName,

            ImmutableArray<Outputs.GetTemplatesV2TemplateTemplateVersionSpecResult> templateVersionSpecs,

            string tenantId,

            string updateTime,

            ImmutableArray<Outputs.GetTemplatesV2TemplateUpdatedByResult> updatedBies)
        {
            CreateTime = createTime;
            CreatedBies = createdBies;
            ExtId = extId;
            GuestUpdateStatuses = guestUpdateStatuses;
            Links = links;
            TemplateDescription = templateDescription;
            TemplateName = templateName;
            TemplateVersionSpecs = templateVersionSpecs;
            TenantId = tenantId;
            UpdateTime = updateTime;
            UpdatedBies = updatedBies;
        }
    }
}
