// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    public static class GetAccessControlPolicy
    {
        /// <summary>
        /// Describes an Access Control Policy.
        /// </summary>
        public static Task<GetAccessControlPolicyResult> InvokeAsync(GetAccessControlPolicyArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAccessControlPolicyResult>("nutanix:index/getAccessControlPolicy:getAccessControlPolicy", args ?? new GetAccessControlPolicyArgs(), options.WithDefaults());

        /// <summary>
        /// Describes an Access Control Policy.
        /// </summary>
        public static Output<GetAccessControlPolicyResult> Invoke(GetAccessControlPolicyInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAccessControlPolicyResult>("nutanix:index/getAccessControlPolicy:getAccessControlPolicy", args ?? new GetAccessControlPolicyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAccessControlPolicyArgs : Pulumi.InvokeArgs
    {
        [Input("accessControlPolicyId")]
        public string? AccessControlPolicyId { get; set; }

        [Input("accessControlPolicyName")]
        public string? AccessControlPolicyName { get; set; }

        [Input("categories")]
        private List<Inputs.GetAccessControlPolicyCategoryArgs>? _categories;
        public List<Inputs.GetAccessControlPolicyCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new List<Inputs.GetAccessControlPolicyCategoryArgs>());
            set => _categories = value;
        }

        public GetAccessControlPolicyArgs()
        {
        }
    }

    public sealed class GetAccessControlPolicyInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("accessControlPolicyId")]
        public Input<string>? AccessControlPolicyId { get; set; }

        [Input("accessControlPolicyName")]
        public Input<string>? AccessControlPolicyName { get; set; }

        [Input("categories")]
        private InputList<Inputs.GetAccessControlPolicyCategoryInputArgs>? _categories;
        public InputList<Inputs.GetAccessControlPolicyCategoryInputArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.GetAccessControlPolicyCategoryInputArgs>());
            set => _categories = value;
        }

        public GetAccessControlPolicyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAccessControlPolicyResult
    {
        public readonly string? AccessControlPolicyId;
        public readonly string? AccessControlPolicyName;
        /// <summary>
        /// The version of the API.
        /// * `state`: - The state of the Access Control Policy.
        /// </summary>
        public readonly string ApiVersion;
        public readonly ImmutableArray<Outputs.GetAccessControlPolicyCategoryResult> Categories;
        public readonly ImmutableArray<Outputs.GetAccessControlPolicyContextFilterListResult> ContextFilterLists;
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Metadata;
        public readonly string Name;
        public readonly ImmutableDictionary<string, string> OwnerReference;
        public readonly ImmutableDictionary<string, string> ProjectReference;
        public readonly ImmutableArray<Outputs.GetAccessControlPolicyRoleReferenceResult> RoleReferences;
        public readonly string State;
        public readonly ImmutableArray<Outputs.GetAccessControlPolicyUserGroupReferenceListResult> UserGroupReferenceLists;
        public readonly ImmutableArray<Outputs.GetAccessControlPolicyUserReferenceListResult> UserReferenceLists;

        [OutputConstructor]
        private GetAccessControlPolicyResult(
            string? accessControlPolicyId,

            string? accessControlPolicyName,

            string apiVersion,

            ImmutableArray<Outputs.GetAccessControlPolicyCategoryResult> categories,

            ImmutableArray<Outputs.GetAccessControlPolicyContextFilterListResult> contextFilterLists,

            string description,

            string id,

            ImmutableDictionary<string, string> metadata,

            string name,

            ImmutableDictionary<string, string> ownerReference,

            ImmutableDictionary<string, string> projectReference,

            ImmutableArray<Outputs.GetAccessControlPolicyRoleReferenceResult> roleReferences,

            string state,

            ImmutableArray<Outputs.GetAccessControlPolicyUserGroupReferenceListResult> userGroupReferenceLists,

            ImmutableArray<Outputs.GetAccessControlPolicyUserReferenceListResult> userReferenceLists)
        {
            AccessControlPolicyId = accessControlPolicyId;
            AccessControlPolicyName = accessControlPolicyName;
            ApiVersion = apiVersion;
            Categories = categories;
            ContextFilterLists = contextFilterLists;
            Description = description;
            Id = id;
            Metadata = metadata;
            Name = name;
            OwnerReference = ownerReference;
            ProjectReference = projectReference;
            RoleReferences = roleReferences;
            State = state;
            UserGroupReferenceLists = userGroupReferenceLists;
            UserReferenceLists = userReferenceLists;
        }
    }
}
