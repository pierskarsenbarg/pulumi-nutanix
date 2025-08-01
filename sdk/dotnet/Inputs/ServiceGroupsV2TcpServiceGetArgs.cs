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

    public sealed class ServiceGroupsV2TcpServiceGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// end port
        /// </summary>
        [Input("endPort", required: true)]
        public Input<int> EndPort { get; set; } = null!;

        /// <summary>
        /// start port
        /// </summary>
        [Input("startPort", required: true)]
        public Input<int> StartPort { get; set; } = null!;

        public ServiceGroupsV2TcpServiceGetArgs()
        {
        }
        public static new ServiceGroupsV2TcpServiceGetArgs Empty => new ServiceGroupsV2TcpServiceGetArgs();
    }
}
