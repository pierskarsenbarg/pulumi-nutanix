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
    public sealed class GetLcmEntitiesV2EntityAvailableVersionDependencyResult
    {
        /// <summary>
        /// Information of the dependent entity versions for this available entity.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLcmEntitiesV2EntityAvailableVersionDependencyDependentVersionResult> DependentVersions;
        /// <summary>
        /// LCM entity class.
        /// </summary>
        public readonly string EntityClass;
        /// <summary>
        /// LCM entity model.
        /// </summary>
        public readonly string EntityModel;
        /// <summary>
        /// Type of an LCM entity.  Enum Values:
        /// * `FIRMWARE`: LCM entity type firmware.
        /// * `SOFTWARE`: LCM entity type software.
        /// </summary>
        public readonly string EntityType;
        /// <summary>
        /// Current version of an LCM entity.
        /// </summary>
        public readonly string EntityVersion;
        /// <summary>
        /// A globally unique identifier of an instance that is suitable for external consumption.
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// A hardware family for a LCM entity.
        /// </summary>
        public readonly string HardwareFamily;
        /// <summary>
        /// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLcmEntitiesV2EntityAvailableVersionDependencyLinkResult> Links;
        /// <summary>
        /// A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
        /// </summary>
        public readonly string TenantId;

        [OutputConstructor]
        private GetLcmEntitiesV2EntityAvailableVersionDependencyResult(
            ImmutableArray<Outputs.GetLcmEntitiesV2EntityAvailableVersionDependencyDependentVersionResult> dependentVersions,

            string entityClass,

            string entityModel,

            string entityType,

            string entityVersion,

            string extId,

            string hardwareFamily,

            ImmutableArray<Outputs.GetLcmEntitiesV2EntityAvailableVersionDependencyLinkResult> links,

            string tenantId)
        {
            DependentVersions = dependentVersions;
            EntityClass = entityClass;
            EntityModel = entityModel;
            EntityType = entityType;
            EntityVersion = entityVersion;
            ExtId = extId;
            HardwareFamily = hardwareFamily;
            Links = links;
            TenantId = tenantId;
        }
    }
}
