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

    public sealed class AuthorizationPolicyV2IdentityArgs : global::Pulumi.ResourceArgs
    {
        [Input("reserved")]
        public Input<string>? Reserved { get; set; }

        public AuthorizationPolicyV2IdentityArgs()
        {
        }
        public static new AuthorizationPolicyV2IdentityArgs Empty => new AuthorizationPolicyV2IdentityArgs();
    }
}
