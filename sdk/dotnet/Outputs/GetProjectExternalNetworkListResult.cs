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
    public sealed class GetProjectExternalNetworkListResult
    {
        /// <summary>
        /// the name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// (Required) the UUID.
        /// </summary>
        public readonly string Uuid;

        [OutputConstructor]
        private GetProjectExternalNetworkListResult(
            string name,

            string uuid)
        {
            Name = name;
            Uuid = uuid;
        }
    }
}
