// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class UserIdentityProviderUserGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Optional) The reference to a identity provider. See #reference for to look the supported attributes.
        /// </summary>
        [Input("identityProviderReference", required: true)]
        public Input<Inputs.UserIdentityProviderUserIdentityProviderReferenceGetArgs> IdentityProviderReference { get; set; } = null!;

        /// <summary>
        /// - (Optional) The username from identity provider. Name ID for SAML Identity Provider.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public UserIdentityProviderUserGetArgs()
        {
        }
        public static new UserIdentityProviderUserGetArgs Empty => new UserIdentityProviderUserGetArgs();
    }
}
