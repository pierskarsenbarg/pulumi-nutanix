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
    public sealed class UsersV2BucketsAccessKeyLink
    {
        /// <summary>
        /// - The URL at which the entity described by the link can be accessed.
        /// </summary>
        public readonly string? Href;
        /// <summary>
        /// - A name that identifies the relationship of the link to the object that is returned by the URL. The unique value of "self" identifies the URL for the object.
        /// </summary>
        public readonly string? Rel;

        [OutputConstructor]
        private UsersV2BucketsAccessKeyLink(
            string? href,

            string? rel)
        {
            Href = href;
            Rel = rel;
        }
    }
}
