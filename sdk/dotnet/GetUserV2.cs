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
    public static class GetUserV2
    {
        /// <summary>
        /// Provides a datasource to View a User.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var get_user = Nutanix.GetUserV2.Invoke(new()
        ///     {
        ///         ExtId = "d3a3232a-9055-4740-b54f-b21a33524565",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// ##  Argument Reference
        /// 
        /// The following arguments are supported:
        /// 
        /// * `ext_id`: -(Required) External Identifier of the User.
        /// </summary>
        public static Task<GetUserV2Result> InvokeAsync(GetUserV2Args args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetUserV2Result>("nutanix:index/getUserV2:getUserV2", args ?? new GetUserV2Args(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to View a User.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var get_user = Nutanix.GetUserV2.Invoke(new()
        ///     {
        ///         ExtId = "d3a3232a-9055-4740-b54f-b21a33524565",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// ##  Argument Reference
        /// 
        /// The following arguments are supported:
        /// 
        /// * `ext_id`: -(Required) External Identifier of the User.
        /// </summary>
        public static Output<GetUserV2Result> Invoke(GetUserV2InvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetUserV2Result>("nutanix:index/getUserV2:getUserV2", args ?? new GetUserV2InvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Provides a datasource to View a User.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var get_user = Nutanix.GetUserV2.Invoke(new()
        ///     {
        ///         ExtId = "d3a3232a-9055-4740-b54f-b21a33524565",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// ##  Argument Reference
        /// 
        /// The following arguments are supported:
        /// 
        /// * `ext_id`: -(Required) External Identifier of the User.
        /// </summary>
        public static Output<GetUserV2Result> Invoke(GetUserV2InvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetUserV2Result>("nutanix:index/getUserV2:getUserV2", args ?? new GetUserV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUserV2Args : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// - A globally unique identifier of an instance that is suitable for external consumption.
        /// </summary>
        [Input("extId", required: true)]
        public string ExtId { get; set; } = null!;

        public GetUserV2Args()
        {
        }
        public static new GetUserV2Args Empty => new GetUserV2Args();
    }

    public sealed class GetUserV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// - A globally unique identifier of an instance that is suitable for external consumption.
        /// </summary>
        [Input("extId", required: true)]
        public Input<string> ExtId { get; set; } = null!;

        public GetUserV2InvokeArgs()
        {
        }
        public static new GetUserV2InvokeArgs Empty => new GetUserV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetUserV2Result
    {
        /// <summary>
        /// -  Any additional attribute for the User.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetUserV2AdditionalAttributeResult> AdditionalAttributes;
        /// <summary>
        /// - Bucket Access Keys for the User.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetUserV2BucketsAccessKeyResult> BucketsAccessKeys;
        /// <summary>
        /// - User or Service who created the User.
        /// </summary>
        public readonly string CreatedBy;
        /// <summary>
        /// - Creation time for the Bucket Access Key.
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        /// - Display name for the User.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// - Email Id for the User.
        /// </summary>
        public readonly string EmailId;
        /// <summary>
        /// - A globally unique identifier of an instance that is suitable for external consumption.
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// - First name for the User.
        /// </summary>
        public readonly string FirstName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// - Identifier of the IDP for the User.
        /// </summary>
        public readonly string IdpId;
        /// <summary>
        /// - Flag to force the User to reset password.
        /// </summary>
        public readonly bool IsForceResetPassword;
        /// <summary>
        /// - Last successful logged in time for the User.
        /// </summary>
        public readonly string LastLoginTime;
        /// <summary>
        /// - Last name for the User.
        /// </summary>
        public readonly string LastName;
        /// <summary>
        /// - Last updated time of the User.
        /// </summary>
        public readonly string LastUpdatedTime;
        /// <summary>
        /// - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetUserV2LinkResult> Links;
        /// <summary>
        /// - Default locale for the User.
        /// </summary>
        public readonly string Locale;
        /// <summary>
        /// - Middle name for the User.
        /// </summary>
        public readonly string MiddleInitial;
        public readonly string Password;
        /// <summary>
        /// - Default Region for the User.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// - Status of the User. `ACTIVE`: Denotes that the local User is active. `INACTIVE`: Denotes that the local User is inactive and needs to be reactivated.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// - Enum: `$UNKNOWN` `$REDACTED` `LOCAL` `SAML` `LDAP` `EXTERNAL`
        /// Type of the User.
        /// </summary>
        public readonly string UserType;
        /// <summary>
        /// - Identifier for the User in the form an email address.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private GetUserV2Result(
            ImmutableArray<Outputs.GetUserV2AdditionalAttributeResult> additionalAttributes,

            ImmutableArray<Outputs.GetUserV2BucketsAccessKeyResult> bucketsAccessKeys,

            string createdBy,

            string createdTime,

            string displayName,

            string emailId,

            string extId,

            string firstName,

            string id,

            string idpId,

            bool isForceResetPassword,

            string lastLoginTime,

            string lastName,

            string lastUpdatedTime,

            ImmutableArray<Outputs.GetUserV2LinkResult> links,

            string locale,

            string middleInitial,

            string password,

            string region,

            string status,

            string userType,

            string username)
        {
            AdditionalAttributes = additionalAttributes;
            BucketsAccessKeys = bucketsAccessKeys;
            CreatedBy = createdBy;
            CreatedTime = createdTime;
            DisplayName = displayName;
            EmailId = emailId;
            ExtId = extId;
            FirstName = firstName;
            Id = id;
            IdpId = idpId;
            IsForceResetPassword = isForceResetPassword;
            LastLoginTime = lastLoginTime;
            LastName = lastName;
            LastUpdatedTime = lastUpdatedTime;
            Links = links;
            Locale = locale;
            MiddleInitial = middleInitial;
            Password = password;
            Region = region;
            Status = status;
            UserType = userType;
            Username = username;
        }
    }
}
