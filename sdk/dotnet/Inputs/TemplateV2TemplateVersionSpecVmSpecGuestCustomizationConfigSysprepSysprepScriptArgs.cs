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

    public sealed class TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptArgs : global::Pulumi.ResourceArgs
    {
        [Input("customKeyValues")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueArgs>? _customKeyValues;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueArgs> CustomKeyValues
        {
            get => _customKeyValues ?? (_customKeyValues = new InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptCustomKeyValueArgs>());
            set => _customKeyValues = value;
        }

        [Input("unattendXmls")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptUnattendXmlArgs>? _unattendXmls;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptUnattendXmlArgs> UnattendXmls
        {
            get => _unattendXmls ?? (_unattendXmls = new InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptUnattendXmlArgs>());
            set => _unattendXmls = value;
        }

        public TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptArgs Empty => new TemplateV2TemplateVersionSpecVmSpecGuestCustomizationConfigSysprepSysprepScriptArgs();
    }
}
