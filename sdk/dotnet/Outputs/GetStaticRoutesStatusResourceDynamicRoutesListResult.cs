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
    public sealed class GetStaticRoutesStatusResourceDynamicRoutesListResult
    {
        /// <summary>
        /// destination ip address with prefix.
        /// </summary>
        public readonly string Destination;
        /// <summary>
        /// Whether this route is currently active. Present in Status Resources.
        /// </summary>
        public readonly bool IsActive;
        /// <summary>
        /// Targeted link to use as the nexthop in a route.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetStaticRoutesStatusResourceDynamicRoutesListNexthopResult> Nexthops;
        /// <summary>
        /// The preference value assigned to this route. A higher value means greater preference. Present in Status Resource.
        /// </summary>
        public readonly int Priority;

        [OutputConstructor]
        private GetStaticRoutesStatusResourceDynamicRoutesListResult(
            string destination,

            bool isActive,

            ImmutableArray<Outputs.GetStaticRoutesStatusResourceDynamicRoutesListNexthopResult> nexthops,

            int priority)
        {
            Destination = destination;
            IsActive = isActive;
            Nexthops = nexthops;
            Priority = priority;
        }
    }
}
