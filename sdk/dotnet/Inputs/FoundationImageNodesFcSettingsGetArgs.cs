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

    public sealed class FoundationImageNodesFcSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - Foundation Central metadata which will be transferred to the newly imaged node.
        /// * `fc_metadata.fc_ip` :- IP address of foundation central.
        /// * `fc_metadata.api_key` :- api_key which the node uses to register itself with foundation central.
        /// </summary>
        [Input("fcMetadata", required: true)]
        public Input<Inputs.FoundationImageNodesFcSettingsFcMetadataGetArgs> FcMetadata { get; set; } = null!;

        /// <summary>
        /// - If this attribute is set to True, FC workflow will be invoked.
        /// </summary>
        [Input("foundationCentral", required: true)]
        public Input<bool> FoundationCentral { get; set; } = null!;

        public FoundationImageNodesFcSettingsGetArgs()
        {
        }
        public static new FoundationImageNodesFcSettingsGetArgs Empty => new FoundationImageNodesFcSettingsGetArgs();
    }
}
