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

    public sealed class PcRegistrationV2ConfigBootstrapConfigCloudInitConfigCloudInitScriptUserDataGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("value")]
        public Input<string>? Value { get; set; }

        public PcRegistrationV2ConfigBootstrapConfigCloudInitConfigCloudInitScriptUserDataGetArgs()
        {
        }
        public static new PcRegistrationV2ConfigBootstrapConfigCloudInitConfigCloudInitScriptUserDataGetArgs Empty => new PcRegistrationV2ConfigBootstrapConfigCloudInitConfigCloudInitScriptUserDataGetArgs();
    }
}
