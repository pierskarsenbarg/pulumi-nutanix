// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepSysprepScript
    {
        public readonly ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepSysprepScriptCustomKeyValue> CustomKeyValues;
        public readonly ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepSysprepScriptUnattendXml> UnattendXmls;

        [OutputConstructor]
        private DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepSysprepScript(
            ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepSysprepScriptCustomKeyValue> customKeyValues,

            ImmutableArray<Outputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigSysprepSysprepScriptUnattendXml> unattendXmls)
        {
            CustomKeyValues = customKeyValues;
            UnattendXmls = unattendXmls;
        }
    }
}
