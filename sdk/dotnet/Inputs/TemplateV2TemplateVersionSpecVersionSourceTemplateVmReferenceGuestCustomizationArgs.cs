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

    public sealed class TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationArgs : global::Pulumi.ResourceArgs
    {
        [Input("configs")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigArgs>? _configs;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigArgs> Configs
        {
            get => _configs ?? (_configs = new InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigArgs>());
            set => _configs = value;
        }

        public TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationArgs Empty => new TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationArgs();
    }
}
