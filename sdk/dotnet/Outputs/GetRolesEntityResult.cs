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
    public sealed class GetRolesEntityResult
    {
        /// <summary>
        /// The version of the API.
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// - Categories for the role.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRolesEntityCategoryResult> Categories;
        /// <summary>
        /// - The description of the role.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// - The role kind metadata.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Metadata;
        /// <summary>
        /// - the name(Optional).
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// - The reference to a user.
        /// </summary>
        public readonly ImmutableDictionary<string, string> OwnerReference;
        /// <summary>
        /// - (Required) List of permission references.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRolesEntityPermissionReferenceListResult> PermissionReferenceLists;
        /// <summary>
        /// - The reference to a project.
        /// </summary>
        public readonly ImmutableDictionary<string, string> ProjectReference;
        public readonly string RoleId;
        /// <summary>
        /// - The state of the role.
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private GetRolesEntityResult(
            string apiVersion,

            ImmutableArray<Outputs.GetRolesEntityCategoryResult> categories,

            string description,

            ImmutableDictionary<string, string> metadata,

            string name,

            ImmutableDictionary<string, string> ownerReference,

            ImmutableArray<Outputs.GetRolesEntityPermissionReferenceListResult> permissionReferenceLists,

            ImmutableDictionary<string, string> projectReference,

            string roleId,

            string state)
        {
            ApiVersion = apiVersion;
            Categories = categories;
            Description = description;
            Metadata = metadata;
            Name = name;
            OwnerReference = ownerReference;
            PermissionReferenceLists = permissionReferenceLists;
            ProjectReference = projectReference;
            RoleId = roleId;
            State = state;
        }
    }
}
