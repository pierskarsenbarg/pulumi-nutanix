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

    public sealed class NdbDbserverVmPostgresDatabaseGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// use SSH public keys to access the database server VM.
        /// </summary>
        [Input("clientPublicKey")]
        public Input<string>? ClientPublicKey { get; set; }

        /// <summary>
        /// name for the database server VM.
        /// </summary>
        [Input("vmName", required: true)]
        public Input<string> VmName { get; set; } = null!;

        public NdbDbserverVmPostgresDatabaseGetArgs()
        {
        }
        public static new NdbDbserverVmPostgresDatabaseGetArgs Empty => new NdbDbserverVmPostgresDatabaseGetArgs();
    }
}
