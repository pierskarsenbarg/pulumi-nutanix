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

    public sealed class DeployTemplatesV2OverrideVmConfigMapGuestCustomizationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("configs")]
        private InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigGetArgs>? _configs;
        public InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigGetArgs> Configs
        {
            get => _configs ?? (_configs = new InputList<Inputs.DeployTemplatesV2OverrideVmConfigMapGuestCustomizationConfigGetArgs>());
            set => _configs = value;
        }

        public DeployTemplatesV2OverrideVmConfigMapGuestCustomizationGetArgs()
        {
        }
        public static new DeployTemplatesV2OverrideVmConfigMapGuestCustomizationGetArgs Empty => new DeployTemplatesV2OverrideVmConfigMapGuestCustomizationGetArgs();
    }
}
