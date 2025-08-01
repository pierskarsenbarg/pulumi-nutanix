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
    public sealed class GetTemplateV2UpdatedByResult
    {
        /// <summary>
        /// Any additional attribute for the User.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateV2UpdatedByAdditionalAttributeResult> AdditionalAttributes;
        public readonly string CreationType;
        /// <summary>
        /// VM description
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Display name for the User.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Email Id for the User.
        /// </summary>
        public readonly string EmailId;
        /// <summary>
        /// The identifier of a Template.
        /// </summary>
        public readonly string ExtId;
        /// <summary>
        /// First name for the User.
        /// </summary>
        public readonly string FirstName;
        /// <summary>
        /// Identifier of the IDP for the User.
        /// </summary>
        public readonly string IdpId;
        /// <summary>
        /// Flag to force the User to reset password.
        /// </summary>
        public readonly bool IsForceResetPasswordEnabled;
        /// <summary>
        /// Last name for the User.
        /// </summary>
        public readonly string LastName;
        /// <summary>
        /// Default locale for the User.
        /// </summary>
        public readonly string Locale;
        /// <summary>
        /// Middle name for the User.
        /// </summary>
        public readonly string MiddleInitial;
        public readonly string Password;
        /// <summary>
        /// Default Region for the User.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Status of the User.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type of the User.
        /// </summary>
        public readonly string UserType;
        /// <summary>
        /// Identifier for the User in the form an email address.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private GetTemplateV2UpdatedByResult(
            ImmutableArray<Outputs.GetTemplateV2UpdatedByAdditionalAttributeResult> additionalAttributes,

            string creationType,

            string description,

            string displayName,

            string emailId,

            string extId,

            string firstName,

            string idpId,

            bool isForceResetPasswordEnabled,

            string lastName,

            string locale,

            string middleInitial,

            string password,

            string region,

            string status,

            string userType,

            string username)
        {
            AdditionalAttributes = additionalAttributes;
            CreationType = creationType;
            Description = description;
            DisplayName = displayName;
            EmailId = emailId;
            ExtId = extId;
            FirstName = firstName;
            IdpId = idpId;
            IsForceResetPasswordEnabled = isForceResetPasswordEnabled;
            LastName = lastName;
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
