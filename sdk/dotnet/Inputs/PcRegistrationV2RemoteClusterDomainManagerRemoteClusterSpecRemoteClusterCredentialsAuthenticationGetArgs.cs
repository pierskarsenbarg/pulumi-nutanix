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

    public sealed class PcRegistrationV2RemoteClusterDomainManagerRemoteClusterSpecRemoteClusterCredentialsAuthenticationGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// -(Required)  Password required for the basic auth scheme.
        /// 
        /// See detailed information in [Nutanix Register a PC Docs](https://developers.nutanix.com/api-reference?namespace=prism&amp;version=v4.0#tag/DomainManager/operation/register).
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// -(Required)  Username required for the basic auth scheme. As per RFC 2617 usernames might be case sensitive.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public PcRegistrationV2RemoteClusterDomainManagerRemoteClusterSpecRemoteClusterCredentialsAuthenticationGetArgs()
        {
        }
        public static new PcRegistrationV2RemoteClusterDomainManagerRemoteClusterSpecRemoteClusterCredentialsAuthenticationGetArgs Empty => new PcRegistrationV2RemoteClusterDomainManagerRemoteClusterSpecRemoteClusterCredentialsAuthenticationGetArgs();
    }
}
