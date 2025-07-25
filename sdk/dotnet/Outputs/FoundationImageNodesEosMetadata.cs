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
    public sealed class FoundationImageNodesEosMetadata
    {
        /// <summary>
        /// - arrya of account names
        /// </summary>
        public readonly ImmutableArray<string> AccountNames;
        /// <summary>
        /// - Id of the Eos config uploaded in foundation GUI.
        /// </summary>
        public readonly string? ConfigId;
        /// <summary>
        /// - Email address of the user who downloaded Eos config.
        /// </summary>
        public readonly string? Email;

        [OutputConstructor]
        private FoundationImageNodesEosMetadata(
            ImmutableArray<string> accountNames,

            string? configId,

            string? email)
        {
            AccountNames = accountNames;
            ConfigId = configId;
            Email = email;
        }
    }
}
