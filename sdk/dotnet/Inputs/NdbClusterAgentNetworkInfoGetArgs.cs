// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class NdbClusterAgentNetworkInfoGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// string of DNS servers(comma separted).
        /// </summary>
        [Input("dns")]
        public Input<string>? Dns { get; set; }

        /// <summary>
        /// string of NTP servers(comma separted).
        /// </summary>
        [Input("ntp")]
        public Input<string>? Ntp { get; set; }

        public NdbClusterAgentNetworkInfoGetArgs()
        {
        }
        public static new NdbClusterAgentNetworkInfoGetArgs Empty => new NdbClusterAgentNetworkInfoGetArgs();
    }
}