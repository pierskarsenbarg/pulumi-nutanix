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

    public sealed class FoundationImageNodesFcSettingsFcMetadataArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiKey", required: true)]
        public Input<string> ApiKey { get; set; } = null!;

        [Input("fcIp", required: true)]
        public Input<string> FcIp { get; set; } = null!;

        public FoundationImageNodesFcSettingsFcMetadataArgs()
        {
        }
        public static new FoundationImageNodesFcSettingsFcMetadataArgs Empty => new FoundationImageNodesFcSettingsFcMetadataArgs();
    }
}
