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

    public sealed class ClusterV2NetworkNameServerIpListFqdnArgs : global::Pulumi.ResourceArgs
    {
        [Input("value")]
        public Input<string>? Value { get; set; }

        public ClusterV2NetworkNameServerIpListFqdnArgs()
        {
        }
        public static new ClusterV2NetworkNameServerIpListFqdnArgs Empty => new ClusterV2NetworkNameServerIpListFqdnArgs();
    }
}
