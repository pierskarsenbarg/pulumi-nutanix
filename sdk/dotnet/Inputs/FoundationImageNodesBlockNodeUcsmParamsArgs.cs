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

    public sealed class FoundationImageNodesBlockNodeUcsmParamsArgs : global::Pulumi.ResourceArgs
    {
        [Input("keepUcsmSettings")]
        public Input<bool>? KeepUcsmSettings { get; set; }

        [Input("macPool")]
        public Input<string>? MacPool { get; set; }

        [Input("nativeVlan")]
        public Input<bool>? NativeVlan { get; set; }

        [Input("vlanName")]
        public Input<string>? VlanName { get; set; }

        public FoundationImageNodesBlockNodeUcsmParamsArgs()
        {
        }
        public static new FoundationImageNodesBlockNodeUcsmParamsArgs Empty => new FoundationImageNodesBlockNodeUcsmParamsArgs();
    }
}
