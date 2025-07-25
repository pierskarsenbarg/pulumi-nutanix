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
    public sealed class ProjectAcp
    {
        /// <summary>
        /// The list of context filters. These are OR filters. The scope-expression-list defines the context, and the filter works in conjunction with the entity-expression-list.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProjectAcpContextFilterList> ContextFilterLists;
        /// <summary>
        /// A description for project.
        /// </summary>
        public readonly string? Description;
        public readonly ImmutableDictionary<string, string>? Metadata;
        /// <summary>
        /// The name for the project.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Reference to role.
        /// </summary>
        public readonly Outputs.ProjectAcpRoleReference RoleReference;
        /// <summary>
        /// List of Reference of users groups.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProjectAcpUserGroupReferenceList> UserGroupReferenceLists;
        /// <summary>
        /// List of Reference of users.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProjectAcpUserReferenceList> UserReferenceLists;

        [OutputConstructor]
        private ProjectAcp(
            ImmutableArray<Outputs.ProjectAcpContextFilterList> contextFilterLists,

            string? description,

            ImmutableDictionary<string, string>? metadata,

            string? name,

            Outputs.ProjectAcpRoleReference roleReference,

            ImmutableArray<Outputs.ProjectAcpUserGroupReferenceList> userGroupReferenceLists,

            ImmutableArray<Outputs.ProjectAcpUserReferenceList> userReferenceLists)
        {
            ContextFilterLists = contextFilterLists;
            Description = description;
            Metadata = metadata;
            Name = name;
            RoleReference = roleReference;
            UserGroupReferenceLists = userGroupReferenceLists;
            UserReferenceLists = userReferenceLists;
        }
    }
}
