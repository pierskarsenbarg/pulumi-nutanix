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

    public sealed class VmGcUpdateV2ConfigCloudInitGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cloudInitScripts")]
        private InputList<Inputs.VmGcUpdateV2ConfigCloudInitCloudInitScriptGetArgs>? _cloudInitScripts;
        public InputList<Inputs.VmGcUpdateV2ConfigCloudInitCloudInitScriptGetArgs> CloudInitScripts
        {
            get => _cloudInitScripts ?? (_cloudInitScripts = new InputList<Inputs.VmGcUpdateV2ConfigCloudInitCloudInitScriptGetArgs>());
            set => _cloudInitScripts = value;
        }

        [Input("datasourceType")]
        public Input<string>? DatasourceType { get; set; }

        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public VmGcUpdateV2ConfigCloudInitGetArgs()
        {
        }
        public static new VmGcUpdateV2ConfigCloudInitGetArgs Empty => new VmGcUpdateV2ConfigCloudInitGetArgs();
    }
}
