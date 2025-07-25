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
    public sealed class GetHostsEntityResult
    {
        /// <summary>
        /// The API version.
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// - Host block config info.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Block;
        /// <summary>
        /// - Categories for the image.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHostsEntityCategoryResult> Categories;
        /// <summary>
        /// - Reference to a kind. Either one of (kind, uuid) or url needs to be specified.
        /// </summary>
        public readonly ImmutableDictionary<string, string> ClusterReference;
        /// <summary>
        /// - Host controller vm information.
        /// </summary>
        public readonly ImmutableDictionary<string, string> ControllerVm;
        /// <summary>
        /// - Host CPU capacity.
        /// </summary>
        public readonly int CpuCapacityHz;
        /// <summary>
        /// - Host CPU model.
        /// </summary>
        public readonly string CpuModel;
        /// <summary>
        /// - Hyper-V failover cluster.
        /// </summary>
        public readonly ImmutableDictionary<string, string> FailoverCluster;
        /// <summary>
        /// - Host GPU driver version.
        /// </summary>
        public readonly string GpuDriverVersion;
        /// <summary>
        /// - List of GPUs on the host.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHostsEntityGpuListResult> GpuLists;
        /// <summary>
        /// - The reference to a disk.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHostsEntityHostDisksReferenceListResult> HostDisksReferenceLists;
        /// <summary>
        /// - Host NICs.
        /// </summary>
        public readonly ImmutableArray<string> HostNicsIdLists;
        /// <summary>
        /// - Host type.
        /// </summary>
        public readonly string HostType;
        /// <summary>
        /// - Host Hypervisor information.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Hypervisor;
        /// <summary>
        /// - Host IPMI info.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Ipmi;
        /// <summary>
        /// - Host memory capacity in MiB.
        /// </summary>
        public readonly int MemoryCapacityMib;
        public readonly ImmutableDictionary<string, string> Metadata;
        /// <summary>
        /// - Host monitoring status.
        /// </summary>
        public readonly string MonitoringState;
        /// <summary>
        /// - the name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// - Number of CPU cores on Host.
        /// </summary>
        public readonly int NumCpuCores;
        /// <summary>
        /// - Number of CPU sockets.
        /// </summary>
        public readonly int NumCpuSockets;
        /// <summary>
        /// - The reference to a user.
        /// </summary>
        public readonly ImmutableDictionary<string, string> OwnerReference;
        /// <summary>
        /// - The reference to a project.
        /// </summary>
        public readonly ImmutableDictionary<string, string> ProjectReference;
        /// <summary>
        /// - The reference to a rackable_unit.
        /// </summary>
        public readonly ImmutableDictionary<string, string> RackableUnitReference;
        /// <summary>
        /// - Node serial number.
        /// </summary>
        public readonly string SerialNumber;
        /// <summary>
        /// - The name of the node to be renamed to during domain-join. If not given,a new name will be automatically assigned.
        /// </summary>
        public readonly ImmutableDictionary<string, string> WindowsDomain;

        [OutputConstructor]
        private GetHostsEntityResult(
            string apiVersion,

            ImmutableDictionary<string, string> block,

            ImmutableArray<Outputs.GetHostsEntityCategoryResult> categories,

            ImmutableDictionary<string, string> clusterReference,

            ImmutableDictionary<string, string> controllerVm,

            int cpuCapacityHz,

            string cpuModel,

            ImmutableDictionary<string, string> failoverCluster,

            string gpuDriverVersion,

            ImmutableArray<Outputs.GetHostsEntityGpuListResult> gpuLists,

            ImmutableArray<Outputs.GetHostsEntityHostDisksReferenceListResult> hostDisksReferenceLists,

            ImmutableArray<string> hostNicsIdLists,

            string hostType,

            ImmutableDictionary<string, string> hypervisor,

            ImmutableDictionary<string, string> ipmi,

            int memoryCapacityMib,

            ImmutableDictionary<string, string> metadata,

            string monitoringState,

            string name,

            int numCpuCores,

            int numCpuSockets,

            ImmutableDictionary<string, string> ownerReference,

            ImmutableDictionary<string, string> projectReference,

            ImmutableDictionary<string, string> rackableUnitReference,

            string serialNumber,

            ImmutableDictionary<string, string> windowsDomain)
        {
            ApiVersion = apiVersion;
            Block = block;
            Categories = categories;
            ClusterReference = clusterReference;
            ControllerVm = controllerVm;
            CpuCapacityHz = cpuCapacityHz;
            CpuModel = cpuModel;
            FailoverCluster = failoverCluster;
            GpuDriverVersion = gpuDriverVersion;
            GpuLists = gpuLists;
            HostDisksReferenceLists = hostDisksReferenceLists;
            HostNicsIdLists = hostNicsIdLists;
            HostType = hostType;
            Hypervisor = hypervisor;
            Ipmi = ipmi;
            MemoryCapacityMib = memoryCapacityMib;
            Metadata = metadata;
            MonitoringState = monitoringState;
            Name = name;
            NumCpuCores = numCpuCores;
            NumCpuSockets = numCpuSockets;
            OwnerReference = ownerReference;
            ProjectReference = projectReference;
            RackableUnitReference = rackableUnitReference;
            SerialNumber = serialNumber;
            WindowsDomain = windowsDomain;
        }
    }
}
