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

    public sealed class UserDirectoryServiceUserDirectoryServiceReferenceGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - The kind name. (Default depends on the resource you are referencing)
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// - the name(Optional).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// - the UUID(Required).
        /// </summary>
        [Input("uuid", required: true)]
        public Input<string> Uuid { get; set; } = null!;

        public UserDirectoryServiceUserDirectoryServiceReferenceGetArgs()
        {
        }
        public static new UserDirectoryServiceUserDirectoryServiceReferenceGetArgs Empty => new UserDirectoryServiceUserDirectoryServiceReferenceGetArgs();
    }
}
