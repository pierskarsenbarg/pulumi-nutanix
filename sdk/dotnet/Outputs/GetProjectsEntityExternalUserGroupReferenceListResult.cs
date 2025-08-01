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
    public sealed class GetProjectsEntityExternalUserGroupReferenceListResult
    {
        /// <summary>
        /// (Required) The kind name (Default value: `project`).
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// (Optional) the name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// (Required) the UUID.
        /// </summary>
        public readonly string Uuid;

        [OutputConstructor]
        private GetProjectsEntityExternalUserGroupReferenceListResult(
            string kind,

            string name,

            string uuid)
        {
            Kind = kind;
            Name = name;
            Uuid = uuid;
        }
    }
}
