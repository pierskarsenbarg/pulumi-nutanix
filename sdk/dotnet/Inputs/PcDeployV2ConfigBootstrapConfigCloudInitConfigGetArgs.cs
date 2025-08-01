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

    public sealed class PcDeployV2ConfigBootstrapConfigCloudInitConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cloudInitScripts")]
        private InputList<Inputs.PcDeployV2ConfigBootstrapConfigCloudInitConfigCloudInitScriptGetArgs>? _cloudInitScripts;

        /// <summary>
        /// -(Optional) The script to use for cloud-init.
        /// - `cloud_init_script.user_data`: -(Optional) user data object
        /// - `cloud_init_script.custom_keys`: -(Optional) The list of the individual KeyValuePair elements.
        /// </summary>
        public InputList<Inputs.PcDeployV2ConfigBootstrapConfigCloudInitConfigCloudInitScriptGetArgs> CloudInitScripts
        {
            get => _cloudInitScripts ?? (_cloudInitScripts = new InputList<Inputs.PcDeployV2ConfigBootstrapConfigCloudInitConfigCloudInitScriptGetArgs>());
            set => _cloudInitScripts = value;
        }

        /// <summary>
        /// -(Optional) Type of datasource. Default: CONFIG_DRIVE_V2
        /// </summary>
        [Input("datasourceType")]
        public Input<string>? DatasourceType { get; set; }

        /// <summary>
        /// -(Optional)The contents of the meta_data configuration for cloud-init. This can be formatted as YAML or JSON. The value must be base64 encoded. Default value is 'CONFIG_DRIVE_V2'.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public PcDeployV2ConfigBootstrapConfigCloudInitConfigGetArgs()
        {
        }
        public static new PcDeployV2ConfigBootstrapConfigCloudInitConfigGetArgs Empty => new PcDeployV2ConfigBootstrapConfigCloudInitConfigGetArgs();
    }
}
