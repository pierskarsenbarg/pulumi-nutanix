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
    public sealed class PcRegistrationV2ConfigResourceConfig
    {
        public readonly ImmutableArray<string> ContainerExtIds;
        public readonly int? DataDiskSizeBytes;
        public readonly int? MemorySizeBytes;
        public readonly int? NumVcpus;

        [OutputConstructor]
        private PcRegistrationV2ConfigResourceConfig(
            ImmutableArray<string> containerExtIds,

            int? dataDiskSizeBytes,

            int? memorySizeBytes,

            int? numVcpus)
        {
            ContainerExtIds = containerExtIds;
            DataDiskSizeBytes = dataDiskSizeBytes;
            MemorySizeBytes = memorySizeBytes;
            NumVcpus = numVcpus;
        }
    }
}
