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
    public sealed class GetUsersEntityResult
    {
        public readonly ImmutableArray<Outputs.GetUsersEntityAccessControlPolicyReferenceListResult> AccessControlPolicyReferenceLists;
        /// <summary>
        /// The version of the API.
        /// * `state`: - The state of the entity.
        /// * `name`: - The name of the user.
        /// * `user_type`: - The name of the user.
        /// * `display_name`: - The display name of the user (common name) provided by the directory service.
        /// * `project_reference_list`: - A list of projects the user is part of. See #reference for more details.
        /// * `access_control_policy_reference_list`: - List of ACP references. See #reference for more details.
        /// * `directory_service_user`: - (Optional) The directory service user configuration. See below for more information.
        /// * `identity_provider_user`: - (Optional) (Optional) The identity provider user configuration. See below for more information.
        /// * `categories`: - (Optional) Categories for the user.
        /// * `project_reference`: - (Optional) The reference to a project.
        /// * `owner_reference`: - (Optional) The reference to a user.
        /// </summary>
        public readonly string ApiVersion;
        public readonly ImmutableArray<Outputs.GetUsersEntityCategoryResult> Categories;
        public readonly ImmutableArray<Outputs.GetUsersEntityDirectoryServiceUserResult> DirectoryServiceUsers;
        public readonly string DisplayName;
        public readonly ImmutableArray<Outputs.GetUsersEntityIdentityProviderUserResult> IdentityProviderUsers;
        public readonly ImmutableDictionary<string, string> Metadata;
        public readonly string Name;
        public readonly ImmutableDictionary<string, string> OwnerReference;
        public readonly ImmutableDictionary<string, string>? ProjectReference;
        public readonly ImmutableArray<Outputs.GetUsersEntityProjectReferenceListResult> ProjectReferenceLists;
        public readonly string State;
        public readonly string UserType;

        [OutputConstructor]
        private GetUsersEntityResult(
            ImmutableArray<Outputs.GetUsersEntityAccessControlPolicyReferenceListResult> accessControlPolicyReferenceLists,

            string apiVersion,

            ImmutableArray<Outputs.GetUsersEntityCategoryResult> categories,

            ImmutableArray<Outputs.GetUsersEntityDirectoryServiceUserResult> directoryServiceUsers,

            string displayName,

            ImmutableArray<Outputs.GetUsersEntityIdentityProviderUserResult> identityProviderUsers,

            ImmutableDictionary<string, string> metadata,

            string name,

            ImmutableDictionary<string, string> ownerReference,

            ImmutableDictionary<string, string>? projectReference,

            ImmutableArray<Outputs.GetUsersEntityProjectReferenceListResult> projectReferenceLists,

            string state,

            string userType)
        {
            AccessControlPolicyReferenceLists = accessControlPolicyReferenceLists;
            ApiVersion = apiVersion;
            Categories = categories;
            DirectoryServiceUsers = directoryServiceUsers;
            DisplayName = displayName;
            IdentityProviderUsers = identityProviderUsers;
            Metadata = metadata;
            Name = name;
            OwnerReference = ownerReference;
            ProjectReference = projectReference;
            ProjectReferenceLists = projectReferenceLists;
            State = state;
            UserType = userType;
        }
    }
}
