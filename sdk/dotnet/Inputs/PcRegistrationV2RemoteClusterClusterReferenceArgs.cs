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

    public sealed class PcRegistrationV2RemoteClusterClusterReferenceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// -(Required)  Cluster UUID of a remote cluster.
        /// </summary>
        [Input("extId", required: true)]
        public Input<string> ExtId { get; set; } = null!;

        public PcRegistrationV2RemoteClusterClusterReferenceArgs()
        {
        }
        public static new PcRegistrationV2RemoteClusterClusterReferenceArgs Empty => new PcRegistrationV2RemoteClusterClusterReferenceArgs();
    }
}
