// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    /// <summary>
    /// Provides a resource to create an access control policy based on the input parameters.
    /// </summary>
    [NutanixResourceType("nutanix:index/accessControlPolicy:AccessControlPolicy")]
    public partial class AccessControlPolicy : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The version of the API.
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// - (Optional) Categories for the Access Control Policy.
        /// </summary>
        [Output("categories")]
        public Output<ImmutableArray<Outputs.AccessControlPolicyCategory>> Categories { get; private set; } = null!;

        [Output("contextFilterLists")]
        public Output<ImmutableArray<Outputs.AccessControlPolicyContextFilterList>> ContextFilterLists { get; private set; } = null!;

        /// <summary>
        /// - (Optional) The description of Access Control Policy.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// - The Access Control Policy kind metadata.
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>> Metadata { get; private set; } = null!;

        /// <summary>
        /// - (Optional) Name of the Access Control Policy.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// - (Optional) The reference to a user.
        /// </summary>
        [Output("ownerReference")]
        public Output<Outputs.AccessControlPolicyOwnerReference> OwnerReference { get; private set; } = null!;

        /// <summary>
        /// - (Required) The reference to a role.
        /// </summary>
        [Output("roleReference")]
        public Output<Outputs.AccessControlPolicyRoleReference> RoleReference { get; private set; } = null!;

        /// <summary>
        /// - The state of the Access Control Policy.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// - (Optional) The User group(s) being assigned a given role.
        /// </summary>
        [Output("userGroupReferenceLists")]
        public Output<ImmutableArray<Outputs.AccessControlPolicyUserGroupReferenceList>> UserGroupReferenceLists { get; private set; } = null!;

        /// <summary>
        /// - (Optional) The User(s) being assigned a given role.
        /// </summary>
        [Output("userReferenceLists")]
        public Output<ImmutableArray<Outputs.AccessControlPolicyUserReferenceList>> UserReferenceLists { get; private set; } = null!;


        /// <summary>
        /// Create a AccessControlPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccessControlPolicy(string name, AccessControlPolicyArgs args, CustomResourceOptions? options = null)
            : base("nutanix:index/accessControlPolicy:AccessControlPolicy", name, args ?? new AccessControlPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AccessControlPolicy(string name, Input<string> id, AccessControlPolicyState? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/accessControlPolicy:AccessControlPolicy", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pierskarsenbarg/pulumi-nutanix",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AccessControlPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccessControlPolicy Get(string name, Input<string> id, AccessControlPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new AccessControlPolicy(name, id, state, options);
        }
    }

    public sealed class AccessControlPolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("categories")]
        private InputList<Inputs.AccessControlPolicyCategoryArgs>? _categories;

        /// <summary>
        /// - (Optional) Categories for the Access Control Policy.
        /// </summary>
        public InputList<Inputs.AccessControlPolicyCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.AccessControlPolicyCategoryArgs>());
            set => _categories = value;
        }

        [Input("contextFilterLists")]
        private InputList<Inputs.AccessControlPolicyContextFilterListArgs>? _contextFilterLists;
        public InputList<Inputs.AccessControlPolicyContextFilterListArgs> ContextFilterLists
        {
            get => _contextFilterLists ?? (_contextFilterLists = new InputList<Inputs.AccessControlPolicyContextFilterListArgs>());
            set => _contextFilterLists = value;
        }

        /// <summary>
        /// - (Optional) The description of Access Control Policy.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// - (Optional) Name of the Access Control Policy.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// - (Optional) The reference to a user.
        /// </summary>
        [Input("ownerReference")]
        public Input<Inputs.AccessControlPolicyOwnerReferenceArgs>? OwnerReference { get; set; }

        /// <summary>
        /// - (Required) The reference to a role.
        /// </summary>
        [Input("roleReference", required: true)]
        public Input<Inputs.AccessControlPolicyRoleReferenceArgs> RoleReference { get; set; } = null!;

        [Input("userGroupReferenceLists")]
        private InputList<Inputs.AccessControlPolicyUserGroupReferenceListArgs>? _userGroupReferenceLists;

        /// <summary>
        /// - (Optional) The User group(s) being assigned a given role.
        /// </summary>
        public InputList<Inputs.AccessControlPolicyUserGroupReferenceListArgs> UserGroupReferenceLists
        {
            get => _userGroupReferenceLists ?? (_userGroupReferenceLists = new InputList<Inputs.AccessControlPolicyUserGroupReferenceListArgs>());
            set => _userGroupReferenceLists = value;
        }

        [Input("userReferenceLists")]
        private InputList<Inputs.AccessControlPolicyUserReferenceListArgs>? _userReferenceLists;

        /// <summary>
        /// - (Optional) The User(s) being assigned a given role.
        /// </summary>
        public InputList<Inputs.AccessControlPolicyUserReferenceListArgs> UserReferenceLists
        {
            get => _userReferenceLists ?? (_userReferenceLists = new InputList<Inputs.AccessControlPolicyUserReferenceListArgs>());
            set => _userReferenceLists = value;
        }

        public AccessControlPolicyArgs()
        {
        }
        public static new AccessControlPolicyArgs Empty => new AccessControlPolicyArgs();
    }

    public sealed class AccessControlPolicyState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The version of the API.
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("categories")]
        private InputList<Inputs.AccessControlPolicyCategoryGetArgs>? _categories;

        /// <summary>
        /// - (Optional) Categories for the Access Control Policy.
        /// </summary>
        public InputList<Inputs.AccessControlPolicyCategoryGetArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.AccessControlPolicyCategoryGetArgs>());
            set => _categories = value;
        }

        [Input("contextFilterLists")]
        private InputList<Inputs.AccessControlPolicyContextFilterListGetArgs>? _contextFilterLists;
        public InputList<Inputs.AccessControlPolicyContextFilterListGetArgs> ContextFilterLists
        {
            get => _contextFilterLists ?? (_contextFilterLists = new InputList<Inputs.AccessControlPolicyContextFilterListGetArgs>());
            set => _contextFilterLists = value;
        }

        /// <summary>
        /// - (Optional) The description of Access Control Policy.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// - The Access Control Policy kind metadata.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        /// <summary>
        /// - (Optional) Name of the Access Control Policy.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// - (Optional) The reference to a user.
        /// </summary>
        [Input("ownerReference")]
        public Input<Inputs.AccessControlPolicyOwnerReferenceGetArgs>? OwnerReference { get; set; }

        /// <summary>
        /// - (Required) The reference to a role.
        /// </summary>
        [Input("roleReference")]
        public Input<Inputs.AccessControlPolicyRoleReferenceGetArgs>? RoleReference { get; set; }

        /// <summary>
        /// - The state of the Access Control Policy.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("userGroupReferenceLists")]
        private InputList<Inputs.AccessControlPolicyUserGroupReferenceListGetArgs>? _userGroupReferenceLists;

        /// <summary>
        /// - (Optional) The User group(s) being assigned a given role.
        /// </summary>
        public InputList<Inputs.AccessControlPolicyUserGroupReferenceListGetArgs> UserGroupReferenceLists
        {
            get => _userGroupReferenceLists ?? (_userGroupReferenceLists = new InputList<Inputs.AccessControlPolicyUserGroupReferenceListGetArgs>());
            set => _userGroupReferenceLists = value;
        }

        [Input("userReferenceLists")]
        private InputList<Inputs.AccessControlPolicyUserReferenceListGetArgs>? _userReferenceLists;

        /// <summary>
        /// - (Optional) The User(s) being assigned a given role.
        /// </summary>
        public InputList<Inputs.AccessControlPolicyUserReferenceListGetArgs> UserReferenceLists
        {
            get => _userReferenceLists ?? (_userReferenceLists = new InputList<Inputs.AccessControlPolicyUserReferenceListGetArgs>());
            set => _userReferenceLists = value;
        }

        public AccessControlPolicyState()
        {
        }
        public static new AccessControlPolicyState Empty => new AccessControlPolicyState();
    }
}
