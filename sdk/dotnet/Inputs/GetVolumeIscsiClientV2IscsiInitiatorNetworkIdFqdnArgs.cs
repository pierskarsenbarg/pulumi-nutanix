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

    public sealed class GetVolumeIscsiClientV2IscsiInitiatorNetworkIdFqdnInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - The fully qualified domain name.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public GetVolumeIscsiClientV2IscsiInitiatorNetworkIdFqdnInputArgs()
        {
        }
        public static new GetVolumeIscsiClientV2IscsiInitiatorNetworkIdFqdnInputArgs Empty => new GetVolumeIscsiClientV2IscsiInitiatorNetworkIdFqdnInputArgs();
    }
}
