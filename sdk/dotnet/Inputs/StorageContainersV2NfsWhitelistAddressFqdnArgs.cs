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

    public sealed class StorageContainersV2NfsWhitelistAddressFqdnArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// value of fqdn address
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public StorageContainersV2NfsWhitelistAddressFqdnArgs()
        {
        }
        public static new StorageContainersV2NfsWhitelistAddressFqdnArgs Empty => new StorageContainersV2NfsWhitelistAddressFqdnArgs();
    }
}
