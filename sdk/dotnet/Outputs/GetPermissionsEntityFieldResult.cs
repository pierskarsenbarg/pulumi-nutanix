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
    public sealed class GetPermissionsEntityFieldResult
    {
        /// <summary>
        /// Allow or disallow the fields mentioned.
        /// </summary>
        public readonly string FieldMode;
        /// <summary>
        /// The list of fields.
        /// </summary>
        public readonly ImmutableArray<string> FieldNameLists;

        [OutputConstructor]
        private GetPermissionsEntityFieldResult(
            string fieldMode,

            ImmutableArray<string> fieldNameLists)
        {
            FieldMode = fieldMode;
            FieldNameLists = fieldNameLists;
        }
    }
}
