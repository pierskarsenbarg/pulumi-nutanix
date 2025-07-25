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

    public sealed class NdbDbserverVmCredentialArgs : global::Pulumi.ResourceArgs
    {
        [Input("label")]
        public Input<string>? Label { get; set; }

        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public NdbDbserverVmCredentialArgs()
        {
        }
        public static new NdbDbserverVmCredentialArgs Empty => new NdbDbserverVmCredentialArgs();
    }
}
