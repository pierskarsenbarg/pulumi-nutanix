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

    public sealed class TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptArgs : global::Pulumi.ResourceArgs
    {
        [Input("customKeyValues")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueArgs>? _customKeyValues;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueArgs> CustomKeyValues
        {
            get => _customKeyValues ?? (_customKeyValues = new InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueArgs>());
            set => _customKeyValues = value;
        }

        [Input("unattendXmls")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptUnattendXmlArgs>? _unattendXmls;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptUnattendXmlArgs> UnattendXmls
        {
            get => _unattendXmls ?? (_unattendXmls = new InputList<Inputs.TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptUnattendXmlArgs>());
            set => _unattendXmls = value;
        }

        public TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptArgs Empty => new TemplateV2TemplateVersionSpecVersionSourceTemplateVmReferenceGuestCustomizationConfigSysprepSysprepScriptArgs();
    }
}
