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
    public static class GetAuthorizationPolicyV2
    {
        public static Task<GetAuthorizationPolicyV2Result> InvokeAsync(GetAuthorizationPolicyV2Args args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAuthorizationPolicyV2Result>("nutanix:index/getAuthorizationPolicyV2:getAuthorizationPolicyV2", args ?? new GetAuthorizationPolicyV2Args(), options.WithDefaults());

        public static Output<GetAuthorizationPolicyV2Result> Invoke(GetAuthorizationPolicyV2InvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAuthorizationPolicyV2Result>("nutanix:index/getAuthorizationPolicyV2:getAuthorizationPolicyV2", args ?? new GetAuthorizationPolicyV2InvokeArgs(), options.WithDefaults());

        public static Output<GetAuthorizationPolicyV2Result> Invoke(GetAuthorizationPolicyV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetAuthorizationPolicyV2Result>("nutanix:index/getAuthorizationPolicyV2:getAuthorizationPolicyV2", args ?? new GetAuthorizationPolicyV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAuthorizationPolicyV2Args : global::Pulumi.InvokeArgs
    {
        [Input("extId", required: true)]
        public string ExtId { get; set; } = null!;

        public GetAuthorizationPolicyV2Args()
        {
        }
        public static new GetAuthorizationPolicyV2Args Empty => new GetAuthorizationPolicyV2Args();
    }

    public sealed class GetAuthorizationPolicyV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("extId", required: true)]
        public Input<string> ExtId { get; set; } = null!;

        public GetAuthorizationPolicyV2InvokeArgs()
        {
        }
        public static new GetAuthorizationPolicyV2InvokeArgs Empty => new GetAuthorizationPolicyV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetAuthorizationPolicyV2Result
    {
        public readonly string AuthorizationPolicyType;
        public readonly string ClientName;
        public readonly string CreatedBy;
        public readonly string CreatedTime;
        public readonly string Description;
        public readonly string DisplayName;
        public readonly ImmutableArray<Outputs.GetAuthorizationPolicyV2EntityResult> Entities;
        public readonly string ExtId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetAuthorizationPolicyV2IdentityResult> Identities;
        public readonly bool IsSystemDefined;
        public readonly string LastUpdatedTime;
        public readonly string Role;

        [OutputConstructor]
        private GetAuthorizationPolicyV2Result(
            string authorizationPolicyType,

            string clientName,

            string createdBy,

            string createdTime,

            string description,

            string displayName,

            ImmutableArray<Outputs.GetAuthorizationPolicyV2EntityResult> entities,

            string extId,

            string id,

            ImmutableArray<Outputs.GetAuthorizationPolicyV2IdentityResult> identities,

            bool isSystemDefined,

            string lastUpdatedTime,

            string role)
        {
            AuthorizationPolicyType = authorizationPolicyType;
            ClientName = clientName;
            CreatedBy = createdBy;
            CreatedTime = createdTime;
            Description = description;
            DisplayName = displayName;
            Entities = entities;
            ExtId = extId;
            Id = id;
            Identities = identities;
            IsSystemDefined = isSystemDefined;
            LastUpdatedTime = lastUpdatedTime;
            Role = role;
        }
    }
}
