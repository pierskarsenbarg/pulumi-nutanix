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

    public sealed class VmCloneV2SerialPortGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extId")]
        public Input<string>? ExtId { get; set; }

        [Input("index")]
        public Input<int>? Index { get; set; }

        [Input("isConnected")]
        public Input<bool>? IsConnected { get; set; }

        public VmCloneV2SerialPortGetArgs()
        {
        }
        public static new VmCloneV2SerialPortGetArgs Empty => new VmCloneV2SerialPortGetArgs();
    }
}
