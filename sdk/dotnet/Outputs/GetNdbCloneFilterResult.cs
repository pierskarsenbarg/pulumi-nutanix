// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class GetNdbCloneFilterResult
    {
        /// <summary>
        /// Get entity(s) if it satisfies query criteria irrespective of status (retrieve even deleted). Default is false
        /// </summary>
        public readonly string? AnyStatus;
        /// <summary>
        /// Load entities with complete details. Default is false
        /// </summary>
        public readonly string? Detailed;
        /// <summary>
        /// Load cluster info. Default is false
        /// </summary>
        public readonly string? LoadDbserverCluster;
        /// <summary>
        /// Default is UTC
        /// </summary>
        public readonly string? Timezone;

        [OutputConstructor]
        private GetNdbCloneFilterResult(
            string? anyStatus,

            string? detailed,

            string? loadDbserverCluster,

            string? timezone)
        {
            AnyStatus = anyStatus;
            Detailed = detailed;
            LoadDbserverCluster = loadDbserverCluster;
            Timezone = timezone;
        }
    }
}