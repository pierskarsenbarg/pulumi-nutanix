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

    public sealed class TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cloudInitScripts")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitCloudInitScriptGetArgs>? _cloudInitScripts;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitCloudInitScriptGetArgs> CloudInitScripts
        {
            get => _cloudInitScripts ?? (_cloudInitScripts = new InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitCloudInitScriptGetArgs>());
            set => _cloudInitScripts = value;
        }

        [Input("datasourceType")]
        public Input<string>? DatasourceType { get; set; }

        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitGetArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitGetArgs Empty => new TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigCloudInitGetArgs();
    }
}
