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
    public sealed class NdbProfileClusterAvailability
    {
        public readonly string? DateCreated;
        public readonly string? DateModified;
        /// <summary>
        /// cluster on which profile created
        /// </summary>
        public readonly string? NxClusterId;
        public readonly string? OwnerId;
        public readonly string? ProfileId;
        /// <summary>
        /// status of profile
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private NdbProfileClusterAvailability(
            string? dateCreated,

            string? dateModified,

            string? nxClusterId,

            string? ownerId,

            string? profileId,

            string? status)
        {
            DateCreated = dateCreated;
            DateModified = dateModified;
            NxClusterId = nxClusterId;
            OwnerId = ownerId;
            ProfileId = profileId;
            Status = status;
        }
    }
}
