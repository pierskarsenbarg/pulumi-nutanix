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
    public sealed class GetProjectsEntityResult
    {
        /// <summary>
        /// List of accounts associated with the project.
        /// * `account_reference_list.#.kind` - The kind name. Default value is `account`
        /// * `account_reference_list.#.uuid` - The UUID of an account.
        /// * `account_reference_list.#.name` - The name of an account.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectsEntityAccountReferenceListResult> AccountReferenceLists;
        /// <summary>
        /// version of the API
        /// </summary>
        public readonly string ApiVersion;
        public readonly ImmutableArray<Outputs.GetProjectsEntityCategoryResult> Categories;
        /// <summary>
        /// Reference to a subnet.
        /// </summary>
        public readonly ImmutableDictionary<string, string> DefaultSubnetReference;
        /// <summary>
        /// A description for project.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// List of environments associated with the project.
        /// * `environment_reference_list.#.kind` - The kind name. Default value is `environment`
        /// * `environment_reference_list.#.uuid` - The UUID of an environment.
        /// * `environment_reference_list.#.name` - The name of an environment.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectsEntityEnvironmentReferenceListResult> EnvironmentReferenceLists;
        /// <summary>
        /// List of external networks associated with the project.
        /// * `external_network_list.#.uuid` - The UUID of a network.
        /// * `external_network_list.#.name` - The name of a network.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectsEntityExternalNetworkListResult> ExternalNetworkLists;
        /// <summary>
        /// List of directory service user groups. These groups are not managed by Nutanix.
        /// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `user_group`
        /// * `external_user_group_reference_list.#.uuid` - The UUID of a user_group
        /// * `external_user_group_reference_list.#.name` - The name of a user_group
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectsEntityExternalUserGroupReferenceListResult> ExternalUserGroupReferenceLists;
        public readonly bool IsDefault;
        public readonly ImmutableDictionary<string, string> Metadata;
        /// <summary>
        /// (Optional) the name.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableDictionary<string, string> OwnerReference;
        public readonly ImmutableDictionary<string, string> ProjectReference;
        /// <summary>
        /// The status for a resource domain (limits and values)
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectsEntityResourceDomainResult> ResourceDomains;
        public readonly string State;
        /// <summary>
        /// List of subnets for the project.
        /// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
        /// * `subnet_reference_list.#.uuid` - The UUID of a subnet
        /// * `subnet_reference_list.#.name` - The name of a subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectsEntitySubnetReferenceListResult> SubnetReferenceLists;
        /// <summary>
        /// List of users in the project.
        /// * `user_reference_list.#.kind` - The kind name. Default value is `user`
        /// * `user_reference_list.#.uuid` - The UUID of a user
        /// * `user_reference_list.#.name` - The name of a user.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectsEntityUserReferenceListResult> UserReferenceLists;

        [OutputConstructor]
        private GetProjectsEntityResult(
            ImmutableArray<Outputs.GetProjectsEntityAccountReferenceListResult> accountReferenceLists,

            string apiVersion,

            ImmutableArray<Outputs.GetProjectsEntityCategoryResult> categories,

            ImmutableDictionary<string, string> defaultSubnetReference,

            string description,

            ImmutableArray<Outputs.GetProjectsEntityEnvironmentReferenceListResult> environmentReferenceLists,

            ImmutableArray<Outputs.GetProjectsEntityExternalNetworkListResult> externalNetworkLists,

            ImmutableArray<Outputs.GetProjectsEntityExternalUserGroupReferenceListResult> externalUserGroupReferenceLists,

            bool isDefault,

            ImmutableDictionary<string, string> metadata,

            string name,

            ImmutableDictionary<string, string> ownerReference,

            ImmutableDictionary<string, string> projectReference,

            ImmutableArray<Outputs.GetProjectsEntityResourceDomainResult> resourceDomains,

            string state,

            ImmutableArray<Outputs.GetProjectsEntitySubnetReferenceListResult> subnetReferenceLists,

            ImmutableArray<Outputs.GetProjectsEntityUserReferenceListResult> userReferenceLists)
        {
            AccountReferenceLists = accountReferenceLists;
            ApiVersion = apiVersion;
            Categories = categories;
            DefaultSubnetReference = defaultSubnetReference;
            Description = description;
            EnvironmentReferenceLists = environmentReferenceLists;
            ExternalNetworkLists = externalNetworkLists;
            ExternalUserGroupReferenceLists = externalUserGroupReferenceLists;
            IsDefault = isDefault;
            Metadata = metadata;
            Name = name;
            OwnerReference = ownerReference;
            ProjectReference = projectReference;
            ResourceDomains = resourceDomains;
            State = state;
            SubnetReferenceLists = subnetReferenceLists;
            UserReferenceLists = userReferenceLists;
        }
    }
}
