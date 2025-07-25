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
    public sealed class GetNdbCloneDatabaseNodeProtectionDomainResult
    {
        public readonly ImmutableArray<string> AssocEntities;
        public readonly string CloudId;
        /// <summary>
        /// date created for clone
        /// </summary>
        public readonly string DateCreated;
        /// <summary>
        /// last modified date for clone
        /// </summary>
        public readonly string DateModified;
        /// <summary>
        /// cloned description
        /// </summary>
        public readonly string Description;
        public readonly bool EraCreated;
        /// <summary>
        /// cloned id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// cloned name
        /// </summary>
        public readonly string Name;
        public readonly string OwnerId;
        public readonly string PrimaryHost;
        /// <summary>
        /// properties of clone
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNdbCloneDatabaseNodeProtectionDomainPropertyResult> Properties;
        /// <summary>
        /// status of clone
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetNdbCloneDatabaseNodeProtectionDomainResult(
            ImmutableArray<string> assocEntities,

            string cloudId,

            string dateCreated,

            string dateModified,

            string description,

            bool eraCreated,

            string id,

            string name,

            string ownerId,

            string primaryHost,

            ImmutableArray<Outputs.GetNdbCloneDatabaseNodeProtectionDomainPropertyResult> properties,

            string status,

            string type)
        {
            AssocEntities = assocEntities;
            CloudId = cloudId;
            DateCreated = dateCreated;
            DateModified = dateModified;
            Description = description;
            EraCreated = eraCreated;
            Id = id;
            Name = name;
            OwnerId = ownerId;
            PrimaryHost = primaryHost;
            Properties = properties;
            Status = status;
            Type = type;
        }
    }
}
