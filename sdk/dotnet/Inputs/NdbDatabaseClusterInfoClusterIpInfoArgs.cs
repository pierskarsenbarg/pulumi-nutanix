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

    public sealed class NdbDatabaseClusterInfoClusterIpInfoArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipInfos")]
        private InputList<Inputs.NdbDatabaseClusterInfoClusterIpInfoIpInfoArgs>? _ipInfos;
        public InputList<Inputs.NdbDatabaseClusterInfoClusterIpInfoIpInfoArgs> IpInfos
        {
            get => _ipInfos ?? (_ipInfos = new InputList<Inputs.NdbDatabaseClusterInfoClusterIpInfoIpInfoArgs>());
            set => _ipInfos = value;
        }

        [Input("nxClusterId", required: true)]
        public Input<string> NxClusterId { get; set; } = null!;

        public NdbDatabaseClusterInfoClusterIpInfoArgs()
        {
        }
        public static new NdbDatabaseClusterInfoClusterIpInfoArgs Empty => new NdbDatabaseClusterInfoClusterIpInfoArgs();
    }
}