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
    public sealed class GetImagePlacementPolicyV2ImageEntityFilterResult
    {
        /// <summary>
        /// Array of strings
        /// </summary>
        public readonly ImmutableArray<string> CategoryExtIds;
        /// <summary>
        /// (Required) Filter matching type. Valid values "CATEGORIES_MATCH_ALL", "CATEGORIES_MATCH_ANY"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetImagePlacementPolicyV2ImageEntityFilterResult(
            ImmutableArray<string> categoryExtIds,

            string type)
        {
            CategoryExtIds = categoryExtIds;
            Type = type;
        }
    }
}
