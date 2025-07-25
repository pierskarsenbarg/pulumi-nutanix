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

    public sealed class PcRegistrationV2RemoteClusterAosRemoteClusterSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// -(Required)  Address configuration of a remote cluster. It requires the address of the remote, that is an IP or domain name along with the basic authentication credentials.
        /// </summary>
        [Input("remoteCluster", required: true)]
        public Input<Inputs.PcRegistrationV2RemoteClusterAosRemoteClusterSpecRemoteClusterArgs> RemoteCluster { get; set; } = null!;

        public PcRegistrationV2RemoteClusterAosRemoteClusterSpecArgs()
        {
        }
        public static new PcRegistrationV2RemoteClusterAosRemoteClusterSpecArgs Empty => new PcRegistrationV2RemoteClusterAosRemoteClusterSpecArgs();
    }
}
