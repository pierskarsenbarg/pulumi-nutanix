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

    public sealed class NdbDatabaseScaleInfoBpgConfigStorageGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("archiveStorages")]
        private InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageArchiveStorageGetArgs>? _archiveStorages;
        public InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageArchiveStorageGetArgs> ArchiveStorages
        {
            get => _archiveStorages ?? (_archiveStorages = new InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageArchiveStorageGetArgs>());
            set => _archiveStorages = value;
        }

        [Input("dataDisks")]
        private InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageDataDiskGetArgs>? _dataDisks;
        public InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageDataDiskGetArgs> DataDisks
        {
            get => _dataDisks ?? (_dataDisks = new InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageDataDiskGetArgs>());
            set => _dataDisks = value;
        }

        [Input("logDisks")]
        private InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageLogDiskGetArgs>? _logDisks;
        public InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageLogDiskGetArgs> LogDisks
        {
            get => _logDisks ?? (_logDisks = new InputList<Inputs.NdbDatabaseScaleInfoBpgConfigStorageLogDiskGetArgs>());
            set => _logDisks = value;
        }

        public NdbDatabaseScaleInfoBpgConfigStorageGetArgs()
        {
        }
        public static new NdbDatabaseScaleInfoBpgConfigStorageGetArgs Empty => new NdbDatabaseScaleInfoBpgConfigStorageGetArgs();
    }
}
