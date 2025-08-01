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
    public sealed class NdbDatabaseInfoBpgConfigStorage
    {
        public readonly ImmutableArray<Outputs.NdbDatabaseInfoBpgConfigStorageArchiveStorage> ArchiveStorages;
        public readonly ImmutableArray<Outputs.NdbDatabaseInfoBpgConfigStorageDataDisk> DataDisks;
        public readonly ImmutableArray<Outputs.NdbDatabaseInfoBpgConfigStorageLogDisk> LogDisks;

        [OutputConstructor]
        private NdbDatabaseInfoBpgConfigStorage(
            ImmutableArray<Outputs.NdbDatabaseInfoBpgConfigStorageArchiveStorage> archiveStorages,

            ImmutableArray<Outputs.NdbDatabaseInfoBpgConfigStorageDataDisk> dataDisks,

            ImmutableArray<Outputs.NdbDatabaseInfoBpgConfigStorageLogDisk> logDisks)
        {
            ArchiveStorages = archiveStorages;
            DataDisks = dataDisks;
            LogDisks = logDisks;
        }
    }
}
