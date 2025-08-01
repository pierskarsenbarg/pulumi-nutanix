// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class PcRegistrationV2RemoteClusterAosRemoteClusterSpecRemoteClusterCredentials
    {
        /// <summary>
        /// -(Required)  An authentication scheme that requires the client to present a username and password. The server will service the request only if it can validate the user-ID and password for the protection space of the Request-URI.
        /// </summary>
        public readonly Outputs.PcRegistrationV2RemoteClusterAosRemoteClusterSpecRemoteClusterCredentialsAuthentication Authentication;

        [OutputConstructor]
        private PcRegistrationV2RemoteClusterAosRemoteClusterSpecRemoteClusterCredentials(Outputs.PcRegistrationV2RemoteClusterAosRemoteClusterSpecRemoteClusterCredentialsAuthentication authentication)
        {
            Authentication = authentication;
        }
    }
}
