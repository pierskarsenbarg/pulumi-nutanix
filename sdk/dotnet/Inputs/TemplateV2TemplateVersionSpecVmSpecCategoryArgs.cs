// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class TemplateV2TemplateVersionSpecVmSpecCategoryArgs : global::Pulumi.ResourceArgs
    {
        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        public TemplateV2TemplateVersionSpecVmSpecCategoryArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVmSpecCategoryArgs Empty => new TemplateV2TemplateVersionSpecVmSpecCategoryArgs();
    }
}
