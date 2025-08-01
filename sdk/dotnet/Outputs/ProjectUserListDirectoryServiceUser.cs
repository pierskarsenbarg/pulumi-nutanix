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
    public sealed class ProjectUserListDirectoryServiceUser
    {
        public readonly string? DefaultUserPrincipalName;
        public readonly Outputs.ProjectUserListDirectoryServiceUserDirectoryServiceReference DirectoryServiceReference;
        public readonly string? UserPrincipalName;

        [OutputConstructor]
        private ProjectUserListDirectoryServiceUser(
            string? defaultUserPrincipalName,

            Outputs.ProjectUserListDirectoryServiceUserDirectoryServiceReference directoryServiceReference,

            string? userPrincipalName)
        {
            DefaultUserPrincipalName = defaultUserPrincipalName;
            DirectoryServiceReference = directoryServiceReference;
            UserPrincipalName = userPrincipalName;
        }
    }
}
