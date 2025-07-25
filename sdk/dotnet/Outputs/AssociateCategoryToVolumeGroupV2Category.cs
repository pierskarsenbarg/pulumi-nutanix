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
    public sealed class AssociateCategoryToVolumeGroupV2Category
    {
        /// <summary>
        /// -(Optional) Type of entity that's represented by this reference. Default value is "CATEGORY". Valid values are:
        /// * "CATEGORY".
        /// 
        /// See detailed information in [Nutanix Associate/Disassociate category to/from a Volume Group V4](https://developers.nutanix.com/api-reference?namespace=volumes&amp;version=v4.0#tag/VolumeGroups/operation/associateCategory).
        /// </summary>
        public readonly string? EntityType;
        /// <summary>
        /// -(Required) The external identifier of the category.
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// -(Optional) Name of entity that's represented by this reference
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// -(Optional) URI of entities that's represented by this reference.
        /// </summary>
        public readonly ImmutableArray<string> Uris;

        [OutputConstructor]
        private AssociateCategoryToVolumeGroupV2Category(
            string? entityType,

            string extId,

            string? name,

            ImmutableArray<string> uris)
        {
            EntityType = entityType;
            ExtId = extId;
            Name = name;
            Uris = uris;
        }
    }
}
