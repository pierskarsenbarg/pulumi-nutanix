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

    public sealed class PcRegistrationV2ConfigBootstrapConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cloudInitConfigs")]
        private InputList<Inputs.PcRegistrationV2ConfigBootstrapConfigCloudInitConfigGetArgs>? _cloudInitConfigs;
        public InputList<Inputs.PcRegistrationV2ConfigBootstrapConfigCloudInitConfigGetArgs> CloudInitConfigs
        {
            get => _cloudInitConfigs ?? (_cloudInitConfigs = new InputList<Inputs.PcRegistrationV2ConfigBootstrapConfigCloudInitConfigGetArgs>());
            set => _cloudInitConfigs = value;
        }

        [Input("environmentInfo")]
        public Input<Inputs.PcRegistrationV2ConfigBootstrapConfigEnvironmentInfoGetArgs>? EnvironmentInfo { get; set; }

        public PcRegistrationV2ConfigBootstrapConfigGetArgs()
        {
        }
        public static new PcRegistrationV2ConfigBootstrapConfigGetArgs Empty => new PcRegistrationV2ConfigBootstrapConfigGetArgs();
    }
}
